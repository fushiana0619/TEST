Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("データを更新した場合はシステムを再起動してください")
        Me.Close()
    End Sub
End Class