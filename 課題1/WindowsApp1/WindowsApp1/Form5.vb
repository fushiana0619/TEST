Public Class Form5
    Private Shared Property _SelectedRow As DataGridViewRow
    Private Shared Property _ExecutingTable As DataTable
    Private Shared Property _strFileName As String

    Private Shared drFilterdTable() As DataRow

    Public ReadOnly Property SelectedRow() As DataGridViewRow
        Get
            Return _SelectedRow
        End Get
    End Property

    Public WriteOnly Property ExecutingTable() As DataTable
        Set(ByVal tbl As DataTable)
            _ExecutingTable = tbl
        End Set
    End Property

    Public WriteOnly Property strFileName() As String
        Set(ByVal strCurrentFileName As String)
            _strFileName = strCurrentFileName
        End Set
    End Property

    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitDataGridView(_ExecutingTable)
        Me.lblCurrentFileName.Text = _strFileName
    End Sub

    Private Sub btnBubun_Click(sender As Object, e As EventArgs) Handles btnBubun.Click
        Dim strFilter As String
        strFilter = "Item1 LIKE '%" & GetSelectFilterString(Trim(Me.txtBuhin.Text)) & "%'"
        SetFilterdDataGridView(strFilter)
    End Sub


    Private Sub btnSento_Click(sender As Object, e As EventArgs) Handles btnSento.Click
        Dim strFilter As String
        strFilter = "Item1 LIKE '" & GetSelectFilterString(Trim(Me.txtBuhin.Text)) & "%'"
        SetFilterdDataGridView(strFilter)
    End Sub

    Private Sub InitDataGridView(ByVal dtDataSource As DataTable)
        Me.dgvSentaku.AutoGenerateColumns = False
        Me.dgvSentaku.DataSource = dtDataSource
        Me.dgvSentaku.ClearSelection()
        Me.dgvSentaku.CurrentCell = Nothing
        Me.dgvSentaku.Columns("colNum").DataPropertyName = "Item0"
        Me.dgvSentaku.Columns("colBuhin").DataPropertyName = "Item1"
        Me.dgvSentaku.Columns("colSetsuhen").DataPropertyName = "Item2"
        Me.dgvSentaku.Columns("colKBN").DataPropertyName = "Item3"
        Me.dgvSentaku.Columns("colUpdateDate").DataPropertyName = "Item4"
    End Sub

    Private Sub btnKakutei_Click(sender As Object, e As EventArgs) Handles btnKakutei.Click
        If Not Me.dgvSentaku.CurrentRow Is Nothing Then
            _SelectedRow = Me.dgvSentaku.CurrentRow
            Me.Close()
        Else
            MessageBox.Show("選択されてない")
        End If
    End Sub

    Private Sub SetFilterdDataGridView(ByVal strSelect As String)
        Dim strFilter As String = ""

        If Trim(Me.txtBuhin.Text) = "" Then
            InitDataGridView(_ExecutingTable)
        Else
            drFilterdTable = _ExecutingTable.Select(strSelect)
            If drFilterdTable.Count = 0 Then
                InitDataGridView(_ExecutingTable)
            Else
                InitDataGridView(drFilterdTable.CopyToDataTable)
            End If
        End If
    End Sub

    Private Function GetSelectFilterString(ByVal filterString As String) As String
        Dim text As String = String.Empty

        For Each c As Char In filterString

            Select Case c
                Case "*"c, "%"c, "["c, "]"c
                    text += "[" & c & "]"
                Case Else
                    text += c
            End Select
        Next

        Return text
    End Function
End Class