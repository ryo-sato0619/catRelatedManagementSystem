<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class existingItemInfoForm
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
        Me.textRemarks_change = New System.Windows.Forms.TextBox()
        Me.textItemName_change = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtextNet_change = New System.Windows.Forms.MaskedTextBox()
        Me.mtextMoney_change = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClose_change = New System.Windows.Forms.Button()
        Me.ButtonOK_change = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemNo_change = New System.Windows.Forms.ComboBox()
        Me.ButtonDellete_change = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textRemarks_change
        '
        Me.textRemarks_change.Location = New System.Drawing.Point(219, 271)
        Me.textRemarks_change.Name = "textRemarks_change"
        Me.textRemarks_change.Size = New System.Drawing.Size(293, 30)
        Me.textRemarks_change.TabIndex = 25
        '
        'textItemName_change
        '
        Me.textItemName_change.Location = New System.Drawing.Point(219, 82)
        Me.textItemName_change.Name = "textItemName_change"
        Me.textItemName_change.Size = New System.Drawing.Size(293, 30)
        Me.textItemName_change.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "個入り"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "円"
        '
        'mtextNet_change
        '
        Me.mtextNet_change.Location = New System.Drawing.Point(219, 205)
        Me.mtextNet_change.Name = "mtextNet_change"
        Me.mtextNet_change.Size = New System.Drawing.Size(105, 30)
        Me.mtextNet_change.TabIndex = 24
        Me.mtextNet_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtextMoney_change
        '
        Me.mtextMoney_change.Location = New System.Drawing.Point(219, 143)
        Me.mtextMoney_change.Name = "mtextMoney_change"
        Me.mtextMoney_change.Size = New System.Drawing.Size(105, 30)
        Me.mtextMoney_change.TabIndex = 23
        Me.mtextMoney_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "備考"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "内容量"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "金額"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "品名"
        '
        'ButtonClose_change
        '
        Me.ButtonClose_change.Location = New System.Drawing.Point(504, 332)
        Me.ButtonClose_change.Name = "ButtonClose_change"
        Me.ButtonClose_change.Size = New System.Drawing.Size(143, 43)
        Me.ButtonClose_change.TabIndex = 15
        Me.ButtonClose_change.Text = "閉じる"
        Me.ButtonClose_change.UseVisualStyleBackColor = True
        '
        'ButtonOK_change
        '
        Me.ButtonOK_change.Location = New System.Drawing.Point(324, 332)
        Me.ButtonOK_change.Name = "ButtonOK_change"
        Me.ButtonOK_change.Size = New System.Drawing.Size(143, 43)
        Me.ButtonOK_change.TabIndex = 14
        Me.ButtonOK_change.Text = "変更登録"
        Me.ButtonOK_change.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "商品番号"
        '
        'itemNo_change
        '
        Me.itemNo_change.FormattingEnabled = True
        Me.itemNo_change.Location = New System.Drawing.Point(219, 23)
        Me.itemNo_change.Name = "itemNo_change"
        Me.itemNo_change.Size = New System.Drawing.Size(100, 31)
        Me.itemNo_change.TabIndex = 28
        '
        'ButtonDellete_change
        '
        Me.ButtonDellete_change.Location = New System.Drawing.Point(147, 332)
        Me.ButtonDellete_change.Name = "ButtonDellete_change"
        Me.ButtonDellete_change.Size = New System.Drawing.Size(143, 43)
        Me.ButtonDellete_change.TabIndex = 29
        Me.ButtonDellete_change.Text = "削除"
        Me.ButtonDellete_change.UseVisualStyleBackColor = True
        '
        'existingItemInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(880, 575)
        Me.Controls.Add(Me.ButtonDellete_change)
        Me.Controls.Add(Me.itemNo_change)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textRemarks_change)
        Me.Controls.Add(Me.textItemName_change)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mtextNet_change)
        Me.Controls.Add(Me.mtextMoney_change)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonClose_change)
        Me.Controls.Add(Me.ButtonOK_change)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "existingItemInfoForm"
        Me.Text = "登録商品情報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textRemarks_change As TextBox
    Friend WithEvents textItemName_change As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtextNet_change As MaskedTextBox
    Friend WithEvents mtextMoney_change As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClose_change As Button
    Friend WithEvents ButtonOK_change As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents itemNo_change As ComboBox
    Friend WithEvents ButtonDellete_change As Button
End Class
