Public Class Form1

    Dim precision As Integer
    Dim ctr As Integer
    Dim ctr2 As Integer
    Dim flag As Integer
    Dim check As Integer
    
    Dim a_step, b_step, c_step As Decimal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorProvider1.SetError(input_a, "Empty String!!")
        ErrorProvider1.SetError(input_b, "Empty String!!")
        ErrorProvider1.SetError(input_c, "Empty String!!")

        btnPrev.Visible = False
        see_again.Visible = False
        btnNext.Visible = False


        flag = 1
        Dim old As Padding = Me.Margin
        Me.Margin = New Padding(old.Left, old.Top, old.Right, 50)

        Me.AutoScroll = True
       
        info.Visible = False
        info2.Visible = False
        Label3.Visible = False
        lbl_step.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
        Label5.Visible = False

        Label7.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        lbltext.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnPrev.Visible = False
        see_again.Visible = False
        btnNext.Visible = False

        txt_root1.Visible = False
        txt_root2.Visible = False
        Label7.Visible = False
        lbltext.Visible = False
        info2.Visible = False

        flag = 1
        info.Visible = False
        info2.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        lbltext.Visible = False

        Label3.Visible = False
        lbl_step.Visible = False
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

        check = -1
        btnPrev.Visible = False
        see_again.Visible = False
        btnNext.Visible = False
        flag = 1
        Label3.Visible = False
        lbl_step.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
        Label5.Visible = False

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

        Dim test1, test2, test3 As Decimal
        If Decimal.TryParse(input_a.Text, test1) And Decimal.TryParse(input_b.Text, test2) And Decimal.TryParse(input_c.Text, test3) Then
            Try
                a = CDec(input_a.Text)
                b = CDec(input_b.Text)
                c = CDec(input_c.Text)

                Timer1.Start()
                If a = 0 Then
                    info.BackColor = Color.White

                    info.ForeColor = Color.Black

                    MessageBox.Show("Warning : You have not enterd a quadratic equation !!")

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
                    flag = 0
                    ctr = 0
                    info2.Text = "The roots are : "
                    Dim show_a, show_b, show_c As String

                    If a < 0 Then
                        show_a = "- " + CStr(-a)
                    Else
                        show_a = " + " + CStr(a)
                    End If


                    If b < 0 Then
                        show_b = " - " + CStr(-b)
                    Else
                        show_b = " + " + CStr(b)
                    End If


                    If c < 0 Then
                        show_c = "- " + CStr(-c)
                    Else
                        show_c = " + " + CStr(c)
                    End If

                    info.Visible = True
                    info.Text = "Nature of roots : "
                    info2.Visible = True

                    txt_root1.ReadOnly = True
                    txt_root2.ReadOnly = True

                    Dim D As Decimal
                    D = ((b * b) - (4 * a * c))

                    Dim term_b As String
                    If b < 0 Then
                        term_b = "(" + CStr(b) + ")"
                    Else
                        term_b = CStr(b)
                    End If

                    Dim term_c As String
                    If c < 0 Then
                        term_c = "(" + CStr(c) + ")"
                    Else
                        term_c = CStr(c)
                    End If

                    Dim term_a As String
                    If a < 0 Then
                        term_a = "(" + CStr(a) + ")"
                    Else
                        term_a = CStr(a)
                    End If

                    If D < 0 Then

                        info.Text += "Imaginary"
                        info.BackColor = Color.Yellow

                        D = Math.Sqrt(-D)

                        root1 = (-1 * b) / (2 * a)
                        root1 = Math.Round(root1, precision)

                        txt_root1.Text = CStr(root1)
                        txt_root2.Text = CStr(root1)

                        root1 = D / (2 * a)
                        root1 = Math.Round(root1, precision)

                        If a < 0 Then
                            txt_root1.Text += " - " + CStr(-root1) + " i"
                            txt_root2.Text += " + " + CStr(-root1) + " i"

                        Else
                            txt_root1.Text += " + " + CStr(root1) + " i"
                            txt_root2.Text += " - " + CStr(root1) + " i"
                        End If



                    ElseIf D = 0 Then
                        info.BackColor = Color.GreenYellow

                        info.Text += "Equal"
                        root1 = -b / (2 * a)
                        root1 = Math.Round(root1, precision)
                        root2 = root1

                        txt_root1.Text = CStr(root1)
                        txt_root2.Text = CStr(root2)

                    Else
                        info.BackColor = Color.OrangeRed
                        info.ForeColor = Color.White

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

            Catch ex1 As Exception
                MessageBox.Show("Overflow condition!!")
            End Try
        Else
            MessageBox.Show("Cannot solve the equation. All inputs for coefficients are not correct. Please see the boxes with a cross sign!!")

        End If

    End Sub






    Function dsadsa() As Single

        Label3.Visible = False
        lbl_step.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
        Label5.Visible = False

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

                    Dim show_a, show_b, show_c As String

                    If a < 0 Then
                        show_a = "- " + CStr(-a)
                    Else
                        show_a = " + " + CStr(a)
                    End If


                    If b < 0 Then
                        show_b = " - " + CStr(-b)
                    Else
                        show_b = " + " + CStr(b)
                    End If


                    If c < 0 Then
                        show_c = "- " + CStr(-c)
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
                    lbl_step.Visible = True

                    Dim term_b As String
                    If b < 0 Then
                        term_b = "(" + CStr(b) + ")"
                    Else
                        term_b = CStr(b)
                    End If

                    Dim term_c As String
                    If c < 0 Then
                        term_c = "(" + CStr(c) + ")"
                    Else
                        term_c = CStr(c)
                    End If

                    Dim term_a As String
                    If a < 0 Then
                        term_a = "(" + CStr(a) + ")"
                    Else
                        term_a = CStr(a)
                    End If



                    lbl_step.Text = "discriminant(D)  = b² - 4ac = " + term_b + " * " + term_b + " - " + "4 *" + term_a + " * " + term_c + " = " + CStr(b * b) + " - " + CStr(4 * a * c) + " = " + CStr(D)

                    If D < 0 Then

                        info.Text += "Imaginary"
                        D = Math.Sqrt(-D)

                        root1 = (-1 * b) / (2 * a)
                        root1 = Math.Round(root1, precision)

                        txt_root1.Text = CStr(root1)
                        txt_root2.Text = CStr(root1)

                        root1 = D / (2 * a)
                        root1 = Math.Round(root1, precision)

                        If a < 0 Then
                            txt_root1.Text += " - " + CStr(-root1) + " i"
                            txt_root2.Text += " + " + CStr(-root1) + " i"

                        Else
                            txt_root1.Text += " + " + CStr(root1) + " i"
                            txt_root2.Text += " - " + CStr(root1) + " i"
                        End If



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

                    Label5.Text = "Ist root = (-b+√D)/(2 * a)" + " = (" + term1 + " + " + term2 + ") / ( 2 * " + term_a + ")" + " = " + txt_root1.Text
                    Label6.Visible = True
                    Label8.Visible = True
                    Label4.Visible = True
                    Label5.Visible = True

                    Label6.Text = "2nd root = (-b-√D)/(2 * a)" + " = (" + term1 + " - " + term2 + ") / ( 2 * " + term_a + ")" + " = " + txt_root2.Text



                End If

            Catch ex1 As Exception
                MessageBox.Show("Overflow condition!!")
            End Try
        Else
            MessageBox.Show("Cannot solve the equation. All inputs for coefficients are not correct. Please see the boxes with a cross sign!!")

        End If

    End Function

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
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_step.Click

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If flag = 0 Then

            ctr = ctr + 1
            If ctr >= 4 Then

                ctr = 1
                txt_root2.Visible = True
                Timer1.Stop()

            ElseIf ctr = 3 Then
                lbltext.Visible = True

            ElseIf ctr = 2 Then

                txt_root1.Visible = True

            End If
        End If

    End Sub


    Private Sub txt_root1_TextChanged(sender As Object, e As EventArgs) Handles txt_root1.TextChanged

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click

    End Sub

    Private Sub txt_root2_TextChanged(sender As Object, e As EventArgs) Handles txt_root2.TextChanged

    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click

        Button1_Click(sender, e)

    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Button1_Click(sender, e)

    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        Button1_Click(sender, e)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        flag = -1
        info2.Visible = False
        txt_root1.Visible = False
        txt_root2.Visible = False
        Label7.Visible = False
        lbltext.Visible = False

        btnPrev.Visible = True
        see_again.Visible = True
        btnNext.Visible = True

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

        Dim test1, test2, test3 As Decimal
        If Decimal.TryParse(input_a.Text, test1) And Decimal.TryParse(input_b.Text, test2) And Decimal.TryParse(input_c.Text, test3) Then
            Try

                a = CDec(input_a.Text)
                b = CDec(input_b.Text)
                c = CDec(input_c.Text)


                If a = 0 Then
                    MessageBox.Show("Warning : You have not entered a quadratic equation !!")
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
                    Dim show_a, show_b, show_c As String

                    If a < 0 Then
                        show_a = "- " + CStr(-a)
                    Else
                        show_a = " + " + CStr(a)
                    End If


                    If b < 0 Then
                        show_b = " - " + CStr(-b)
                    Else
                        show_b = " + " + CStr(b)
                    End If


                    If c < 0 Then
                        show_c = "- " + CStr(-c)
                    Else
                        show_c = " + " + CStr(c)
                    End If

                    Label7.Text = show_a + " x²" + show_b + " x" + show_c + " = 0"
                    Label7.Visible = True

                    visualize(sender, a, b, c, e)

                End If

            Catch ex As Exception
                MessageBox.Show("Error:Overflow Situation !! ")
                Label7.Visible = False
            End Try
        Else
            MessageBox.Show("Error:Overflow Situation !! ")
            Label7.Visible = False

        End If



    End Sub

    Private Sub visualize(sender As Object, ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, e As EventArgs)

        lbl_step.Text = "Step 1 : "
        lbl_step.Visible = True
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
        Label5.Visible = False

        a_step = a
        b_step = b
        c_step = c


        step1(sender, e)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ctr2 += 1

        If check = 1 Then

            If ctr2 = 1 Then
                Label6.Visible = True
            ElseIf ctr2 = 2 Then
                Label4.Visible = True
            ElseIf ctr2 = 3 Then
                Label8.Visible = True
            End If

        ElseIf check = 2 Then

            If ctr2 = 1 Then
                Label5.Visible = True
            ElseIf ctr2 = 2 Then
                Label4.Visible = True
            ElseIf ctr2 = 3 Then
                Label8.Visible = True
            End If

        ElseIf check = 3 Then
            If ctr2 = 1 Then
                Label5.Visible = True
            ElseIf ctr2 = 2 Then
                Label4.Visible = True
            ElseIf ctr2 = 3 Then
                Label8.Visible = True
            End If


        End If

    End Sub

    Private Sub step1(sender As Object, e As EventArgs)

        lbl_step.Text = "Step 1 : "

        Label5.Visible = False
        Dim D As Decimal
        Try
            D = ((b_step * b_step) - (4 * a_step * c_step))

        Catch ex As Exception
            MessageBox.Show("Overflow has occured !! Please try another input !!")
            Button2_Click(sender, e)

        End Try


        Dim term_b As String
        If b_step < 0 Then
            term_b = "(" + CStr(b_step) + ")"
        Else
            term_b = CStr(b_step)
        End If

        Dim term_c As String
        If c_step < 0 Then
            term_c = "(" + CStr(c_step) + ")"
        Else
            term_c = CStr(c_step)
        End If

        Dim term_a As String
        If a_step < 0 Then
            term_a = "(" + CStr(a_step) + ")"
        Else
            term_a = CStr(a_step)
        End If

        Label6.Text = "discriminant(D)  = b² - 4ac = " + term_b + " * " + term_b + " - " + "4 *" + term_a + " * " + term_c
        Label4.Text = "= " + CStr(b_step * b_step) + " - " + CStr(4 * a_step * c_step)
        Label8.Text = "= " + CStr(D)



        check = 1
        ctr2 = 0
        Timer2.Start()


    End Sub

    Private Sub step2(sender As Object, e As EventArgs)

        check = 2

        Dim root1 As Decimal

        txt_root1.Text = String.Empty

        Dim D As Decimal
        D = ((b_step * b_step) - (4 * a_step * c_step))

        If D < 0 Then

            root1 = (-1 * b_step) / (2 * a_step)
            root1 = Math.Round(root1, precision)

            txt_root1.Text = CStr(root1)

            D = Math.Sqrt(-D)
            root1 = D / (2 * a_step)
            root1 = Math.Round(root1, precision)
            If a_step < 0 Then
                txt_root1.Text += " - " + CStr(-root1) + " i"

            Else
                txt_root1.Text += " + " + CStr(root1) + " i"

            End If


        ElseIf D = 0 Then
            root1 = -b_step / (2 * a_step)
            root1 = Math.Round(root1, precision)

            txt_root1.Text = CStr(root1)
        Else
            D = Math.Sqrt(D)
            root1 = -b_step + D
            root1 /= 2 * a_step

            root1 = Math.Round(root1, precision)
            
            txt_root1.Text = CStr(root1)

        End If

        lbl_step.Text = "Step 2 : "
        ctr2 = 0

        Dim term_a As String
        If a_step < 0 Then
            term_a = "(" + CStr(a_step) + ")"
        Else
            term_a = CStr(a_step)
        End If

        Dim D1 As Decimal

        D1 = ((b_step * b_step) - (4 * a_step * c_step))

        Dim term1 As String
        If b_step < 0 Then
            term1 = CStr(-1 * b_step)
        Else
            term1 = "-" + CStr(b_step)
        End If

        Dim term2 As String
        term2 = ""
        If D1 < 0 Then
            term2 += CStr(Math.Round(Math.Sqrt(-D1), precision)) + " i "
        Else
            term2 += CStr(Math.Round(Math.Sqrt(D1), precision))
        End If



        Label5.Text = "Ist root = (-b+√D)/(2 * a)"
        Label4.Text = " = (" + term1 + " + " + term2 + ") / ( 2 * " + term_a + ")"
        Label8.Text = " = " + txt_root1.Text

        
    End Sub

    Private Sub step3(sender As Object, e As EventArgs)

        check = 3

        Dim root2 As Decimal

        txt_root2.Text = String.Empty

        Dim D As Decimal
        D = ((b_step * b_step) - (4 * a_step * c_step))

        If D < 0 Then

            root2 = (-1 * b_step) / (2 * a_step)
            root2 = Math.Round(root2, precision)

            txt_root2.Text = CStr(root2)

            D = Math.Sqrt(-D)
            root2 = D / (2 * a_step)
            root2 = Math.Round(root2, precision)
            If a_step < 0 Then
                txt_root2.Text += " + " + CStr(-root2) + " i"

            Else
                txt_root2.Text += " - " + CStr(root2) + " i"

            End If


        ElseIf D = 0 Then
            root2 = -b_step / (2 * a_step)
            root2 = Math.Round(root2, precision)

            txt_root2.Text = CStr(root2)
        Else
            D = Math.Sqrt(D)
            root2 = -b_step + D
            root2 /= 2 * a_step

            root2 = Math.Round(root2, precision)

            txt_root2.Text = CStr(root2)

        End If

        lbl_step.Text = "Step 3 : "
        ctr2 = 0

        Dim term_a As String
        If a_step < 0 Then
            term_a = "(" + CStr(a_step) + ")"
        Else
            term_a = CStr(a_step)
        End If

        Dim D1 As Decimal

        D1 = ((b_step * b_step) - (4 * a_step * c_step))

        Dim term1 As String
        If b_step < 0 Then
            term1 = CStr(-1 * b_step)
        Else
            term1 = "-" + CStr(b_step)
        End If

        Dim term2 As String
        term2 = ""
        If D1 < 0 Then
            term2 += CStr(Math.Round(Math.Sqrt(-D1), precision)) + " i "
        Else
            term2 += CStr(Math.Round(Math.Sqrt(D1), precision))
        End If


        Label5.Text = "2nd root = (-b-√D)/(2 * a)"
        Label4.Text = " = (" + term1 + " + " + term2 + ") / ( 2 * " + term_a + ")"
        Label8.Text = " = " + txt_root2.Text


    End Sub

    Private Sub see_again_Click(sender As Object, e As EventArgs) Handles see_again.Click
        ctr2 = 0
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        If lbl_step.Text = "Step 1 : " Then
            '    check = 1
            step1(sender, e)
        ElseIf lbl_step.Text = "Step 2 : " Then
            step2(sender, e)

        ElseIf lbl_step.Text = "Step 3 : " Then
            step3(sender, e)

        End If

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If lbl_step.Text = "Step 1 : " Then

            check = 2

            Label6.Visible = False
            Label4.Visible = False
            Label8.Visible = False

            step2(sender, e)

        ElseIf lbl_step.Text = "Step 2 : " Then
            Label6.Visible = False
            Label4.Visible = False
            Label8.Visible = False
            check = 3
            step3(sender, e)

        ElseIf lbl_step.Text = "Step 2 : " Then
            MessageBox.Show("Hurray!! You have reached the last step !!")

        End If


    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If lbl_step.Text = "Step 1 : " Then

            MessageBox.Show("You are already on the first step !!")

        ElseIf lbl_step.Text = "Step 2 : " Then

            check = 1

            Label6.Visible = False
            Label4.Visible = False
            Label8.Visible = False

            step1(sender, e)

        ElseIf lbl_step.Text = "Step 3 : " Then

            check = 2

            Label6.Visible = False
            Label4.Visible = False
            Label8.Visible = False

            step2(sender, e)

        End If


    End Sub
End Class
