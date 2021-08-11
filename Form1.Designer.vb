<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_launcher
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_launcher))
        Me.pb_play = New System.Windows.Forms.PictureBox()
        Me.pb_cache = New System.Windows.Forms.PictureBox()
        Me.pb_website = New System.Windows.Forms.PictureBox()
        Me.b_close = New System.Windows.Forms.Button()
        Me.b_minimize = New System.Windows.Forms.Button()
        Me.progress_load = New System.Windows.Forms.ProgressBar()
        Me.lbl_update = New System.Windows.Forms.Label()
        CType(Me.pb_play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cache, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_website, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_play
        '
        Me.pb_play.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_play.BackColor = System.Drawing.Color.Transparent
        Me.pb_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pb_play.Image = Global.Winterspring_Launcher.My.Resources.Resources.play_static
        Me.pb_play.Location = New System.Drawing.Point(328, 320)
        Me.pb_play.Name = "pb_play"
        Me.pb_play.Size = New System.Drawing.Size(181, 118)
        Me.pb_play.TabIndex = 0
        Me.pb_play.TabStop = False
        '
        'pb_cache
        '
        Me.pb_cache.BackColor = System.Drawing.Color.Transparent
        Me.pb_cache.Image = Global.Winterspring_Launcher.My.Resources.Resources.cache_static
        Me.pb_cache.Location = New System.Drawing.Point(173, 376)
        Me.pb_cache.Name = "pb_cache"
        Me.pb_cache.Size = New System.Drawing.Size(161, 62)
        Me.pb_cache.TabIndex = 1
        Me.pb_cache.TabStop = False
        '
        'pb_website
        '
        Me.pb_website.BackColor = System.Drawing.Color.Transparent
        Me.pb_website.Image = Global.Winterspring_Launcher.My.Resources.Resources.web_static
        Me.pb_website.Location = New System.Drawing.Point(12, 376)
        Me.pb_website.Name = "pb_website"
        Me.pb_website.Size = New System.Drawing.Size(161, 62)
        Me.pb_website.TabIndex = 1
        Me.pb_website.TabStop = False
        '
        'b_close
        '
        Me.b_close.BackColor = System.Drawing.Color.Transparent
        Me.b_close.Location = New System.Drawing.Point(505, 4)
        Me.b_close.Name = "b_close"
        Me.b_close.Size = New System.Drawing.Size(20, 20)
        Me.b_close.TabIndex = 2
        Me.b_close.TabStop = False
        Me.b_close.Text = "x"
        Me.b_close.UseVisualStyleBackColor = False
        '
        'b_minimize
        '
        Me.b_minimize.BackColor = System.Drawing.Color.Transparent
        Me.b_minimize.Location = New System.Drawing.Point(484, 4)
        Me.b_minimize.Name = "b_minimize"
        Me.b_minimize.Size = New System.Drawing.Size(20, 20)
        Me.b_minimize.TabIndex = 2
        Me.b_minimize.TabStop = False
        Me.b_minimize.Text = "-"
        Me.b_minimize.UseVisualStyleBackColor = False
        '
        'progress_load
        '
        Me.progress_load.Location = New System.Drawing.Point(111, 353)
        Me.progress_load.Name = "progress_load"
        Me.progress_load.Size = New System.Drawing.Size(211, 23)
        Me.progress_load.Step = 5
        Me.progress_load.TabIndex = 3
        Me.progress_load.Visible = False
        '
        'lbl_update
        '
        Me.lbl_update.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_update.AutoSize = True
        Me.lbl_update.BackColor = System.Drawing.Color.Transparent
        Me.lbl_update.ForeColor = System.Drawing.Color.White
        Me.lbl_update.Location = New System.Drawing.Point(27, 357)
        Me.lbl_update.Name = "lbl_update"
        Me.lbl_update.Size = New System.Drawing.Size(0, 13)
        Me.lbl_update.TabIndex = 4
        '
        'frm_launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Winterspring_Launcher.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(528, 450)
        Me.Controls.Add(Me.lbl_update)
        Me.Controls.Add(Me.b_minimize)
        Me.Controls.Add(Me.b_close)
        Me.Controls.Add(Me.pb_website)
        Me.Controls.Add(Me.pb_cache)
        Me.Controls.Add(Me.pb_play)
        Me.Controls.Add(Me.progress_load)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_launcher"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Winterspring Launcher"
        CType(Me.pb_play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cache, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_website, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_play As PictureBox
    Friend WithEvents pb_cache As PictureBox
    Friend WithEvents pb_website As PictureBox
    Friend WithEvents b_close As Button
    Friend WithEvents b_minimize As Button
    Friend WithEvents progress_load As ProgressBar
    Friend WithEvents lbl_update As Label
End Class
