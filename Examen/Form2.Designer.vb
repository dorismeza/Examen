<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.chkpositivo = New System.Windows.Forms.CheckBox()
        Me.chknegativo = New System.Windows.Forms.CheckBox()
        Me.cmbpositivo = New System.Windows.Forms.ComboBox()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtrecuperados = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtedad = New System.Windows.Forms.MaskedTextBox()
        Me.Lugar = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkrecuperados = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listaPacientes = New System.Windows.Forms.ListBox()
        Me.listaDepto = New System.Windows.Forms.ListBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Lugar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(94, 34)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Departamento "
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(89, 57)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(121, 20)
        Me.txtMunicipio.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 28)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(381, 45)
        Me.txtDescripcion.TabIndex = 12
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlantida", "Colón", "Comayagua", "Copan", "Cortes", "Choluteca", "El Paraiso", "Francisco Morazán", "Gracias a Dios", "Intibuca ", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(89, 22)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepartamento.TabIndex = 13
        '
        'chkpositivo
        '
        Me.chkpositivo.AutoSize = True
        Me.chkpositivo.Location = New System.Drawing.Point(6, 27)
        Me.chkpositivo.Name = "chkpositivo"
        Me.chkpositivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkpositivo.Size = New System.Drawing.Size(63, 17)
        Me.chkpositivo.TabIndex = 15
        Me.chkpositivo.Text = "Positivo"
        Me.chkpositivo.UseVisualStyleBackColor = True
        '
        'chknegativo
        '
        Me.chknegativo.AutoSize = True
        Me.chknegativo.Location = New System.Drawing.Point(167, 27)
        Me.chknegativo.Name = "chknegativo"
        Me.chknegativo.Size = New System.Drawing.Size(69, 17)
        Me.chknegativo.TabIndex = 16
        Me.chknegativo.Text = "Negativo"
        Me.chknegativo.UseVisualStyleBackColor = True
        '
        'cmbpositivo
        '
        Me.cmbpositivo.Enabled = False
        Me.cmbpositivo.FormattingEnabled = True
        Me.cmbpositivo.Items.AddRange(New Object() {"Activo", "Estado Critico", "Muerto"})
        Me.cmbpositivo.Location = New System.Drawing.Point(6, 53)
        Me.cmbpositivo.Name = "cmbpositivo"
        Me.cmbpositivo.Size = New System.Drawing.Size(115, 21)
        Me.cmbpositivo.TabIndex = 17
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(35, 361)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(75, 23)
        Me.btnHistorial.TabIndex = 18
        Me.btnHistorial.Text = "Agregar registro"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(510, 358)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.ReadOnly = True
        Me.txtActivos.Size = New System.Drawing.Size(59, 20)
        Me.txtActivos.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Positivos"
        '
        'txtnegativos
        '
        Me.txtnegativos.Location = New System.Drawing.Point(511, 326)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.ReadOnly = True
        Me.txtnegativos.Size = New System.Drawing.Size(58, 20)
        Me.txtnegativos.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(438, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Negativos"
        '
        'txtrecuperados
        '
        Me.txtrecuperados.Location = New System.Drawing.Point(686, 322)
        Me.txtrecuperados.Name = "txtrecuperados"
        Me.txtrecuperados.ReadOnly = True
        Me.txtrecuperados.Size = New System.Drawing.Size(55, 20)
        Me.txtrecuperados.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(611, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Recuperados"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(153, 361)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(94, 68)
        Me.txtedad.Mask = "999"
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 20)
        Me.txtedad.TabIndex = 5
        Me.txtedad.ValidatingType = GetType(Integer)
        '
        'Lugar
        '
        Me.Lugar.Controls.Add(Me.cmbDepartamento)
        Me.Lugar.Controls.Add(Me.Label4)
        Me.Lugar.Controls.Add(Me.txtMunicipio)
        Me.Lugar.Controls.Add(Me.Label2)
        Me.Lugar.Location = New System.Drawing.Point(218, 12)
        Me.Lugar.Name = "Lugar"
        Me.Lugar.Size = New System.Drawing.Size(217, 100)
        Me.Lugar.TabIndex = 28
        Me.Lugar.TabStop = False
        Me.Lugar.Text = "Lugar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkrecuperados)
        Me.GroupBox2.Controls.Add(Me.cmbpositivo)
        Me.GroupBox2.Controls.Add(Me.chkpositivo)
        Me.GroupBox2.Controls.Add(Me.chknegativo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 80)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado de Pruebas"
        '
        'chkrecuperados
        '
        Me.chkrecuperados.AutoSize = True
        Me.chkrecuperados.Location = New System.Drawing.Point(286, 27)
        Me.chkrecuperados.Name = "chkrecuperados"
        Me.chkrecuperados.Size = New System.Drawing.Size(90, 17)
        Me.chkrecuperados.TabIndex = 18
        Me.chkrecuperados.Text = "Recuperados"
        Me.chkrecuperados.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 88)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descripción"
        '
        'listaPacientes
        '
        Me.listaPacientes.FormattingEnabled = True
        Me.listaPacientes.HorizontalScrollbar = True
        Me.listaPacientes.Location = New System.Drawing.Point(448, 17)
        Me.listaPacientes.MultiColumn = True
        Me.listaPacientes.Name = "listaPacientes"
        Me.listaPacientes.ScrollAlwaysVisible = True
        Me.listaPacientes.Size = New System.Drawing.Size(291, 199)
        Me.listaPacientes.TabIndex = 13
        '
        'listaDepto
        '
        Me.listaDepto.FormattingEnabled = True
        Me.listaDepto.HorizontalScrollbar = True
        Me.listaDepto.Location = New System.Drawing.Point(448, 216)
        Me.listaDepto.Name = "listaDepto"
        Me.listaDepto.Size = New System.Drawing.Size(291, 82)
        Me.listaDepto.TabIndex = 31
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.listaDepto)
        Me.Controls.Add(Me.listaPacientes)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lugar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtrecuperados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnegativos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtActivos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Ingreso de Pruebas "
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Lugar.ResumeLayout(False)
        Me.Lugar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents chkpositivo As CheckBox
    Friend WithEvents chknegativo As CheckBox
    Friend WithEvents cmbpositivo As ComboBox
    Friend WithEvents btnHistorial As Button
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtrecuperados As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lugar As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtedad As MaskedTextBox
    Friend WithEvents listaDepto As ListBox
    Friend WithEvents listaPacientes As ListBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents chkrecuperados As CheckBox
End Class
