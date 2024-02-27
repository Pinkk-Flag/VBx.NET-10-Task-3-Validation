<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtOne.Location = New System.Drawing.Point(12, 12)
        Me.txtOne.Multiline = True
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(110, 82)
        Me.txtOne.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTotal.Location = New System.Drawing.Point(251, 12)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(110, 82)
        Me.txtTotal.TabIndex = 1
        '
        'txtTwo
        '
        Me.txtTwo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTwo.Location = New System.Drawing.Point(469, 12)
        Me.txtTwo.Multiline = True
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(110, 82)
        Me.txtTwo.TabIndex = 2
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlus.Location = New System.Drawing.Point(158, 35)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(43, 45)
        Me.lblPlus.TabIndex = 3
        Me.lblPlus.Text = "+"
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEqual.Location = New System.Drawing.Point(400, 35)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(43, 45)
        Me.lblEqual.TabIndex = 4
        Me.lblEqual.Text = "="
        '
        'btnValidate
        '
        Me.btnValidate.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnValidate.Location = New System.Drawing.Point(633, 370)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(155, 68)
        Me.btnValidate.TabIndex = 5
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(294, 184)
        Me.txtPostcode.Multiline = True
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(169, 58)
        Me.txtPostcode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Postcode (For Victoria)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Were you born in Australia (Yes/No)"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(441, 310)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(169, 58)
        Me.txtAnswer.TabIndex = 9
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(633, 288)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(155, 68)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseCompatibleTextRendering = True
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(633, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 68)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "s"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOne As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents lblPlus As Label
    Friend WithEvents lblEqual As Label
    Friend WithEvents btnValidate As Button
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Button1 As Button
End Class
