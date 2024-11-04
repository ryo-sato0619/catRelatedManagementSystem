Public Class mainForm
    Private allTabs As New List(Of TabPage)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期状態でTabPagesをリストに保存
        For Each tab As TabPage In TabControl1.TabPages
            allTabs.Add(tab)
        Next

        ' 初期状態でタブページ0を表示し、他のタブを削除
        ShowTab(0)
    End Sub
    '在庫管理ページの表示
    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        ShowTab(0)
    End Sub
    '納品登録ページの表示
    Private Sub deliveryAddButton_Click(sender As Object, e As EventArgs) Handles deliveryAddButton.Click
        ShowTab(1)
    End Sub
    '商品登録ページの表示
    Private Sub itemAddButton_Click(sender As Object, e As EventArgs) Handles itemAddButton.Click
        ShowTab(2)
    End Sub
    'ユーザー登録ページの表示
    Private Sub userAddButton_Click(sender As Object, e As EventArgs) Handles userAddButton.Click
        ShowTab(3)
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
End Class