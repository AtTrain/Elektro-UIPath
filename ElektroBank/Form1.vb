Public Class Form1
    Dim _accounts As List(Of Account)
    Dim _currentAccount As Account

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sæt startværdier
        lblDate.Text = DateTime.Now.ToShortDateString()
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss")

        ' Konfigurer Timer
        Dim clockTimer As New Timer()
        AddHandler clockTimer.Tick, AddressOf ClockTick

        'As Lambda
        'AddHandler clockTimer.Tick, Sub(tickObject As Object, tickEventArgs As EventArgs)
        '                                lblClock.Text = DateTime.Now.ToString("HH:mm:ss")
        '                            End Sub
        clockTimer.Interval = 1000
        clockTimer.Start()

        _accounts = New List(Of Account)()
    End Sub

    Private Sub ClockTick(tickObject As Object, tickEventArgs As EventArgs)
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        _currentAccount = New Account()
        _accounts.Add(_currentAccount)
        FillAccountDeails()
        RefreshGrid()
    End Sub

    Private Sub FillAccountDeails()
        If _currentAccount Is Nothing Then
            Return
        End If
        lblAccountNo.Text = _currentAccount.AccountNo
        lblBalance.Text = _currentAccount.Balance
        txtDeposit.Clear()
        txtWithdraw.Clear()
    End Sub

    Private Sub lblDeposit_Click(sender As Object, e As EventArgs) Handles lblDeposit.Click
        If _currentAccount Is Nothing Then
            Return
        End If
        Dim amount As Decimal
        If Not Decimal.TryParse(txtDeposit.Text, amount) Then
            MessageBox.Show($"{txtDeposit.Text} can't be parsed as a decimal.")
            txtDeposit.Select()
            txtDeposit.SelectAll()
            Return
        End If
        Try
            _currentAccount.Deposit(amount)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtDeposit.Select()
            txtDeposit.SelectAll()
            Return
        End Try
        FillAccountDeails()
        RefreshGrid()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        If _currentAccount Is Nothing Then
            Return
        End If
        Dim amount As Decimal
        If Not Decimal.TryParse(txtWithdraw.Text, amount) Then
            MessageBox.Show($"{txtWithdraw.Text} can't be parsed as a decimal.")
            txtWithdraw.Select()
            txtWithdraw.SelectAll()
            Return
        End If
        Try
            _currentAccount.Withdraw(amount)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtWithdraw.Select()
            txtWithdraw.SelectAll()
            Return
        End Try
        FillAccountDeails()
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        gridAccounts.DataSource = Nothing
        gridAccounts.DataSource = _accounts
    End Sub

    Private Sub gridAccounts_SelectionChanged(sender As Object, e As EventArgs) Handles gridAccounts.SelectionChanged
        If gridAccounts.SelectedRows.Count = 1 Then
            _currentAccount = gridAccounts.SelectedRows(0).DataBoundItem
            FillAccountDeails()
        End If
    End Sub
End Class
