Partial Class DataSet1
    Partial Public Class DataTable_Shubetsu1DataTable
        Private Sub DataTable_Shubetsu1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.I_SHUBETSU_CDColumn.ColumnName) Then
                'ユーザー コードをここに追加してください
            End If

        End Sub

    End Class
End Class
