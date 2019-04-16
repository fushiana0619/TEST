Imports System.Xml

Public Class clsCommon
    Public Function ShowSelectdFolderDialog(ByVal strDefaultFilePath As String) As String
        Dim fbd As New FolderBrowserDialog
        Dim strSelectedPath As String = ""
        Dim strShokiHyojiPath As String = ""
        Try
            '上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。"
            '初期選択フォルダの設定
            If System.IO.Directory.Exists(strDefaultFilePath) Then
                strShokiHyojiPath = strDefaultFilePath
            Else
                strShokiHyojiPath = System.Environment.CurrentDirectory
            End If

            'ユーザーが新しいフォルダを作成できないようにする
            fbd.ShowNewFolderButton = False

            fbd.SelectedPath = strShokiHyojiPath

            'フォルダ選択ダイアログでOKボタンを押下した場合
            If fbd.ShowDialog = DialogResult.OK Then
                strSelectedPath = fbd.SelectedPath
            Else
                strSelectedPath = ""
            End If

        Catch ex As Exception
            MessageBox.Show("フォルダ選択ダイアログ展開時エラー")
            '何かしらのエラーの場合はカレントディレクトリを戻す
            strSelectedPath = System.Environment.CurrentDirectory
        End Try
        Return strSelectedPath
    End Function

    Public Sub GetPatternShubetsu()

    End Sub

End Class
