<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSentaku = New System.Windows.Forms.DataGridView()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBuhin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSetsuhen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBubun = New System.Windows.Forms.Button()
        Me.btnSento = New System.Windows.Forms.Button()
        Me.txtBuhin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKakutei = New System.Windows.Forms.Button()
        Me.lblCurrentFileName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSentaku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSentaku
        '
        Me.dgvSentaku.AllowUserToAddRows = False
        Me.dgvSentaku.AllowUserToDeleteRows = False
        Me.dgvSentaku.AllowUserToResizeColumns = False
        Me.dgvSentaku.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSentaku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSentaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSentaku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colBuhin, Me.colSetsuhen, Me.colKBN, Me.colUpdateDate})
        Me.dgvSentaku.Location = New System.Drawing.Point(41, 130)
        Me.dgvSentaku.MultiSelect = False
        Me.dgvSentaku.Name = "dgvSentaku"
        Me.dgvSentaku.ReadOnly = True
        Me.dgvSentaku.RowHeadersVisible = False
        Me.dgvSentaku.RowTemplate.Height = 21
        Me.dgvSentaku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSentaku.Size = New System.Drawing.Size(715, 291)
        Me.dgvSentaku.TabIndex = 4
        '
        'colNum
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNum.DefaultCellStyle = DataGridViewCellStyle12
        Me.colNum.HeaderText = "番号"
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNum.Width = 60
        '
        'colBuhin
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colBuhin.DefaultCellStyle = DataGridViewCellStyle13
        Me.colBuhin.HeaderText = "部品番号"
        Me.colBuhin.Name = "colBuhin"
        Me.colBuhin.ReadOnly = True
        Me.colBuhin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colBuhin.Width = 300
        '
        'colSetsuhen
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSetsuhen.DefaultCellStyle = DataGridViewCellStyle14
        Me.colSetsuhen.HeaderText = "設変番号"
        Me.colSetsuhen.Name = "colSetsuhen"
        Me.colSetsuhen.ReadOnly = True
        Me.colSetsuhen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSetsuhen.Width = 150
        '
        'colKBN
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colKBN.DefaultCellStyle = DataGridViewCellStyle15
        Me.colKBN.HeaderText = "選択可能区分"
        Me.colKBN.Name = "colKBN"
        Me.colKBN.ReadOnly = True
        Me.colKBN.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colUpdateDate
        '
        Me.colUpdateDate.HeaderText = "更新日"
        Me.colUpdateDate.Name = "colUpdateDate"
        Me.colUpdateDate.ReadOnly = True
        '
        'btnBubun
        '
        Me.btnBubun.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnBubun.Location = New System.Drawing.Point(41, 20)
        Me.btnBubun.Name = "btnBubun"
        Me.btnBubun.Size = New System.Drawing.Size(94, 23)
        Me.btnBubun.TabIndex = 0
        Me.btnBubun.Text = "部分一致"
        Me.btnBubun.UseVisualStyleBackColor = True
        '
        'btnSento
        '
        Me.btnSento.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnSento.Location = New System.Drawing.Point(154, 20)
        Me.btnSento.Name = "btnSento"
        Me.btnSento.Size = New System.Drawing.Size(94, 23)
        Me.btnSento.TabIndex = 1
        Me.btnSento.Text = "先頭一致"
        Me.btnSento.UseVisualStyleBackColor = True
        '
        'txtBuhin
        '
        Me.txtBuhin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.txtBuhin.Location = New System.Drawing.Point(41, 79)
        Me.txtBuhin.Name = "txtBuhin"
        Me.txtBuhin.Size = New System.Drawing.Size(207, 23)
        Me.txtBuhin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(41, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "部品番号"
        '
        'btnKakutei
        '
        Me.btnKakutei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnKakutei.Location = New System.Drawing.Point(671, 20)
        Me.btnKakutei.Name = "btnKakutei"
        Me.btnKakutei.Size = New System.Drawing.Size(75, 23)
        Me.btnKakutei.TabIndex = 5
        Me.btnKakutei.Text = "確定"
        Me.btnKakutei.UseVisualStyleBackColor = True
        '
        'lblCurrentFileName
        '
        Me.lblCurrentFileName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lblCurrentFileName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrentFileName.Location = New System.Drawing.Point(288, 79)
        Me.lblCurrentFileName.Name = "lblCurrentFileName"
        Me.lblCurrentFileName.Size = New System.Drawing.Size(457, 23)
        Me.lblCurrentFileName.TabIndex = 6
        Me.lblCurrentFileName.Text = "ABCDEFG.pdfAAAA"
        Me.lblCurrentFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(599, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "現在選択中のファイル"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCurrentFileName)
        Me.Controls.Add(Me.btnKakutei)
        Me.Controls.Add(Me.dgvSentaku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuhin)
        Me.Controls.Add(Me.btnSento)
        Me.Controls.Add(Me.btnBubun)
        Me.Name = "Form5"
        Me.Text = "ファイル名履歴選択"
        CType(Me.dgvSentaku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBubun As Button
    Friend WithEvents btnSento As Button
    Friend WithEvents txtBuhin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKakutei As Button
    Friend WithEvents lblCurrentFileName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSentaku As DataGridView
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colBuhin As DataGridViewTextBoxColumn
    Friend WithEvents colSetsuhen As DataGridViewTextBoxColumn
    Friend WithEvents colKBN As DataGridViewTextBoxColumn
    Friend WithEvents colUpdateDate As DataGridViewTextBoxColumn
End Class
