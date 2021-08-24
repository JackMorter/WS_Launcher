Imports System.IO
Imports System.Net

Public Class frm_launcher
    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private WithEvents WebC As New WebClient

    'Dragable Form
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    'ProgressBar
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        progress_load.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    'Download Function
    Private Sub download_patch()
        Dim client As WebClient = New WebClient
        Dim local_path As String = My.Computer.FileSystem.CurrentDirectory & "\Data\Patch-Z.MPQ"

        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted

        client.DownloadFileAsync(New Uri("https://download.winterspring.online/WOW/Patch-Z.MPQ"), local_path)

        progress_load.Visible = True

        lbl_update.Visible = True
        lbl_update.Text = "Downloading..."

        pb_play.Enabled = False
        pb_cache.Enabled = False
    End Sub

    'Change Realmlist
    Private Sub change_realmlist_wtf()
        'TO DO
    End Sub

    'Download Complete
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        pb_play.Enabled = True
        pb_cache.Enabled = True

        lbl_update.Text = "Up to date!"
    End Sub

    '################################################ BUTTONS ##################################################

    'Play Button
    Private Sub pb_play_Click(sender As Object, e As EventArgs) Handles pb_play.Click
        If File.Exists(My.Computer.FileSystem.CurrentDirectory & "/Data/Patch-Z.MPQ") Then

            If File.Exists(My.Computer.FileSystem.CurrentDirectory & "/Wow.exe") Then
                Shell(My.Computer.FileSystem.CurrentDirectory & "/Wow.exe")
                Me.Close()
            Else
                MsgBox("Could not start Wow.exe", MsgBoxStyle.Critical, "Application Not Found")
            End If

        Else
            'Download Patch-Z from WebSite
            download_patch()

        End If
    End Sub

    'Cache Button
    Private Sub pb_cache_Click(sender As Object, e As EventArgs) Handles pb_cache.Click
        pb_cache.Image = My.Resources.cache_pressed

        If Directory.Exists(My.Computer.FileSystem.CurrentDirectory & "/Cache") Then

            Dim Cache As String = (My.Computer.FileSystem.CurrentDirectory & "/Cache")

            Select Case MsgBox("Do you want to delete the Cache folder?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING")
                Case MsgBoxResult.Yes
                    Directory.Delete(Cache, True)

                Case MsgBoxResult.No

            End Select
        End If
    End Sub

    'Website Buton
    Private Sub pb_website_Click(sender As Object, e As EventArgs) Handles pb_website.Click
        pb_website.Image = My.Resources.web_pressed
        Process.Start("https://winterspring.online")
    End Sub

    'Minimize
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Close
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_close.Click
        Me.Close()
    End Sub

    'Button Hover
    Private Sub pb_play_MouseHover(sender As Object, e As EventArgs) Handles pb_play.MouseEnter
        pb_play.Image = My.Resources.play_pressed
    End Sub

    Private Sub pb_play_MouseLeave(sender As Object, e As EventArgs) Handles pb_play.MouseLeave
        pb_play.Image = My.Resources.play_static
    End Sub

    Private Sub pb_cache_MouseEnter(sender As Object, e As EventArgs) Handles pb_cache.MouseEnter
        pb_cache.Image = My.Resources.cache_pressed
    End Sub

    Private Sub pb_cache_MouseLeave(sender As Object, e As EventArgs) Handles pb_cache.MouseLeave
        pb_cache.Image = My.Resources.cache_static
    End Sub

    Private Sub pb_website_MouseEnter(sender As Object, e As EventArgs) Handles pb_website.MouseEnter
        pb_website.Image = My.Resources.web_pressed
    End Sub

    Private Sub pb_website_MouseLeave(sender As Object, e As EventArgs) Handles pb_website.MouseLeave
        pb_website.Image = My.Resources.web_static
    End Sub

End Class
