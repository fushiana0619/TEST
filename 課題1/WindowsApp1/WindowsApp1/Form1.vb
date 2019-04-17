Imports System.Text
Imports System.Xml
Imports System.Data
'Imports System.Data.OracleClient
Imports Oracle.DataAccess.Client

Public Class Form1

    Private Const CONFIG_FILE_NAME As String = "config.xml"
    Private Const ROOT As String = "ROOT"
    Private Const FOLDER As String = "FOLDER"
    Private Const CONNECTION As String = "Data Source=orcl;User Id=system;Password=Tyatarou0;"
    Dim g_DataTable As New DataTable()

    Public Property _ExecutingRow As DataTable

    Public ReadOnly Property SearchResult() As DataTable
        Get
            Return _ExecutingRow
        End Get
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnMente1_Click(sender As Object, e As EventArgs) Handles btnMente1.Click
        Dim frmMente1 As Form = New Form2()
        frmMente1.ShowDialog()
    End Sub

    Private Sub btnMente2_Click(sender As Object, e As EventArgs) Handles btnMente2.Click
        Dim frmMente2 As Form = New Form3()
        frmMente2.ShowDialog()
    End Sub

    Private Sub btnReadFolder_Click(sender As Object, e As EventArgs) Handles btnReadFolder.Click
        '★★★FolderBrowserDialogを表示★★★
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim strSettingFilePath As String          'XML保存パス
        Dim strSelectedPath As String = ""        '選択したフォルダ
        Dim strDefaultFolderPath As String = ""   'フォルダ選択ダイアログ展開時の初期表示フォルダ
        Dim clsCommon As New clsCommon

        Try
            strSettingFilePath = System.Environment.CurrentDirectory & "\" & CONFIG_FILE_NAME

            'フォルダパスが入力されている場合はそのフォルダを表示
            '設定情報XMLファイルが存在する場合は設定されている設定情報にあるフォルダパスを初期表示
            If Me.FilePath.Text <> "" Then
                strDefaultFolderPath = Me.FilePath.Text
            Else
                If System.IO.File.Exists(strSettingFilePath) Then
                    strDefaultFolderPath = LoadXML(strSettingFilePath)
                Else
                    strDefaultFolderPath = System.Environment.CurrentDirectory
                End If
            End If

            'ダイアログを表示する
            strSelectedPath = clsCommon.ShowSelectdFolderDialog(strDefaultFolderPath)

            'フォルダ選択ダイアログがキャンセルされなかった場合
            If Not strSelectedPath = "" Then
                Me.FilePath.Text = strSelectedPath
            End If
            '選択されたフォルダを表示する

        Catch ex As Exception
            MessageBox.Show("取り込みフォルダ選択エラー")
        End Try
    End Sub

    Private Function SaveXML(ByVal strSettingFilePath As String, ByVal strSaveFolderPath As String) As String
        Dim strXMLFilePath As String = ""
        Dim XDoc As XmlDocument = New XmlDocument()

        Dim Xnode_file_node As XmlNode = XDoc.CreateNode(XmlNodeType.Text, "", "")
        Dim Xelem_root As XmlElement = XDoc.CreateElement(ROOT)
        Dim Xelem_folder As XmlElement = XDoc.CreateElement(FOLDER)
        Try

            If System.IO.File.Exists(strSettingFilePath) Then
                XDoc.Load(strSettingFilePath)
                XDoc.SelectSingleNode(ROOT & "/" & FOLDER).InnerText = strSaveFolderPath
            Else
                XDoc.AppendChild(Xelem_root)
                Xelem_root.AppendChild(Xelem_folder)
                Xnode_file_node.Value = strSaveFolderPath
                Xelem_folder.AppendChild(Xnode_file_node)
            End If

            XDoc.Save(strSettingFilePath)

        Catch ex As Exception
            MessageBox.Show("設定情報ファイルの保存に失敗しました")
        End Try
        Return strXMLFilePath
    End Function

    Private Function LoadXML(ByVal strSettingFilePath As String) As String
        Dim xmlLoadXML As XmlDocument = New XmlDocument()
        Dim strXMLFilePath As String = ""
        Dim strImportFolderPath As String = ""
        Try
            xmlLoadXML.Load(strSettingFilePath)
            strImportFolderPath = xmlLoadXML.SelectSingleNode(ROOT & "/" & FOLDER).InnerText
        Catch ex As Exception
            MessageBox.Show("設定情報ファイルの読み込みに失敗しました")
        End Try
        Return strImportFolderPath
    End Function

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        Dim strFolderPath As String = Me.FilePath.Text
        Dim files As String()
        Dim dtDatatable As New DataTable()
        Dim intLoop As Integer = 0
        Dim cboKBN1 As New DataGridViewComboBoxColumn()
        Dim cboKBN2 As New DataGridViewComboBoxColumn()
        Dim cboKBN3 As New DataGridViewComboBoxColumn()

        Try
            If System.IO.Directory.Exists(Me.FilePath.Text) Then

                ' データベースオープン
                'Dim conn As New OracleConnection(CONNECTION)
                Dim ds As New DataSet1()

                'conn.Open()
                ' 種別コンボボックスの内容をデータベースから取得して設定
                'Dim cmd1 As OracleCommand = New OracleCommand("SELECT * FROM TEST_DB WHERE I_SHUBETSU_CD = 1", conn)
                'Dim da1 As OracleDataAdapter = New OracleDataAdapter(cmd1)
                'Dim cmd2 As OracleCommand = New OracleCommand("SELECT * FROM TEST_DB WHERE I_SHUBETSU_CD = 2", conn)
                'Dim da2 As OracleDataAdapter = New OracleDataAdapter(cmd2)
                'Dim cmd3 As OracleCommand = New OracleCommand("SELECT * FROM TEST_DB WHERE I_SHUBETSU_CD = 3", conn)
                'Dim da3 As OracleDataAdapter = New OracleDataAdapter(cmd3)
                'Dim cmd_MEIMEI As OracleCommand = New OracleCommand("SELECT * FROM RULE_DB", conn)
                'Dim da_MEIMEI As OracleDataAdapter = New OracleDataAdapter(cmd_MEIMEI)
                Dim row As DataRow
                row = ds.DataTable_Shubetsu1.NewRow
                row("I_SHUBETSU_CD") = "1"
                row("I_CD_NUM") = "1"
                row("I_CD_MEISHO") = "A"
                ds.DataTable_Shubetsu1.Rows.Add(row)

                row = ds.DataTable_Shubetsu2.NewRow
                row("I_SHUBETSU_CD") = "2"
                row("I_CD_NUM") = "2"
                row("I_CD_MEISHO") = "B"
                ds.DataTable_Shubetsu2.Rows.Add(row)

                row = ds.DataTable_Shubetsu3.NewRow
                row("I_SHUBETSU_CD") = "3"
                row("I_CD_NUM") = "3"
                row("I_CD_MEISHO") = "C"
                ds.DataTable_Shubetsu3.Rows.Add(row)
                'g_DataTable = New DataTable()
                'da_MEIMEI.Fill(g_DataTable)
                cboKBN1 = CType(dgvFileData.Columns(2), DataGridViewComboBoxColumn)
                cboKBN2 = CType(dgvFileData.Columns(3), DataGridViewComboBoxColumn)
                cboKBN3 = CType(dgvFileData.Columns(4), DataGridViewComboBoxColumn)
                cboKBN1.DataSource = ds.DataTable_Shubetsu1
                cboKBN1.ValueMember = "I_CD_NUM"
                cboKBN1.DisplayMember = "I_CD_MEISHO"
                cboKBN2.DataSource = ds.DataTable_Shubetsu2
                cboKBN2.ValueMember = "I_CD_NUM"
                cboKBN2.DisplayMember = "I_CD_MEISHO"
                cboKBN3.DataSource = ds.DataTable_Shubetsu3
                cboKBN3.ValueMember = "I_CD_NUM"
                cboKBN3.DisplayMember = "I_CD_MEISHO"


                dtDatatable.Columns.Add(New DataColumn("FileName"))
                files = System.IO.Directory.GetFiles(strFolderPath, "*", System.IO.SearchOption.AllDirectories)
                For Each file As String In files
                    dtDatatable.Rows.Add()
                    dtDatatable.Rows(intLoop).Item(0) = System.IO.Path.GetFileName(file)
                    intLoop += 1
                Next


                SaveXML(System.Environment.CurrentDirectory & "\" & CONFIG_FILE_NAME, Me.FilePath.Text)
            Else
                MessageBox.Show("指定フォルダーが存在しません。取り込みフォルダパスを確認してください。")
            End If

            Me.dgvFileData.AutoGenerateColumns = False
            Me.dgvFileData.DataSource = dtDatatable
            Me.dgvFileData.Columns("colFileName").DataPropertyName = "FileName"

        Catch ex As Exception
            MessageBox.Show("一覧表示エラー。")
        End Try
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object,
    ByVal e As DataGridViewCellEventArgs) _
    Handles dgvFileData.CellEnter
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name.Contains("KBN") AndAlso
            TypeOf dgv.Columns(e.ColumnIndex) Is DataGridViewComboBoxColumn Then
            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub btnAllSelect_Click(sender As Object, e As EventArgs) Handles btnAllSelect.Click
        Try
            If Me.dgvFileData.RowCount <> 0 Then
                For i As Integer = 0 To Me.dgvFileData.RowCount - 1
                    ' チェックボックスの列番号を指定して、チェックをつける
                    Me.dgvFileData(0, i).Value = True
                Next
            End If
            Dim dt As New DataTable
            dt = g_DataTable
        Catch ex As Exception
            MessageBox.Show("全選択エラー")
        End Try
    End Sub

    Private Sub btnAllRelease_Click(sender As Object, e As EventArgs) Handles btnAllRelease.Click
        Try
            If Me.dgvFileData.RowCount <> 0 Then
                For i As Integer = 0 To Me.dgvFileData.RowCount - 1
                    ' チェックボックスの列番号を指定して、チェックをはずす
                    Me.dgvFileData(0, i).Value = False
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("全解除エラー")
        End Try
    End Sub

    Private dataGridViewComboBox As DataGridViewComboBoxEditingControl = Nothing

    'EditingControlShowingイベントハンドラ
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object,
        ByVal e As DataGridViewEditingControlShowingEventArgs) _
        Handles dgvFileData.EditingControlShowing
        '表示されているコントロールがDataGridViewComboBoxEditingControlか調べる
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            Dim dgv As DataGridView = CType(sender, DataGridView)

            '該当する列か調べる
            If dgv.CurrentCell.OwningColumn.Name.IndexOf("KBN") >= 0 Then
                '編集のために表示されているコントロールを取得
                Me.dataGridViewComboBox =
                CType(e.Control, DataGridViewComboBoxEditingControl)
                'SelectedIndexChangedイベントハンドラを追加
                AddHandler Me.dataGridViewComboBox.SelectedIndexChanged,
                AddressOf dataGridViewComboBox_SelectedIndexChanged
            End If
        End If
    End Sub

    'CellEndEditイベントハンドラ
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object,
        ByVal e As DataGridViewCellEventArgs) _
        Handles dgvFileData.CellEndEdit
        'SelectedIndexChangedイベントハンドラを削除
        If Not (Me.dataGridViewComboBox Is Nothing) Then
            RemoveHandler Me.dataGridViewComboBox.SelectedIndexChanged,
            AddressOf dataGridViewComboBox_SelectedIndexChanged
            Me.dataGridViewComboBox = Nothing
        End If
    End Sub

    'DataGridViewに表示されているコンボボックスの
    'SelectedIndexChangedイベントハンドラ
    Private Sub dataGridViewComboBox_SelectedIndexChanged(ByVal sender As Object,
        ByVal e As EventArgs)
        '選択されたアイテムを表示
        Dim cb As DataGridViewComboBoxEditingControl =
        CType(sender, DataGridViewComboBoxEditingControl)
        Console.WriteLine(cb.SelectedItem)
    End Sub

    Private Sub dgvFileData_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFileData.CurrentCellDirtyStateChanged
        'ここでコミットすることで、ユーザがDataGridViewCheckBoxColumn列のチェックを変更したらすぐにCellValueChangedイベントが走るようにする
        dgvFileData.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dgvFileData.EndEdit()
        Dim intSelectedRowNum As Integer = Me.dgvFileData.CurrentRow.Index
        If Me.dgvFileData(intSelectedRowNum, 2).Value <> "" _
           AndAlso Me.dgvFileData(intSelectedRowNum, 3).Value <> "" _
           AndAlso Me.dgvFileData(intSelectedRowNum, 4).Value <> "" Then
            Me.dgvFileData(intSelectedRowNum, 8).Value = g_DataTable
        End If
    End Sub

    ''' <summary>
    ''' チェックボックスがチェックされている行のコンボボックスが入力されているかどうかのチェック
    ''' </summary>
    ''' <returns></returns>
    Private Function ComboBlankCheckAll() As Boolean

        Dim blnCheckComplete As Boolean = True

        For Each dr As DataGridViewRow In Me.dgvFileData.Rows
            If CType(dr.Cells("CheckBox").Value, Boolean) Then
                ' チェックされている行のコンボボックスが入力されている場合
                If Not (dr.Cells(2).Value <> "" AndAlso dr.Cells(3).Value <> "" AndAlso dr.Cells(4).Value <> "") Then
                    blnCheckComplete = False
                    Exit For
                End If
            End If
        Next
        Return blnCheckComplete
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmKensaku As Form5
        Dim tbl As DataTable = New DataTable("table1")
        Dim row As DataRow
        Dim drSelectedRow As DataGridViewRow
        tbl.Columns.Add("Item0")
        tbl.Columns.Add("Item1")
        tbl.Columns.Add("Item2")
        tbl.Columns.Add("Item3")
        tbl.Columns.Add("Item4")
        '１列目
        row = tbl.NewRow
        row("Item0") = "1"
        row("Item1") = "BCDEFGHIJK"
        row("Item2") = "A2"
        row("Item3") = "A3"
        row("Item4") = "2019/4/1"
        tbl.Rows.Add(row)

        '２列目
        row = tbl.NewRow
        row("Item0") = "2"
        row("Item1") = "ABCDEFGHIJ"
        row("Item2") = "B2"
        row("Item3") = "B3"
        row("Item4") = "2019/4/2"
        tbl.Rows.Add(row)

        '３列目
        row = tbl.NewRow
        row("Item0") = "3"
        row("Item1") = "ZZXX"
        row("Item2") = "B2"
        row("Item3") = "B3"
        row("Item4") = "2019/4/3"
        tbl.Rows.Add(row)
        If ComboBlankCheckAll() Then
            For Each dr As DataGridViewRow In Me.dgvFileData.Rows
                If CType(dr.Cells("CheckBox").Value, Boolean) Then
                    If tbl.Rows.Count >= 2 Then
                        frmKensaku = New Form5()
                        frmKensaku.ExecutingTable = tbl
                        frmKensaku.strFileName = dr.Cells(1).Value
                        frmKensaku.ShowDialog()
                        drSelectedRow = frmKensaku.SelectedRow
                        dr.Cells("colBuhin").Value = drSelectedRow.Cells("colBuhin").Value
                        dr.Cells("colSetsuhen").Value = drSelectedRow.Cells("colSetsuhen").Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("未入力あり")
        End If
    End Sub
End Class
