<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentStatusForm
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
        Me.Label_A = New System.Windows.Forms.Label()
        Me.Result_A = New System.Windows.Forms.Button()
        Me.Result_B = New System.Windows.Forms.Button()
        Me.Label_B = New System.Windows.Forms.Label()
        Me.Result_C = New System.Windows.Forms.Button()
        Me.Label_C = New System.Windows.Forms.Label()
        Me.Result_D = New System.Windows.Forms.Button()
        Me.Label_D = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_A
        '
        Me.Label_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_A.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_A.Location = New System.Drawing.Point(71, 59)
        Me.Label_A.Name = "Label_A"
        Me.Label_A.Size = New System.Drawing.Size(368, 52)
        Me.Label_A.TabIndex = 0
        Me.Label_A.Text = "Issue resolved,Root cause known"
        Me.Label_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Result_A
        '
        Me.Result_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_A.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Result_A.Location = New System.Drawing.Point(470, 71)
        Me.Result_A.Name = "Result_A"
        Me.Result_A.Size = New System.Drawing.Size(134, 31)
        Me.Result_A.TabIndex = 1
        Me.Result_A.Text = "View Result"
        Me.Result_A.UseVisualStyleBackColor = True
        '
        'Result_B
        '
        Me.Result_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_B.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Result_B.Location = New System.Drawing.Point(470, 140)
        Me.Result_B.Name = "Result_B"
        Me.Result_B.Size = New System.Drawing.Size(134, 31)
        Me.Result_B.TabIndex = 3
        Me.Result_B.Text = "View Result"
        Me.Result_B.UseVisualStyleBackColor = True
        '
        'Label_B
        '
        Me.Label_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_B.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_B.Location = New System.Drawing.Point(71, 128)
        Me.Label_B.Name = "Label_B"
        Me.Label_B.Size = New System.Drawing.Size(368, 52)
        Me.Label_B.TabIndex = 2
        Me.Label_B.Text = "Issue Resolved, Root Cause Unknown"
        Me.Label_B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Result_C
        '
        Me.Result_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_C.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Result_C.Location = New System.Drawing.Point(470, 214)
        Me.Result_C.Name = "Result_C"
        Me.Result_C.Size = New System.Drawing.Size(134, 31)
        Me.Result_C.TabIndex = 5
        Me.Result_C.Text = "View Result"
        Me.Result_C.UseVisualStyleBackColor = True
        '
        'Label_C
        '
        Me.Label_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_C.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_C.Location = New System.Drawing.Point(71, 202)
        Me.Label_C.Name = "Label_C"
        Me.Label_C.Size = New System.Drawing.Size(368, 52)
        Me.Label_C.TabIndex = 4
        Me.Label_C.Text = "User confirmed, Issue resolved. No Action taken by SD"
        Me.Label_C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Result_D
        '
        Me.Result_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_D.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Result_D.Location = New System.Drawing.Point(470, 284)
        Me.Result_D.Name = "Result_D"
        Me.Result_D.Size = New System.Drawing.Size(134, 31)
        Me.Result_D.TabIndex = 7
        Me.Result_D.Text = "View Result"
        Me.Result_D.UseVisualStyleBackColor = True
        '
        'Label_D
        '
        Me.Label_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_D.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_D.Location = New System.Drawing.Point(71, 272)
        Me.Label_D.Name = "Label_D"
        Me.Label_D.Size = New System.Drawing.Size(368, 52)
        Me.Label_D.TabIndex = 6
        Me.Label_D.Text = "Rule of 3 followed"
        Me.Label_D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IncidentStatusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Result_D)
        Me.Controls.Add(Me.Label_D)
        Me.Controls.Add(Me.Result_C)
        Me.Controls.Add(Me.Label_C)
        Me.Controls.Add(Me.Result_B)
        Me.Controls.Add(Me.Label_B)
        Me.Controls.Add(Me.Result_A)
        Me.Controls.Add(Me.Label_A)
        Me.Name = "IncidentStatusForm"
        Me.Text = "IncidentStatus"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_A As Label
    Friend WithEvents Result_A As Button
    Friend WithEvents Result_B As Button
    Friend WithEvents Label_B As Label
    Friend WithEvents Result_C As Button
    Friend WithEvents Label_C As Label
    Friend WithEvents Result_D As Button
    Friend WithEvents Label_D As Label
End Class
