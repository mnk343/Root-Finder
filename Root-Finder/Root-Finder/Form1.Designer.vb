﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
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
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(685, 9)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(15, 285)
        Me.VScrollBar1.TabIndex = 0
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.SystemColors.Control
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(272, 9)
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
        Me.equation.Location = New System.Drawing.Point(272, 51)
        Me.equation.Name = "equation"
        Me.equation.Size = New System.Drawing.Size(135, 20)
        Me.equation.TabIndex = 3
        Me.equation.Text = "a x²+ b x + c = 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kindly enter the values of the coefficients a , b and c : "
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(123, 125)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(18, 20)
        Me.a.TabIndex = 5
        Me.a.Text = "a"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(351, 125)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(18, 20)
        Me.b.TabIndex = 6
        Me.b.Text = "b"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(561, 125)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(17, 20)
        Me.c.TabIndex = 7
        Me.c.Text = "c"
        '
        'input_a
        '
        Me.input_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_a.Location = New System.Drawing.Point(54, 160)
        Me.input_a.Name = "input_a"
        Me.input_a.Size = New System.Drawing.Size(160, 26)
        Me.input_a.TabIndex = 8
        '
        'input_b
        '
        Me.input_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_b.Location = New System.Drawing.Point(276, 160)
        Me.input_b.Name = "input_b"
        Me.input_b.Size = New System.Drawing.Size(160, 26)
        Me.input_b.TabIndex = 9
        '
        'input_c
        '
        Me.input_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_c.Location = New System.Drawing.Point(493, 160)
        Me.input_c.Name = "input_c"
        Me.input_c.Size = New System.Drawing.Size(160, 26)
        Me.input_c.TabIndex = 10
        '
        'btnSolve
        '
        Me.btnSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolve.Location = New System.Drawing.Point(182, 204)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 11
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(309, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(434, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.AutoSize = True
        Me.btn_0.Location = New System.Drawing.Point(192, 286)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(65, 17)
        Me.btn_0.TabIndex = 14
        Me.btn_0.Text = "0 places"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.AutoSize = True
        Me.btn_3.Checked = True
        Me.btn_3.Location = New System.Drawing.Point(309, 286)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(65, 17)
        Me.btn_3.TabIndex = 15
        Me.btn_3.TabStop = True
        Me.btn_3.Text = "3 places"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.AutoSize = True
        Me.btn_6.Location = New System.Drawing.Point(434, 286)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(65, 17)
        Me.btn_6.TabIndex = 16
        Me.btn_6.Text = "6 places"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please specify the number of digits required after decimal point"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 497)
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
        Me.Controls.Add(Me.VScrollBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
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

End Class