<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerify
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imgHuella = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTextCedula = New System.Windows.Forms.Label()
        Me.lblTextNombres = New System.Windows.Forms.Label()
        Me.lblTextApellidos = New System.Windows.Forms.Label()
        Me.lblTextCorreo = New System.Windows.Forms.Label()
        Me.lblStatusFound = New System.Windows.Forms.Label()
        CType(Me.imgHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgHuella
        '
        Me.imgHuella.BackColor = System.Drawing.Color.Transparent
        Me.imgHuella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgHuella.Location = New System.Drawing.Point(10, 44)
        Me.imgHuella.Margin = New System.Windows.Forms.Padding(1)
        Me.imgHuella.Name = "imgHuella"
        Me.imgHuella.Size = New System.Drawing.Size(147, 179)
        Me.imgHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHuella.TabIndex = 3
        Me.imgHuella.TabStop = False
        Me.imgHuella.WaitOnLoad = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(42, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 23)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Verificacion de Usuario por Huella"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(325, 233)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Regresar"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(175, 68)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(40, 13)
        Me.lblCedula.TabIndex = 6
        Me.lblCedula.Text = "Cedula"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(166, 101)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 7
        Me.lblNombres.Text = "Nombres"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(166, 138)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos.TabIndex = 8
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(177, 174)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 9
        Me.lblCorreo.Text = "Correo"
        '
        'lblTextCedula
        '
        Me.lblTextCedula.AutoSize = True
        Me.lblTextCedula.ForeColor = System.Drawing.Color.Green
        Me.lblTextCedula.Location = New System.Drawing.Point(215, 68)
        Me.lblTextCedula.Name = "lblTextCedula"
        Me.lblTextCedula.Size = New System.Drawing.Size(0, 13)
        Me.lblTextCedula.TabIndex = 10
        '
        'lblTextNombres
        '
        Me.lblTextNombres.AutoSize = True
        Me.lblTextNombres.ForeColor = System.Drawing.Color.Green
        Me.lblTextNombres.Location = New System.Drawing.Point(215, 101)
        Me.lblTextNombres.Name = "lblTextNombres"
        Me.lblTextNombres.Size = New System.Drawing.Size(0, 13)
        Me.lblTextNombres.TabIndex = 11
        '
        'lblTextApellidos
        '
        Me.lblTextApellidos.AutoSize = True
        Me.lblTextApellidos.ForeColor = System.Drawing.Color.Green
        Me.lblTextApellidos.Location = New System.Drawing.Point(215, 138)
        Me.lblTextApellidos.Name = "lblTextApellidos"
        Me.lblTextApellidos.Size = New System.Drawing.Size(0, 13)
        Me.lblTextApellidos.TabIndex = 12
        '
        'lblTextCorreo
        '
        Me.lblTextCorreo.AutoSize = True
        Me.lblTextCorreo.ForeColor = System.Drawing.Color.Green
        Me.lblTextCorreo.Location = New System.Drawing.Point(215, 174)
        Me.lblTextCorreo.Name = "lblTextCorreo"
        Me.lblTextCorreo.Size = New System.Drawing.Size(0, 13)
        Me.lblTextCorreo.TabIndex = 13
        '
        'lblStatusFound
        '
        Me.lblStatusFound.AutoSize = True
        Me.lblStatusFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusFound.ForeColor = System.Drawing.Color.Green
        Me.lblStatusFound.Location = New System.Drawing.Point(121, 233)
        Me.lblStatusFound.Name = "lblStatusFound"
        Me.lblStatusFound.Size = New System.Drawing.Size(167, 17)
        Me.lblStatusFound.TabIndex = 14
        Me.lblStatusFound.Text = "¡ usuario encontrado !"
        Me.lblStatusFound.Visible = False
        '
        'frmVerify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 268)
        Me.Controls.Add(Me.lblStatusFound)
        Me.Controls.Add(Me.lblTextCorreo)
        Me.Controls.Add(Me.lblTextApellidos)
        Me.Controls.Add(Me.lblTextNombres)
        Me.Controls.Add(Me.lblTextCedula)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.imgHuella)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Verificacion"
        CType(Me.imgHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgHuella As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTextCedula As Label
    Friend WithEvents lblTextNombres As Label
    Friend WithEvents lblTextApellidos As Label
    Friend WithEvents lblTextCorreo As Label
    Friend WithEvents lblStatusFound As Label
End Class
