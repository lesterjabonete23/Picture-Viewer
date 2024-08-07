Public Class ViewerForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPicture.Click
        ' Show the open file dialog box.
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form’s caption.
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub picShowPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShowPicture.Click
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        MsgBox("Program was terminated.")
        Me.Close()
    End Sub
End Class
