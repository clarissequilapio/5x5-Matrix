Public Class Form1
    Private Sub nameInfo_TextChanged(sender As Object, e As EventArgs) Handles nameInfo.TextChanged


    End Sub

    Private Sub ageInfo_TextChanged(sender As Object, e As EventArgs) Handles ageInfo.TextChanged
        Dim ageInfo As Byte

    End Sub

    Private Sub addressInfo_TextChanged(sender As Object, e As EventArgs) Handles addressInfo.TextChanged
        Dim addressInfo As String

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub txtbtn_Click(sender As Object, e As EventArgs) Handles txtbtn.Click
        My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Sample.txt", "" & nameInfo.Text, True)
    End Sub
End Class
