<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblUnitsDaily = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtEnteredUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverageOutput = New System.Windows.Forms.Label()
        Me.ttpAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(112, 21)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(64, 20)
        Me.txtUnitsInput.TabIndex = 1
        Me.ttpAverageUnitsShipped.SetToolTip(Me.txtUnitsInput, "Enter the  daily number of units shipped in this field.")
        '
        'lblUnitsDaily
        '
        Me.lblUnitsDaily.AutoSize = True
        Me.lblUnitsDaily.Location = New System.Drawing.Point(58, 25)
        Me.lblUnitsDaily.Name = "lblUnitsDaily"
        Me.lblUnitsDaily.Size = New System.Drawing.Size(37, 13)
        Me.lblUnitsDaily.TabIndex = 0
        Me.lblUnitsDaily.Text = "&Units: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(191, 25)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(35, 13)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "&Day 1"
        '
        'txtEnteredUnits
        '
        Me.txtEnteredUnits.AcceptsReturn = True
        Me.txtEnteredUnits.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEnteredUnits.Location = New System.Drawing.Point(61, 49)
        Me.txtEnteredUnits.Multiline = True
        Me.txtEnteredUnits.Name = "txtEnteredUnits"
        Me.txtEnteredUnits.ReadOnly = True
        Me.txtEnteredUnits.Size = New System.Drawing.Size(183, 168)
        Me.txtEnteredUnits.TabIndex = 7
        Me.ttpAverageUnitsShipped.SetToolTip(Me.txtEnteredUnits, "This field displays all daily units shipped values entered so far for this week.")
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEnter.Location = New System.Drawing.Point(30, 268)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnEnter, "Press this button to submit the number of units shipped for a single day.")
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(111, 268)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnReset, "Press this button to clear all values and reset the application to it's initial s" &
        "tate.")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(192, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnExit, "Press this button to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAverageOutput
        '
        Me.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageOutput.Location = New System.Drawing.Point(59, 225)
        Me.lblAverageOutput.Name = "lblAverageOutput"
        Me.lblAverageOutput.Size = New System.Drawing.Size(185, 36)
        Me.lblAverageOutput.TabIndex = 4
        Me.lblAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShipped.SetToolTip(Me.lblAverageOutput, "Once 7 values are entered above, this field will output the average number of uni" &
        "ts shipped per day.")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(308, 343)
        Me.Controls.Add(Me.lblAverageOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEnteredUnits)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnitsDaily)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblUnitsDaily As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents txtEnteredUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverageOutput As Label
    Friend WithEvents ttpAverageUnitsShipped As ToolTip
End Class
