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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddWordLastStatusL = New System.Windows.Forms.Label()
        Me.AddNewWordBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewWordDefTB = New System.Windows.Forms.TextBox()
        Me.NewWordTB = New System.Windows.Forms.TextBox()
        Me.DefineBTN = New System.Windows.Forms.Button()
        Me.DefinitionTB = New System.Windows.Forms.TextBox()
        Me.WordBox = New System.Windows.Forms.ListBox()
        Me.DefineWordTAB = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExampleSentenceRTB = New System.Windows.Forms.RichTextBox()
        Me.DefineRandomTB = New System.Windows.Forms.TextBox()
        Me.DefineRandomBTN = New System.Windows.Forms.Button()
        Me.RandomWordTB = New System.Windows.Forms.TextBox()
        Me.RandomWordBTN = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReverseBTN = New System.Windows.Forms.Button()
        Me.ReverseWordTB = New System.Windows.Forms.TextBox()
        Me.ReverseRandomWordBTN = New System.Windows.Forms.Button()
        Me.ReverseRandomWordTB = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ExampleSentenceTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExampleSentenceWorldList_RTB = New System.Windows.Forms.RichTextBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DefineWordTAB.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.DefineWordTAB)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(715, 647)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.ExampleSentenceWorldList_RTB)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DefineBTN)
        Me.TabPage1.Controls.Add(Me.DefinitionTB)
        Me.TabPage1.Controls.Add(Me.WordBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 621)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Word List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ExampleSentenceTB)
        Me.GroupBox1.Controls.Add(Me.AddWordLastStatusL)
        Me.GroupBox1.Controls.Add(Me.AddNewWordBTN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NewWordDefTB)
        Me.GroupBox1.Controls.Add(Me.NewWordTB)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 465)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 137)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Word"
        '
        'AddWordLastStatusL
        '
        Me.AddWordLastStatusL.AutoSize = True
        Me.AddWordLastStatusL.Location = New System.Drawing.Point(13, 56)
        Me.AddWordLastStatusL.Name = "AddWordLastStatusL"
        Me.AddWordLastStatusL.Size = New System.Drawing.Size(0, 13)
        Me.AddWordLastStatusL.TabIndex = 11
        '
        'AddNewWordBTN
        '
        Me.AddNewWordBTN.Location = New System.Drawing.Point(250, 109)
        Me.AddNewWordBTN.Name = "AddNewWordBTN"
        Me.AddNewWordBTN.Size = New System.Drawing.Size(91, 22)
        Me.AddNewWordBTN.TabIndex = 10
        Me.AddNewWordBTN.Text = "Add"
        Me.AddNewWordBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "---->"
        '
        'NewWordDefTB
        '
        Me.NewWordDefTB.Location = New System.Drawing.Point(313, 23)
        Me.NewWordDefTB.Name = "NewWordDefTB"
        Me.NewWordDefTB.Size = New System.Drawing.Size(281, 20)
        Me.NewWordDefTB.TabIndex = 8
        '
        'NewWordTB
        '
        Me.NewWordTB.Location = New System.Drawing.Point(14, 23)
        Me.NewWordTB.Name = "NewWordTB"
        Me.NewWordTB.Size = New System.Drawing.Size(262, 20)
        Me.NewWordTB.TabIndex = 7
        '
        'DefineBTN
        '
        Me.DefineBTN.Location = New System.Drawing.Point(185, 374)
        Me.DefineBTN.Name = "DefineBTN"
        Me.DefineBTN.Size = New System.Drawing.Size(34, 25)
        Me.DefineBTN.TabIndex = 12
        Me.DefineBTN.Text = "--->"
        Me.DefineBTN.UseVisualStyleBackColor = True
        '
        'DefinitionTB
        '
        Me.DefinitionTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DefinitionTB.Location = New System.Drawing.Point(240, 377)
        Me.DefinitionTB.Name = "DefinitionTB"
        Me.DefinitionTB.ReadOnly = True
        Me.DefinitionTB.Size = New System.Drawing.Size(263, 20)
        Me.DefinitionTB.TabIndex = 11
        '
        'WordBox
        '
        Me.WordBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordBox.FormattingEnabled = True
        Me.WordBox.ItemHeight = 20
        Me.WordBox.Location = New System.Drawing.Point(185, 34)
        Me.WordBox.Name = "WordBox"
        Me.WordBox.Size = New System.Drawing.Size(318, 324)
        Me.WordBox.TabIndex = 10
        '
        'DefineWordTAB
        '
        Me.DefineWordTAB.Controls.Add(Me.GroupBox2)
        Me.DefineWordTAB.Controls.Add(Me.DefineRandomTB)
        Me.DefineWordTAB.Controls.Add(Me.DefineRandomBTN)
        Me.DefineWordTAB.Controls.Add(Me.RandomWordTB)
        Me.DefineWordTAB.Controls.Add(Me.RandomWordBTN)
        Me.DefineWordTAB.Location = New System.Drawing.Point(4, 22)
        Me.DefineWordTAB.Name = "DefineWordTAB"
        Me.DefineWordTAB.Padding = New System.Windows.Forms.Padding(3)
        Me.DefineWordTAB.Size = New System.Drawing.Size(707, 583)
        Me.DefineWordTAB.TabIndex = 1
        Me.DefineWordTAB.Text = "Definition Mode"
        Me.DefineWordTAB.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExampleSentenceRTB)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 82)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Example Sentence"
        '
        'ExampleSentenceRTB
        '
        Me.ExampleSentenceRTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExampleSentenceRTB.Location = New System.Drawing.Point(9, 19)
        Me.ExampleSentenceRTB.Name = "ExampleSentenceRTB"
        Me.ExampleSentenceRTB.Size = New System.Drawing.Size(534, 49)
        Me.ExampleSentenceRTB.TabIndex = 0
        Me.ExampleSentenceRTB.Text = ""
        '
        'DefineRandomTB
        '
        Me.DefineRandomTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DefineRandomTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefineRandomTB.Location = New System.Drawing.Point(63, 300)
        Me.DefineRandomTB.Name = "DefineRandomTB"
        Me.DefineRandomTB.ReadOnly = True
        Me.DefineRandomTB.Size = New System.Drawing.Size(557, 24)
        Me.DefineRandomTB.TabIndex = 20
        Me.DefineRandomTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DefineRandomBTN
        '
        Me.DefineRandomBTN.Location = New System.Drawing.Point(277, 227)
        Me.DefineRandomBTN.Name = "DefineRandomBTN"
        Me.DefineRandomBTN.Size = New System.Drawing.Size(106, 24)
        Me.DefineRandomBTN.TabIndex = 19
        Me.DefineRandomBTN.Text = "Define"
        Me.DefineRandomBTN.UseVisualStyleBackColor = True
        '
        'RandomWordTB
        '
        Me.RandomWordTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RandomWordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomWordTB.Location = New System.Drawing.Point(217, 132)
        Me.RandomWordTB.Name = "RandomWordTB"
        Me.RandomWordTB.ReadOnly = True
        Me.RandomWordTB.Size = New System.Drawing.Size(242, 44)
        Me.RandomWordTB.TabIndex = 18
        Me.RandomWordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomWordBTN
        '
        Me.RandomWordBTN.Location = New System.Drawing.Point(265, 72)
        Me.RandomWordBTN.Name = "RandomWordBTN"
        Me.RandomWordBTN.Size = New System.Drawing.Size(143, 28)
        Me.RandomWordBTN.TabIndex = 17
        Me.RandomWordBTN.Text = "Random Word"
        Me.RandomWordBTN.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.ReverseBTN)
        Me.TabPage3.Controls.Add(Me.ReverseWordTB)
        Me.TabPage3.Controls.Add(Me.ReverseRandomWordBTN)
        Me.TabPage3.Controls.Add(Me.ReverseRandomWordTB)
        Me.TabPage3.Controls.Add(Me.TextBox13)
        Me.TabPage3.Controls.Add(Me.TextBox14)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(707, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reverse Define"
        '
        'ReverseBTN
        '
        Me.ReverseBTN.Location = New System.Drawing.Point(297, 219)
        Me.ReverseBTN.Name = "ReverseBTN"
        Me.ReverseBTN.Size = New System.Drawing.Size(90, 26)
        Me.ReverseBTN.TabIndex = 27
        Me.ReverseBTN.Text = "Reverse"
        Me.ReverseBTN.UseVisualStyleBackColor = True
        '
        'ReverseWordTB
        '
        Me.ReverseWordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReverseWordTB.Location = New System.Drawing.Point(227, 286)
        Me.ReverseWordTB.Name = "ReverseWordTB"
        Me.ReverseWordTB.Size = New System.Drawing.Size(227, 31)
        Me.ReverseWordTB.TabIndex = 26
        Me.ReverseWordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReverseRandomWordBTN
        '
        Me.ReverseRandomWordBTN.Location = New System.Drawing.Point(274, 69)
        Me.ReverseRandomWordBTN.Name = "ReverseRandomWordBTN"
        Me.ReverseRandomWordBTN.Size = New System.Drawing.Size(140, 26)
        Me.ReverseRandomWordBTN.TabIndex = 25
        Me.ReverseRandomWordBTN.Text = "Random Word"
        Me.ReverseRandomWordBTN.UseVisualStyleBackColor = True
        '
        'ReverseRandomWordTB
        '
        Me.ReverseRandomWordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReverseRandomWordTB.Location = New System.Drawing.Point(91, 125)
        Me.ReverseRandomWordTB.Name = "ReverseRandomWordTB"
        Me.ReverseRandomWordTB.Size = New System.Drawing.Size(523, 26)
        Me.ReverseRandomWordTB.TabIndex = 24
        Me.ReverseRandomWordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(162, 678)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(0, 20)
        Me.TextBox13.TabIndex = 23
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(201, 653)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(0, 20)
        Me.TextBox14.TabIndex = 22
        '
        'ExampleSentenceTB
        '
        Me.ExampleSentenceTB.Location = New System.Drawing.Point(16, 79)
        Me.ExampleSentenceTB.Name = "ExampleSentenceTB"
        Me.ExampleSentenceTB.Size = New System.Drawing.Size(578, 20)
        Me.ExampleSentenceTB.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Example:"
        '
        'ExampleSentenceWorldList_RTB
        '
        Me.ExampleSentenceWorldList_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExampleSentenceWorldList_RTB.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExampleSentenceWorldList_RTB.Location = New System.Drawing.Point(185, 411)
        Me.ExampleSentenceWorldList_RTB.Name = "ExampleSentenceWorldList_RTB"
        Me.ExampleSentenceWorldList_RTB.Size = New System.Drawing.Size(318, 38)
        Me.ExampleSentenceWorldList_RTB.TabIndex = 18
        Me.ExampleSentenceWorldList_RTB.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 671)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "RN PAX"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DefineWordTAB.ResumeLayout(False)
        Me.DefineWordTAB.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddWordLastStatusL As System.Windows.Forms.Label
    Friend WithEvents AddNewWordBTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewWordDefTB As System.Windows.Forms.TextBox
    Friend WithEvents NewWordTB As System.Windows.Forms.TextBox
    Friend WithEvents DefineBTN As System.Windows.Forms.Button
    Friend WithEvents DefinitionTB As System.Windows.Forms.TextBox
    Friend WithEvents WordBox As System.Windows.Forms.ListBox
    Friend WithEvents DefineWordTAB As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DefineRandomTB As System.Windows.Forms.TextBox
    Friend WithEvents DefineRandomBTN As System.Windows.Forms.Button
    Friend WithEvents RandomWordTB As System.Windows.Forms.TextBox
    Friend WithEvents RandomWordBTN As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExampleSentenceRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents ReverseBTN As System.Windows.Forms.Button
    Friend WithEvents ReverseWordTB As System.Windows.Forms.TextBox
    Friend WithEvents ReverseRandomWordBTN As System.Windows.Forms.Button
    Friend WithEvents ReverseRandomWordTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExampleSentenceTB As System.Windows.Forms.TextBox
    Friend WithEvents ExampleSentenceWorldList_RTB As System.Windows.Forms.RichTextBox

End Class
