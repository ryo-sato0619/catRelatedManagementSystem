Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports Npgsql

Public Class mainForm

    Private allTabs As New List(Of TabPage)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期状態でTabPagesをリストに保存
        For Each tab As TabPage In TabControl1.TabPages
            allTabs.Add(tab)
        Next

        ' 初期状態でタブページ0を表示し、他のタブを削除
        ShowTab(1)

        ' DataGridViewの設定
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.MultiSelect = False

        '在庫一覧情報の読み込み
        LoadData()

    End Sub
    '在庫一覧情報の読み込み
    Private Sub LoadData()
        'データベース接続
        psql.sqlSt()
        ' SQLクエリの設定
        Dim query As String = "SELECT iteminventory.item_number,iteminfo.item_name,iteminventory.inventory,iteminfo.item_remarks,iteminventory.time_stamp FROM iteminventory INNER JOIN iteminfo ON iteminventory.item_number = iteminfo.item_number;"

        ' データベース接続とデータ取得
        'Using connection As New NpgsqlConnection(connString)
        'connection.Open()

        ' データテーブルの作成
        Dim dataTable As New DataTable()
        Dim adapter As New NpgsqlDataAdapter(query, psql.pgsqlCon)
        adapter.Fill(dataTable)

        ' カラム名の変更
        dataTable.Columns("item_number").ColumnName = "商品番号"
        dataTable.Columns("item_name").ColumnName = "商品名"
        dataTable.Columns("inventory").ColumnName = "在庫数"
        dataTable.Columns("item_remarks").ColumnName = "備考"
        dataTable.Columns("time_stamp").ColumnName = "最終更新日"

        ' DataGridViewにデータをバインド
        DataGridView1.DataSource = dataTable

        'データベース接続を閉じる
        psql.sqlCl()
    End Sub

    '在庫管理ページの表示
    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        ShowTab(1)
        'データベース接続
        psql.sqlSt()
        ' SQLクエリの設定
        Dim query As String = "SELECT iteminventory.item_number,iteminfo.item_name,iteminventory.inventory,iteminfo.item_remarks,iteminventory.time_stamp FROM iteminventory INNER JOIN iteminfo ON iteminventory.item_number = iteminfo.item_number;"

        ' データベース接続とデータ取得
        'Using connection As New NpgsqlConnection(connString)
        'connection.Open()

        ' データテーブルの作成
        Dim dataTable As New DataTable()
        Dim adapter As New NpgsqlDataAdapter(query, psql.pgsqlCon)
        adapter.Fill(dataTable)

        ' カラム名の変更
        dataTable.Columns("item_number").ColumnName = "商品番号"
        dataTable.Columns("item_name").ColumnName = "商品名"
        dataTable.Columns("inventory").ColumnName = "在庫数"
        dataTable.Columns("item_remarks").ColumnName = "備考"
        dataTable.Columns("time_stamp").ColumnName = "最終更新日"

        ' DataGridViewにデータをバインド
        DataGridView1.DataSource = dataTable

        'データベース接続を閉じる
        psql.sqlCl()
    End Sub
    '納品登録ページの表示
    Private Sub deliveryAddButton_Click(sender As Object, e As EventArgs) Handles deliveryAddButton.Click
        ShowTab(2)
        'コンボボックスをクリア
        itemIndication.Items.Clear()
        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "SELECT item_number,item_name FROM iteminfo" ' iteminfoテーブルからitemName列を取得

        'データベース接続とデータ取得
        Dim cmd As New NpgsqlCommand(query, psql.pgsqlCon)

        Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            'itemIndication（コンボボックス）にデータを追加
            Dim combinedText As String = reader("item_number").ToString() & " ： " & reader("item_name").ToString()
            itemIndication.Items.Add(combinedText)
        End While

        reader.Close()
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub
    '商品登録ページの表示
    Private Sub itemAddButton_Click(sender As Object, e As EventArgs) Handles itemAddButton.Click
        ShowTab(3)
    End Sub
    'ユーザー登録ページの表示
    Private Sub userAddButton_Click(sender As Object, e As EventArgs) Handles userAddButton.Click
        ShowTab(4)
    End Sub
    '使用登録ぺージの表示
    Private Sub userdButton_Click(sender As Object, e As EventArgs) Handles userdButton.Click
        ShowTab(0)

        'コンボボックスをクリア
        itemIndicationUsed.Items.Clear()
        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "SELECT item_number,item_name FROM iteminfo" ' iteminfoテーブルからitemName列を取得

        'データベース接続とデータ取得
        'Using conn As New NpgsqlConnection(connString)
        Dim cmd As New NpgsqlCommand(query, psql.pgsqlCon)

        Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            'itemIndicationUsed（コンボボックス）にデータを追加
            Dim combinedText As String = reader("item_number").ToString() & " ： " & reader("item_name").ToString()
            itemIndicationUsed.Items.Add(combinedText)
        End While

        reader.Close()
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub
    '使用登録のキャンセルボタン押下時
    Private Sub ButtonCancel_used_Click(sender As Object, e As EventArgs) Handles ButtonCancel_used.Click
        itemIndicationUsed.Text = ""
        usedQuantity.Text = ""
    End Sub
    '使用登録のOKボタン押下時
    Private Sub ButtonOK_used_Click(sender As Object, e As EventArgs) Handles ButtonOK_used.Click
        '選択項目を取得
        Dim selectedItem As String = itemIndicationUsed.SelectedItem.ToString

        'コンボボックス内の情報からitem_number情報を取得
        Dim itemNumber As String = selectedItem.Split("：")(0)

        AddInventoryUsed(itemNumber)
    End Sub

    Private Sub ShowTab(index As Integer)
        ' タブのインデックス範囲を確認
        If index < 0 OrElse index >= allTabs.Count Then
            MessageBox.Show("指定されたインデックスは有効ではありません。")
            Return
        End If

        ' すべてのタブをクリア
        TabControl1.TabPages.Clear()

        ' 指定されたタブを表示
        TabControl1.TabPages.Add(allTabs(index))
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Hide()
        loginForm.Show()
    End Sub
    'フォームが閉じられた時にシステム終了
    Private Sub mainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ButtonCannel_user_Click(sender As Object, e As EventArgs) Handles ButtonCannel_user.Click, ButtonCancel.Click
        'テキストボックスの中身を空にする
        textUserName.Text = ""
        textPassword.Text = ""
        CheckBoxPermission.Checked = False
    End Sub
    '登録ボタン押下時
    Private Sub ButtonOK_user_Click(sender As Object, e As EventArgs) Handles ButtonOK_user.Click
        ' テキストボックスおよびチェックボックスの情報を取得
        Dim userName As String = textUserName.Text
        Dim password As String = textPassword.Text
        Dim authority As Boolean = CheckBoxPermission.Checked

        ' データベース接続
        psql.sqlSt()
        'SQLクエリ INSERT 文の作成
        Dim query As String = "INSERT INTO userinfo (user_name, password, authority) VALUES (@user_name, @password, @authority)"

        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            ' パラメータの設定
            cmd.Parameters.AddWithValue("@user_name", userName)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@authority", authority)

            ' SQL INSERT 文の実行
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("データの登録が成功しました。")
            Catch ex As Exception
                MessageBox.Show("データの登録に失敗しました: " & ex.Message)
            End Try
        End Using
        ' データベース接続を閉じる
        psql.sqlCl()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        'テキストボックスの情報を取得
        Dim itemName As String = textItemName.Text
        Dim itemMoney As Integer = mtextMoney.Text
        Dim itemNet As Integer = mtextNet.Text
        Dim itemRemarks As String = textRemarks.Text
        Dim currentTime As DateTime = DateTime.Now()

        'データベース接続
        psql.sqlSt()

        'SQLクエリ INSERT文の作成
        Dim query As String = "INSERT INTO iteminfo (item_name, item_money, item_net, item_remarks, time_stamp) VALUES (@item_name, @item_money, @item_net, @item_remarks, @time_stamp)"

        Using cmd As New NpgsqlCommand(query, psql.pgsqlCon)
            'パラメータの設定
            cmd.Parameters.AddWithValue("@item_name", itemName)
            cmd.Parameters.AddWithValue("@item_money", itemMoney)
            cmd.Parameters.AddWithValue("@item_net", itemNet)
            cmd.Parameters.AddWithValue("@item_remarks", itemRemarks)
            cmd.Parameters.AddWithValue("@time_stamp", currentTime)
            cmd.Parameters.AddWithValue("@display_flg", "True")

            'SQL INSERT文の実行
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("商品データの登録が成功しました")
            Catch ex As Exception
                MessageBox.Show("商品データの登録に失敗しました" & ex.Message)

            End Try
        End Using
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs)
        'テキストボックスの中身を空にする
        textItemName.Text = ""
        mtextMoney.Text = ""
        mtextNet.Text = ""
        textRemarks.Text = ""
    End Sub

    Private Sub quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles deliveryQuantity.KeyPress
        '数字と制御文字のみ許可
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonCancel_delivery_Click(sender As Object, e As EventArgs) Handles ButtonCancel_delivery.Click
        'テキストボックスを含む項目を空にする
        itemIndication.Text = ""
        deliveryQuantity.Text = ""
    End Sub

    Private Sub ButtonOK_delivery_Click(sender As Object, e As EventArgs) Handles ButtonOK_delivery.Click
        '選択項目を取得
        Dim selectedItem As String = itemIndication.SelectedItem.ToString

        'コンボボックス内の情報からitem_number情報を取得
        Dim itemNumber As String = selectedItem.Split("：")(0)

        AddInventory(itemNumber)
    End Sub
    '入庫処理
    Private Sub AddInventory(itemNumber As Integer)
        '数量情報の取得
        Dim deliveryQuantityInfo As Integer = Integer.Parse(deliveryQuantity.Text)

        'データベース接続
        psql.sqlSt()
        'SQLクエリ
        Dim query As String = "SELECT item_net FROM iteminfo WHERE item_number = @itemNumber"
        Dim command As New NpgsqlCommand(query, psql.pgsqlCon)
        command.Parameters.AddWithValue("@itemNumber", itemNumber)

        Dim itemNet As Integer = Integer.Parse(command.ExecuteScalar().ToString())

        '入庫数を計算
        Dim inventory As Integer = itemNet * deliveryQuantityInfo

        ' iteminventoryテーブルにitem_numberが存在するか確認
        query = "SELECT inventory FROM iteminventory WHERE item_number = @itemNumber"
        command = New NpgsqlCommand(query, psql.pgsqlCon)
        command.Parameters.AddWithValue("@itemNumber", itemNumber)

        Dim existingInventory As Object = command.ExecuteScalar()

        If existingInventory IsNot Nothing Then
            ' 既存の在庫が存在する場合、在庫を更新
            Dim newInventory As Integer = Integer.Parse(existingInventory.ToString()) + inventory
            query = "UPDATE iteminventory SET inventory = @newInventory, time_stamp = @timeStamp WHERE item_number = @itemNumber"
            command = New NpgsqlCommand(query, psql.pgsqlCon)
            command.Parameters.AddWithValue("@newInventory", newInventory)
            command.Parameters.AddWithValue("@timeStamp", DateTime.Now)
            command.Parameters.AddWithValue("@itemNumber", itemNumber)
        Else
            ' 既存の在庫が存在しない場合、新しいエントリを追加
            query = "INSERT INTO iteminventory (item_number, inventory, display_flg, time_stamp) VALUES (@itemNumber, @inventory, @displayFlg, @timeStamp)"
            command = New NpgsqlCommand(query, psql.pgsqlCon)
            command.Parameters.AddWithValue("@itemNumber", itemNumber)
            command.Parameters.AddWithValue("@inventory", inventory)
            command.Parameters.AddWithValue("@displayFlg", True)
            command.Parameters.AddWithValue("@timeStamp", DateTime.Now)
        End If

        command.ExecuteNonQuery()
        MessageBox.Show("登録完了しました")
        'データベース接続を閉じる
        psql.sqlCl()
    End Sub
    '出庫処理
    Private Sub AddInventoryUsed(itemNumber As Integer)
        '出庫数の取得
        Dim inventoryUsed As Integer = Integer.Parse(usedQuantity.Text)

        'データベース接続
        psql.sqlSt()
        'SQLクエリ 
        Dim query As String = "SELECT item_net FROM iteminfo WHERE item_number = @itemNumber"
        Dim command As New NpgsqlCommand(query, psql.pgsqlCon)
        command.Parameters.AddWithValue("@itemNumber", itemNumber)

        Dim itemNet As Integer = Integer.Parse(command.ExecuteScalar().ToString())

        'SQLクエリ　在庫数
        Dim query_inv As String = "SELECT inventory FROM iteminventory WHERE item_number = @itemNumber"
        command = New NpgsqlCommand(query_inv, psql.pgsqlCon)
        command.Parameters.AddWithValue("@itemNumber", itemNumber)

        Dim existingInventory As Object = command.ExecuteScalar()

        If existingInventory IsNot Nothing Then
            ' 既存の在庫が存在する場合、在庫を更新
            Dim newInventory As Integer = Integer.Parse(existingInventory.ToString()) - inventoryUsed
            'SQLクエリ 在庫更新
            Dim query_update As String = "UPDATE iteminventory SET inventory = @newInventory, time_stamp = @timeStamp WHERE item_number = @itemNumber"
            command = New NpgsqlCommand(query_update, psql.pgsqlCon)
            command.Parameters.AddWithValue("@newInventory", newInventory)
            command.Parameters.AddWithValue("@timeStamp", DateTime.Now)
            command.Parameters.AddWithValue("@itemNumber", itemNumber)
        Else
            ' 既存の在庫が存在しない場合、新しいエントリを追加
            MessageBox.Show("在庫の存在しない商品です。入庫情報の登録からお願いします")
            End
        End If

        command.ExecuteNonQuery()
        MessageBox.Show("登録完了しました")
        'データベース接続を閉じる
        psql.sqlCl()

    End Sub

    Private Sub cahngeButton_Click(sender As Object, e As EventArgs) Handles cahngeButton.Click
        '変更登録用フォームを開く
        existingItemInfoForm.Show()
    End Sub

    Private Sub userInfoChangeButton_Click(sender As Object, e As EventArgs) Handles userInfoChangeButton.Click
        '変更登録用フォームを開く
        existingUserInfoForm.Show()
    End Sub

End Class