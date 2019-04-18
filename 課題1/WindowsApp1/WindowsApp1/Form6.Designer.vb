<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim dgvFolderPath As System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnKakutei = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        dgvFolderPath = New System.Windows.Forms.DataGridView()
        CType(dgvFolderPath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFolderPath
        '
        dgvFolderPath.AllowUserToAddRows = False
        dgvFolderPath.AllowUserToDeleteRows = False
        dgvFolderPath.AllowUserToResizeColumns = False
        dgvFolderPath.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        dgvFolderPath.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvFolderPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFolderPath.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colFolderPath})
        dgvFolderPath.Location = New System.Drawing.Point(26, 71)
        dgvFolderPath.MultiSelect = False
        dgvFolderPath.Name = "dgvFolderPath"
        dgvFolderPath.ReadOnly = True
        dgvFolderPath.RowHeadersVisible = False
        dgvFolderPath.RowTemplate.Height = 21
        dgvFolderPath.Size = New System.Drawing.Size(566, 133)
        dgvFolderPath.TabIndex = 47
        '
        'colNum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colNum.HeaderText = "番号"
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNum.Width = 60
        '
        'colFolderPath
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFolderPath.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFolderPath.HeaderText = "フォルダパス"
        Me.colFolderPath.Name = "colFolderPath"
        Me.colFolderPath.ReadOnly = True
        Me.colFolderPath.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFolderPath.Width = 500
        '
        'btnKakutei
        '
        Me.btnKakutei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnKakutei.Location = New System.Drawing.Point(324, 17)
        Me.btnKakutei.Name = "btnKakutei"
        Me.btnKakutei.Size = New System.Drawing.Size(75, 23)
        Me.btnKakutei.TabIndex = 54
        Me.btnKakutei.Text = "確定"
        Me.btnKakutei.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(517, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(218, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "削除"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(123, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "修正"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(26, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(292, 24)
        Me.ComboBox1.TabIndex = 43
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 261)
        Me.Controls.Add(Me.btnKakutei)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(dgvFolderPath)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form6"
        Me.Text = "Form8"
        CType(dgvFolderPath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKakutei As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colFolderPath As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
