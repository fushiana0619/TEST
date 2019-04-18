Public Class Form2

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtCombo As New DataTable
        Dim row As DataRow

        dtCombo.Columns.Add("MeishoCD")
        dtCombo.Columns.Add("PatternMeisho")

        row = dtCombo.NewRow
        row("MeishoCD") = "1"
        row("PatternMeisho") = "図面"
        dtCombo.Rows.Add(row)

        row = dtCombo.NewRow
        row("MeishoCD") = "2"
        row("PatternMeisho") = "取引先"
        dtCombo.Rows.Add(row)

        row = dtCombo.NewRow
        row("MeishoCD") = "3"
        row("PatternMeisho") = "図面種類"
        dtCombo.Rows.Add(row)

        cmbShubetsu.DataSource = dtCombo
        Me.cmbShubetsu.DisplayMember = "PatternMeisho"
        Me.cmbShubetsu.ValueMember = "MeishoCD"

        Me.txtCDNUM.Enabled = False
        Me.txtCDMeisho.Enabled = False

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("データを更新した場合はシステムを再起動してください")
        Me.Close()
    End Sub

    Private Sub btnHyoji_Click(sender As Object, e As EventArgs) Handles btnHyoji.Click

        '種別コード
        Dim intShubetsu As Integer = CType(Me.cmbShubetsu.SelectedValue, Integer)

        Dim dtListData As New DataTable
        Dim row As DataRow

        RemoveHandler lstShubetsu.SelectedIndexChanged, AddressOf lstShubetsu_SelectedIndexChanged

        Me.txtCDNUM.Text = ""
        Me.txtCDMeisho.Text = ""
        Me.txtCDNUM.Enabled = True
        Me.txtCDMeisho.Enabled = True

        '修正行↓
        dtListData.Columns.Add("KEYCD")
        dtListData.Columns.Add("PatternMeisho")

        row = dtListData.NewRow
        row("KEYCD") = "1"
        row("PatternMeisho") = "帳票"
        dtListData.Rows.Add(row)

        row = dtListData.NewRow
        row("KEYCD") = "2"
        row("PatternMeisho") = "2D図面"
        dtListData.Rows.Add(row)

        row = dtListData.NewRow
        row("KEYCD") = "3"
        row("PatternMeisho") = "3D図面"
        dtListData.Rows.Add(row)
        '修正行↑

        Me.lstShubetsu.DataSource = dtListData
        Me.lstShubetsu.DisplayMember = "PatternMeisho"
        Me.lstShubetsu.ValueMember = "KEYCD"
        Me.lstShubetsu.SelectedIndex = -1
        AddHandler lstShubetsu.SelectedIndexChanged, AddressOf lstShubetsu_SelectedIndexChanged

        Me.cmbShubetsu.Enabled = False

    End Sub

    Private Sub lstShubetsu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstShubetsu.SelectedIndexChanged
        Me.txtCDNUM.Text = Me.lstShubetsu.SelectedValue.ToString
        Me.txtCDMeisho.Text = DirectCast(Me.lstShubetsu.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RemoveHandler lstShubetsu.SelectedIndexChanged, AddressOf lstShubetsu_SelectedIndexChanged
        Me.txtCDNUM.Text = ""
        Me.txtCDMeisho.Text = ""
        Me.txtCDNUM.Enabled = False
        Me.txtCDMeisho.Enabled = False
        Me.cmbShubetsu.Enabled = True
        Me.lstShubetsu.DataSource = Nothing
    End Sub

    Private Sub txtCDNUM_KeyPress(ByVal sender As System.Object,
    ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtCDNUM.KeyPress
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Function BlankCheck() As Boolean
        Dim blnCheckFLG As Boolean = False
        If Trim(Me.txtCDNUM.Text) <> "" AndAlso Trim(Me.txtCDMeisho.Text) <> "" Then
            blnCheckFLG = True
        Else
            blnCheckFLG = False
        End If
        Return blnCheckFLG
    End Function

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        If Not BlankCheck() Then
            MessageBox.Show("空白が入力されているため処理を中止しました。")
            Exit Sub
        End If

        'キー項目重複チェック
        For Each objListItem In Me.lstShubetsu.Items
            If Trim(Me.txtCDNUM.Text) = DirectCast(objListItem, System.Data.DataRowView).Row.ItemArray(0) Then
                MessageBox.Show("重複あり")
                Exit Sub
            End If
        Next

        'Insert処理

        '再表示
        btnHyoji.PerformClick()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim blnJuufukuFLG As Boolean = False

        If Not BlankCheck() Then
            MessageBox.Show("空白が入力されているため処理を中止しました。")
            Exit Sub
        End If

        For Each objListItem In Me.lstShubetsu.Items
            If Trim(Me.txtCDNUM.Text) = DirectCast(objListItem, System.Data.DataRowView).Row.ItemArray(0) Then
                blnJuufukuFLG = True
                Exit For
            End If
        Next

        If Not blnJuufukuFLG Then
            MessageBox.Show("修正対象がありません")
            Exit Sub
        End If
        'キー存在チェック

        '再表示
        btnHyoji.PerformClick()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not BlankCheck() Then
            MessageBox.Show("空白が入力されているため処理を中止しました。")
            Exit Sub
        End If
        '命名テーブル、チェック

        '再表示
        btnHyoji.PerformClick()

    End Sub
End Class