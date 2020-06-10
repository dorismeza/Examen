Imports System.ComponentModel

Public Class Form2
    Dim nombre As String
    Dim edad, positivo, negativo, recuperado, cont As Integer
    Dim iddepartamento, itemdepartamento As String
    Dim municipio As String
    Dim descripcion As String
    Dim listpacient, listdepto, idpositivo, itempositivo As String
    Dim i As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
        cmbpositivo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        cont = 0

        nombre = txtnombre.Text
        edad = Val(txtedad.Text)
        iddepartamento = cmbDepartamento.SelectedIndex
        itemdepartamento = cmbDepartamento.SelectedItem
        idpositivo = cmbpositivo.SelectedIndex
        itempositivo = cmbpositivo.SelectedItem
        municipio = txtMunicipio.Text
        descripcion = txtDescripcion.Text
        listpacient = listaPacientes.Text
        listdepto = listaDepto.Text

        Try
            cont += 1
            validaciones()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtActivos.Text = positivo
        txtnegativos.Text = negativo
        txtrecuperados.Text = recuperado


    End Sub

    Private Sub chkpositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkpositivo.CheckedChanged
        If chkpositivo.Checked = True Then
            chknegativo.Enabled = False
            chkrecuperados.Enabled = False
            cmbpositivo.Enabled = True
        End If
        If chkpositivo.Checked = False Then
            chknegativo.Enabled = True
            chkrecuperados.Enabled = True
            cmbpositivo.Enabled = False
        End If
    End Sub

    Private Sub chknegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chknegativo.CheckedChanged
        If chknegativo.Checked = True Then
            chkrecuperados.Enabled = False
            chkpositivo.Enabled = False
            cmbpositivo.Enabled = False

        End If
        If chknegativo.Checked = False Then
            chkrecuperados.Enabled = True
            chkpositivo.Enabled = True
            cmbpositivo.Enabled = False
        End If
    End Sub
    Private Sub chkrecuperados_CheckedChanged(sender As Object, e As EventArgs) Handles chkrecuperados.CheckedChanged
        If chkrecuperados.Checked = True Then
            chkpositivo.Enabled = False
            chknegativo.Enabled = False
            cmbpositivo.Enabled = False

        End If
        If chkrecuperados.Checked = False Then
            chknegativo.Enabled = True
            chkpositivo.Enabled = True
            cmbpositivo.Enabled = False
        End If
    End Sub

    Private Sub Estado()
        Dim a, b, c As Integer
        Try

            Select Case idpositivo
                Case 0 'activo
                    a += 1
                    b += recuperado
                    a += 1
                    b += recuperado
                    listdepto = listaDepto.Items.Add(itemdepartamento)
                    listdepto = listaDepto.Items.Add("Infectados: " & a)
                    listdepto = listaDepto.Items.Add("Mertos " & c)
                    listdepto = listaDepto.Items.Add("Recuperados " & b)
                Case 1 'critico
                    a += 1
                    b += recuperado
                    listdepto = listaDepto.Items.Add(itemdepartamento)
                    listdepto = listaDepto.Items.Add("Infectados: " & a)
                    listdepto = listaDepto.Items.Add("Mertos " & c)
                    listdepto = listaDepto.Items.Add("Recuperados " & b)
                Case 2 'muerto
                    c += 1
                    b += recuperado
                    listdepto = listaDepto.Items.Add(itemdepartamento)
                    listdepto = listaDepto.Items.Add("Infectados: " & a)
                    listdepto = listaDepto.Items.Add("Mertos " & c)
                    listdepto = listaDepto.Items.Add("Recuperados " & b)


            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Deptos()
        Try
            Select Case iddepartamento
                Case 0

                    Estado()
                Case 1

                    Estado()
                Case 2

                    Estado()
                Case 3

                    Estado()
                Case 4

                    Estado()
                Case 5

                    Estado()
                Case 6

                    Estado()
                Case 7

                    Estado()
                Case 8

                    Estado()
                Case 9

                    Estado()
                Case 10

                    Estado()
                Case 11

                    Estado()
                Case 12

                    Estado()
                Case 13

                    Estado()
                Case 14

                    Estado()
                Case 15

                    Estado()
                Case 16

                    Estado()
                Case 17

                    Estado()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtActivos.Clear()
        txtnombre.Clear()
        txtedad.Clear()
        txtDescripcion.Clear()
        txtMunicipio.Clear()
        chknegativo.Checked = False
        chkpositivo.Checked = False
        chkrecuperados.Checked = False
        listaDepto.Items.Clear()
        txtnegativos.Clear()
        txtrecuperados.Clear()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer
        Try
            If (MsgBox("¿Esta seguro que desea salir? ", vbCritical + vbYesNo) = vbYes) Then
                Me.Close()
            Else
                no = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub validaciones()
        If cmbDepartamento.Text = "" Then
            MsgBox("Agregue un departamento")

        ElseIf txtMunicipio.Text = "" Then
            MsgBox("Agregue un municipio")

        ElseIf txtnombre.Text = "" Then
            MsgBox("Ingrese un nombre ")


        ElseIf txtedad.Text = "" Then
            MsgBox("Ingrese una edad ")


        ElseIf IsNumeric(txtnombre.Text) Then
            MsgBox("Nombre incorrecto")
            txtnombre.Text = ""

        ElseIf IsNumeric(txtMunicipio.Text) Then
            MsgBox("Municipio incorrecto")
            txtMunicipio.Text = ""

        Else

            If chkpositivo.Checked = True Then
                listpacient = listaPacientes.Items.Add(cont & " - " & municipio & ", " & itemdepartamento & ", Paciente: " & nombre & ", Edad: " & edad & ", Positivo: " & itempositivo)
                listpacient = listaPacientes.Items.Add(descripcion)
                listpacient = listaPacientes.Items.Add(" ")
                positivo += 1
            ElseIf chknegativo.Checked = True Then
                listpacient = listaPacientes.Items.Add(cont & " - " & municipio & ", " & itemdepartamento & ", Paciente: " & nombre & ", Edad: " & edad & ", Negativo ")
                listpacient = listaPacientes.Items.Add(descripcion)
                listpacient = listaPacientes.Items.Add(" ")
                negativo += 1

            ElseIf chkrecuperados.Checked = True Then
                listpacient = listaPacientes.Items.Add(cont & " - " & municipio & ", " & itemdepartamento & ", Paciente: " & nombre & ", Edad: " & edad & ", Recuperado ")
                listpacient = listaPacientes.Items.Add(descripcion)
                listpacient = listaPacientes.Items.Add(" ")
                recuperado += 1
            End If

            Deptos()

            If chkpositivo.Checked = False And chknegativo.Checked = False And chkrecuperados.Checked = False Then
                MsgBox("Seleccione un resultado de la prueba ")
            End If
        End If


    End Sub
    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una nombre")
        End If
    End Sub

    Private Sub listaDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaDepto.SelectedIndexChanged
        Deptos()
    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese la edad")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un Municipio")
        End If
    End Sub

    Private Sub cmbDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepartamento.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un Departamento")
        End If
    End Sub

    Private Sub cmbpositivo_Validating(sender As Object, e As CancelEventArgs) Handles cmbpositivo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un estado")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Descripcion")
        End If
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ToolTip.SetToolTip(txtnombre, "Escribe un nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        ToolTip.SetToolTip(txtedad, "Esccibe una edad")
        ToolTip.ToolTipTitle = "Edad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Escribe el municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip.SetToolTip(cmbDepartamento, "Selecciona un Departamento")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Escribe una descripcion")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbpositivo_MouseHover(sender As Object, e As EventArgs) Handles cmbpositivo.MouseHover
        ToolTip.SetToolTip(cmbpositivo, "Selecciona")
        ToolTip.ToolTipTitle = "Estado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class