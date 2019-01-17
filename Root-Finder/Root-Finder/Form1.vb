Public Class Form1

    Dim precision As Integer
    Dim ctr As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim old As Padding = Me.Margin
        Me.Margin = New Padding(old.Left, old.Top, old.Right, 50)

        Me.AutoScroll = True

        info.Visible = False
        info2.Visible = False
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
                        info2.Text = " The only root is : " + CStr(-c / b)
                    End If
                Else
                    Dim root1 As Decimal
                    Dim root2 As Decimal

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
            ctr += 1
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

End Class
