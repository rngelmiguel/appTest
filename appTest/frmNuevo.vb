Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports DPFP
Imports DPFP.Capture
Public Class frmNuevo
    Implements DPFP.Capture.EventHandler
    Private Captura As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    Private template As DPFP.Template

    Public isCapturada As Boolean = False
    Public connection As New connection

    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    Private Delegate Sub SetControlVisibilityDelegate(ByVal ctl As Control, ByVal visible As Boolean)
    Private Delegate Sub SetControlEnabledDelegate(ByVal ctl As Control, ByVal enabled As Boolean)
    Private Delegate Sub SetControlChageTextDelegate(ByVal ctl As Control, ByVal text As String)
    Private Delegate Sub SetControlChangeImgDelegate(ByVal ctl As PictureBox, ByVal img As Image)

    Private Sub mostrarVeces(ByVal texto As String)
        If (lblDedo.InvokeRequired) Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            lblDedo.Text = texto
        End If
    End Sub

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                Enroller = New DPFP.Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Scanear ({0}) veces el dedo", Enroller.FeaturesNeeded)
                lblDedo.Text = text.ToString()
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Public Sub validaRegistro()
        If (isCapturada = False Or txtCedula.Text = "" Or txtNombres.Text = "" Or txtApellidos.Text = "" Or txtCorreo.Text = "") Then
            'btnGuardar.Enabled = False
            SetControlEnabled(btnGuardar, False)
        Else
            'btnGuardar.Enabled = True
            SetControlEnabled(btnGuardar, True)
        End If
    End Sub
    Public Sub changeStatusCapture(ByVal status)
        If status = True Then
            isCapturada = True
            imgStatus.Image = Image.FromFile("C:\appTest\appTest\img\check.png")
            'Me.lblCapturar.Visible = False
            SetControlVisibility(lblCapturar, False)
        Else
            isCapturada = False
            imgStatus.Image = Image.FromFile("C:\appTest\appTest\img\error.png")
            'Me.lblCapturar.Visible = True
            SetControlVisibility(lblCapturar, True)
        End If
        'ctnCaptura.Visible = False
        SetControlVisibility(ctnCaptura, False)
        validaRegistro()
    End Sub
    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        validaRegistro()
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        validaRegistro()
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged
        validaRegistro()
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
        validaRegistro()
    End Sub

    Private Sub lblCapturar_Click(sender As Object, e As EventArgs) Handles lblCapturar.Click
        ctnCaptura.Visible = True
    End Sub

    Private Sub ctnCaptura_VisibleChanged(sender As Object, e As EventArgs) Handles ctnCaptura.VisibleChanged
        If ctnCaptura.Visible = True Then
            Init()
            iniciarCaptura()
            'MsgBox("Aqui ejecute el captahuella")
        Else
            pararCaptura()
        End If
    End Sub
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        graficarHuella(convertirSampleMapadeBits(Sample))
        procesar(Sample)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'MessageBox.Show("Se ha tocado el captahuella")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub lblDedo_Click(sender As Object, e As EventArgs) Handles lblDedo.Click

    End Sub
    Protected Function convertirSampleMapadeBits(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() 'Variable de tipo conversor de un DPFP.Sample
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits
    End Function

    Private Sub graficarHuella(ByVal bmp)
        imgHuella.Image = bmp
    End Sub

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

    Protected Sub procesar(ByVal Sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extraeCaracteristicasHuella(Sample, DPFP.Processing.DataPurpose.Enrollment)

        If Not caracteristicas Is Nothing Then
            Try
                Enroller.AddFeatures(caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Scanear ({0}) veces el dedo", Enroller.FeaturesNeeded)
                mostrarVeces(text.ToString())

                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = Enroller.Template
                        pararCaptura()
                        changeStatusCapture(True)
                    Case DPFP.Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        pararCaptura()
                        changeStatusCapture(False)
                        'iniciarCaptura()
                End Select
            End Try
        End If
    End Sub
    Private Sub SetControlVisibility(ByVal ctl As Control, ByVal visible As Boolean)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlVisibilityDelegate(AddressOf SetControlVisibility), ctl, visible)
        Else
            ctl.Visible = visible
        End If
    End Sub
    Private Sub SetControlEnabled(ByVal ctl As Control, ByVal enabled As Boolean)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlEnabledDelegate(AddressOf SetControlEnabled), ctl, enabled)
        Else
            ctl.Enabled = enabled
        End If
    End Sub
    Private Sub SetControlChangeText(ByVal ctl As Control, ByVal texto As String)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlChageTextDelegate(AddressOf SetControlChangeText), ctl, texto)
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

    Private Sub restablecer()
        SetControlChangeText(txtCedula, "")
        SetControlChangeText(txtNombres, "")
        SetControlChangeText(txtApellidos, "")
        SetControlChangeText(txtCorreo, "")

        SetControlEnabled(txtCedula, True)
        SetControlEnabled(txtNombres, True)
        SetControlEnabled(txtApellidos, True)
        SetControlEnabled(txtCorreo, True)

        SetControlChangeImg(imgHuella, Nothing)

        isCapturada = False
        imgStatus.Image = Image.FromFile("C:\appTest\appTest\img\question.png")
        Enroller.Clear()
        SetControlVisibility(lblCapturar, True)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SetControlEnabled(btnGuardar, False)
        SetControlEnabled(txtCedula, False)
        SetControlEnabled(txtNombres, False)
        SetControlEnabled(txtApellidos, False)
        SetControlEnabled(txtCorreo, False)

        'cnt1.Visible = True
        'Dim query = "SELECT id, nombres, apellidos, email FROM nscasino_usuarios;"
        'Dim SqlAdp As MySqlDataAdapter = New MySqlDataAdapter(query, connection.cn)
        'Dim ds As New DataSet()
        If (connection.cn.State = ConnectionState.Closed) Then
            Try
                connection.cn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString())
                Exit Sub
            End Try
        End If
        'SqlAdp.Fill(ds)
        'DataGridView1.DataSource = ds.Tables(0)

        Dim cmd As New MySqlCommand()
        cmd = connection.cn.CreateCommand
        cmd.CommandText = "INSERT INTO nscasino_usuarios(id, nombres, apellidos, email, huella) VALUES(?,?,?,?,?)"
        cmd.Parameters.AddWithValue("id", txtCedula.Text.ToString())
        cmd.Parameters.AddWithValue("nombres", txtNombres.Text.ToString())
        cmd.Parameters.AddWithValue("apellidos", txtApellidos.Text.ToString())
        cmd.Parameters.AddWithValue("email", txtCorreo.Text.ToString())
        Using fm As New MemoryStream(template.Bytes)
            cmd.Parameters.AddWithValue("huella", fm.ToArray())
        End Using
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        connection.CerraConexion()
        restablecer()

    End Sub
    Private Sub frmNuevo_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        pararCaptura()
    End Sub

    Private Sub frmNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class