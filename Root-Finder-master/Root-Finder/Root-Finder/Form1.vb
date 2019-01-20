Public Class Form1

    Dim precision As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VScroll = True

        info.Visible = False
        info2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        lbltext.Visible = False

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

        info.Visible = False
        info2.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        lbltext.Visible = False

        If btn_0.Checked = True Then
            precision = 0
        ElseIf btn_3.Checked = True Then
            precision = 3
        Else
            precision = 6
        End If

        Dim a As Decimal = CDec(input_a.Text)
        Dim b As Decimal = CDec(input_b.Text)
        Dim c As Decimal = CDec(input_c.Text)

        If a = 0 Then
            If b = 0 Then
                If c = 0 Then
                    info.Visible = True
                    info.Text = " Infinite roots are possible for the equation 0 = 0 "
                Else
                    info.Visible = True
                    info.Text = " No roots exist for the equation " + CStr(c) + " = 0 "
                End If

            Else
                info.Visible = True
                info2.Visible = True
                info.Text = "The equation " + CStr(b) + "x + " + CStr(c) + " = 0 has one root . "
                info2.Text = " The only root is : " + CStr(-c / b)
            End If
        Else
            Dim root1 As Decimal
            Dim root2 As Decimal

            info.Visible = True
            info.Text = "Nature of roots : "
            info2.Visible = True
            lbltext.Visible = True
            Label3.Visible = True
            Label7.Text = "(" & input_a.Text & ")x2 +(" & input_b.Text & ")x +(" & input_c.Text & ")"
            Label7.Visible = True
            txt_root1.Visible = True
            txt_root2.Visible = True
            txt_root1.ReadOnly = True
            txt_root2.ReadOnly = True

            Dim D As Decimal
            D = ((b * b) - (4 * a * c))
            Label4.Visible = True
            Label4.Text = "discriminent(D)  = b2 - 4ac =" & CStr(D)
            If D < 0 Then

                info.Text += "Imaginary"
                D = Math.Sqrt(-D)

                root1 = (-1 * b) / (2 * a)
                root1 = Math.Round(root1, precision)

                txt_root1.Text = CStr(root1)
                txt_root2.Text = CStr(root1)

                root1 = D / (2 * a)
                root1 = Math.Round(root1, precision)

                txt_root1.Text += " + " + CStr(root1) + "i"
                txt_root2.Text += " + " + CStr(-root1) + "i"



            ElseIf D = 0 Then
                info.Text += "Equal"
                root1 = -b / (2 * a)
                root1 = Math.Round(root1, precision)
                root2 = root1

                txt_root1.Text = CStr(root1)
                txt_root2.Text = CStr(root2)

            Else
                info.Text += "Distinct"
                D = Math.Sqrt(D)
                root1 = -b + D
                root1 /= 2 * a

                root2 = -b - D
                root2 /= 2 * a

                root1 = Math.Round(root1, precision)
                root2 = Math.Round(root2, precision)

                txt_root1.Text = CStr(root1)
                txt_root2.Text = CStr(root2)

            End If

        End If
        Label5.Visible = True
        Label5.Text = "root_1 = (-b+√D)/2 = " & txt_root1.Text
        Label6.Visible = True
        Label6.Text = "root_2 = (-b-√D)/2 = " & txt_root2.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles input_a.TextChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles input_b.TextChanged

    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub root2_TextChanged(sender As Object, e As EventArgs) Handles txt_root2.TextChanged

    End Sub

    Private Sub lbltext_Click(sender As Object, e As EventArgs) Handles lbltext.Click

    End Sub

    Private Sub root1_TextChanged(sender As Object, e As EventArgs) Handles txt_root1.TextChanged

    End Sub

    Private Sub roots_Click(sender As Object, e As EventArgs) Handles info2.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub qeq_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
