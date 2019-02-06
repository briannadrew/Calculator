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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Input_1 = New System.Windows.Forms.TextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Addition = New System.Windows.Forms.Button()
        Me.Subtraction = New System.Windows.Forms.Button()
        Me.Multipication = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.Equals_Button = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Clear_List = New System.Windows.Forms.Button()
        Me.Input_2 = New System.Windows.Forms.TextBox()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.Equal_Sign = New System.Windows.Forms.Label()
        Me.Operator_Symbol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input_1
        '
        Me.Input_1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Input_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_1.Location = New System.Drawing.Point(466, 72)
        Me.Input_1.Multiline = True
        Me.Input_1.Name = "Input_1"
        Me.Input_1.Size = New System.Drawing.Size(186, 141)
        Me.Input_1.TabIndex = 0
        '
        'ListBox
        '
        Me.ListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 58
        Me.ListBox.Location = New System.Drawing.Point(42, 72)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(398, 526)
        Me.ListBox.TabIndex = 1
        '
        'Addition
        '
        Me.Addition.BackColor = System.Drawing.Color.Orange
        Me.Addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addition.Location = New System.Drawing.Point(466, 239)
        Me.Addition.Name = "Addition"
        Me.Addition.Size = New System.Drawing.Size(421, 117)
        Me.Addition.TabIndex = 2
        Me.Addition.Text = "&+"
        Me.Addition.UseVisualStyleBackColor = False
        '
        'Subtraction
        '
        Me.Subtraction.BackColor = System.Drawing.Color.Orange
        Me.Subtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtraction.Location = New System.Drawing.Point(895, 239)
        Me.Subtraction.Name = "Subtraction"
        Me.Subtraction.Size = New System.Drawing.Size(421, 117)
        Me.Subtraction.TabIndex = 3
        Me.Subtraction.Text = "&-"
        Me.Subtraction.UseVisualStyleBackColor = False
        '
        'Multipication
        '
        Me.Multipication.BackColor = System.Drawing.Color.Orange
        Me.Multipication.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multipication.Location = New System.Drawing.Point(466, 362)
        Me.Multipication.Name = "Multipication"
        Me.Multipication.Size = New System.Drawing.Size(421, 117)
        Me.Multipication.TabIndex = 4
        Me.Multipication.Text = "&x"
        Me.Multipication.UseVisualStyleBackColor = False
        '
        'Division
        '
        Me.Division.BackColor = System.Drawing.Color.Orange
        Me.Division.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division.Location = New System.Drawing.Point(895, 362)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(421, 117)
        Me.Division.TabIndex = 5
        Me.Division.Text = "&/"
        Me.Division.UseVisualStyleBackColor = False
        '
        'Equals_Button
        '
        Me.Equals_Button.BackColor = System.Drawing.Color.Orange
        Me.Equals_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equals_Button.Location = New System.Drawing.Point(466, 485)
        Me.Equals_Button.Name = "Equals_Button"
        Me.Equals_Button.Size = New System.Drawing.Size(421, 117)
        Me.Equals_Button.TabIndex = 6
        Me.Equals_Button.Text = "&="
        Me.Equals_Button.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Orange
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(895, 485)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(421, 117)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "&CLEAR"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.AutoSize = True
        Me.Exit_Button.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(466, 627)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(850, 87)
        Me.Exit_Button.TabIndex = 8
        Me.Exit_Button.Text = "&QUIT"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Clear_List
        '
        Me.Clear_List.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Clear_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_List.Location = New System.Drawing.Point(42, 627)
        Me.Clear_List.Name = "Clear_List"
        Me.Clear_List.Size = New System.Drawing.Size(398, 87)
        Me.Clear_List.TabIndex = 9
        Me.Clear_List.Text = "&RESET"
        Me.Clear_List.UseVisualStyleBackColor = False
        '
        'Input_2
        '
        Me.Input_2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Input_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 49.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_2.Location = New System.Drawing.Point(752, 72)
        Me.Input_2.Multiline = True
        Me.Input_2.Name = "Input_2"
        Me.Input_2.Size = New System.Drawing.Size(186, 141)
        Me.Input_2.TabIndex = 10
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 49.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(1036, 72)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(279, 141)
        Me.Output.TabIndex = 11
        '
        'Equal_Sign
        '
        Me.Equal_Sign.AutoSize = True
        Me.Equal_Sign.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equal_Sign.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Equal_Sign.Location = New System.Drawing.Point(944, 97)
        Me.Equal_Sign.Name = "Equal_Sign"
        Me.Equal_Sign.Size = New System.Drawing.Size(89, 95)
        Me.Equal_Sign.TabIndex = 12
        Me.Equal_Sign.Text = "="
        '
        'Operator_Symbol
        '
        Me.Operator_Symbol.AutoSize = True
        Me.Operator_Symbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 49.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operator_Symbol.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Operator_Symbol.Location = New System.Drawing.Point(658, 97)
        Me.Operator_Symbol.Name = "Operator_Symbol"
        Me.Operator_Symbol.Size = New System.Drawing.Size(0, 95)
        Me.Operator_Symbol.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(508, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "First Operand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(783, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Second Operand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(1152, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Result"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(173, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Calculation History"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1357, 764)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Operator_Symbol)
        Me.Controls.Add(Me.Equal_Sign)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input_2)
        Me.Controls.Add(Me.Clear_List)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Equals_Button)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Multipication)
        Me.Controls.Add(Me.Subtraction)
        Me.Controls.Add(Me.Addition)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.Input_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input_1 As TextBox
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Addition As Button
    Friend WithEvents Subtraction As Button
    Friend WithEvents Multipication As Button
    Friend WithEvents Division As Button
    Friend WithEvents Equals_Button As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Clear_List As Button
    Friend WithEvents Input_2 As TextBox
    Friend WithEvents Output As TextBox
    Friend WithEvents Equal_Sign As Label
    Friend WithEvents Operator_Symbol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
