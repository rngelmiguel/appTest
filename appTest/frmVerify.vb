Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.ComponentModel

Public Class frmVerify
    Implements DPFP.Capture.EventHandler
    Private template As DPFP.Template
    Private Captura As DPFP.Capture.Capture
    Private verifica As DPFP.Verification.Verification
    Public connection As New connection
    Private oDataReaderUsuarios As MySqlDataReader
    Private oDataTableUsuarios As DataTable

    Private Delegate Sub SetControlVisibilityDelegate(ByVal ctl As Control, ByVal visible As Boolean)
    Private Delegate Sub SetControlChangeTextColorDelegate(ByVal ctl As Control, ByVal color As Color)
    Private Delegate Sub SetControlChangeTextDelegate(ByVal ctl As Control, ByVal text As String)
    Private Delegate Sub SetControlChangeImgDelegate(ByVal ctl As PictureBox, ByVal img As Image)
    'Private oDataReaderUsuarios As MySqlDataReader

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                verifica = New Verification.Verification()
                template = New Template()
            Else
                MessageBox.Show("No se pudo instanciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub iniciarCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If
    End Sub

    Protected Sub pararCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub

    Private Sub graficarHuella(ByVal bmp)
        imgHuella.Image = bmp
    End Sub

    Protected Function convertirSampleMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() 'Variable de tipo conversor de un DPFP.Sample
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Protected Function extraeCaracteristicasHuella(ByVal Sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim FitbackCapture As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, purpose, FitbackCapture, caracteristicas)

        If FitbackCapture = DPFP.Capture.CaptureFeedback.Good Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function

    Private Sub SetControlVisibility(ByVal ctl As Control, ByVal visible As Boolean)
        If ctl.InvokeRequired Then
            'This is a worker thread so create a delegate to cross the thread boundary.
            ctl.Invoke(New SetControlVisibilityDelegate(AddressOf SetControlVisibility), ctl, visible)
        Else
            'This is the UI thread so access the control's members directly.
            ctl.Visible = visible
        End If
    End Sub
    Private Sub SetControlChangeTextColor(ByVal ctl As Control, ByVal color As Color)
        If ctl.InvokeRequired Then
            'This is a worker thread so create a delegate to cross the thread boundary.
            ctl.Invoke(New SetControlChangeTextColorDelegate(AddressOf SetControlChangeTextColor), ctl, color)
        Else
            'This is the UI thread so access the control's members directly.
            ctl.ForeColor = color
        End If
    End Sub
    Private Sub SetControlChangeText(ByVal ctl As Control, ByVal texto As String)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlChangeTextDelegate(AddressOf SetControlChangeText), ctl, texto)
        Else
            ctl.Text = texto
        End If
    End Sub

    Private Sub SetControlChangeImg(ByVal ctl As PictureBox, ByVal img As Image)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlChangeImgDelegate(AddressOf SetControlChangeImg), ctl, img)
        Else
            ctl.Image = img
        End If
    End Sub

    Private Sub userFound(ByVal isFound As Boolean)
        'pararCaptura()

        If isFound Then
            SetControlChangeText(lblStatusFound, "¡ usuario encontrado !")
            SetControlChangeTextColor(lblStatusFound, Color.Green)
            SetControlVisibility(lblStatusFound, True)
        Else
            SetControlChangeText(lblStatusFound, "¡ usuario NO encontrado !")
            SetControlChangeTextColor(lblStatusFound, Color.Red)
            SetControlVisibility(lblStatusFound, True)
        End If

        Thread.Sleep(5000)
        'iniciarCaptura()

        SetControlVisibility(lblStatusFound, False)

        SetControlChangeText(lblTextCedula, "")
        SetControlChangeText(lblTextNombres, "")
        SetControlChangeText(lblTextApellidos, "")
        SetControlChangeText(lblTextCorreo, "")

        SetControlChangeImg(imgHuella, Nothing)
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete

        graficarHuella(convertirSampleMapadeBits(Sample))
        Console.WriteLine("Texto de Salida de Prueba")
        Dim caracteristicas As DPFP.FeatureSet = extraeCaracteristicasHuella(Sample, DPFP.Processing.DataPurpose.Verification)
        If Not caracteristicas Is Nothing Then
            Console.WriteLine("Entre en caracteristicas")

            Dim result As New DPFP.Verification.Verification.Result()
            Dim encontrado As Boolean = False
            Dim cedula As String
            Dim nombres As String
            Dim apellidos As String
            Dim correo As String

            'While (oDataReaderUsuarios.Read())
            '    Console.WriteLine("Entre al reader")
            '    Dim memoria As New MemoryStream(CType(oDataReaderUsuarios("huella"), Byte()))
            '    template.DeSerialize(memoria.ToArray())
            '    verifica.Verify(caracteristicas, template, result)
            '    If (result.Verified) Then
            '        encontrado = True
            '        cedula = oDataReaderUsuarios("id")
            '        nombres = oDataReaderUsuarios("nombres")
            '        apellidos = oDataReaderUsuarios("apellidos")
            '        correo = oDataReaderUsuarios("email")
            '        Exit While
            '    End If
            'End While

            For Each row As DataRow In oDataTableUsuarios.Rows
                Console.WriteLine("Entre al datatable")
                Dim memoria As New MemoryStream(CType(row.Item("huella"), Byte()))
                template.DeSerialize(memoria.ToArray())
                verifica.Verify(caracteristicas, template, result)
                If (result.Verified) Then
                    encontrado = True
                    cedula = row.Item("id")
                    nombres = row.Item("nombres")
                    apellidos = row.Item("apellidos")
                    correo = row.Item("email")
                    Exit For
                End If
            Next row

            If (encontrado) Then
                SetControlChangeText(lblTextCedula, cedula)
                SetControlChangeText(lblTextNombres, nombres)
                SetControlChangeText(lblTextApellidos, apellidos)
                SetControlChangeText(lblTextCorreo, correo)
                userFound(True)
            Else
                userFound(False)
            End If

        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub frmVerify_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        pararCaptura()
    End Sub
    Private Sub frmVerify_Load(sender As Object, e As EventArgs) Handles Me.Load
        Init()
        iniciarCaptura()

        If (connection.cn.State = ConnectionState.Closed) Then
            Try
                connection.cn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString())
                Exit Sub
            End Try
        End If

        Dim cmd As New MySqlCommand()
        cmd = connection.cn.CreateCommand
        cmd.CommandText = "SELECT id, nombres, apellidos, email, huella FROM nscasino_usuarios"

        'Dim oDataReaderUsuarios As MySqlDataReader
        oDataReaderUsuarios = cmd.ExecuteReader()

        oDataTableUsuarios = New DataTable()
        oDataTableUsuarios.Load(oDataReaderUsuarios)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Leave(sender As Object, e As EventArgs) Handles btnBack.Leave
        pararCaptura()
    End Sub

    Private Sub frmVerify_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        pararCaptura()
    End Sub
End Class