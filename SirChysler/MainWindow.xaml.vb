Class MainWindow
    Private Sub Submit_button(sender As Object, e As RoutedEventArgs)
        Dim NameGreet, AgeGreet, AddressGreet As String
        NameGreet = "Hello I am" & Name.Text
        AgeGreet = "I am" & Age.Text
        AddressGreet = "I lived in" & Address.Text
        MsgBox(NameGreet & Chr(10) & AgeGreet & Chr(10) & AddressGreet)
    End Sub
    Private Sub Clear(sender As Object, e As RoutedEventArgs)
        Name.Text = ""
        Age.Text = ""
        Address.Text = ""
    End Sub
End Class
