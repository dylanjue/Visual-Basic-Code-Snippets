<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        grosstaxtxt = New TextBox()
        calculatebtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 0
        Label1.Text = "Input Gross Tax :"
        ' 
        ' grosstaxtxt
        ' 
        grosstaxtxt.BackColor = SystemColors.ControlLightLight
        grosstaxtxt.Location = New Point(212, 131)
        grosstaxtxt.Name = "grosstaxtxt"
        grosstaxtxt.Size = New Size(100, 23)
        grosstaxtxt.TabIndex = 1
        ' 
        ' calculatebtn
        ' 
        calculatebtn.BackColor = Color.Gray
        calculatebtn.Location = New Point(113, 172)
        calculatebtn.Name = "calculatebtn"
        calculatebtn.Size = New Size(199, 35)
        calculatebtn.TabIndex = 2
        calculatebtn.Text = "Calculate Tax and Net Pay"
        calculatebtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(477, 323)
        Controls.Add(calculatebtn)
        Controls.Add(grosstaxtxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Simple Tax Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grosstaxtxt As TextBox
    Friend WithEvents calculatebtn As Button

End Class
