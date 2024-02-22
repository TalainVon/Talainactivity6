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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Txtbox1 = New TextBox()
        Txtbox2 = New TextBox()
        Txtbox3 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the first number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(93, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter the second number"
        ' 
        ' Txtbox1
        ' 
        Txtbox1.Location = New Point(93, 88)
        Txtbox1.Name = "Txtbox1"
        Txtbox1.Size = New Size(100, 23)
        Txtbox1.TabIndex = 2
        ' 
        ' Txtbox2
        ' 
        Txtbox2.Location = New Point(93, 161)
        Txtbox2.Name = "Txtbox2"
        Txtbox2.Size = New Size(100, 23)
        Txtbox2.TabIndex = 3
        ' 
        ' Txtbox3
        ' 
        Txtbox3.Location = New Point(93, 261)
        Txtbox3.Name = "Txtbox3"
        Txtbox3.Size = New Size(100, 23)
        Txtbox3.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(93, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 532)
        Controls.Add(Button1)
        Controls.Add(Txtbox3)
        Controls.Add(Txtbox2)
        Controls.Add(Txtbox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtbox1 As TextBox
    Friend WithEvents Txtbox2 As TextBox
    Friend WithEvents Txtbox3 As TextBox
    Friend WithEvents Button1 As Button

End Class
