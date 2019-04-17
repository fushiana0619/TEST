<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvFileData = New System.Windows.Forms.DataGridView()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.dsDataSet = New System.Data.DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAllSelect = New System.Windows.Forms.Button()
        Me.btnAllRelease = New System.Windows.Forms.Button()
        Me.btnReadFolder = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMente1 = New System.Windows.Forms.Button()
        Me.btnMente2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KBN1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KBN2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KBN3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colBuhin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSetsuhen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFoloder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbDirectory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgvFileData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFileData
        '
        Me.dgvFileData.AllowUserToAddRows = False
        Me.dgvFileData.AllowUserToDeleteRows = False
        Me.dgvFileData.AllowUserToResizeColumns = False
        Me.dgvFileData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFileData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBox, Me.colFileName, Me.KBN1, Me.KBN2, Me.KBN3, Me.colBuhin, Me.colSetsuhen, Me.colPage, Me.SaveFoloder, Me.cmbDirectory})
        Me.dgvFileData.Location = New System.Drawing.Point(12, 109)
        Me.dgvFileData.Name = "dgvFileData"
        Me.dgvFileData.RowHeadersVisible = False
        Me.dgvFileData.RowTemplate.Height = 21
        Me.dgvFileData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFileData.Size = New System.Drawing.Size(1304, 305)
        Me.dgvFileData.TabIndex = 2
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(12, 31)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(333, 19)
        Me.FilePath.TabIndex = 0
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(501, 27)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "読み込み"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'dsDataSet
        '
        Me.dsDataSet.DataSetName = "NewDataSet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1241, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "閉じる"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(1241, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "変換"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAllSelect
        '
        Me.btnAllSelect.Location = New System.Drawing.Point(13, 75)
        Me.btnAllSelect.Name = "btnAllSelect"
        Me.btnAllSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnAllSelect.TabIndex = 8
        Me.btnAllSelect.Text = "全選択"
        Me.btnAllSelect.UseVisualStyleBackColor = True
        '
        'btnAllRelease
        '
        Me.btnAllRelease.Location = New System.Drawing.Point(94, 75)
        Me.btnAllRelease.Name = "btnAllRelease"
        Me.btnAllRelease.Size = New System.Drawing.Size(75, 23)
        Me.btnAllRelease.TabIndex = 9
        Me.btnAllRelease.Text = "全解除"
        Me.btnAllRelease.UseVisualStyleBackColor = True
        '
        'btnReadFolder
        '
        Me.btnReadFolder.Location = New System.Drawing.Point(351, 30)
        Me.btnReadFolder.Name = "btnReadFolder"
        Me.btnReadFolder.Size = New System.Drawing.Size(75, 19)
        Me.btnReadFolder.TabIndex = 1
        Me.btnReadFolder.Text = "参照"
        Me.btnReadFolder.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "取り込みフォルダ選択"
        '
        'btnMente1
        '
        Me.btnMente1.Location = New System.Drawing.Point(12, 451)
        Me.btnMente1.Name = "btnMente1"
        Me.btnMente1.Size = New System.Drawing.Size(185, 23)
        Me.btnMente1.TabIndex = 4
        Me.btnMente1.Text = "メンテナンス画面1"
        Me.btnMente1.UseVisualStyleBackColor = True
        '
        'btnMente2
        '
        Me.btnMente2.Location = New System.Drawing.Point(229, 451)
        Me.btnMente2.Name = "btnMente2"
        Me.btnMente2.Size = New System.Drawing.Size(185, 23)
        Me.btnMente2.TabIndex = 5
        Me.btnMente2.Text = "メンテナンス画面2"
        Me.btnMente2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(329, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "表示"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox
        '
        Me.CheckBox.HeaderText = "選択"
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Width = 40
        '
        'colFileName
        '
        Me.colFileName.HeaderText = "ファイル名"
        Me.colFileName.Name = "colFileName"
        '
        'KBN1
        '
        Me.KBN1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.KBN1.HeaderText = "帳票"
        Me.KBN1.Name = "KBN1"
        Me.KBN1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KBN1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KBN1.Width = 50
        '
        'KBN2
        '
        Me.KBN2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.KBN2.HeaderText = "取引先"
        Me.KBN2.Name = "KBN2"
        Me.KBN2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KBN2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'KBN3
        '
        Me.KBN3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.KBN3.HeaderText = "区分3"
        Me.KBN3.Name = "KBN3"
        '
        'colBuhin
        '
        Me.colBuhin.HeaderText = "部品番号"
        Me.colBuhin.Name = "colBuhin"
        Me.colBuhin.Width = 150
        '
        'colSetsuhen
        '
        Me.colSetsuhen.HeaderText = "説変番号"
        Me.colSetsuhen.Name = "colSetsuhen"
        Me.colSetsuhen.Width = 130
        '
        'colPage
        '
        Me.colPage.HeaderText = "ページ"
        Me.colPage.Name = "colPage"
        Me.colPage.Width = 70
        '
        'SaveFoloder
        '
        Me.SaveFoloder.HeaderText = "保存先ファイルパス"
        Me.SaveFoloder.Name = "SaveFoloder"
        Me.SaveFoloder.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SaveFoloder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaveFoloder.Width = 460
        '
        'cmbDirectory
        '
        Me.cmbDirectory.HeaderText = "保存フォルダ"
        Me.cmbDirectory.Name = "cmbDirectory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1339, 508)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAllRelease)
        Me.Controls.Add(Me.btnAllSelect)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMente2)
        Me.Controls.Add(Me.btnMente1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.dgvFileData)
        Me.Controls.Add(Me.btnReadFolder)
        Me.Controls.Add(Me.FilePath)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvFileData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilePath As TextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents dgvFileData As DataGridView
    Friend WithEvents dsDataSet As DataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAllSelect As Button
    Friend WithEvents btnAllRelease As Button
    Friend WithEvents btnReadFolder As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMente1 As Button
    Friend WithEvents btnMente2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents colFileName As DataGridViewTextBoxColumn
    Friend WithEvents KBN1 As DataGridViewComboBoxColumn
    Friend WithEvents KBN2 As DataGridViewComboBoxColumn
    Friend WithEvents KBN3 As DataGridViewComboBoxColumn
    Friend WithEvents colBuhin As DataGridViewTextBoxColumn
    Friend WithEvents colSetsuhen As DataGridViewTextBoxColumn
    Friend WithEvents colPage As DataGridViewTextBoxColumn
    Friend WithEvents SaveFoloder As DataGridViewTextBoxColumn
    Friend WithEvents cmbDirectory As DataGridViewComboBoxColumn
End Class
