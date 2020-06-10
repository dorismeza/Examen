Public Class registro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtusuario.Text = "Administrador" And txtcontraseña.Text = "SinHacer2020" Then
                Form2.Show()
                Me.Close()
            Else
                MsgBox(" Usuario o contraseña incorrecta", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class