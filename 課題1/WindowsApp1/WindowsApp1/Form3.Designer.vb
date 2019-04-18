<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lstZumen = New System.Windows.Forms.ListBox()
        Me.lstTorihiki = New System.Windows.Forms.ListBox()
        Me.lstZumenShurui = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHyoji = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gpbRule = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpFolder3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rdoFolder3Nashi = New System.Windows.Forms.RadioButton()
        Me.rdoFolder3Ari = New System.Windows.Forms.RadioButton()
        Me.grpPage = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rdoPageNashi = New System.Windows.Forms.RadioButton()
        Me.rdoPageAri = New System.Windows.Forms.RadioButton()
        Me.grpFolder2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdoFolder2Nashi = New System.Windows.Forms.RadioButton()
        Me.rdoFolder2Ari = New System.Windows.Forms.RadioButton()
        Me.grpSetsuhen = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdoSetsuhenNashi = New System.Windows.Forms.RadioButton()
        Me.rdoSetsuhenAri = New System.Windows.Forms.RadioButton()
        Me.grpFolder1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdoFolder1Nashi = New System.Windows.Forms.RadioButton()
        Me.rdoFolder1Ari = New System.Windows.Forms.RadioButton()
        Me.txtKBN = New System.Windows.Forms.TextBox()
        Me.txtFolderPath = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblRuleHyoji = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpShohin = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdoShohinNashi = New System.Windows.Forms.RadioButton()
        Me.rdoShohinAri = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gpbRule.SuspendLayout()
        Me.grpFolder3.SuspendLayout()
        Me.grpPage.SuspendLayout()
        Me.grpFolder2.SuspendLayout()
        Me.grpSetsuhen.SuspendLayout()
        Me.grpFolder1.SuspendLayout()
        Me.grpShohin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstZumen
        '
        Me.lstZumen.FormattingEnabled = True
        Me.lstZumen.ItemHeight = 12
        Me.lstZumen.Location = New System.Drawing.Point(31, 67)
        Me.lstZumen.Name = "lstZumen"
        Me.lstZumen.Size = New System.Drawing.Size(120, 88)
        Me.lstZumen.TabIndex = 0
        '
        'lstTorihiki
        '
        Me.lstTorihiki.FormattingEnabled = True
        Me.lstTorihiki.ItemHeight = 12
        Me.lstTorihiki.Location = New System.Drawing.Point(187, 67)
        Me.lstTorihiki.Name = "lstTorihiki"
        Me.lstTorihiki.Size = New System.Drawing.Size(120, 88)
        Me.lstTorihiki.TabIndex = 1
        '
        'lstZumenShurui
        '
        Me.lstZumenShurui.FormattingEnabled = True
        Me.lstZumenShurui.ItemHeight = 12
        Me.lstZumenShurui.Location = New System.Drawing.Point(337, 67)
        Me.lstZumenShurui.Name = "lstZumenShurui"
        Me.lstZumenShurui.Size = New System.Drawing.Size(120, 88)
        Me.lstZumenShurui.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "図面"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "取引先"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "図面種類"
        '
        'btnHyoji
        '
        Me.btnHyoji.Location = New System.Drawing.Point(506, 103)
        Me.btnHyoji.Name = "btnHyoji"
        Me.btnHyoji.Size = New System.Drawing.Size(75, 23)
        Me.btnHyoji.TabIndex = 6
        Me.btnHyoji.Text = "表示"
        Me.btnHyoji.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(506, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "閉じる"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(33, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "一覧表示"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gpbRule
        '
        Me.gpbRule.BackColor = System.Drawing.SystemColors.Control
        Me.gpbRule.Controls.Add(Me.Label11)
        Me.gpbRule.Controls.Add(Me.grpFolder3)
        Me.gpbRule.Controls.Add(Me.grpPage)
        Me.gpbRule.Controls.Add(Me.grpFolder2)
        Me.gpbRule.Controls.Add(Me.grpSetsuhen)
        Me.gpbRule.Controls.Add(Me.grpFolder1)
        Me.gpbRule.Controls.Add(Me.txtKBN)
        Me.gpbRule.Controls.Add(Me.txtFolderPath)
        Me.gpbRule.Controls.Add(Me.Label10)
        Me.gpbRule.Controls.Add(Me.lblRuleHyoji)
        Me.gpbRule.Controls.Add(Me.Label4)
        Me.gpbRule.Controls.Add(Me.grpShohin)
        Me.gpbRule.Location = New System.Drawing.Point(31, 216)
        Me.gpbRule.Name = "gpbRule"
        Me.gpbRule.Size = New System.Drawing.Size(570, 432)
        Me.gpbRule.TabIndex = 30
        Me.gpbRule.TabStop = False
        Me.gpbRule.Text = "ルール"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(175, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 12)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "フォルダパス"
        '
        'grpFolder3
        '
        Me.grpFolder3.Controls.Add(Me.Label12)
        Me.grpFolder3.Controls.Add(Me.rdoFolder3Nashi)
        Me.grpFolder3.Controls.Add(Me.rdoFolder3Ari)
        Me.grpFolder3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpFolder3.Location = New System.Drawing.Point(352, 370)
        Me.grpFolder3.Name = "grpFolder3"
        Me.grpFolder3.Size = New System.Drawing.Size(200, 37)
        Me.grpFolder3.TabIndex = 56
        Me.grpFolder3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 12)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "保存フォルダ3"
        '
        'rdoFolder3Nashi
        '
        Me.rdoFolder3Nashi.AutoSize = True
        Me.rdoFolder3Nashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoFolder3Nashi.Name = "rdoFolder3Nashi"
        Me.rdoFolder3Nashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder3Nashi.TabIndex = 20
        Me.rdoFolder3Nashi.TabStop = True
        Me.rdoFolder3Nashi.Text = "無"
        Me.rdoFolder3Nashi.UseVisualStyleBackColor = True
        '
        'rdoFolder3Ari
        '
        Me.rdoFolder3Ari.AutoSize = True
        Me.rdoFolder3Ari.Location = New System.Drawing.Point(100, 12)
        Me.rdoFolder3Ari.Name = "rdoFolder3Ari"
        Me.rdoFolder3Ari.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder3Ari.TabIndex = 0
        Me.rdoFolder3Ari.TabStop = True
        Me.rdoFolder3Ari.Text = "有"
        Me.rdoFolder3Ari.UseVisualStyleBackColor = True
        '
        'grpPage
        '
        Me.grpPage.Controls.Add(Me.Label9)
        Me.grpPage.Controls.Add(Me.rdoPageNashi)
        Me.grpPage.Controls.Add(Me.rdoPageAri)
        Me.grpPage.Location = New System.Drawing.Point(353, 168)
        Me.grpPage.Name = "grpPage"
        Me.grpPage.Size = New System.Drawing.Size(200, 37)
        Me.grpPage.TabIndex = 40
        Me.grpPage.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 12)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "ページ"
        '
        'rdoPageNashi
        '
        Me.rdoPageNashi.AutoSize = True
        Me.rdoPageNashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoPageNashi.Name = "rdoPageNashi"
        Me.rdoPageNashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoPageNashi.TabIndex = 20
        Me.rdoPageNashi.TabStop = True
        Me.rdoPageNashi.Text = "無"
        Me.rdoPageNashi.UseVisualStyleBackColor = True
        '
        'rdoPageAri
        '
        Me.rdoPageAri.AutoSize = True
        Me.rdoPageAri.Location = New System.Drawing.Point(100, 12)
        Me.rdoPageAri.Name = "rdoPageAri"
        Me.rdoPageAri.Size = New System.Drawing.Size(35, 16)
        Me.rdoPageAri.TabIndex = 0
        Me.rdoPageAri.TabStop = True
        Me.rdoPageAri.Text = "有"
        Me.rdoPageAri.UseVisualStyleBackColor = True
        '
        'grpFolder2
        '
        Me.grpFolder2.Controls.Add(Me.Label13)
        Me.grpFolder2.Controls.Add(Me.rdoFolder2Nashi)
        Me.grpFolder2.Controls.Add(Me.rdoFolder2Ari)
        Me.grpFolder2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpFolder2.Location = New System.Drawing.Point(352, 327)
        Me.grpFolder2.Name = "grpFolder2"
        Me.grpFolder2.Size = New System.Drawing.Size(200, 37)
        Me.grpFolder2.TabIndex = 57
        Me.grpFolder2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 12)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "保存フォルダ2"
        '
        'rdoFolder2Nashi
        '
        Me.rdoFolder2Nashi.AutoSize = True
        Me.rdoFolder2Nashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoFolder2Nashi.Name = "rdoFolder2Nashi"
        Me.rdoFolder2Nashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder2Nashi.TabIndex = 20
        Me.rdoFolder2Nashi.TabStop = True
        Me.rdoFolder2Nashi.Text = "無"
        Me.rdoFolder2Nashi.UseVisualStyleBackColor = True
        '
        'rdoFolder2Ari
        '
        Me.rdoFolder2Ari.AutoSize = True
        Me.rdoFolder2Ari.Location = New System.Drawing.Point(100, 12)
        Me.rdoFolder2Ari.Name = "rdoFolder2Ari"
        Me.rdoFolder2Ari.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder2Ari.TabIndex = 0
        Me.rdoFolder2Ari.TabStop = True
        Me.rdoFolder2Ari.Text = "有"
        Me.rdoFolder2Ari.UseVisualStyleBackColor = True
        '
        'grpSetsuhen
        '
        Me.grpSetsuhen.Controls.Add(Me.Label8)
        Me.grpSetsuhen.Controls.Add(Me.rdoSetsuhenNashi)
        Me.grpSetsuhen.Controls.Add(Me.rdoSetsuhenAri)
        Me.grpSetsuhen.Location = New System.Drawing.Point(353, 124)
        Me.grpSetsuhen.Name = "grpSetsuhen"
        Me.grpSetsuhen.Size = New System.Drawing.Size(200, 37)
        Me.grpSetsuhen.TabIndex = 39
        Me.grpSetsuhen.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "説変番号"
        '
        'rdoSetsuhenNashi
        '
        Me.rdoSetsuhenNashi.AutoSize = True
        Me.rdoSetsuhenNashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoSetsuhenNashi.Name = "rdoSetsuhenNashi"
        Me.rdoSetsuhenNashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoSetsuhenNashi.TabIndex = 20
        Me.rdoSetsuhenNashi.TabStop = True
        Me.rdoSetsuhenNashi.Text = "無"
        Me.rdoSetsuhenNashi.UseVisualStyleBackColor = True
        '
        'rdoSetsuhenAri
        '
        Me.rdoSetsuhenAri.AutoSize = True
        Me.rdoSetsuhenAri.Location = New System.Drawing.Point(100, 12)
        Me.rdoSetsuhenAri.Name = "rdoSetsuhenAri"
        Me.rdoSetsuhenAri.Size = New System.Drawing.Size(35, 16)
        Me.rdoSetsuhenAri.TabIndex = 0
        Me.rdoSetsuhenAri.TabStop = True
        Me.rdoSetsuhenAri.Text = "有"
        Me.rdoSetsuhenAri.UseVisualStyleBackColor = True
        '
        'grpFolder1
        '
        Me.grpFolder1.Controls.Add(Me.Label14)
        Me.grpFolder1.Controls.Add(Me.rdoFolder1Nashi)
        Me.grpFolder1.Controls.Add(Me.rdoFolder1Ari)
        Me.grpFolder1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpFolder1.Location = New System.Drawing.Point(352, 284)
        Me.grpFolder1.Name = "grpFolder1"
        Me.grpFolder1.Size = New System.Drawing.Size(200, 37)
        Me.grpFolder1.TabIndex = 55
        Me.grpFolder1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 12)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "保存フォルダ1"
        '
        'rdoFolder1Nashi
        '
        Me.rdoFolder1Nashi.AutoSize = True
        Me.rdoFolder1Nashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoFolder1Nashi.Name = "rdoFolder1Nashi"
        Me.rdoFolder1Nashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder1Nashi.TabIndex = 20
        Me.rdoFolder1Nashi.TabStop = True
        Me.rdoFolder1Nashi.Text = "無"
        Me.rdoFolder1Nashi.UseVisualStyleBackColor = True
        '
        'rdoFolder1Ari
        '
        Me.rdoFolder1Ari.AutoSize = True
        Me.rdoFolder1Ari.Location = New System.Drawing.Point(100, 12)
        Me.rdoFolder1Ari.Name = "rdoFolder1Ari"
        Me.rdoFolder1Ari.Size = New System.Drawing.Size(35, 16)
        Me.rdoFolder1Ari.TabIndex = 0
        Me.rdoFolder1Ari.TabStop = True
        Me.rdoFolder1Ari.Text = "有"
        Me.rdoFolder1Ari.UseVisualStyleBackColor = True
        '
        'txtKBN
        '
        Me.txtKBN.Location = New System.Drawing.Point(453, 220)
        Me.txtKBN.MaxLength = 255
        Me.txtKBN.Name = "txtKBN"
        Me.txtKBN.Size = New System.Drawing.Size(100, 19)
        Me.txtKBN.TabIndex = 35
        '
        'txtFolderPath
        '
        Me.txtFolderPath.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.txtFolderPath.Location = New System.Drawing.Point(251, 255)
        Me.txtFolderPath.MaxLength = 255
        Me.txtFolderPath.Name = "txtFolderPath"
        Me.txtFolderPath.Size = New System.Drawing.Size(302, 23)
        Me.txtFolderPath.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(350, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "選択可能区分"
        '
        'lblRuleHyoji
        '
        Me.lblRuleHyoji.AutoSize = True
        Me.lblRuleHyoji.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.lblRuleHyoji.Location = New System.Drawing.Point(276, 43)
        Me.lblRuleHyoji.Name = "lblRuleHyoji"
        Me.lblRuleHyoji.Size = New System.Drawing.Size(246, 15)
        Me.lblRuleHyoji.TabIndex = 31
        Me.lblRuleHyoji.Text = "１２３-商品番号_説編番号_ページ_１２３"
        Me.lblRuleHyoji.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(276, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "現在の命名ルール"
        '
        'grpShohin
        '
        Me.grpShohin.Controls.Add(Me.Label7)
        Me.grpShohin.Controls.Add(Me.rdoShohinNashi)
        Me.grpShohin.Controls.Add(Me.rdoShohinAri)
        Me.grpShohin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpShohin.Location = New System.Drawing.Point(353, 82)
        Me.grpShohin.Name = "grpShohin"
        Me.grpShohin.Size = New System.Drawing.Size(200, 37)
        Me.grpShohin.TabIndex = 38
        Me.grpShohin.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "商品番号"
        '
        'rdoShohinNashi
        '
        Me.rdoShohinNashi.AutoSize = True
        Me.rdoShohinNashi.Location = New System.Drawing.Point(156, 12)
        Me.rdoShohinNashi.Name = "rdoShohinNashi"
        Me.rdoShohinNashi.Size = New System.Drawing.Size(35, 16)
        Me.rdoShohinNashi.TabIndex = 20
        Me.rdoShohinNashi.TabStop = True
        Me.rdoShohinNashi.Text = "無"
        Me.rdoShohinNashi.UseVisualStyleBackColor = True
        '
        'rdoShohinAri
        '
        Me.rdoShohinAri.AutoSize = True
        Me.rdoShohinAri.Location = New System.Drawing.Point(100, 12)
        Me.rdoShohinAri.Name = "rdoShohinAri"
        Me.rdoShohinAri.Size = New System.Drawing.Size(35, 16)
        Me.rdoShohinAri.TabIndex = 0
        Me.rdoShohinAri.TabStop = True
        Me.rdoShohinAri.Text = "有"
        Me.rdoShohinAri.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(506, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "削除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(412, 187)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "修正"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(314, 187)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "追加"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(33, 187)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(615, 678)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHyoji)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstZumenShurui)
        Me.Controls.Add(Me.lstTorihiki)
        Me.Controls.Add(Me.lstZumen)
        Me.Controls.Add(Me.gpbRule)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.gpbRule.ResumeLayout(False)
        Me.gpbRule.PerformLayout()
        Me.grpFolder3.ResumeLayout(False)
        Me.grpFolder3.PerformLayout()
        Me.grpPage.ResumeLayout(False)
        Me.grpPage.PerformLayout()
        Me.grpFolder2.ResumeLayout(False)
        Me.grpFolder2.PerformLayout()
        Me.grpSetsuhen.ResumeLayout(False)
        Me.grpSetsuhen.PerformLayout()
        Me.grpFolder1.ResumeLayout(False)
        Me.grpFolder1.PerformLayout()
        Me.grpShohin.ResumeLayout(False)
        Me.grpShohin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstZumen As ListBox
    Friend WithEvents lstTorihiki As ListBox
    Friend WithEvents lstZumenShurui As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHyoji As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gpbRule As GroupBox
    Friend WithEvents grpPage As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rdoPageNashi As RadioButton
    Friend WithEvents rdoPageAri As RadioButton
    Friend WithEvents grpSetsuhen As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rdoSetsuhenNashi As RadioButton
    Friend WithEvents rdoSetsuhenAri As RadioButton
    Friend WithEvents txtKBN As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblRuleHyoji As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpShohin As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rdoShohinNashi As RadioButton
    Friend WithEvents rdoShohinAri As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents grpFolder3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rdoFolder3Nashi As RadioButton
    Friend WithEvents rdoFolder3Ari As RadioButton
    Friend WithEvents grpFolder2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents rdoFolder2Nashi As RadioButton
    Friend WithEvents rdoFolder2Ari As RadioButton
    Friend WithEvents grpFolder1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rdoFolder1Nashi As RadioButton
    Friend WithEvents rdoFolder1Ari As RadioButton
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents btnClear As Button
End Class
