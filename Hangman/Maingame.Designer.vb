<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maingame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.img_title = New System.Windows.Forms.PictureBox()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.lbl_word = New System.Windows.Forms.Label()
        Me.lbl_lettersinword = New System.Windows.Forms.Label()
        Me.lbl_numlettersinword = New System.Windows.Forms.Label()
        CType(Me.img_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_title
        '
        Me.img_title.Image = Global.Hangman.My.Resources.Resources.HangmanTitle
        Me.img_title.InitialImage = Nothing
        Me.img_title.Location = New System.Drawing.Point(30, 12)
        Me.img_title.Name = "img_title"
        Me.img_title.Size = New System.Drawing.Size(568, 147)
        Me.img_title.TabIndex = 0
        Me.img_title.TabStop = False
        '
        'btn_play
        '
        Me.btn_play.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_play.Location = New System.Drawing.Point(217, 165)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(179, 66)
        Me.btn_play.TabIndex = 1
        Me.btn_play.Text = "Lets Play"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'lbl_word
        '
        Me.lbl_word.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_word.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_word.Location = New System.Drawing.Point(-4, 365)
        Me.lbl_word.Name = "lbl_word"
        Me.lbl_word.Size = New System.Drawing.Size(633, 52)
        Me.lbl_word.TabIndex = 2
        Me.lbl_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_lettersinword
        '
        Me.lbl_lettersinword.AutoSize = True
        Me.lbl_lettersinword.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lettersinword.Location = New System.Drawing.Point(88, 244)
        Me.lbl_lettersinword.Name = "lbl_lettersinword"
        Me.lbl_lettersinword.Size = New System.Drawing.Size(364, 33)
        Me.lbl_lettersinword.TabIndex = 3
        Me.lbl_lettersinword.Text = "Number of letters in the word :"
        '
        'lbl_numlettersinword
        '
        Me.lbl_numlettersinword.AutoSize = True
        Me.lbl_numlettersinword.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numlettersinword.Location = New System.Drawing.Point(468, 244)
        Me.lbl_numlettersinword.Name = "lbl_numlettersinword"
        Me.lbl_numlettersinword.Size = New System.Drawing.Size(0, 33)
        Me.lbl_numlettersinword.TabIndex = 4
        '
        'Maingame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 520)
        Me.Controls.Add(Me.lbl_numlettersinword)
        Me.Controls.Add(Me.lbl_lettersinword)
        Me.Controls.Add(Me.lbl_word)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.img_title)
        Me.Name = "Maingame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman"
        CType(Me.img_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_title As PictureBox
    Friend WithEvents btn_play As Button
    Friend WithEvents lbl_word As Label
    Friend WithEvents lbl_lettersinword As Label
    Friend WithEvents lbl_numlettersinword As Label
End Class
