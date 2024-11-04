<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.userNameText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userNameText
        '
        Me.userNameText.Location = New System.Drawing.Point(173, 41)
        Me.userNameText.MinimumSize = New System.Drawing.Size(250, 25)
        Me.userNameText.Name = "userNameText"
        Me.userNameText.Size = New System.Drawing.Size(250, 25)
        Me.userNameText.TabIndex = 0
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(173, 127)
        Me.passwordText.MinimumSize = New System.Drawing.Size(250, 25)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordText.Size = New System.Drawing.Size(250, 25)
        Me.passwordText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ユーザー名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "パスワード:"
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(41, 204)
        Me.loginButton.MinimumSize = New System.Drawing.Size(380, 50)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(380, 50)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "ログイン"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 324)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.userNameText)
        Me.MaximumSize = New System.Drawing.Size(500, 380)
        Me.MinimumSize = New System.Drawing.Size(500, 380)
        Me.Name = "loginForm"
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userNameText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginButton As Button
End Class
