<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevo))
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblHuella = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.imgStatus = New System.Windows.Forms.PictureBox()
        Me.lblCapturar = New System.Windows.Forms.Label()
        Me.ctnCaptura = New System.Windows.Forms.GroupBox()
        Me.imgHuella = New System.Windows.Forms.PictureBox()
        Me.lblDedo = New System.Windows.Forms.Label()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctnCaptura.SuspendLayout()
        CType(Me.imgHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(25, 58)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(40, 13)
        Me.lblCedula.TabIndex = 0
        Me.lblCedula.Text = "Cedula"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(16, 85)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 1
        Me.lblNombres.Text = "Nombres"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(16, 110)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos.TabIndex = 2
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(27, 135)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 3
        Me.lblCorreo.Text = "Correo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(64, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(249, 23)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Registro de Nuevo Usuario"
        '
        'lblHuella
        '
        Me.lblHuella.AutoSize = True
        Me.lblHuella.Location = New System.Drawing.Point(28, 169)
        Me.lblHuella.Name = "lblHuella"
        Me.lblHuella.Size = New System.Drawing.Size(37, 13)
        Me.lblHuella.TabIndex = 5
        Me.lblHuella.Text = "Huella"
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(107, 207)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(257, 34)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(18, 207)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(83, 35)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(66, 55)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 8
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(66, 82)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(303, 20)
        Me.txtNombres.TabIndex = 9
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(66, 107)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(303, 20)
        Me.txtApellidos.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(66, 135)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(303, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'imgStatus
        '
        Me.imgStatus.Image = CType(resources.GetObject("imgStatus.Image"), System.Drawing.Image)
        Me.imgStatus.Location = New System.Drawing.Point(66, 161)
        Me.imgStatus.Name = "imgStatus"
        Me.imgStatus.Size = New System.Drawing.Size(31, 31)
        Me.imgStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStatus.TabIndex = 12
        Me.imgStatus.TabStop = False
        '
        'lblCapturar
        '
        Me.lblCapturar.AutoSize = True
        Me.lblCapturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapturar.ForeColor = System.Drawing.Color.Blue
        Me.lblCapturar.Location = New System.Drawing.Point(103, 169)
        Me.lblCapturar.Name = "lblCapturar"
        Me.lblCapturar.Size = New System.Drawing.Size(55, 13)
        Me.lblCapturar.TabIndex = 13
        Me.lblCapturar.Text = "Capturar"
        '
        'ctnCaptura
        '
        Me.ctnCaptura.Controls.Add(Me.imgHuella)
        Me.ctnCaptura.Controls.Add(Me.lblDedo)
        Me.ctnCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctnCaptura.Location = New System.Drawing.Point(12, 8)
        Me.ctnCaptura.Name = "ctnCaptura"
        Me.ctnCaptura.Size = New System.Drawing.Size(357, 233)
        Me.ctnCaptura.TabIndex = 14
        Me.ctnCaptura.TabStop = False
        Me.ctnCaptura.Text = "Capturando Huella"
        Me.ctnCaptura.Visible = False
        '
        'imgHuella
        '
        Me.imgHuella.BackColor = System.Drawing.Color.Transparent
        Me.imgHuella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgHuella.Location = New System.Drawing.Point(104, 24)
        Me.imgHuella.Margin = New System.Windows.Forms.Padding(1)
        Me.imgHuella.Name = "imgHuella"
        Me.imgHuella.Size = New System.Drawing.Size(167, 189)
        Me.imgHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHuella.TabIndex = 2
        Me.imgHuella.TabStop = False
        Me.imgHuella.WaitOnLoad = True
        '
        'lblDedo
        '
        Me.lblDedo.AutoSize = True
        Me.lblDedo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDedo.Location = New System.Drawing.Point(113, 217)
        Me.lblDedo.Name = "lblDedo"
        Me.lblDedo.Size = New System.Drawing.Size(43, 13)
        Me.lblDedo.TabIndex = 1
        Me.lblDedo.Text = "Label1"
        '
        'frmNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 253)
        Me.Controls.Add(Me.ctnCaptura)
        Me.Controls.Add(Me.lblCapturar)
        Me.Controls.Add(Me.imgStatus)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblHuella)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblCedula)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctnCaptura.ResumeLayout(False)
        Me.ctnCaptura.PerformLayout()
        CType(Me.imgHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblHuella As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents imgStatus As PictureBox
    Friend WithEvents lblCapturar As Label
    Friend WithEvents ctnCaptura As GroupBox
    Friend WithEvents lblDedo As Label
    Friend WithEvents imgHuella As PictureBox
End Class
