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
        Me.label_question = New System.Windows.Forms.Label()
        Me.label_description = New System.Windows.Forms.Label()
        Me.RadioButton_Option_A = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option_B = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option_C = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option_D = New System.Windows.Forms.RadioButton()
        Me.RespostaCorreta = New System.Windows.Forms.Label()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.Button_Resume = New System.Windows.Forms.Button()
        Me.Button_loadFile = New System.Windows.Forms.Button()
        Me.RadioButton_Option_E = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'label_question
        '
        Me.label_question.AutoSize = True
        Me.label_question.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_question.Location = New System.Drawing.Point(53, 9)
        Me.label_question.Name = "label_question"
        Me.label_question.Size = New System.Drawing.Size(0, 20)
        Me.label_question.TabIndex = 0
        '
        'label_description
        '
        Me.label_description.AutoSize = True
        Me.label_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_description.Location = New System.Drawing.Point(53, 39)
        Me.label_description.Name = "label_description"
        Me.label_description.Size = New System.Drawing.Size(0, 20)
        Me.label_description.TabIndex = 3
        '
        'RadioButton_Option_A
        '
        Me.RadioButton_Option_A.AutoSize = True
        Me.RadioButton_Option_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option_A.Location = New System.Drawing.Point(56, 144)
        Me.RadioButton_Option_A.Name = "RadioButton_Option_A"
        Me.RadioButton_Option_A.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton_Option_A.TabIndex = 4
        Me.RadioButton_Option_A.UseVisualStyleBackColor = True
        '
        'RadioButton_Option_B
        '
        Me.RadioButton_Option_B.AutoSize = True
        Me.RadioButton_Option_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option_B.Location = New System.Drawing.Point(56, 248)
        Me.RadioButton_Option_B.Name = "RadioButton_Option_B"
        Me.RadioButton_Option_B.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton_Option_B.TabIndex = 5
        Me.RadioButton_Option_B.UseVisualStyleBackColor = True
        '
        'RadioButton_Option_C
        '
        Me.RadioButton_Option_C.AutoSize = True
        Me.RadioButton_Option_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option_C.Location = New System.Drawing.Point(56, 342)
        Me.RadioButton_Option_C.Name = "RadioButton_Option_C"
        Me.RadioButton_Option_C.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton_Option_C.TabIndex = 6
        Me.RadioButton_Option_C.UseVisualStyleBackColor = True
        '
        'RadioButton_Option_D
        '
        Me.RadioButton_Option_D.AutoSize = True
        Me.RadioButton_Option_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option_D.Location = New System.Drawing.Point(56, 450)
        Me.RadioButton_Option_D.Name = "RadioButton_Option_D"
        Me.RadioButton_Option_D.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton_Option_D.TabIndex = 7
        Me.RadioButton_Option_D.UseVisualStyleBackColor = True
        '
        'RespostaCorreta
        '
        Me.RespostaCorreta.AutoSize = True
        Me.RespostaCorreta.Location = New System.Drawing.Point(53, 664)
        Me.RespostaCorreta.Name = "RespostaCorreta"
        Me.RespostaCorreta.Size = New System.Drawing.Size(51, 17)
        Me.RespostaCorreta.TabIndex = 8
        Me.RespostaCorreta.Text = "Label1"
        '
        'Button_Previous
        '
        Me.Button_Previous.Location = New System.Drawing.Point(56, 702)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(153, 62)
        Me.Button_Previous.TabIndex = 9
        Me.Button_Previous.Text = "PREVIOUS"
        Me.Button_Previous.UseVisualStyleBackColor = True
        '
        'Button_next
        '
        Me.Button_next.Location = New System.Drawing.Point(232, 702)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(153, 62)
        Me.Button_next.TabIndex = 10
        Me.Button_next.Text = "NEXT"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'Button_Resume
        '
        Me.Button_Resume.Location = New System.Drawing.Point(406, 702)
        Me.Button_Resume.Name = "Button_Resume"
        Me.Button_Resume.Size = New System.Drawing.Size(153, 62)
        Me.Button_Resume.TabIndex = 11
        Me.Button_Resume.Text = "RESUME"
        Me.Button_Resume.UseVisualStyleBackColor = True
        '
        'Button_loadFile
        '
        Me.Button_loadFile.Location = New System.Drawing.Point(887, 702)
        Me.Button_loadFile.Name = "Button_loadFile"
        Me.Button_loadFile.Size = New System.Drawing.Size(153, 62)
        Me.Button_loadFile.TabIndex = 12
        Me.Button_loadFile.Text = "LOAD FILE"
        Me.Button_loadFile.UseVisualStyleBackColor = True
        '
        'RadioButton_Option_E
        '
        Me.RadioButton_Option_E.AutoSize = True
        Me.RadioButton_Option_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option_E.Location = New System.Drawing.Point(56, 553)
        Me.RadioButton_Option_E.Name = "RadioButton_Option_E"
        Me.RadioButton_Option_E.Size = New System.Drawing.Size(17, 16)
        Me.RadioButton_Option_E.TabIndex = 13
        Me.RadioButton_Option_E.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 776)
        Me.Controls.Add(Me.RadioButton_Option_E)
        Me.Controls.Add(Me.Button_loadFile)
        Me.Controls.Add(Me.Button_Resume)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.Button_Previous)
        Me.Controls.Add(Me.RespostaCorreta)
        Me.Controls.Add(Me.RadioButton_Option_D)
        Me.Controls.Add(Me.RadioButton_Option_C)
        Me.Controls.Add(Me.RadioButton_Option_B)
        Me.Controls.Add(Me.RadioButton_Option_A)
        Me.Controls.Add(Me.label_description)
        Me.Controls.Add(Me.label_question)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_question As System.Windows.Forms.Label
    Friend WithEvents label_description As System.Windows.Forms.Label
    Friend WithEvents RadioButton_Option_A As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option_B As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option_C As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option_D As System.Windows.Forms.RadioButton
    Friend WithEvents RespostaCorreta As System.Windows.Forms.Label
    Friend WithEvents Button_Previous As System.Windows.Forms.Button
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents Button_Resume As System.Windows.Forms.Button
    Friend WithEvents Button_loadFile As System.Windows.Forms.Button
    Friend WithEvents RadioButton_Option_E As System.Windows.Forms.RadioButton

End Class
