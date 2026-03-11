Public Class hii
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Получаем текущее время
        Dim nowTime As DateTime = DateTime.Now
        ' Выводим время в TextBox
        TextBox1.Text = nowTime.ToString("HH:mm")
        ' Определяем час
        Dim hour As Integer = nowTime.Hour
        ' Проверка диапазонов
        If hour >= 8 And hour < 12 Then
            LabelResult.Text = "Доброе утро!"
        ElseIf hour >= 12 And hour < 17 Then
            LabelResult.Text = "Добрый день!"
        ElseIf hour >= 17 And hour < 23 Then
            LabelResult.Text = "Добрый вечер!"
        Else
            LabelResult.Text = "Доброй ночи!"
        End If
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