'ユーザーIDとパスワードが一致すれば
Public Class loginForm
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim userName As String = userNameText.Text
        Dim password As String = passwordText.Text

        'データベースに接続
        psql.sqlSt()

        'クエリ作成
        Dim query As String = $"SELECT authority, user_name FROM userinfo WHERE user_name = '{userName}' AND password = '{password}'"

        '結果の取得
        Dim dt As DataTable = psql.sqlResultReturn(query)

        '結果検証
        If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)(0)) > 0 Then
            MessageBox.Show("ログイン成功です")
            Dim authority As Boolean = Convert.ToBoolean(dt.Rows(0)("authority"))
            Dim retrievedUserName As String = dt.Rows(0)("user_name").ToString
            'メインフォームを開く
            Dim mainForm As New mainForm()
            mainForm.Show()
            'ログインフォームを閉じる
            Me.Hide()
        Else
            MessageBox.Show("ユーザー名かパスワードが異なります")
        End If

        'データベースの切断
        psql.sqlCl()
    End Sub
End Class
