Public Class Form3
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("データを更新した場合はシステムを再起動してください")
        Me.Close()
    End Sub
End Class