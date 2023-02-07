<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.picBoxTeach = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstTeach = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBoxTeach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxTeach
        '
        Me.picBoxTeach.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picBoxTeach.Location = New System.Drawing.Point(86, 32)
        Me.picBoxTeach.Name = "picBoxTeach"
        Me.picBoxTeach.Size = New System.Drawing.Size(218, 258)
        Me.picBoxTeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxTeach.TabIndex = 0
        Me.picBoxTeach.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblName.Font = New System.Drawing.Font("Gill Sans MT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(86, 322)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(218, 23)
        Me.lblName.TabIndex = 1
        '
        'lstTeach
        '
        Me.lstTeach.Font = New System.Drawing.Font("Gill Sans MT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTeach.FormattingEnabled = True
        Me.lstTeach.ItemHeight = 25
        Me.lstTeach.Items.AddRange(New Object() {"1# - Larisa Selimovic-Milo", "2# - Seiler Margaret", "3# - Brenda Kukay", "4# - Bee Arens", "5# - Elizabeth Chambers"})
        Me.lstTeach.Location = New System.Drawing.Point(360, 161)
        Me.lstTeach.Name = "lstTeach"
        Me.lstTeach.Size = New System.Drawing.Size(192, 129)
        Me.lstTeach.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Top 5 Teachers:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTeach)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBoxTeach)
        Me.Name = "frmMain"
        Me.Text = "Top 5 Teachers"
        CType(Me.picBoxTeach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxTeach As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lstTeach As ListBox
    Friend WithEvents Label1 As Label
End Class
