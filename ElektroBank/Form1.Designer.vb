<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.panelAccount = New System.Windows.Forms.Panel()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.lblDeposit = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridAccounts = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelAccount.SuspendLayout
        CType(Me.gridAccounts,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblDate
        '
        Me.lblDate.AutoSize = true
        Me.lblDate.Location = New System.Drawing.Point(12, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(57, 20)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Label1"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = true
        Me.lblClock.Location = New System.Drawing.Point(614, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblClock.Size = New System.Drawing.Size(57, 20)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "Label1"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(16, 76)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(157, 85)
        Me.btnAddAccount.TabIndex = 2
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = true
        '
        'panelAccount
        '
        Me.panelAccount.Controls.Add(Me.txtWithdraw)
        Me.panelAccount.Controls.Add(Me.txtDeposit)
        Me.panelAccount.Controls.Add(Me.Label5)
        Me.panelAccount.Controls.Add(Me.Label6)
        Me.panelAccount.Controls.Add(Me.btnWithdraw)
        Me.panelAccount.Controls.Add(Me.lblDeposit)
        Me.panelAccount.Controls.Add(Me.lblBalance)
        Me.panelAccount.Controls.Add(Me.Label4)
        Me.panelAccount.Controls.Add(Me.lblAccountNo)
        Me.panelAccount.Controls.Add(Me.Label2)
        Me.panelAccount.Location = New System.Drawing.Point(210, 99)
        Me.panelAccount.Name = "panelAccount"
        Me.panelAccount.Size = New System.Drawing.Size(457, 363)
        Me.panelAccount.TabIndex = 3
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(156, 317)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(100, 26)
        Me.txtWithdraw.TabIndex = 13
        Me.txtWithdraw.Text = "0"
        Me.txtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(156, 272)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 26)
        Me.txtDeposit.TabIndex = 12
        Me.txtDeposit.Text = "0"
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(19, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Withdraw Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(19, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Deposit Amount"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(287, 312)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(157, 36)
        Me.btnWithdraw.TabIndex = 9
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = true
        '
        'lblDeposit
        '
        Me.lblDeposit.Location = New System.Drawing.Point(287, 266)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(157, 39)
        Me.lblDeposit.TabIndex = 5
        Me.lblDeposit.Text = "Deposit"
        Me.lblDeposit.UseVisualStyleBackColor = true
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = true
        Me.lblBalance.Location = New System.Drawing.Point(144, 42)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblBalance.Size = New System.Drawing.Size(18, 20)
        Me.lblBalance.TabIndex = 8
        Me.lblBalance.Text = "#"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(19, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Balance"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = true
        Me.lblAccountNo.Location = New System.Drawing.Point(144, 9)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAccountNo.Size = New System.Drawing.Size(18, 20)
        Me.lblAccountNo.TabIndex = 6
        Me.lblAccountNo.Text = "#"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(19, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AccountNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(210, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Current Account"
        '
        'gridAccounts
        '
        Me.gridAccounts.AllowUserToAddRows = false
        Me.gridAccounts.AllowUserToDeleteRows = false
        Me.gridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAccounts.Location = New System.Drawing.Point(210, 516)
        Me.gridAccounts.Name = "gridAccounts"
        Me.gridAccounts.ReadOnly = true
        Me.gridAccounts.RowTemplate.Height = 28
        Me.gridAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAccounts.Size = New System.Drawing.Size(457, 211)
        Me.gridAccounts.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(210, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "All Accounts"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 756)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridAccounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelAccount)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelAccount.ResumeLayout(false)
        Me.panelAccount.PerformLayout
        CType(Me.gridAccounts,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents panelAccount As Panel
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents lblDeposit As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAccountNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gridAccounts As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWithdraw As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
