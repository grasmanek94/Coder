Public Class Form1
    Dim WasNum(0 To 1000) As Boolean
    Dim WasNumCT(0 To 100) As Boolean
    Dim RandomClass As New Random()
    Function GetRandomNumNext() As String
        Dim num As Integer = RandomClass.Next(0, 1000)
        Dim TempString As String = ""
        While WasNum(num) = True
            num = RandomClass.Next(0, 1000)
        End While
        TempString = num.ToString()
        If num < 100 Then
            TempString = "0" + TempString
            If num < 10 Then
                TempString = "0" + TempString
            End If
        End If
        GetRandomNumNext = TempString
    End Function
    Function GetRandomNumNextCT() As String
        Dim num As Integer = RandomClass.Next(10, 100)
        Dim TempString As String = ""
        While WasNumCT(num) = True
            num = RandomClass.Next(10, 100)
        End While
        TempString = num.ToString()
        If num < 10 Then
            TempString = "0" + TempString
        End If
        GetRandomNumNextCT = TempString
    End Function
    Function Numerize(ByVal Add As String, ByVal Replc As String, Optional ByVal ending As Boolean = False) As String
        If ending = False Then
            Numerize = "        ({""" + Add + """, """ + Replc + """}),"
        Else
            Numerize = "        ({""" + Add + """, """ + Replc + """})"
        End If
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For index As Integer = 0 To 1000 Step 1
            WasNum(index) = False
        Next index
        For index As Integer = 0 To 100 Step 1
            WasNumCT(index) = False
        Next index
        RichTextBox1.Text = ""
        RichTextBox1.Text = RichTextBox1.Text + "   Dim SwitchTable()() As String ="
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + "   {"
        For index As Integer = 0 To 255 Step 1
            RichTextBox1.Text = RichTextBox1.Text + vbNewLine + "       ({""" + GetRandomNumNext() + """, """ + GetRandomNumNext() + """, """ + GetRandomNumNext() + """}),"
        Next index
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + "       ({""" + GetRandomNumNext() + """, """ + GetRandomNumNext() + """, """ + GetRandomNumNext() + """})" + vbNewLine + " }"

        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + "   Dim CompressionTable()() As String ="
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + "   {"

        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + Numerize(Chr(32), GetRandomNumNextCT())
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + Numerize(Chr(33), GetRandomNumNextCT())
        For index As Integer = 35 To 125 Step 1
            RichTextBox1.Text = RichTextBox1.Text + vbNewLine + Numerize(Chr(index), GetRandomNumNextCT())
        Next index
        RichTextBox1.Text = RichTextBox1.Text + vbNewLine + Numerize(Chr(126), GetRandomNumNextCT(), True) + vbNewLine + "  }"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If RichTextBox1.TextLength > 0 Then
            Clipboard.Clear()
            Clipboard.SetText(RichTextBox1.Text)
        End If
    End Sub
End Class
