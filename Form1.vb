Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temperature As Integer
        Dim input As String = TextBox1.Text.Trim()

        ' Проверка пустого ввода
        If input = "" Then
            ShowMessage("Введите температуру воздуха!", Color.DarkOrange)
            Exit Sub
        End If

        ' Проверка числа
        If Not Integer.TryParse(input, temperature) Then
            ShowMessage("Ошибка! Введите целое число, например -15", Color.Red)
            Exit Sub
        End If

        ' Проверка разумного диапазона
        If temperature < -60 Or temperature > 60 Then
            ShowMessage("Ошибка! Такой температуры не бывает.", Color.Red)
            Exit Sub
        End If

        ' Основная логика
        If temperature < -25 Or temperature >= 40 Then
            ShowMessage("Занятия в школе отменяются!", Color.Blue)
        Else
            ShowMessage("Можешь идти в школу. Желаю успехов!", Color.Green)
        End If

    End Sub


    Private Sub ShowMessage(text As String, textColor As Color)
        LabelResult.Text = text
        LabelResult.ForeColor = textColor
        LabelResult.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        LabelResult.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
