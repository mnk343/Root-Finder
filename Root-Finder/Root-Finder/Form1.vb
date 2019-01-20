Public Class Form1

    Dim precision As Integer
    Dim ctr As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim old As Padding = Me.Margin
        Me.Margin = New Padding(old.Left, old.Top, old.Right, 50)

        Me.AutoScroll = True

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        info.Visible = False
        info2.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        lbltext.Visible = False

        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = False

        If input_a.Text = String.Empty And input_b.Text = String.Empty And input_c.Text = String.Empty Then
            MessageBox.Show("Values were empty already !!")

        Else
            input_a.Clear()
            input_b.Clear()
            input_c.Clear()
            MessageBox.Show("All the values of the coefficients have been cleared !!")
        End If


        ErrorProvider1.SetError(input_a, "Empty String!!")
        ErrorProvider3.SetError(input_a, "")


        ErrorProvider1.SetError(input_b, "Empty String!!")
        ErrorProvider3.SetError(input_b, "")

        ErrorProvider1.SetError(input_c, "Empty String!!")
        ErrorProvider3.SetError(input_c, "")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False

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


        Dim a As Decimal
        Dim b As Decimal
        Dim c As Decimal

        'If ctr < 3 Then
        'MessageBox.Show("Cannot solve the equation. All inputs for coefficients are not correct. Please see the boxes with a cross sign!!")
        Dim test1, test2, test3 As Decimal
        If Decimal.TryParse(input_a.Text, test1) And Decimal.TryParse(input_b.Text, test2) And Decimal.TryParse(input_c.Text, test3) Then
            Try
                a = CDec(input_a.Text)
                b = CDec(input_b.Text)
                c = CDec(input_c.Text)

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
                        info2.Text = " The only root is : " + CStr(Math.Round(-c / b, precision))

                    End If
                Else
                    Dim root1 As Decimal
                    Dim root2 As Decimal

                    Label3.Visible = True

                    Dim show_a, show_b, show_c As String

                    If a < 0 Then
                        show_a = "- " + CStr(a)
                    Else
                        show_a = " + " + CStr(a)
                    End If


                    If b < 0 Then
                        show_b = " - " + CStr(b)
                    Else
                        show_b = " + " + CStr(b)
                    End If


                    If c < 0 Then
                        show_c = "- " + CStr(c)
                    Else
                        show_c = " + " + CStr(c)
                    End If

                    Label7.Text = show_a + " x²" + show_b + " x" + show_c + " = 0"
                    Label7.Visible = True

                    info.Visible = True
                    info.Text = "Nature of roots : "
                    info2.Visible = True
                    lbltext.Visible = True
                    txt_root1.Visible = True
                    txt_root2.Visible = True
                    txt_root1.ReadOnly = True
                    txt_root2.ReadOnly = True

                    Dim D As Decimal
                    D = ((b * b) - (4 * a * c))
                    Label4.Visible = True
                    Label4.Text = "discriminent(D)  = b² - 4ac = " + CStr(b) + " * " + CStr(b) + " - " + "4 *" + CStr(a) + " * " + CStr(c) + " = " + CStr(b * b) + " - " + CStr(4 * a * c) + " = " + CStr(D)

                    If D < 0 Then

                        info.Text += "Imaginary"
                        D = Math.Sqrt(-D)

                        root1 = (-1 * b) / (2 * a)
                        root1 = Math.Round(root1, precision)

                        txt_root1.Text = CStr(root1)
                        txt_root2.Text = CStr(root1)

                        root1 = D / (2 * a)
                        root1 = Math.Round(root1, precision)

                        txt_root1.Text += " + " + CStr(root1) + " i"
                        txt_root2.Text += " + " + CStr(-root1) + " i"



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
                    Label5.Visible = True
                    Dim D1 As Decimal

                    D1 = ((b * b) - (4 * a * c))

                    Dim term1 As String
                    If b < 0 Then
                        term1 = CStr(-1 * b)
                    Else
                        term1 = "-" + CStr(b)
                    End If

                    Dim term2 As String
                    term2 = ""
                    If D1 < 0 Then
                        term2 += CStr(Math.Round(Math.Sqrt(-D1), precision)) + " i "
                    Else
                        term2 += CStr(Math.Round(Math.Sqrt(D1), precision))
                    End If

                    Label5.Text = "Ist root = (-b+√D)/(2 * a)" + " = (" + term1 + " + " + term2 + ") / ( 2 * " + CStr(Math.Round(a, precision)) + ")" + " = " + txt_root1.Text
                    Label6.Visible = True
                    Label6.Text = "2nd root = (-b-√D)/(2 * a)" + " = (" + term1 + " - " + term2 + ") / ( 2 * " + CStr(Math.Round(a, precision)) + ")" + " = " + txt_root2.Text



                End If
              
            Catch ex1 As Exception
                MessageBox.Show("Overflow condition!!")
            End Try
        Else
            MessageBox.Show("Cannot solve the equation. All inputs for coefficients are not correct. Please see the boxes with a cross sign!!")

        End If

    End Sub

    Private Sub input_a_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles input_a.Validating

        ErrorProvider1.SetError(input_a, "")
        ErrorProvider2.SetError(input_a, "")
        ErrorProvider3.SetError(input_a, "")

        Dim test As Decimal

        If (input_a.Text = String.Empty) Then
            ErrorProvider1.SetError(input_a, "Please Enter an input ")


        ElseIf Decimal.TryParse(input_a.Text, test) Then
            ErrorProvider2.SetError(input_a, "")
            ErrorProvider3.SetError(input_a, "Correct")

        Else
            ErrorProvider2.SetError(input_a, "Please enter a number and not an alphanumeric string !!")

        End If

    End Sub

    Private Sub input_b_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles input_b.Validating
        ErrorProvider1.SetError(input_b, "")
        ErrorProvider2.SetError(input_b, "")
        ErrorProvider3.SetError(input_b, "")

        Dim test As Decimal

        If (input_b.Text = String.Empty) Then
            ErrorProvider1.SetError(input_b, "Please Enter an input ")


        ElseIf Decimal.TryParse(input_b.Text, test) Then
            ctr += 1
            ErrorProvider2.SetError(input_b, "")
            ErrorProvider3.SetError(input_b, "Correct")

        Else
            ErrorProvider2.SetError(input_b, "Please enter a number and not an alphanumeric string !!")

        End If
    End Sub


    Private Sub input_c_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles input_c.Validating
        ErrorProvider1.SetError(input_c, "")
        ErrorProvider2.SetError(input_c, "")
        ErrorProvider3.SetError(input_c, "")

        Dim test As Decimal

        If (input_c.Text = String.Empty) Then
            ErrorProvider1.SetError(input_c, "Please Enter an input ")

        ElseIf Decimal.TryParse(input_c.Text, test) Then
            ErrorProvider2.SetError(input_c, "")
            ErrorProvider3.SetError(input_c, "Correct")
            ctr += 1

        Else
            ErrorProvider2.SetError(input_c, "Please enter a number and not an alphanumeric string !!")

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
