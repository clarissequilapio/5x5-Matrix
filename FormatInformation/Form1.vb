Public Class Form1
    Dim i As Short
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
            i += 1

            allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
            vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
            "==============================================" + vbNewLine

            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\Text\Sample" & i & ".txt", "" & allInfo.Text, True)
            MsgBox("Successfully saved as Text File.", MsgBoxStyle.Information, "Successfully Saved")
            clearboxes()
        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical, "Input Data")

        End If
    End Sub
    Private Sub xmlbtn_Click(sender As Object, e As EventArgs) Handles xmlbtn.Click
        If nameInfo.Text <> "" And ageInfo.Text <> "" And addressInfo.Text <> "" Then
            i += 1

            allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
            vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
            "==============================================" + vbNewLine

            My.Computer.FileSystem.WriteAllText("C:\Users\Clarisse\Documents\5th year documents\2nd sem\electives 3\Files\XML\Sample" & i & ".xml", "" & allInfo.Text, True)
            MsgBox("Successfully saved as XML File.", MsgBoxStyle.Information, "Successfully Saved")
            clearboxes()
        Else
            MsgBox("Please Write all Information.", MsgBoxStyle.Critical, "Input Data")

        End If
    End Sub


    Private Sub allInfo_TextChanged(sender As Object, e As EventArgs) Handles allInfo.TextChanged


    End Sub

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click

        allInfo.Visible = True
        allInfo.Text = "==============================================" + vbNewLine +
            nameLabel.Text + " " + nameInfo.Text + vbNewLine + ageLabel.Text + " " + ageInfo.Text +
        vbNewLine + addressLabel.Text + " " + addressInfo.Text + vbNewLine +
        "==============================================" + vbNewLine

    End Sub
    Sub clearboxes()
        nameInfo.Clear()
        ageInfo.Clear()
        addressInfo.Clear()
        allInfo.Clear()
        allInfo.Visible = False
    End Sub


End Class
