Public Class Maingame

    Dim word As String
    Dim letterguess As Char

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        word = InputBox("Enter a word to guess")
        lbl_word.Text = ""
        lbl_numlettersinword.Text = ""

        lbl_numlettersinword.Text = word.Length

        For i As Integer = 1 To Len(word)

            lbl_word.Text += "_"

        Next

        word.ToCharArray()

        Do
            letterguess = InputBox("Guess a letter from a-z?", XPos:=900, YPos:=300).ToLower


            For i = 0 To Integer.Parse(word.Length) - 1 Step 1

                If word(i) = letterguess Then
                    Me.lbl_word.Text = lbl_word.Text.Remove(i, 1)
                    Me.lbl_word.Text = lbl_word.Text.Insert(i, letterguess)
                End If
            Next
        Loop Until lbl_word.Text = word
    End Sub

End Class
