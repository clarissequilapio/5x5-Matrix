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
        If nameInfo.Text <> "" And ageInfo.Text <> "" And addressInfo.Text <> "" Then
            allInfo.AppendText(nameLabel.Text + " " + nameInfo.Text + vbNewLine)
            allInfo.AppendText(ageLabel.Text + " " + ageInfo.Text + vbNewLine)
            allInfo.AppendText(addressLabel.Text + " " + addressInfo.Text + vbNewLine)
            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\Sample.txt", "" & allInfo.Text, True)
            MsgBox("Successfully saved as Text File.", MsgBoxStyle.Information)
        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical)

        End If
    End Sub


    Private Sub allInfo_TextChanged(sender As Object, e As EventArgs) Handles allInfo.TextChanged


    End Sub

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        allInfo.Visible = True
        allInfo.Equals(nameLabel.Text + " " + nameInfo.Text + vbNewLine)
        allInfo.Equals(ageLabel.Text + " " + ageInfo.Text + vbNewLine)
        allInfo.Equals(addressLabel.Text + " " + addressInfo.Text + vbNewLine)
    End Sub
    Sub clearboxes()
        nameInfo.Clear()
        ageInfo.Clear()
        addressInfo.Clear()
    End Sub
End Class
