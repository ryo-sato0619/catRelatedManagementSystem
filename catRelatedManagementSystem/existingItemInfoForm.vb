Imports System.Data.SqlClient
Imports Npgsql

Public Class existingItemInfoForm

    Private Sub existingItemInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'データベース接続
        psql.sqlSt()

        'SQLクエリ
        Dim query As String = "SELECT item_number FROM iteminfo WHERE display_flg = TRUE" ' iteminfoテーブルからitem_number列を取得

        'データベース接続とデータ取得
        Dim cmd As New NpgsqlCommand(query, psql.pgsqlCon)

        Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                'itemNo_change（コンボボックス）にデータを追加
                Dim itemNumber As String = reader("item_number").ToString()
                itemNo_change.Items.Add(itemNumber)
            End While

        reader.Close()
        'データべース接続を閉じる
        psql.sqlCl()
    End Sub

    Private Sub itemNo_change_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemNo_change.SelectedIndexChanged
        'itemNo_changeの値を取得
        Dim itemNo As Integer = itemNo_change.SelectedItem.ToString()

        'iteminfoテーブルからデータを取得
        Dim itemInfo As ItemInfo = GetItemInfo(itemNo)

        If itemInfo IsNot Nothing Then

            'テキストボックスに値を設定
            textItemName_change.Text = itemInfo.item_name
            mtextMoney_change.Text = itemInfo.item_money.ToString()
            mtextNet_change.Text = itemInfo.item_net.ToString()
            textRemarks_change.Text = itemInfo.item_remarks

        End If
    End Sub
    ' データベースからiteminfoテーブルの情報を取得するメソッド
    Private Function GetItemInfo(itemNo As Integer) As ItemInfo
        Dim itemInfo As New ItemInfo()
        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "SELECT item_name, item_money, item_net, item_remarks, time_stamp, version_number FROM iteminfo WHERE item_number = @itemNo"

        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            cmd.Parameters.AddWithValue("@itemNo", itemNo)
            Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    itemInfo.item_number = itemNo
                    itemInfo.item_name = reader("item_name").ToString()
                    itemInfo.item_money = Convert.ToDecimal(reader("item_money"))
                    itemInfo.item_net = Convert.ToDecimal(reader("item_net"))
                    itemInfo.item_remarks = reader("item_remarks").ToString()
                    itemInfo.time_stamp = reader("time_stamp")
                    itemInfo.version_number = reader("version_number")
                End If
            End Using
        End Using
        Return itemInfo
        'データベース接続を閉じる
        psql.sqlCl()
    End Function
    '変更登録ボタン押下時
    Private Sub ButtonOK_change_Click(sender As Object, e As EventArgs) Handles ButtonOK_change.Click
        'itemNo_changeの値を取得
        Dim itemNo As Integer = itemNo_change.SelectedItem.ToString()

        'iteminfoテーブルからデータを取得
        Dim itemInfo As ItemInfo = GetItemInfo(itemNo)

        'データベースへの更新処理
        UpdateItemInfo(itemInfo)

    End Sub
    ' データベースにiteminfoテーブルの情報を更新するメソッド
    Private Sub UpdateItemInfo(itemInfo As ItemInfo)
        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "UPDATE iteminfo SET item_name = @item_name, item_money = @item_money, item_net = @item_net, item_remarks = @item_remarks, time_stamp = @time_stamp, version_number = version_number + 1 WHERE item_number = @itemNo AND version_number = @version_number;"

        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            'パラメータの設定
            cmd.Parameters.AddWithValue("@version_number", itemInfo.version_number)
            cmd.Parameters.AddWithValue("@item_name", textItemName_change.Text)
            cmd.Parameters.AddWithValue("@item_money", Convert.ToInt32(mtextMoney_change.Text))
            cmd.Parameters.AddWithValue("@item_net", Convert.ToInt32(mtextNet_change.Text))
            cmd.Parameters.AddWithValue("@item_remarks", textRemarks_change.Text)
            cmd.Parameters.AddWithValue("@time_stamp", Now())
            cmd.Parameters.AddWithValue("@itemNo", itemInfo.item_number)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("変更成功しました")
            Else
                MessageBox.Show("別のユーザーが更新しました。" & vbCrLf & "改めて変更内容確認後に登録をお願いします。")
            End If
        End Using
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub
    '閉じるボタン押下時
    Private Sub ButtonClose_change_Click(sender As Object, e As EventArgs) Handles ButtonClose_change.Click
        Me.Close()
    End Sub
    '削除ボタン押下時
    Private Sub ButtonDellete_change_Click(sender As Object, e As EventArgs) Handles ButtonDellete_change.Click
        'itemNo_changeの値を取得
        Dim itemNo As Integer = itemNo_change.SelectedItem

        Dim result As DialogResult
        result = MessageBox.Show("商品番号" & itemNo & "を削除します" & vbCrLf & "削除後の復旧は出来ませんがよろしいでしょうか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            'YESを選択時
            'データベース接続
            psql.sqlSt()
            'SQLクエリ
            Dim query As String = "UPDATE iteminfo SET  display_flg = @display_flg, time_stamp = @time_stamp WHERE item_number = @itemNo;"

            Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
                'パラメータの設定
                cmd.Parameters.AddWithValue("@time_stamp", Now())
                cmd.Parameters.AddWithValue("@itemNo", itemNo)
                cmd.Parameters.AddWithValue("@display_flg", False)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("削除成功しました")
                    '商品番号リスト更新の為、リロード
                    Me.Close()
                    Dim newForm As New existingItemInfoForm()
                    newForm.Show()
                Else
                    MessageBox.Show("削除失敗しました")
                End If
            End Using
            'データベース接続を閉じる
            psql.sqlCl()
        Else
            'NOを選択時
            MessageBox.Show("キャンセルします")
            Exit Sub
        End If
    End Sub
End Class