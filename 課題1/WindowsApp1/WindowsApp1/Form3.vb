Public Class Form3

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtRuleShubetsu1 As New DataTable
        Dim row As DataRow
        Dim dtShubetsu1 As New DataTable

        dtShubetsu1.Columns.Add("ShubetsuCD")
        dtShubetsu1.Columns.Add("KEYCD")
        dtShubetsu1.Columns.Add("PatternMeisho")

        row = dtShubetsu1.NewRow
        row("ShubetsuCD") = "1"
        row("KEYCD") = "1"
        row("PatternMeisho") = "図面1"
        dtShubetsu1.Rows.Add(row)

        row = dtShubetsu1.NewRow
        row("ShubetsuCD") = "1"
        row("KEYCD") = "2"
        row("PatternMeisho") = "取引先1"
        dtShubetsu1.Rows.Add(row)

        row = dtShubetsu1.NewRow
        row("ShubetsuCD") = "1"
        row("KEYCD") = "3"
        row("PatternMeisho") = "図面種類1"
        dtShubetsu1.Rows.Add(row)

        Me.lstZumen.DataSource = dtShubetsu1
        Me.lstZumen.DisplayMember = "PatternMeisho"
        Me.lstZumen.ValueMember = "KEYCD"
        Me.lstZumen.SelectedIndex = -1

        Dim dtShubetsu2 As New DataTable

        dtShubetsu2.Columns.Add("ShubetsuCD")
        dtShubetsu2.Columns.Add("KEYCD")
        dtShubetsu2.Columns.Add("PatternMeisho")

        row = dtShubetsu2.NewRow
        row("ShubetsuCD") = "2"
        row("KEYCD") = "1"
        row("PatternMeisho") = "図面2"
        dtShubetsu2.Rows.Add(row)

        row = dtShubetsu2.NewRow
        row("ShubetsuCD") = "2"
        row("KEYCD") = "2"
        row("PatternMeisho") = "取引先2"
        dtShubetsu2.Rows.Add(row)

        row = dtShubetsu2.NewRow
        row("ShubetsuCD") = "2"
        row("KEYCD") = "3"
        row("PatternMeisho") = "図面種類2"
        dtShubetsu2.Rows.Add(row)

        Me.lstTorihiki.DataSource = dtShubetsu2
        Me.lstTorihiki.DisplayMember = "PatternMeisho"
        Me.lstTorihiki.ValueMember = "KEYCD"
        Me.lstTorihiki.SelectedIndex = -1

        Dim dtShubetsu3 As New DataTable

        dtShubetsu3.Columns.Add("ShubetsuCD")
        dtShubetsu3.Columns.Add("KEYCD")
        dtShubetsu3.Columns.Add("PatternMeisho")

        row = dtShubetsu3.NewRow
        row("ShubetsuCD") = "3"
        row("KEYCD") = "1"
        row("PatternMeisho") = "図面3"
        dtShubetsu3.Rows.Add(row)

        row = dtShubetsu3.NewRow
        row("ShubetsuCD") = "3"
        row("KEYCD") = "2"
        row("PatternMeisho") = "取引先3"
        dtShubetsu3.Rows.Add(row)

        row = dtShubetsu3.NewRow
        row("ShubetsuCD") = "3"
        row("KEYCD") = "3"
        row("PatternMeisho") = "図面種類3"
        dtShubetsu3.Rows.Add(row)

        Me.lstZumenShurui.DataSource = dtShubetsu3
        Me.lstZumenShurui.DisplayMember = "PatternMeisho"
        Me.lstZumenShurui.ValueMember = "KEYCD"
        Me.lstZumenShurui.SelectedIndex = -1

        Me.lblRuleHyoji.Text = ""
        ControlObject(2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("データを更新した場合はシステムを再起動してください")
        Me.Close()
    End Sub

    Private Sub btnHyoji_Click(sender As Object, e As EventArgs) Handles btnHyoji.Click
        If Not (Me.lstZumen.SelectedValue IsNot Nothing AndAlso
           Me.lstTorihiki.SelectedValue IsNot Nothing AndAlso
           Me.lstZumenShurui.SelectedValue IsNot Nothing) Then
            MessageBox.Show("入力パターン3つすべて選択してください")
            Exit Sub
        End If

        ControlObject(1)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ControlObject(2)
        ClearState(Me)
    End Sub

    Private Sub ControlObject(ByVal intMode As Integer)
        If intMode = 1 Then
            Me.lstZumen.Enabled = False
            Me.lstTorihiki.Enabled = False
            Me.lstZumenShurui.Enabled = False


            Me.gpbRule.Enabled = True
        Else
            Me.lstZumen.Enabled = True
            Me.lstTorihiki.Enabled = True
            Me.lstZumenShurui.Enabled = True

            Me.gpbRule.Enabled = False

        End If
    End Sub

    Private Sub ClearState(ByVal obj As Object)
        Dim ctl As Object
        For Each ctl In obj.Controls
            If ctl.GetType Is GetType(TextBox) Then
                ctl.Text = ""
            ElseIf ctl.GetType Is GetType(RadioButton) Then
                ctl.checked = False
            ElseIf ctl.GetType Is GetType(GroupBox) Then
                ClearState(ctl)
            End If
        Next
    End Sub

End Class