<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
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
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblOwed = New System.Windows.Forms.Label
        Me.lblPaid = New System.Windows.Forms.Label
        Me.lblChange = New System.Windows.Forms.Label
        Me.lblDollars = New System.Windows.Forms.Label
        Me.lblQuarters = New System.Windows.Forms.Label
        Me.lblDimes = New System.Windows.Forms.Label
        Me.lblNickles = New System.Windows.Forms.Label
        Me.lblPennies = New System.Windows.Forms.Label
        Me.lblChangeAmt = New System.Windows.Forms.Label
        Me.txtOwed = New System.Windows.Forms.TextBox
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.lblAmtDollar = New System.Windows.Forms.Label
        Me.lblAmtQuarter = New System.Windows.Forms.Label
        Me.lblAmtDime = New System.Windows.Forms.Label
        Me.lblAmtNickle = New System.Windows.Forms.Label
        Me.lblAmtPenny = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(177, 13)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(105, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate Change"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 42)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clea&r Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 71)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOwed
        '
        Me.lblOwed.AutoSize = True
        Me.lblOwed.Location = New System.Drawing.Point(9, 18)
        Me.lblOwed.Name = "lblOwed"
        Me.lblOwed.Size = New System.Drawing.Size(75, 13)
        Me.lblOwed.TabIndex = 0
        Me.lblOwed.Text = "Amount &owed:"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(9, 47)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(69, 13)
        Me.lblPaid.TabIndex = 2
        Me.lblPaid.Text = "Amount &paid:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(9, 78)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(68, 13)
        Me.lblChange.TabIndex = 5
        Me.lblChange.Text = "Change due:"
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(16, 117)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(42, 13)
        Me.lblDollars.TabIndex = 6
        Me.lblDollars.Text = "Dollars:"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(67, 117)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 7
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(128, 117)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 8
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickles
        '
        Me.lblNickles.AutoSize = True
        Me.lblNickles.Location = New System.Drawing.Point(180, 117)
        Me.lblNickles.Name = "lblNickles"
        Me.lblNickles.Size = New System.Drawing.Size(45, 13)
        Me.lblNickles.TabIndex = 9
        Me.lblNickles.Text = "Nickles:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(233, 117)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 10
        Me.lblPennies.Text = "Pennies:"
        '
        'lblChangeAmt
        '
        Me.lblChangeAmt.BackColor = System.Drawing.SystemColors.Control
        Me.lblChangeAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChangeAmt.Location = New System.Drawing.Point(94, 73)
        Me.lblChangeAmt.Name = "lblChangeAmt"
        Me.lblChangeAmt.Size = New System.Drawing.Size(72, 23)
        Me.lblChangeAmt.TabIndex = 16
        Me.lblChangeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOwed
        '
        Me.txtOwed.AcceptsTab = True
        Me.txtOwed.Location = New System.Drawing.Point(94, 15)
        Me.txtOwed.Name = "txtOwed"
        Me.txtOwed.Size = New System.Drawing.Size(72, 20)
        Me.txtOwed.TabIndex = 1
        '
        'txtPaid
        '
        Me.txtPaid.AcceptsTab = True
        Me.txtPaid.Location = New System.Drawing.Point(94, 44)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(72, 20)
        Me.txtPaid.TabIndex = 3
        '
        'lblAmtDollar
        '
        Me.lblAmtDollar.BackColor = System.Drawing.SystemColors.Control
        Me.lblAmtDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtDollar.Location = New System.Drawing.Point(12, 138)
        Me.lblAmtDollar.Name = "lblAmtDollar"
        Me.lblAmtDollar.Size = New System.Drawing.Size(50, 28)
        Me.lblAmtDollar.TabIndex = 19
        Me.lblAmtDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmtQuarter
        '
        Me.lblAmtQuarter.BackColor = System.Drawing.SystemColors.Control
        Me.lblAmtQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtQuarter.Location = New System.Drawing.Point(67, 138)
        Me.lblAmtQuarter.Name = "lblAmtQuarter"
        Me.lblAmtQuarter.Size = New System.Drawing.Size(50, 28)
        Me.lblAmtQuarter.TabIndex = 20
        Me.lblAmtQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmtDime
        '
        Me.lblAmtDime.BackColor = System.Drawing.SystemColors.Control
        Me.lblAmtDime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtDime.Location = New System.Drawing.Point(122, 138)
        Me.lblAmtDime.Name = "lblAmtDime"
        Me.lblAmtDime.Size = New System.Drawing.Size(50, 28)
        Me.lblAmtDime.TabIndex = 21
        Me.lblAmtDime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmtNickle
        '
        Me.lblAmtNickle.BackColor = System.Drawing.SystemColors.Control
        Me.lblAmtNickle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtNickle.Location = New System.Drawing.Point(177, 138)
        Me.lblAmtNickle.Name = "lblAmtNickle"
        Me.lblAmtNickle.Size = New System.Drawing.Size(50, 28)
        Me.lblAmtNickle.TabIndex = 22
        Me.lblAmtNickle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmtPenny
        '
        Me.lblAmtPenny.BackColor = System.Drawing.SystemColors.Control
        Me.lblAmtPenny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmtPenny.Location = New System.Drawing.Point(232, 138)
        Me.lblAmtPenny.Name = "lblAmtPenny"
        Me.lblAmtPenny.Size = New System.Drawing.Size(50, 28)
        Me.lblAmtPenny.TabIndex = 23
        Me.lblAmtPenny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChange
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 178)
        Me.Controls.Add(Me.lblAmtPenny)
        Me.Controls.Add(Me.lblAmtNickle)
        Me.Controls.Add(Me.lblAmtDime)
        Me.Controls.Add(Me.lblAmtQuarter)
        Me.Controls.Add(Me.lblAmtDollar)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.txtOwed)
        Me.Controls.Add(Me.lblChangeAmt)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickles)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblOwed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblOwed As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblDollars As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickles As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblChangeAmt As System.Windows.Forms.Label
    Friend WithEvents txtOwed As System.Windows.Forms.TextBox
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblAmtDollar As System.Windows.Forms.Label
    Friend WithEvents lblAmtQuarter As System.Windows.Forms.Label
    Friend WithEvents lblAmtDime As System.Windows.Forms.Label
    Friend WithEvents lblAmtNickle As System.Windows.Forms.Label
    Friend WithEvents lblAmtPenny As System.Windows.Forms.Label

End Class
