Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        txtResltado.Text = Val(txtNumero1.Text) + Val(txtNumero2.Text)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        txtResltado.Text = Val(txtNumero1.Text) * Val(txtNumero2.Text)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        txtResltado.Text = Val(txtNumero1.Text) - Val(txtNumero2.Text)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        txtResltado.Text = Val(txtNumero1.Text) / Val(txtNumero2.Text)
    End Sub
End Class
