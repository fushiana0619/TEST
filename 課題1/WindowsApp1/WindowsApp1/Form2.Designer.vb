<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cmbShubetsu = New System.Windows.Forms.ComboBox()
        Me.lstShubetsu = New System.Windows.Forms.ListBox()
        Me.txtCDNUM = New System.Windows.Forms.TextBox()
        Me.txtCDMeisho = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHyoji = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbShubetsu
        '
        Me.cmbShubetsu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.cmbShubetsu.FormattingEnabled = True
        Me.cmbShubetsu.Location = New System.Drawing.Point(38, 33)
        Me.cmbShubetsu.Name = "cmbShubetsu"
        Me.cmbShubetsu.Size = New System.Drawing.Size(237, 24)
        Me.cmbShubetsu.TabIndex = 0
        '
        'lstShubetsu
        '
        Me.lstShubetsu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.lstShubetsu.FormattingEnabled = True
        Me.lstShubetsu.ItemHeight = 16
        Me.lstShubetsu.Location = New System.Drawing.Point(38, 124)
        Me.lstShubetsu.Name = "lstShubetsu"
        Me.lstShubetsu.Size = New System.Drawing.Size(296, 292)
        Me.lstShubetsu.TabIndex = 1
        '
        'txtCDNUM
        '
        Me.txtCDNUM.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.txtCDNUM.Location = New System.Drawing.Point(489, 211)
        Me.txtCDNUM.MaxLength = 3
        Me.txtCDNUM.Name = "txtCDNUM"
        Me.txtCDNUM.Size = New System.Drawing.Size(100, 23)
        Me.txtCDNUM.TabIndex = 2
        '
        'txtCDMeisho
        '
        Me.txtCDMeisho.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCDMeisho.Location = New System.Drawing.Point(489, 264)
        Me.txtCDMeisho.MaxLength = 50
        Me.txtCDMeisho.Name = "txtCDMeisho"
        Me.txtCDMeisho.Size = New System.Drawing.Size(267, 23)
        Me.txtCDMeisho.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "コード番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "コード名称"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(489, 124)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "追加"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(587, 124)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(681, 124)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(681, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "閉じる"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "パターン種別"
        '
        'btnHyoji
        '
        Me.btnHyoji.Location = New System.Drawing.Point(281, 33)
        Me.btnHyoji.Name = "btnHyoji"
        Me.btnHyoji.Size = New System.Drawing.Size(75, 23)
        Me.btnHyoji.TabIndex = 11
        Me.btnHyoji.Text = "表示"
        Me.btnHyoji.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(38, 95)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHyoji)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCDMeisho)
        Me.Controls.Add(Me.txtCDNUM)
        Me.Controls.Add(Me.lstShubetsu)
        Me.Controls.Add(Me.cmbShubetsu)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbShubetsu As ComboBox
    Friend WithEvents lstShubetsu As ListBox
    Friend WithEvents txtCDNUM As TextBox
    Friend WithEvents txtCDMeisho As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHyoji As Button
    Friend WithEvents btnClear As Button
End Class
