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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        Button_Yellow = New Button()
        Button_Green = New Button()
        Button_Red = New Button()
        BindingSource1 = New BindingSource(components)
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox_Green = New TextBox()
        Button_Stop = New Button()
        Button_Start = New Button()
        Label5 = New Label()
        TextBox_Yellow = New TextBox()
        TextBox_Red = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Button_Yellow)
        GroupBox1.Controls.Add(Button_Green)
        GroupBox1.Controls.Add(Button_Red)
        GroupBox1.Location = New Point(295, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(141, 158)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Set Colour"
        ' 
        ' Button_Yellow
        ' 
        Button_Yellow.BackColor = Color.Yellow
        Button_Yellow.Location = New Point(34, 72)
        Button_Yellow.Name = "Button_Yellow"
        Button_Yellow.Size = New Size(75, 23)
        Button_Yellow.TabIndex = 1
        Button_Yellow.Text = "Yellow"
        Button_Yellow.UseVisualStyleBackColor = False
        ' 
        ' Button_Green
        ' 
        Button_Green.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button_Green.Location = New Point(34, 113)
        Button_Green.Name = "Button_Green"
        Button_Green.Size = New Size(75, 23)
        Button_Green.TabIndex = 1
        Button_Green.Text = "Green"
        Button_Green.UseVisualStyleBackColor = False
        ' 
        ' Button_Red
        ' 
        Button_Red.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button_Red.Location = New Point(34, 33)
        Button_Red.Name = "Button_Red"
        Button_Red.Size = New Size(75, 23)
        Button_Red.TabIndex = 1
        Button_Red.Text = "Red"
        Button_Red.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox_Green)
        GroupBox2.Controls.Add(Button_Stop)
        GroupBox2.Controls.Add(Button_Start)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox_Yellow)
        GroupBox2.Controls.Add(TextBox_Red)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(295, 185)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(141, 166)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cycle"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(111, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 15)
        Label8.TabIndex = 5
        Label8.Text = "sec"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(111, 88)
        Label7.Name = "Label7"
        Label7.Size = New Size(24, 15)
        Label7.TabIndex = 5
        Label7.Text = "sec"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(111, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 15)
        Label6.TabIndex = 5
        Label6.Text = "sec"
        ' 
        ' TextBox_Green
        ' 
        TextBox_Green.Location = New Point(77, 111)
        TextBox_Green.MaxLength = 1
        TextBox_Green.Name = "TextBox_Green"
        TextBox_Green.PlaceholderText = "2"
        TextBox_Green.Size = New Size(32, 23)
        TextBox_Green.TabIndex = 4
        TextBox_Green.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button_Stop
        ' 
        Button_Stop.Location = New Point(3, 140)
        Button_Stop.Name = "Button_Stop"
        Button_Stop.Size = New Size(58, 23)
        Button_Stop.TabIndex = 3
        Button_Stop.Text = "Stop"
        Button_Stop.UseVisualStyleBackColor = True
        ' 
        ' Button_Start
        ' 
        Button_Start.Location = New Point(77, 140)
        Button_Start.Name = "Button_Start"
        Button_Start.Size = New Size(58, 23)
        Button_Start.TabIndex = 3
        Button_Start.Text = "Start"
        Button_Start.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 2
        Label5.Text = "Green:"
        ' 
        ' TextBox_Yellow
        ' 
        TextBox_Yellow.Location = New Point(77, 85)
        TextBox_Yellow.MaxLength = 1
        TextBox_Yellow.Name = "TextBox_Yellow"
        TextBox_Yellow.PlaceholderText = "2"
        TextBox_Yellow.Size = New Size(32, 23)
        TextBox_Yellow.TabIndex = 4
        TextBox_Yellow.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Red
        ' 
        TextBox_Red.Location = New Point(77, 58)
        TextBox_Red.MaxLength = 1
        TextBox_Red.Name = "TextBox_Red"
        TextBox_Red.PlaceholderText = "2"
        TextBox_Red.Size = New Size(32, 23)
        TextBox_Red.TabIndex = 4
        TextBox_Red.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 2
        Label4.Text = "Yellow:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 1
        Label3.Text = "Red:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "Set Timings:"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(277, 339)
        Panel1.TabIndex = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 360)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Yellow As Button
    Friend WithEvents Button_Green As Button
    Friend WithEvents Button_Red As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Green As TextBox
    Friend WithEvents Button_Start As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Yellow As TextBox
    Friend WithEvents TextBox_Red As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Stop As Button
    Friend WithEvents Timer1 As Timer
End Class
