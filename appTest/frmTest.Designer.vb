<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.cnt1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_CerrarCnt1 = New System.Windows.Forms.Button()
        Me.cnt1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(177, 164)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(140, 39)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "Conectar y cargar datos"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'cnt1
        '
        Me.cnt1.Controls.Add(Me.Button1)
        Me.cnt1.Controls.Add(Me.btnNuevo)
        Me.cnt1.Controls.Add(Me.DataGridView1)
        Me.cnt1.Controls.Add(Me.btn_CerrarCnt1)
        Me.cnt1.Location = New System.Drawing.Point(12, 4)
        Me.cnt1.Name = "cnt1"
        Me.cnt1.Size = New System.Drawing.Size(457, 351)
        Me.cnt1.TabIndex = 1
        Me.cnt1.TabStop = False
        Me.cnt1.Text = "Resultados de Conexion a BD"
        Me.cnt1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Verificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 307)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 32)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 282)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_CerrarCnt1
        '
        Me.btn_CerrarCnt1.Location = New System.Drawing.Point(363, 307)
        Me.btn_CerrarCnt1.Name = "btn_CerrarCnt1"
        Me.btn_CerrarCnt1.Size = New System.Drawing.Size(88, 32)
        Me.btn_CerrarCnt1.TabIndex = 0
        Me.btn_CerrarCnt1.Text = "Cerrar"
        Me.btn_CerrarCnt1.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 367)
        Me.Controls.Add(Me.cnt1)
        Me.Controls.Add(Me.btn_connect)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de prueba"
        Me.cnt1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents cnt1 As GroupBox
    Friend WithEvents btn_CerrarCnt1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Button1 As Button
End Class
