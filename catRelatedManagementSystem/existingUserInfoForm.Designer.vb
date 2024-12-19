<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class existingUserInfoForm
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
        Me.userInfoDeleteButton = New System.Windows.Forms.Button()
        Me.ButtonCannel_userChange = New System.Windows.Forms.Button()
        Me.ButtonOK_userChange = New System.Windows.Forms.Button()
        Me.CheckBoxPermission_change = New System.Windows.Forms.CheckBox()
        Me.textPassword_change = New System.Windows.Forms.TextBox()
        Me.textUserName_change = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userNo_change = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'userInfoDeleteButton
        '
        Me.userInfoDeleteButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userInfoDeleteButton.Location = New System.Drawing.Point(279, 333)
        Me.userInfoDeleteButton.Name = "userInfoDeleteButton"
        Me.userInfoDeleteButton.Size = New System.Drawing.Size(144, 42)
        Me.userInfoDeleteButton.TabIndex = 17
        Me.userInfoDeleteButton.Text = "削除"
        Me.userInfoDeleteButton.UseVisualStyleBackColor = True
        '
        'ButtonCannel_userChange
        '
        Me.ButtonCannel_userChange.Location = New System.Drawing.Point(620, 333)
        Me.ButtonCannel_userChange.Name = "ButtonCannel_userChange"
        Me.ButtonCannel_userChange.Size = New System.Drawing.Size(144, 42)
        Me.ButtonCannel_userChange.TabIndex = 16
        Me.ButtonCannel_userChange.Text = "閉じる"
        Me.ButtonCannel_userChange.UseVisualStyleBackColor = True
        '
        'ButtonOK_userChange
        '
        Me.ButtonOK_userChange.Location = New System.Drawing.Point(452, 333)
        Me.ButtonOK_userChange.Name = "ButtonOK_userChange"
        Me.ButtonOK_userChange.Size = New System.Drawing.Size(144, 42)
        Me.ButtonOK_userChange.TabIndex = 15
        Me.ButtonOK_userChange.Text = "変更登録"
        Me.ButtonOK_userChange.UseVisualStyleBackColor = True
        '
        'CheckBoxPermission_change
        '
        Me.CheckBoxPermission_change.AutoSize = True
        Me.CheckBoxPermission_change.Location = New System.Drawing.Point(250, 239)
        Me.CheckBoxPermission_change.Name = "CheckBoxPermission_change"
        Me.CheckBoxPermission_change.Size = New System.Drawing.Size(108, 27)
        Me.CheckBoxPermission_change.TabIndex = 14
        Me.CheckBoxPermission_change.Text = "権限有無"
        Me.CheckBoxPermission_change.UseVisualStyleBackColor = True
        '
        'textPassword_change
        '
        Me.textPassword_change.Location = New System.Drawing.Point(250, 159)
        Me.textPassword_change.Name = "textPassword_change"
        Me.textPassword_change.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.textPassword_change.Size = New System.Drawing.Size(293, 30)
        Me.textPassword_change.TabIndex = 13
        '
        'textUserName_change
        '
        Me.textUserName_change.Location = New System.Drawing.Point(250, 91)
        Me.textUserName_change.Name = "textUserName_change"
        Me.textUserName_change.Size = New System.Drawing.Size(293, 30)
        Me.textUserName_change.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "管理者権限"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "パスワード"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "名前"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ユーザー番号"
        '
        'userNo_change
        '
        Me.userNo_change.FormattingEnabled = True
        Me.userNo_change.Location = New System.Drawing.Point(250, 28)
        Me.userNo_change.Name = "userNo_change"
        Me.userNo_change.Size = New System.Drawing.Size(120, 31)
        Me.userNo_change.TabIndex = 19
        '
        'existingUserInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(880, 575)
        Me.Controls.Add(Me.userNo_change)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userInfoDeleteButton)
        Me.Controls.Add(Me.ButtonCannel_userChange)
        Me.Controls.Add(Me.ButtonOK_userChange)
        Me.Controls.Add(Me.CheckBoxPermission_change)
        Me.Controls.Add(Me.textPassword_change)
        Me.Controls.Add(Me.textUserName_change)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "existingUserInfoForm"
        Me.Text = "登録ユーザー情報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userInfoDeleteButton As Button
    Friend WithEvents ButtonCannel_userChange As Button
    Friend WithEvents ButtonOK_userChange As Button
    Friend WithEvents CheckBoxPermission_change As CheckBox
    Friend WithEvents textPassword_change As TextBox
    Friend WithEvents textUserName_change As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents userNo_change As ComboBox
End Class
