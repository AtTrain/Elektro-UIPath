Imports System.Runtime.Serialization

Public Class Account
    Private Shared _usedAccountNumbers As List(Of Integer) = New List(Of Integer)()

    Private _accountNo As Integer
    Private _balance As Decimal
    Private ReadOnly _random = New Random()

    Property AccountNo As Integer
        Get
            Return _accountNo
        End Get
        Private Set(value As Integer)
            _accountNo = value
        End Set
    End Property

    Property Balance As Decimal
        Get
            Return _balance
        End Get
        Private Set(value As Decimal)
            _balance = value
        End Set
    End Property

    Public Sub New()
        Dim accNo As Integer
        Do
            accNo = _random.Next(10000, 99999)
        Loop While (_usedAccountNumbers.FirstOrDefault(Function(no) accNo = no) <> Nothing)
        _usedAccountNumbers.Add(accNo)
        Me._accountNo = accNo
        Me._balance = 0
    End Sub


    Function Deposit(amount As Decimal) As Decimal
        If amount < 0 Then
            Throw New Exception("You can't desposit a negative amount")
        End If
        _balance += amount
        Return Balance
    End Function

    Function Withdraw(amount As Decimal) As Decimal
        If amount < 0 Then
            Throw New Exception("You can't withdraw a negative amount")
        End If
        If _balance - amount < 0 Then
            Throw New Exception($"You can't withdraw {amount} as your balance is only {_balance}")
        End If
        _balance -= amount
        Return Balance
    End Function
End Class
