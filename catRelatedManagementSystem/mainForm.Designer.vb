<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.userdButton = New System.Windows.Forms.Button()
        Me.userAddButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.itemAddButton = New System.Windows.Forms.Button()
        Me.deliveryAddButton = New System.Windows.Forms.Button()
        Me.inventoryButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ButtonCancel_used = New System.Windows.Forms.Button()
        Me.ButtonOK_used = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.usedQuantity = New System.Windows.Forms.TextBox()
        Me.itemIndicationUsed = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonCancel_delivery = New System.Windows.Forms.Button()
        Me.ButtonOK_delivery = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.deliveryQuantity = New System.Windows.Forms.TextBox()
        Me.itemIndication = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.textRemarks = New System.Windows.Forms.TextBox()
        Me.textItemName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtextNet = New System.Windows.Forms.MaskedTextBox()
        Me.mtextMoney = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ButtonCannel_user = New System.Windows.Forms.Button()
        Me.ButtonOK_user = New System.Windows.Forms.Button()
        Me.CheckBoxPermission = New System.Windows.Forms.CheckBox()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUserName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cahngeButton = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.MaximumSize = New System.Drawing.Size(1180, 680)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SplitContainer1.Panel1.Controls.Add(Me.userdButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.userAddButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.logoutButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.itemAddButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.deliveryAddButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.inventoryButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScrollMargin = New System.Drawing.Size(1200, 700)
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1178, 644)
        Me.SplitContainer1.SplitterDistance = 142
        Me.SplitContainer1.TabIndex = 0
        '
        'userdButton
        '
        Me.userdButton.Font = New System.Drawing.Font("Meiryo UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userdButton.Location = New System.Drawing.Point(18, 83)
        Me.userdButton.Name = "userdButton"
        Me.userdButton.Size = New System.Drawing.Size(135, 50)
        Me.userdButton.TabIndex = 7
        Me.userdButton.Text = "使用登録"
        Me.userdButton.UseVisualStyleBackColor = True
        '
        'userAddButton
        '
        Me.userAddButton.Font = New System.Drawing.Font("Meiryo UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userAddButton.Location = New System.Drawing.Point(583, 83)
        Me.userAddButton.Name = "userAddButton"
        Me.userAddButton.Size = New System.Drawing.Size(135, 50)
        Me.userAddButton.TabIndex = 6
        Me.userAddButton.Text = "ユーザー登録"
        Me.userAddButton.UseVisualStyleBackColor = True
        '
        'logoutButton
        '
        Me.logoutButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.logoutButton.Location = New System.Drawing.Point(1031, 84)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(135, 50)
        Me.logoutButton.TabIndex = 5
        Me.logoutButton.Text = "ログアウト"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'itemAddButton
        '
        Me.itemAddButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.itemAddButton.Location = New System.Drawing.Point(442, 83)
        Me.itemAddButton.Name = "itemAddButton"
        Me.itemAddButton.Size = New System.Drawing.Size(135, 50)
        Me.itemAddButton.TabIndex = 3
        Me.itemAddButton.Text = "商品登録"
        Me.itemAddButton.UseVisualStyleBackColor = True
        '
        'deliveryAddButton
        '
        Me.deliveryAddButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.deliveryAddButton.Location = New System.Drawing.Point(301, 84)
        Me.deliveryAddButton.Name = "deliveryAddButton"
        Me.deliveryAddButton.Size = New System.Drawing.Size(135, 50)
        Me.deliveryAddButton.TabIndex = 2
        Me.deliveryAddButton.Text = "納品登録"
        Me.deliveryAddButton.UseVisualStyleBackColor = True
        '
        'inventoryButton
        '
        Me.inventoryButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.inventoryButton.Location = New System.Drawing.Point(160, 83)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.Size = New System.Drawing.Size(135, 50)
        Me.inventoryButton.TabIndex = 1
        Me.inventoryButton.Text = "在庫管理"
        Me.inventoryButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "在庫管理システム"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.MaximumSize = New System.Drawing.Size(1180, 490)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1180, 490)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage5.Controls.Add(Me.ButtonCancel_used)
        Me.TabPage5.Controls.Add(Me.ButtonOK_used)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.usedQuantity)
        Me.TabPage5.Controls.Add(Me.itemIndicationUsed)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Location = New System.Drawing.Point(4, 32)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "使用登録"
        '
        'ButtonCancel_used
        '
        Me.ButtonCancel_used.Location = New System.Drawing.Point(517, 175)
        Me.ButtonCancel_used.Name = "ButtonCancel_used"
        Me.ButtonCancel_used.Size = New System.Drawing.Size(143, 43)
        Me.ButtonCancel_used.TabIndex = 15
        Me.ButtonCancel_used.Text = "キャンセル"
        Me.ButtonCancel_used.UseVisualStyleBackColor = True
        '
        'ButtonOK_used
        '
        Me.ButtonOK_used.Location = New System.Drawing.Point(329, 175)
        Me.ButtonOK_used.Name = "ButtonOK_used"
        Me.ButtonOK_used.Size = New System.Drawing.Size(143, 43)
        Me.ButtonOK_used.TabIndex = 14
        Me.ButtonOK_used.Text = "登録"
        Me.ButtonOK_used.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(266, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "個"
        '
        'usedQuantity
        '
        Me.usedQuantity.Location = New System.Drawing.Point(136, 112)
        Me.usedQuantity.Name = "usedQuantity"
        Me.usedQuantity.Size = New System.Drawing.Size(87, 30)
        Me.usedQuantity.TabIndex = 12
        '
        'itemIndicationUsed
        '
        Me.itemIndicationUsed.FormattingEnabled = True
        Me.itemIndicationUsed.Location = New System.Drawing.Point(136, 54)
        Me.itemIndicationUsed.Name = "itemIndicationUsed"
        Me.itemIndicationUsed.Size = New System.Drawing.Size(346, 31)
        Me.itemIndicationUsed.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 23)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "数量"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 23)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "品名"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "在庫一覧"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1166, 448)
        Me.DataGridView1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.Controls.Add(Me.ButtonCancel_delivery)
        Me.TabPage2.Controls.Add(Me.ButtonOK_delivery)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.deliveryQuantity)
        Me.TabPage2.Controls.Add(Me.itemIndication)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "納品登録"
        '
        'ButtonCancel_delivery
        '
        Me.ButtonCancel_delivery.Location = New System.Drawing.Point(517, 177)
        Me.ButtonCancel_delivery.Name = "ButtonCancel_delivery"
        Me.ButtonCancel_delivery.Size = New System.Drawing.Size(143, 43)
        Me.ButtonCancel_delivery.TabIndex = 8
        Me.ButtonCancel_delivery.Text = "キャンセル"
        Me.ButtonCancel_delivery.UseVisualStyleBackColor = True
        '
        'ButtonOK_delivery
        '
        Me.ButtonOK_delivery.Location = New System.Drawing.Point(329, 177)
        Me.ButtonOK_delivery.Name = "ButtonOK_delivery"
        Me.ButtonOK_delivery.Size = New System.Drawing.Size(143, 43)
        Me.ButtonOK_delivery.TabIndex = 7
        Me.ButtonOK_delivery.Text = "登録"
        Me.ButtonOK_delivery.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(266, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 23)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "個"
        '
        'deliveryQuantity
        '
        Me.deliveryQuantity.Location = New System.Drawing.Point(136, 114)
        Me.deliveryQuantity.Name = "deliveryQuantity"
        Me.deliveryQuantity.Size = New System.Drawing.Size(87, 30)
        Me.deliveryQuantity.TabIndex = 4
        '
        'itemIndication
        '
        Me.itemIndication.FormattingEnabled = True
        Me.itemIndication.Location = New System.Drawing.Point(136, 56)
        Me.itemIndication.Name = "itemIndication"
        Me.itemIndication.Size = New System.Drawing.Size(346, 31)
        Me.itemIndication.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "数量"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "品名"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage3.Controls.Add(Me.cahngeButton)
        Me.TabPage3.Controls.Add(Me.textRemarks)
        Me.TabPage3.Controls.Add(Me.textItemName)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.mtextNet)
        Me.TabPage3.Controls.Add(Me.mtextMoney)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.ButtonCancel)
        Me.TabPage3.Controls.Add(Me.ButtonOK)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "商品登録"
        '
        'textRemarks
        '
        Me.textRemarks.Location = New System.Drawing.Point(214, 235)
        Me.textRemarks.Name = "textRemarks"
        Me.textRemarks.Size = New System.Drawing.Size(293, 30)
        Me.textRemarks.TabIndex = 13
        '
        'textItemName
        '
        Me.textItemName.Location = New System.Drawing.Point(214, 46)
        Me.textItemName.Name = "textItemName"
        Me.textItemName.Size = New System.Drawing.Size(293, 30)
        Me.textItemName.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "個入り"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "円"
        '
        'mtextNet
        '
        Me.mtextNet.Location = New System.Drawing.Point(214, 169)
        Me.mtextNet.Mask = "999999"
        Me.mtextNet.Name = "mtextNet"
        Me.mtextNet.Size = New System.Drawing.Size(105, 30)
        Me.mtextNet.TabIndex = 12
        Me.mtextNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtextMoney
        '
        Me.mtextMoney.Location = New System.Drawing.Point(214, 107)
        Me.mtextMoney.Mask = "999999"
        Me.mtextMoney.Name = "mtextMoney"
        Me.mtextMoney.Size = New System.Drawing.Size(105, 30)
        Me.mtextMoney.TabIndex = 11
        Me.mtextMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "備考"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "内容量"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "金額"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "品名"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(499, 296)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(143, 43)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(319, 296)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(143, 43)
        Me.ButtonOK.TabIndex = 0
        Me.ButtonOK.Text = "登録"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage4.Controls.Add(Me.ButtonCannel_user)
        Me.TabPage4.Controls.Add(Me.ButtonOK_user)
        Me.TabPage4.Controls.Add(Me.CheckBoxPermission)
        Me.TabPage4.Controls.Add(Me.textPassword)
        Me.TabPage4.Controls.Add(Me.textUserName)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ユーザー登録"
        '
        'ButtonCannel_user
        '
        Me.ButtonCannel_user.Location = New System.Drawing.Point(481, 300)
        Me.ButtonCannel_user.Name = "ButtonCannel_user"
        Me.ButtonCannel_user.Size = New System.Drawing.Size(144, 42)
        Me.ButtonCannel_user.TabIndex = 7
        Me.ButtonCannel_user.Text = "キャンセル"
        Me.ButtonCannel_user.UseVisualStyleBackColor = True
        '
        'ButtonOK_user
        '
        Me.ButtonOK_user.Location = New System.Drawing.Point(297, 300)
        Me.ButtonOK_user.Name = "ButtonOK_user"
        Me.ButtonOK_user.Size = New System.Drawing.Size(144, 42)
        Me.ButtonOK_user.TabIndex = 6
        Me.ButtonOK_user.Text = "登録"
        Me.ButtonOK_user.UseVisualStyleBackColor = True
        '
        'CheckBoxPermission
        '
        Me.CheckBoxPermission.AutoSize = True
        Me.CheckBoxPermission.Location = New System.Drawing.Point(252, 206)
        Me.CheckBoxPermission.Name = "CheckBoxPermission"
        Me.CheckBoxPermission.Size = New System.Drawing.Size(108, 27)
        Me.CheckBoxPermission.TabIndex = 4
        Me.CheckBoxPermission.Text = "権限有無"
        Me.CheckBoxPermission.UseVisualStyleBackColor = True
        '
        'textPassword
        '
        Me.textPassword.Location = New System.Drawing.Point(252, 126)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.textPassword.Size = New System.Drawing.Size(293, 30)
        Me.textPassword.TabIndex = 3
        '
        'textUserName
        '
        Me.textUserName.Location = New System.Drawing.Point(252, 58)
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(293, 30)
        Me.textUserName.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "管理者権限"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "パスワード"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "名前"
        '
        'cahngeButton
        '
        Me.cahngeButton.Location = New System.Drawing.Point(677, 296)
        Me.cahngeButton.Name = "cahngeButton"
        Me.cahngeButton.Size = New System.Drawing.Size(143, 43)
        Me.cahngeButton.TabIndex = 14
        Me.cahngeButton.Text = "既存商品編集"
        Me.cahngeButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 644)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximumSize = New System.Drawing.Size(1200, 700)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "mainForm"
        Me.Text = "メイン"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents logoutButton As Button
    Friend WithEvents itemAddButton As Button
    Friend WithEvents deliveryAddButton As Button
    Friend WithEvents inventoryButton As Button
    Friend WithEvents userAddButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents userdButton As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents mtextNet As MaskedTextBox
    Friend WithEvents mtextMoney As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textRemarks As TextBox
    Friend WithEvents textItemName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents textUserName As TextBox
    Friend WithEvents CheckBoxPermission As CheckBox
    Friend WithEvents ButtonCannel_user As Button
    Friend WithEvents ButtonOK_user As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents itemIndication As ComboBox
    Friend WithEvents deliveryQuantity As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ButtonCancel_delivery As Button
    Friend WithEvents ButtonOK_delivery As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonCancel_used As Button
    Friend WithEvents ButtonOK_used As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents usedQuantity As TextBox
    Friend WithEvents itemIndicationUsed As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cahngeButton As Button
End Class
