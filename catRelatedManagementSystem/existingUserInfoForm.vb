Imports System.ComponentModel
Imports Npgsql

Public Class existingUserInfoForm
    Private Sub existingUserInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'データベース接続を開始
        psql.sqlSt()

        'SQLクエリの設定
        Dim query As String = "SELECT number FROM userinfo WHERE display_flg = TRUE" 'userinfoテーブルからnumber列を取得

        'データベース接続とデータ取得
        'Using conn As New NpgsqlConnection(connString)
        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)

            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                'userNO_change(コンボボックス)にデータを追加
                Dim userNumber As String = reader("number").ToString()
                userNo_change.Items.Add(userNumber)
            End While
            reader.Close()
        End Using
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub

    Private Sub userNo_change_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userNo_change.SelectedIndexChanged
        'userNo_chageの値を取得
        Dim userNo As Integer = userNo_change.SelectedItem.ToString()

        'userinfoテーブルからデータを取得
        Dim userInfo As UserInfo = GetUserInfo(userNo)

        If userInfo IsNot Nothing Then

            'テキストボックスに値を設定
            textUserName_change.Text = userInfo.user_name
            textPassword_change.Text = userInfo.password
            'チェックボックスに値を設定
            CheckBoxPermission_change.Checked = userInfo.authority

        End If
    End Sub

    'データベースからuserinfoテーブルの情報を取得するメソッド
    Private Function GetUserInfo(userNo As Integer) As UserInfo
        Dim userInfo As New UserInfo()
        'データベース接続
        psql.sqlSt()

        'SQLクエリ
        Dim query As String = "SELECT user_name, password, authority, version_number FROM userinfo WHERE number = @userNo;"

        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            cmd.Parameters.AddWithValue("@userNo", userNo)
            'conn.Open()
            Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userInfo.number = userNo
                    userInfo.user_name = reader("user_name").ToString()
                    userInfo.password = reader("password").ToString()
                    userInfo.authority = Convert.ToBoolean(reader("authority"))
                    userInfo.version_number = reader("version_number")
                End If
            End Using
        End Using

        Return userInfo
        'データベース接続を閉じる
        psql.sqlCl()
    End Function
    '変更登録ボタン押下時
    Private Sub ButtonOK_userChange_Click(sender As Object, e As EventArgs) Handles ButtonOK_userChange.Click
        'userNo_changeの値を取得
        Dim userNo As Integer = userNo_change.SelectedItem.ToString()

        'userinfoテーブルからデータを取得
        Dim userInfo As UserInfo = GetUserInfo(userNo)

        'データベースの更新処理
        UpdateUserInfo(userInfo)
    End Sub

    'データベースにuserinfoテーブルの情報を更新するメソッド
    Private Sub UpdateUserInfo(userInfo As UserInfo)
        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "UPDATE userinfo SET user_name = @user_name, password = @password, authority = @authority, version_number = version_number + 1 WHERE number = @userNo AND version_number = @version_number;"

        'データベース接続とデータ取得
        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            'パラメータの設定
            cmd.Parameters.AddWithValue("@version_number", userInfo.version_number)
            cmd.Parameters.AddWithValue("@user_name", textUserName_change.Text)
            cmd.Parameters.AddWithValue("@password", textPassword_change.Text)
            cmd.Parameters.AddWithValue("@authority", CheckBoxPermission_change.Checked)
            cmd.Parameters.AddWithValue("@userNo", userInfo.number)

            '接続
            'conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("変更成功しました")
            Else
                MessageBox.Show("別のユーザーが更新しました。" & vbCrLf & "改めて変更内容確認後に登録をお願いします。")
            End If
            'End Using
        End Using

        'データベース接続を閉じる
        psql.sqlCl()
    End Sub

    '閉じるボタン押下時
    Private Sub ButtonCannel_userChange_Click(sender As Object, e As EventArgs) Handles ButtonCannel_userChange.Click
        Me.Close()
    End Sub
    '削除ボタン押下時
    Private Sub userInfoDeleteButton_Click(sender As Object, e As EventArgs) Handles userInfoDeleteButton.Click
        'userNo_changeの値を取得
        Dim userNo As Integer = userNo_change.SelectedItem

        Dim result As DialogResult
        result = MessageBox.Show("ユーザー番号" & userNo & "を削除します" & vbCrLf & "削除後の復旧は出来ませんがよろしいでしょうか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            'YESを選択時
            'データベース接続
            psql.sqlSt()
            'SQLクエリ
            Dim query As String = "UPDATE userinfo SET  display_flg = @display_flg WHERE number = @userNo;"

            Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
                'パラメータの設定
                cmd.Parameters.AddWithValue("@userNo", userNo)
                cmd.Parameters.AddWithValue("@display_flg", False)

                Dim rowsaffected As Integer = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MessageBox.Show("削除成功しました")
                    'ユーザー番号更新の為にリロード
                    Me.Close()
                    Dim newForm As New existingUserInfoForm()
                    newForm.Show()
                Else
                    MessageBox.Show("削除失敗しました")
                End If
            End Using
            psql.sqlCl()
        Else
            'Noを選択時
            MessageBox.Show("キャンセルします")
            Exit Sub

        End If
    End Sub
End Class