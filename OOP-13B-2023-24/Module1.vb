Module Module1

    Sub Main()
        Dim b As New BankAccount("Mr Stone", 0.32)
        Console.WriteLine(b.getBalance)
    End Sub

End Module
Class BankAccount
    Private AcNum As String
    Private ACBalance As Decimal
    Private ACHolder As String
    Public Sub New(_ACHolder As String, OpenBalance As Decimal)
        ACHolder = _ACHolder
        ACBalance = OpenBalance
    End Sub
    Public Sub Deposit(amount As Decimal)
        ACBalance += amount
    End Sub
    Public Function getBalance()
        Return ACBalance
    End Function
End Class

