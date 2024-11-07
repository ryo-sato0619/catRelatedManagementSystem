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
        Me.userAddButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.itemAddButton = New System.Windows.Forms.Button()
        Me.deliveryAddButton = New System.Windows.Forms.Button()
        Me.inventoryButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.userdButton = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
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
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "納品登録"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(49, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 30)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "仮で納品管理です"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "商品登録"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(201, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 30)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "仮で商品登録です"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ユーザー登録"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(155, 87)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 30)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = "仮でユーザー登録です"
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 32)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1172, 454)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "使用登録"
        Me.TabPage5.UseVisualStyleBackColor = True
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents userdButton As Button
End Class
