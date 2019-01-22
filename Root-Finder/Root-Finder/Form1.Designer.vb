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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_step = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.see_again = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.SystemColors.Control
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(378, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(133, 24)
        Me.title.TabIndex = 2
        Me.title.Text = "Root - Finder"
        '
        'equation
        '
        Me.equation.AutoSize = True
        Me.equation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.equation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equation.Location = New System.Drawing.Point(376, 53)
        Me.equation.Name = "equation"
        Me.equation.Size = New System.Drawing.Size(135, 20)
        Me.equation.TabIndex = 3
        Me.equation.Text = "a x²+ b x + c = 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kindly enter the values of the coefficients a , b and c : "
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(170, 125)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(18, 20)
        Me.a.TabIndex = 5
        Me.a.Text = "a"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(398, 125)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(18, 20)
        Me.b.TabIndex = 6
        Me.b.Text = "b"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(647, 125)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(17, 20)
        Me.c.TabIndex = 7
        Me.c.Text = "c"
        '
        'input_a
        '
        Me.input_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_a.Location = New System.Drawing.Point(97, 160)
        Me.input_a.Name = "input_a"
        Me.input_a.Size = New System.Drawing.Size(160, 26)
        Me.input_a.TabIndex = 8
        '
        'input_b
        '
        Me.input_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_b.Location = New System.Drawing.Point(339, 160)
        Me.input_b.Name = "input_b"
        Me.input_b.Size = New System.Drawing.Size(160, 26)
        Me.input_b.TabIndex = 9
        '
        'input_c
        '
        Me.input_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_c.Location = New System.Drawing.Point(565, 160)
        Me.input_c.Name = "input_c"
        Me.input_c.Size = New System.Drawing.Size(160, 26)
        Me.input_c.TabIndex = 10
        '
        'btnSolve
        '
        Me.btnSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(229, 204)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(145, 23)
        Me.btnSolve.TabIndex = 11
        Me.btnSolve.Text = "Show Answer"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(425, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(613, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.AutoSize = True
        Me.btn_0.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(237, 286)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(90, 25)
        Me.btn_0.TabIndex = 14
        Me.btn_0.Text = "0 places"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.AutoSize = True
        Me.btn_3.Checked = True
        Me.btn_3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(382, 286)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(90, 25)
        Me.btn_3.TabIndex = 15
        Me.btn_3.TabStop = True
        Me.btn_3.Text = "3 places"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.AutoSize = True
        Me.btn_6.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(538, 286)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(90, 25)
        Me.btn_6.TabIndex = 16
        Me.btn_6.Text = "6 places"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please specify the number of digits required after decimal point"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(299, 331)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(149, 19)
        Me.info.TabIndex = 18
        Me.info.Text = "This is not visible"
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.Location = New System.Drawing.Point(94, 368)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(115, 19)
        Me.info2.TabIndex = 19
        Me.info2.Text = "The roots are :"
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.Location = New System.Drawing.Point(495, 368)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(37, 19)
        Me.lbltext.TabIndex = 21
        Me.lbltext.Text = "and"
        '
        'txt_root2
        '
        Me.txt_root2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root2.Location = New System.Drawing.Point(599, 364)
        Me.txt_root2.Name = "txt_root2"
        Me.txt_root2.Size = New System.Drawing.Size(136, 30)
        Me.txt_root2.TabIndex = 24
        '
        'txt_root1
        '
        Me.txt_root1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root1.Location = New System.Drawing.Point(283, 362)
        Me.txt_root1.Name = "txt_root1"
        Me.txt_root1.Size = New System.Drawing.Size(154, 32)
        Me.txt_root1.TabIndex = 25
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        Me.ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), System.Drawing.Icon)
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        Me.ErrorProvider3.Icon = CType(resources.GetObject("ErrorProvider3.Icon"), System.Drawing.Icon)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(298, 331)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 27)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "The equation : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 416)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 24)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Part 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 416)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Step 2:"
        '
        'lbl_step
        '
        Me.lbl_step.AutoSize = True
        Me.lbl_step.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step.Location = New System.Drawing.Point(339, 379)
        Me.lbl_step.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_step.Name = "lbl_step"
        Me.lbl_step.Size = New System.Drawing.Size(90, 25)
        Me.lbl_step.TabIndex = 33
        Me.lbl_step.Text = "Step 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 331)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Calculation:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Visualize"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(335, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Part 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(335, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Part 3"
        '
        'see_again
        '
        Me.see_again.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.see_again.Location = New System.Drawing.Point(303, 566)
        Me.see_again.Name = "see_again"
        Me.see_again.Size = New System.Drawing.Size(184, 47)
        Me.see_again.TabIndex = 40
        Me.see_again.Text = "See Again"
        Me.see_again.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(565, 565)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(177, 47)
        Me.btnNext.TabIndex = 41
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(56, 566)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(184, 47)
        Me.btnPrev.TabIndex = 42
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 703)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.see_again)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_step)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_step As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents see_again As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button

End Class
