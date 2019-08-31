﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewer
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.timeLabel = New MetroFramework.Controls.MetroLabel()
        Me.timeProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.AlbumLabel = New System.Windows.Forms.Label()
        Me.ArtistLabel = New System.Windows.Forms.Label()
        Me.TrackLabel = New System.Windows.Forms.Label()
        Me.AlbumCover = New System.Windows.Forms.PictureBox()
        CType(Me.AlbumCover,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'timeLabel
        '
        Me.timeLabel.Location = New System.Drawing.Point(275, 214)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(350, 19)
        Me.timeLabel.TabIndex = 14
        Me.timeLabel.Text = "Don't change the design here! Use the other design forms!"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.timeLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'timeProgressBar
        '
        Me.timeProgressBar.Location = New System.Drawing.Point(275, 194)
        Me.timeProgressBar.Name = "timeProgressBar"
        Me.timeProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.timeProgressBar.Size = New System.Drawing.Size(350, 17)
        Me.timeProgressBar.Style = MetroFramework.MetroColorStyle.Green
        Me.timeProgressBar.TabIndex = 13
        Me.timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'AlbumLabel
        '
        Me.AlbumLabel.AutoSize = true
        Me.AlbumLabel.Font = New System.Drawing.Font("Calibri", 14!)
        Me.AlbumLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AlbumLabel.Location = New System.Drawing.Point(276, 154)
        Me.AlbumLabel.Name = "AlbumLabel"
        Me.AlbumLabel.Size = New System.Drawing.Size(153, 23)
        Me.AlbumLabel.TabIndex = 12
        Me.AlbumLabel.Text = "<< Album Name >>"
        '
        'ArtistLabel
        '
        Me.ArtistLabel.AutoSize = true
        Me.ArtistLabel.Font = New System.Drawing.Font("Calibri", 16!)
        Me.ArtistLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ArtistLabel.Location = New System.Drawing.Point(275, 119)
        Me.ArtistLabel.Name = "ArtistLabel"
        Me.ArtistLabel.Size = New System.Drawing.Size(174, 27)
        Me.ArtistLabel.TabIndex = 11
        Me.ArtistLabel.Text = "<< Artist Name >>"
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = true
        Me.TrackLabel.Font = New System.Drawing.Font("Calibri", 20!)
        Me.TrackLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TrackLabel.Location = New System.Drawing.Point(274, 84)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(205, 33)
        Me.TrackLabel.TabIndex = 10
        Me.TrackLabel.Text = "<< Track Name >>"
        '
        'AlbumCover
        '
        Me.AlbumCover.Location = New System.Drawing.Point(110, 73)
        Me.AlbumCover.Name = "AlbumCover"
        Me.AlbumCover.Size = New System.Drawing.Size(160, 160)
        Me.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlbumCover.TabIndex = 9
        Me.AlbumCover.TabStop = false
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 319)
        Me.ControlBox = false
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.timeProgressBar)
        Me.Controls.Add(Me.AlbumLabel)
        Me.Controls.Add(Me.ArtistLabel)
        Me.Controls.Add(Me.TrackLabel)
        Me.Controls.Add(Me.AlbumCover)
        Me.DisplayHeader = false
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Viewer"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = false
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Viewer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.AlbumCover,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents timeLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AlbumLabel As Label
    Friend WithEvents ArtistLabel As Label
    Friend WithEvents TrackLabel As Label
    Friend WithEvents AlbumCover As PictureBox
    Public WithEvents timeProgressBar As MetroFramework.Controls.MetroProgressBar
End Class
