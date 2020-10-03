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
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPromptBox = New System.Windows.Forms.Label()
        Me.txtNameBox = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGreeting.Location = New System.Drawing.Point(68, 317)
        Me.btnShowGreeting.MaximumSize = New System.Drawing.Size(180, 70)
        Me.btnShowGreeting.MinimumSize = New System.Drawing.Size(180, 70)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(180, 70)
        Me.btnShowGreeting.TabIndex = 0
        Me.btnShowGreeting.Text = "Show Greeting"
        Me.btnShowGreeting.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(518, 317)
        Me.btnExit.MaximumSize = New System.Drawing.Size(180, 70)
        Me.btnExit.MinimumSize = New System.Drawing.Size(180, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 70)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPromptBox
        '
        Me.lblPromptBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptBox.Location = New System.Drawing.Point(237, 90)
        Me.lblPromptBox.Name = "lblPromptBox"
        Me.lblPromptBox.Padding = New System.Windows.Forms.Padding(10)
        Me.lblPromptBox.Size = New System.Drawing.Size(300, 53)
        Me.lblPromptBox.TabIndex = 2
        Me.lblPromptBox.Text = "Enter Your Name"
        Me.lblPromptBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameBox
        '
        Me.txtNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameBox.Location = New System.Drawing.Point(234, 146)
        Me.txtNameBox.Name = "txtNameBox"
        Me.txtNameBox.Size = New System.Drawing.Size(303, 23)
        Me.txtNameBox.TabIndex = 3
        Me.txtNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreeting.Location = New System.Drawing.Point(237, 211)
        Me.lblGreeting.MaximumSize = New System.Drawing.Size(300, 39)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Padding = New System.Windows.Forms.Padding(10)
        Me.lblGreeting.Size = New System.Drawing.Size(300, 39)
        Me.lblGreeting.TabIndex = 4
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(293, 317)
        Me.btnClear.MaximumSize = New System.Drawing.Size(180, 70)
        Me.btnClear.MinimumSize = New System.Drawing.Size(180, 70)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(180, 70)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.txtNameBox)
        Me.Controls.Add(Me.lblPromptBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowGreeting)
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "Form1"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowGreeting As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPromptBox As Label
    Friend WithEvents txtNameBox As TextBox
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnClear As Button
End Class
