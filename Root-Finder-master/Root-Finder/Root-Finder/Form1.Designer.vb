<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.title = New System.Windows.Forms.Label()
        Me.equation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.input_a = New System.Windows.Forms.TextBox()
        Me.input_b = New System.Windows.Forms.TextBox()
        Me.input_c = New System.Windows.Forms.TextBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.RadioButton()
        Me.btn_3 = New System.Windows.Forms.RadioButton()
        Me.btn_6 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.info2 = New System.Windows.Forms.Label()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.txt_root2 = New System.Windows.Forms.TextBox()
        Me.txt_root1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.SystemColors.Control
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(363, 11)
        Me.title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(167, 29)
        Me.title.TabIndex = 2
        Me.title.Text = "Root - Finder"
        '
        'equation
        '
        Me.equation.AutoSize = True
        Me.equation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.equation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equation.Location = New System.Drawing.Point(363, 63)
        Me.equation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.equation.Name = "equation"
        Me.equation.Size = New System.Drawing.Size(170, 25)
        Me.equation.TabIndex = 3
        Me.equation.Text = "a x²+ b x + c = 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kindly enter the values of the coefficients a , b and c : "
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(164, 154)
        Me.a.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(23, 25)
        Me.a.TabIndex = 5
        Me.a.Text = "a"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(468, 154)
        Me.b.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(23, 25)
        Me.b.TabIndex = 6
        Me.b.Text = "b"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(748, 154)
        Me.c.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(22, 25)
        Me.c.TabIndex = 7
        Me.c.Text = "c"
        '
        'input_a
        '
        Me.input_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_a.Location = New System.Drawing.Point(72, 197)
        Me.input_a.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.input_a.Name = "input_a"
        Me.input_a.Size = New System.Drawing.Size(212, 30)
        Me.input_a.TabIndex = 8
        '
        'input_b
        '
        Me.input_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_b.Location = New System.Drawing.Point(368, 197)
        Me.input_b.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.input_b.Name = "input_b"
        Me.input_b.Size = New System.Drawing.Size(212, 30)
        Me.input_b.TabIndex = 9
        '
        'input_c
        '
        Me.input_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_c.Location = New System.Drawing.Point(657, 197)
        Me.input_c.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.input_c.Name = "input_c"
        Me.input_c.Size = New System.Drawing.Size(212, 30)
        Me.input_c.TabIndex = 10
        '
        'btnSolve
        '
        Me.btnSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(243, 251)
        Me.btnSolve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(100, 28)
        Me.btnSolve.TabIndex = 11
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(412, 251)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(579, 251)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.AutoSize = True
        Me.btn_0.Location = New System.Drawing.Point(256, 352)
        Me.btn_0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(82, 21)
        Me.btn_0.TabIndex = 14
        Me.btn_0.Text = "0 places"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.AutoSize = True
        Me.btn_3.Checked = True
        Me.btn_3.Location = New System.Drawing.Point(412, 352)
        Me.btn_3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(82, 21)
        Me.btn_3.TabIndex = 15
        Me.btn_3.TabStop = True
        Me.btn_3.Text = "3 places"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.AutoSize = True
        Me.btn_6.Location = New System.Drawing.Point(579, 352)
        Me.btn_6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(82, 21)
        Me.btn_6.TabIndex = 16
        Me.btn_6.Text = "6 places"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 309)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(480, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please specify the number of digits required after decimal point"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(16, 396)
        Me.info.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(160, 25)
        Me.info.TabIndex = 18
        Me.info.Text = "This is not visible"
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.Location = New System.Drawing.Point(16, 441)
        Me.info2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(139, 25)
        Me.info2.TabIndex = 19
        Me.info2.Text = "The roots are :"
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(311, 443)
        Me.lbltext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(45, 25)
        Me.lbltext.TabIndex = 21
        Me.lbltext.Text = "and"
        '
        'txt_root2
        '
        Me.txt_root2.Location = New System.Drawing.Point(368, 446)
        Me.txt_root2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_root2.Name = "txt_root2"
        Me.txt_root2.Size = New System.Drawing.Size(132, 22)
        Me.txt_root2.TabIndex = 24
        '
        'txt_root1
        '
        Me.txt_root1.Location = New System.Drawing.Point(169, 441)
        Me.txt_root1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_root1.Name = "txt_root1"
        Me.txt_root1.Size = New System.Drawing.Size(132, 22)
        Me.txt_root1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "calculation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 596)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 633)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 669)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 742)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_root1)
        Me.Controls.Add(Me.txt_root2)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.input_c)
        Me.Controls.Add(Me.input_b)
        Me.Controls.Add(Me.input_a)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.equation)
        Me.Controls.Add(Me.title)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents equation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.Label
    Friend WithEvents input_a As System.Windows.Forms.TextBox
    Friend WithEvents input_b As System.Windows.Forms.TextBox
    Friend WithEvents input_c As System.Windows.Forms.TextBox
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.RadioButton
    Friend WithEvents btn_3 As System.Windows.Forms.RadioButton
    Friend WithEvents btn_6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents info2 As System.Windows.Forms.Label
    Friend WithEvents lbltext As System.Windows.Forms.Label
    Friend WithEvents txt_root2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_root1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
