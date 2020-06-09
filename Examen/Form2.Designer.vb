<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtHistorial = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cmbpositivo = New System.Windows.Forms.ComboBox()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtrecuperados = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(77, 22)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Departamento "
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(77, 59)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 20)
        Me.txtedad.TabIndex = 6
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(77, 132)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtMunicipio.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(77, 271)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(279, 45)
        Me.txtDescripcion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Descripcion"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Comayagua", "Francisco Morazan"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(95, 94)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartamento.TabIndex = 13
        '
        'txtHistorial
        '
        Me.txtHistorial.Location = New System.Drawing.Point(441, 12)
        Me.txtHistorial.Multiline = True
        Me.txtHistorial.Name = "txtHistorial"
        Me.txtHistorial.Size = New System.Drawing.Size(299, 304)
        Me.txtHistorial.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 198)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Positivo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Resultado"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(174, 198)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Negativo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmbpositivo
        '
        Me.cmbpositivo.FormattingEnabled = True
        Me.cmbpositivo.Items.AddRange(New Object() {"Muerto", "Recuperacion", "Cuidados intensivos"})
        Me.cmbpositivo.Location = New System.Drawing.Point(12, 221)
        Me.cmbpositivo.Name = "cmbpositivo"
        Me.cmbpositivo.Size = New System.Drawing.Size(115, 21)
        Me.cmbpositivo.TabIndex = 17
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(95, 327)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(75, 23)
        Me.btnHistorial.TabIndex = 18
        Me.btnHistorial.Text = "Agregar registro"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(511, 334)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.Size = New System.Drawing.Size(79, 20)
        Me.txtActivos.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Positivos"
        '
        'txtnegativos
        '
        Me.txtnegativos.Location = New System.Drawing.Point(511, 360)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.Size = New System.Drawing.Size(79, 20)
        Me.txtnegativos.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(438, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Negativos"
        '
        'txtrecuperados
        '
        Me.txtrecuperados.Location = New System.Drawing.Point(513, 386)
        Me.txtrecuperados.Name = "txtrecuperados"
        Me.txtrecuperados.Size = New System.Drawing.Size(79, 20)
        Me.txtrecuperados.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(438, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Recuperados"
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Location = New System.Drawing.Point(287, 198)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(85, 17)
        Me.chkRecuperado.TabIndex = 25
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkRecuperado)
        Me.Controls.Add(Me.txtrecuperados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnegativos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtActivos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.cmbpositivo)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtHistorial)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "Form2"
        Me.Text = "Ingreso de puruebas "
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents txtHistorial As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cmbpositivo As ComboBox
    Friend WithEvents btnHistorial As Button
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtrecuperados As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
