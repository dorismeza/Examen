Imports System.ComponentModel

Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
        cmbpositivo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cancel As Integer
        If (MsgBox("Esta seguro que desea salir ", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
            Cancel = 1
        End If

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim nombre As String
        Dim edad, positivo, negativo, recuperado As Integer
        Dim iddepartamento, itemdepartamento As String
        Dim municipio As String
        Dim descripcion As String
        Dim historial, idpositivo, itempositivo As String

        nombre = txtnombre.Text
        edad = txtedad.Text
        iddepartamento = cmbDepartamento.SelectedIndex
        itemdepartamento = cmbDepartamento.SelectedItem.ToString
        idpositivo = cmbpositivo.SelectedIndex
        itempositivo = cmbpositivo.SelectedItem.ToString
        municipio = txtMunicipio.Text
        descripcion = txtDescripcion.Text
        historial = txtHistorial.Text

        If CheckBox1.Checked = True Then
            positivo += 1
        ElseIf CheckBox2.Checked = True Then
            negativo += 1
        ElseIf chkRecuperado.Checked = True Then
            recuperado += 1
        End If

        Try
            Select Case iddepartamento
                Case 0
                    If CheckBox1.Checked = True Then

                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf
                    End If
                    If CheckBox2.Checked = True Then
                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf

                    End If
                    If chkRecuperado.Checked = True Then

                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf
                    End If
                Case 1
                    If CheckBox1.Checked = True Then

                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf
                    End If
                    If CheckBox2.Checked = True Then
                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf

                    End If
                    If chkRecuperado.Checked = True Then

                        txtHistorial.Text = txtHistorial.Text & itemdepartamento & nombre & " " & edad & vbCrLf & descripcion & vbCrLf
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        txtActivos.Text = positivo
        txtnegativos.Text = negativo
        txtrecuperados.Text = recuperado


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            chkRecuperado.Enabled = False
            cmbpositivo.Enabled = True
        End If
        If CheckBox1.Checked = False Then
            CheckBox2.Enabled = True
            chkRecuperado.Enabled = True
            cmbpositivo.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            chkRecuperado.Enabled = False
            cmbpositivo.Enabled = True

        End If
        If CheckBox2.Checked = False Then
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub chkRecuperado_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecuperado.CheckedChanged
        If chkRecuperado.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            cmbpositivo.Enabled = True
        End If
        If chkRecuperado.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating

    End Sub
End Class