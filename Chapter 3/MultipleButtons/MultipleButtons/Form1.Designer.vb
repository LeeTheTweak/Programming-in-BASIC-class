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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnJapanese = New System.Windows.Forms.Button()
        Me.btnChinese = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.lblTranslate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(207, 88)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(353, 27)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Click a language and I'll Good Morning."
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnJapanese
        '
        Me.btnJapanese.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJapanese.Location = New System.Drawing.Point(51, 298)
        Me.btnJapanese.Name = "btnJapanese"
        Me.btnJapanese.Size = New System.Drawing.Size(200, 50)
        Me.btnJapanese.TabIndex = 1
        Me.btnJapanese.Text = "Japanese"
        Me.btnJapanese.UseVisualStyleBackColor = True
        '
        'btnChinese
        '
        Me.btnChinese.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChinese.Location = New System.Drawing.Point(297, 298)
        Me.btnChinese.Name = "btnChinese"
        Me.btnChinese.Size = New System.Drawing.Size(200, 50)
        Me.btnChinese.TabIndex = 2
        Me.btnChinese.Text = "Chinese"
        Me.btnChinese.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpanish.Location = New System.Drawing.Point(543, 298)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(200, 50)
        Me.btnSpanish.TabIndex = 3
        Me.btnSpanish.Text = "Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'lblTranslation
        '
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Location = New System.Drawing.Point(392, 164)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(0, 17)
        Me.lblTranslation.TabIndex = 4
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTranslate
        '
        Me.lblTranslate.AutoSize = True
        Me.lblTranslate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslate.Location = New System.Drawing.Point(386, 161)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(0, 20)
        Me.lblTranslate.TabIndex = 5
        Me.lblTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnChinese)
        Me.Controls.Add(Me.btnJapanese)
        Me.Controls.Add(Me.lblGreeting)
        Me.Name = "Form1"
        Me.Text = "Language Translater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnJapanese As Button
    Friend WithEvents btnChinese As Button
    Friend WithEvents btnSpanish As Button
    Friend WithEvents lblTranslation As Label
    Friend WithEvents lblTranslate As Label
End Class
