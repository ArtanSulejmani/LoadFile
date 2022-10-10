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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.OFDReader = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOutput.Location = New System.Drawing.Point(274, 21)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(317, 244)
        Me.txtOutput.TabIndex = 0
        '
        'cmdLoad
        '
        Me.cmdLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdLoad.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.cmdLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(359, 289)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(148, 23)
        Me.cmdLoad.TabIndex = 1
        Me.cmdLoad.Text = "Load File"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'OFDReader
        '
        Me.OFDReader.AddExtension = False
        Me.OFDReader.FileName = "*.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.txtOutput)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents OFDReader As OpenFileDialog
End Class
