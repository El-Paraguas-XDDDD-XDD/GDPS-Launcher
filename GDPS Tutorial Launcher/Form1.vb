Imports System.Diagnostics

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim gdpsFolderPath As String = IO.Path.Combine(Application.StartupPath, "gdps")

        ' Gracias a @DimisAIO por arreglar el botón de "Launch"
        ' Establece el directorio de trabajo en la carpeta gdps
        ' (Aunque puedes cambiar el nombre de la carpeta)
        ' [y para que no hayan errores, también tienes que cambiarlo aquí]
        ' Específicamente en esta parte del código
        ' Dim gdpsFolderPath As String = IO.Path.Combine(Application.StartupPath, "NOMBRE DE LA CARPETA")

        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = IO.Path.Combine(gdpsFolderPath, "YOURGDPS.exe") ' es necesario cambiar "YOURGDPS.exe" por el nombre de tu GDPS para que el launcher funcione
        startInfo.WorkingDirectory = gdpsFolderPath

        ' Inicia el proceso (en este caso, YOURGDPS.exe)
        ' Cuando el proceso no inicie correctamente o no se encuentre, va a aparecer un MessageBox
        ' Es recomendado dejar esta parte del código tal y como está para evitar errores

        Try
            Dim process As New Process()
            process.StartInfo = startInfo
            process.Start()
        Catch ex As Exception
            MessageBox.Show("No se pudo iniciar el proceso: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Al marcar la casilla "Cerrar al abrir el juego"
        ' y al presionar el botón "Launch", el launcher se cerrará

        If CheckBox1.Checked Then
            Me.Close()
        End If

    End Sub

    ' Para cambiar las URLs de los botones, es necesario ver que hace cada uno
    ' PictureBox3 es para las herramientas del GDPS (Resubir niveles, canciones, banear usuarios, etc...)
    ' PictureBox2 es para los hacks del GDPS (Si quieres hacer un 
    ' PictureBox4 es para la demonlist del GDPS (en caso de que el servidor cuente con una) ¯\_(ツ)_/¯
    ' Y en este caso, sería https://example.com/tools
    ' Solo tienes que cambiar "https://example.com/" por la página del GDPS

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://example.com")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://example.com")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://example.com")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Aquí puedes programar una acción al momento de iniciar el programa
        ' Por ejemplo, una MessageBox (aquí tienes un ejemplo de como hacerlo)
        ' MessageBox.Show("Hola :D", "Hola :D", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' [aunque eso puede ser molesto al momento de iniciar el launcher]

    End Sub

End Class
