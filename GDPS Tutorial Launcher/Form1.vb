Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim gdpsFolderPath As String = IO.Path.Combine(Application.StartupPath, "gdps")

        ' Set the working directory to the gdps folder
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = IO.Path.Combine(gdpsFolderPath, "KTNGDPS.exe")
        startInfo.WorkingDirectory = gdpsFolderPath

        ' Start the process
        Dim process As New Process()
        process.StartInfo = startInfo
        process.Start()
        Me.Close() ' hace que el launcher se cierre luego de hacer click al botón
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://twitter.com")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://instagram.com")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://youtube.com")
    End Sub
End Class
