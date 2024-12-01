Imports System.Data.SqlClient
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

        'データべ‐スへの接続状況を確認後、接続作業
        If psql.pgsqlCon.State = ConnectionState.Closed Then
            psql.sqlSt()
        End If

        '必要なデータの取得
        Dim query As String = "SELECT * FROM iteminventory"
        Dim dt As DataTable = psql.sqlResultReturn(query)

        'DataGridView1にデータをバインド
        DataGridView1.DataSource = dt

        'データベースの接続を閉じる
        psql.sqlCl()

    End Sub
    '在庫管理ページの表示
    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        ShowTab(1)
    End Sub
    '納品登録ページの表示
    Private Sub deliveryAddButton_Click(sender As Object, e As EventArgs) Handles deliveryAddButton.Click
        ShowTab(2)
        'データベース接続文字列の設定
        Dim connString As String = "Host=localhost;Username=postgres;Password=test;Database=catdb"
        ' SQLクエリの設定
        Dim query As String = "SELECT item_number,item_name FROM iteminfo" ' iteminfoテーブルからitemName列を取得

        'データベース接続とデータ取得
        Using conn As New NpgsqlConnection(connString)
            Dim cmd As New NpgsqlCommand(query, conn)
            conn.Open()

            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                'itemIndication（コンボボックス）にデータを追加
                Dim combinedText As String = reader("item_number").ToString() & " ： " & reader("item_name").ToString()
                itemIndication.Items.Add(combinedText)
            End While

            reader.Close()
        End Using
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPermission.CheckedChanged

    End Sub

    Private Sub ButtonCannel_user_Click(sender As Object, e As EventArgs) Handles ButtonCannel_user.Click
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

        ' データベース接続文字列の設定
        Dim connString As String = "Host=localhost;Username=postgres;Password=test;Database=catdb"
        Using conn As New NpgsqlConnection(connString)
            conn.Open()

            ' SQL INSERT 文の作成
            Dim query As String = "INSERT INTO userinfo (user_name, password, authority) VALUES (@user_name, @password, @authority)"

            Using cmd As New NpgsqlCommand(query, conn)
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
        End Using

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        'テキストボックスの情報を取得
        Dim itemName As String = textItemName.Text
        Dim itemMoney As Integer = mtextMoney.Text
        Dim itemNet As Integer = mtextNet.Text
        Dim itemRemarks As String = textRemarks.Text
        Dim currentTime As DateTime = DateTime.Now()

        'データベース接続文字列の設定
        Dim connString As String = "Host=localhost;Username=postgres;Password=test;Database=catdb"
        Using conn As New NpgsqlConnection(connString)

            conn.Open()

            'SQL INSERT文の作成
            Dim query As String = "INSERT INTO iteminfo (item_name, item_money, item_net, item_remarks, time_stamp) VALUES (@item_name, @item_money, @item_net, @item_remarks, @time_stamp)"

            Using cmd As New NpgsqlCommand(query, conn)
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
        End Using
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
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

    Private Sub itemIndication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemIndication.SelectedIndexChanged

    End Sub

    Private Sub AddInventory(itemNumber As Integer)
        '数量情報の取得
        Dim deliveryQuantityInfo As Integer = Integer.Parse(deliveryQuantity.Text)

        'データベース接続文字列の設定
        Dim connString As String = "Host=localhost;Username=postgres;Password=test;Database=catdb"
        Using conn As New NpgsqlConnection(connString)
            conn.Open()

            'iteminfoテーブルからitem_netを取得
            Dim query As String = "SELECT item_net FROM iteminfo WHERE item_number = @itemNumber"
            Dim command As New NpgsqlCommand(query, conn)
            command.Parameters.AddWithValue("@itemNumber", itemNumber)

            Dim itemNet As Integer = Integer.Parse(command.ExecuteScalar().ToString())

            '入庫数を計算
            Dim inventory As Integer = itemNet * deliveryQuantityInfo

            ' iteminventoryテーブルにitem_numberが存在するか確認
            query = "SELECT inventory FROM iteminventory WHERE item_number = @itemNumber"
            command = New NpgsqlCommand(query, conn)
            command.Parameters.AddWithValue("@itemNumber", itemNumber)

            Dim existingInventory As Object = command.ExecuteScalar()

            If existingInventory IsNot Nothing Then
                ' 既存の在庫が存在する場合、在庫を更新
                Dim newInventory As Integer = Integer.Parse(existingInventory.ToString()) + inventory
                query = "UPDATE iteminventory SET inventory = @newInventory, time_stamp = @timeStamp WHERE item_number = @itemNumber"
                command = New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@newInventory", newInventory)
                command.Parameters.AddWithValue("@timeStamp", DateTime.Now)
                command.Parameters.AddWithValue("@itemNumber", itemNumber)
            Else
                ' 既存の在庫が存在しない場合、新しいエントリを追加
                query = "INSERT INTO iteminventory (item_number, inventory, display_flg, time_stamp) VALUES (@itemNumber, @inventory, @displayFlg, @timeStamp)"
                command = New NpgsqlCommand(query, conn)
                command.Parameters.AddWithValue("@itemNumber", itemNumber)
                command.Parameters.AddWithValue("@inventory", inventory)
                command.Parameters.AddWithValue("@displayFlg", True)
                command.Parameters.AddWithValue("@timeStamp", DateTime.Now)
            End If

            command.ExecuteNonQuery()

        End Using

        MessageBox.Show("登録完了しました")
    End Sub
End Class