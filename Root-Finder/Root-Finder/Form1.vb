Public Class Form1

    Dim precision As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub title_Click(sender As Object, e As EventArgs) Handles title.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles equation.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If input_a.Text = String.Empty And input_b.Text = String.Empty And input_c.Text = String.Empty Then
            MessageBox.Show("Values were empty already !!")

        Else
            input_a.Clear()
            input_b.Clear()
            input_c.Clear()
            MessageBox.Show("All the values of the coefficients have been cleared !!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        If btn_0.Checked = True Then
            precision = 0
        ElseIf btn_3.Checked = True Then
            precision = 3
        Else
            precision = 6
        End If

        input_a.Text = precision


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles input_a.TextChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles input_b.TextChanged

    End Sub
End Class
