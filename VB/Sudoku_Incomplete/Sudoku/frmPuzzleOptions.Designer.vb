<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuzzleOptions
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
        Me.rdoEasy = New System.Windows.Forms.RadioButton()
        Me.gpbDifficulty = New System.Windows.Forms.GroupBox()
        Me.rdoExtreme = New System.Windows.Forms.RadioButton()
        Me.rdoVeryHard = New System.Windows.Forms.RadioButton()
        Me.rdoHard = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.gbpShowScores = New System.Windows.Forms.GroupBox()
        Me.btnShowScores = New System.Windows.Forms.Button()
        Me.rdoShowByDate = New System.Windows.Forms.RadioButton()
        Me.rdoShowAll = New System.Windows.Forms.RadioButton()
        Me.rdoShowByDifficulty = New System.Windows.Forms.RadioButton()
        Me.cboDate = New System.Windows.Forms.ComboBox()
        Me.btnNewPuzzle = New System.Windows.Forms.Button()
        Me.btnPlaySelected = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPuzzlesOnDay = New System.Windows.Forms.Label()
        Me.cboPuzzlesOnDate = New System.Windows.Forms.ComboBox()
        Me.gpbDifficulty.SuspendLayout()
        Me.gbpShowScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoEasy
        '
        Me.rdoEasy.AutoSize = True
        Me.rdoEasy.Location = New System.Drawing.Point(6, 19)
        Me.rdoEasy.Name = "rdoEasy"
        Me.rdoEasy.Size = New System.Drawing.Size(48, 17)
        Me.rdoEasy.TabIndex = 0
        Me.rdoEasy.TabStop = True
        Me.rdoEasy.Text = "Easy"
        Me.rdoEasy.UseVisualStyleBackColor = True
        '
        'gpbDifficulty
        '
        Me.gpbDifficulty.Controls.Add(Me.rdoExtreme)
        Me.gpbDifficulty.Controls.Add(Me.rdoVeryHard)
        Me.gpbDifficulty.Controls.Add(Me.rdoHard)
        Me.gpbDifficulty.Controls.Add(Me.rdoMedium)
        Me.gpbDifficulty.Controls.Add(Me.rdoEasy)
        Me.gpbDifficulty.Location = New System.Drawing.Point(1, 12)
        Me.gpbDifficulty.Name = "gpbDifficulty"
        Me.gpbDifficulty.Size = New System.Drawing.Size(86, 138)
        Me.gpbDifficulty.TabIndex = 1
        Me.gpbDifficulty.TabStop = False
        Me.gpbDifficulty.Text = "Difficulty"
        '
        'rdoExtreme
        '
        Me.rdoExtreme.AutoSize = True
        Me.rdoExtreme.Location = New System.Drawing.Point(6, 111)
        Me.rdoExtreme.Name = "rdoExtreme"
        Me.rdoExtreme.Size = New System.Drawing.Size(63, 17)
        Me.rdoExtreme.TabIndex = 4
        Me.rdoExtreme.TabStop = True
        Me.rdoExtreme.Text = "Extreme"
        Me.rdoExtreme.UseVisualStyleBackColor = True
        '
        'rdoVeryHard
        '
        Me.rdoVeryHard.AutoSize = True
        Me.rdoVeryHard.Location = New System.Drawing.Point(6, 88)
        Me.rdoVeryHard.Name = "rdoVeryHard"
        Me.rdoVeryHard.Size = New System.Drawing.Size(72, 17)
        Me.rdoVeryHard.TabIndex = 3
        Me.rdoVeryHard.TabStop = True
        Me.rdoVeryHard.Text = "Very Hard"
        Me.rdoVeryHard.UseVisualStyleBackColor = True
        '
        'rdoHard
        '
        Me.rdoHard.AutoSize = True
        Me.rdoHard.Location = New System.Drawing.Point(6, 65)
        Me.rdoHard.Name = "rdoHard"
        Me.rdoHard.Size = New System.Drawing.Size(48, 17)
        Me.rdoHard.TabIndex = 2
        Me.rdoHard.TabStop = True
        Me.rdoHard.Text = "Hard"
        Me.rdoHard.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Location = New System.Drawing.Point(6, 42)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(62, 17)
        Me.rdoMedium.TabIndex = 1
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'gbpShowScores
        '
        Me.gbpShowScores.Controls.Add(Me.btnShowScores)
        Me.gbpShowScores.Controls.Add(Me.rdoShowByDate)
        Me.gbpShowScores.Controls.Add(Me.rdoShowAll)
        Me.gbpShowScores.Controls.Add(Me.rdoShowByDifficulty)
        Me.gbpShowScores.Enabled = False
        Me.gbpShowScores.Location = New System.Drawing.Point(7, 156)
        Me.gbpShowScores.Name = "gbpShowScores"
        Me.gbpShowScores.Size = New System.Drawing.Size(273, 131)
        Me.gbpShowScores.TabIndex = 2
        Me.gbpShowScores.TabStop = False
        Me.gbpShowScores.Text = "Show Scores"
        Me.gbpShowScores.Visible = False
        '
        'btnShowScores
        '
        Me.btnShowScores.Location = New System.Drawing.Point(158, 99)
        Me.btnShowScores.Name = "btnShowScores"
        Me.btnShowScores.Size = New System.Drawing.Size(109, 23)
        Me.btnShowScores.TabIndex = 4
        Me.btnShowScores.Text = "Show My Scores"
        Me.btnShowScores.UseVisualStyleBackColor = True
        '
        'rdoShowByDate
        '
        Me.rdoShowByDate.AutoSize = True
        Me.rdoShowByDate.Location = New System.Drawing.Point(6, 65)
        Me.rdoShowByDate.Name = "rdoShowByDate"
        Me.rdoShowByDate.Size = New System.Drawing.Size(128, 17)
        Me.rdoShowByDate.TabIndex = 2
        Me.rdoShowByDate.TabStop = True
        Me.rdoShowByDate.Text = "Show Scores by Date"
        Me.rdoShowByDate.UseVisualStyleBackColor = True
        '
        'rdoShowAll
        '
        Me.rdoShowAll.AutoSize = True
        Me.rdoShowAll.Location = New System.Drawing.Point(6, 19)
        Me.rdoShowAll.Name = "rdoShowAll"
        Me.rdoShowAll.Size = New System.Drawing.Size(102, 17)
        Me.rdoShowAll.TabIndex = 1
        Me.rdoShowAll.TabStop = True
        Me.rdoShowAll.Text = "Show All Scores"
        Me.rdoShowAll.UseVisualStyleBackColor = True
        '
        'rdoShowByDifficulty
        '
        Me.rdoShowByDifficulty.AutoSize = True
        Me.rdoShowByDifficulty.Location = New System.Drawing.Point(6, 42)
        Me.rdoShowByDifficulty.Name = "rdoShowByDifficulty"
        Me.rdoShowByDifficulty.Size = New System.Drawing.Size(145, 17)
        Me.rdoShowByDifficulty.TabIndex = 0
        Me.rdoShowByDifficulty.TabStop = True
        Me.rdoShowByDifficulty.Text = "Show Scores by Difficulty"
        Me.rdoShowByDifficulty.UseVisualStyleBackColor = True
        '
        'cboDate
        '
        Me.cboDate.Enabled = False
        Me.cboDate.FormattingEnabled = True
        Me.cboDate.Location = New System.Drawing.Point(193, 30)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(68, 21)
        Me.cboDate.TabIndex = 3
        Me.cboDate.Visible = False
        '
        'btnNewPuzzle
        '
        Me.btnNewPuzzle.Location = New System.Drawing.Point(93, 127)
        Me.btnNewPuzzle.Name = "btnNewPuzzle"
        Me.btnNewPuzzle.Size = New System.Drawing.Size(81, 23)
        Me.btnNewPuzzle.TabIndex = 5
        Me.btnNewPuzzle.Text = "New Puzzle"
        Me.btnNewPuzzle.UseVisualStyleBackColor = True
        '
        'btnPlaySelected
        '
        Me.btnPlaySelected.Enabled = False
        Me.btnPlaySelected.Location = New System.Drawing.Point(193, 127)
        Me.btnPlaySelected.Name = "btnPlaySelected"
        Me.btnPlaySelected.Size = New System.Drawing.Size(81, 23)
        Me.btnPlaySelected.TabIndex = 6
        Me.btnPlaySelected.Text = "Play Selected"
        Me.btnPlaySelected.UseVisualStyleBackColor = True
        Me.btnPlaySelected.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Enabled = False
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(120, 31)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'lblPuzzlesOnDay
        '
        Me.lblPuzzlesOnDay.AutoSize = True
        Me.lblPuzzlesOnDay.Enabled = False
        Me.lblPuzzlesOnDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuzzlesOnDay.Location = New System.Drawing.Point(120, 65)
        Me.lblPuzzlesOnDay.Name = "lblPuzzlesOnDay"
        Me.lblPuzzlesOnDay.Size = New System.Drawing.Size(57, 17)
        Me.lblPuzzlesOnDay.TabIndex = 8
        Me.lblPuzzlesOnDay.Text = "Puzzles"
        Me.lblPuzzlesOnDay.Visible = False
        '
        'cboPuzzlesOnDate
        '
        Me.cboPuzzlesOnDate.Enabled = False
        Me.cboPuzzlesOnDate.FormattingEnabled = True
        Me.cboPuzzlesOnDate.Location = New System.Drawing.Point(193, 64)
        Me.cboPuzzlesOnDate.Name = "cboPuzzlesOnDate"
        Me.cboPuzzlesOnDate.Size = New System.Drawing.Size(68, 21)
        Me.cboPuzzlesOnDate.TabIndex = 9
        Me.cboPuzzlesOnDate.Visible = False
        '
        'frmPuzzleOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 290)
        Me.Controls.Add(Me.cboPuzzlesOnDate)
        Me.Controls.Add(Me.lblPuzzlesOnDay)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnPlaySelected)
        Me.Controls.Add(Me.cboDate)
        Me.Controls.Add(Me.btnNewPuzzle)
        Me.Controls.Add(Me.gbpShowScores)
        Me.Controls.Add(Me.gpbDifficulty)
        Me.Name = "frmPuzzleOptions"
        Me.Text = "Puzzle Options"
        Me.gpbDifficulty.ResumeLayout(False)
        Me.gpbDifficulty.PerformLayout()
        Me.gbpShowScores.ResumeLayout(False)
        Me.gbpShowScores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoEasy As System.Windows.Forms.RadioButton
    Friend WithEvents gpbDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents rdoExtreme As System.Windows.Forms.RadioButton
    Friend WithEvents rdoVeryHard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMedium As System.Windows.Forms.RadioButton
    Friend WithEvents gbpShowScores As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowScores As System.Windows.Forms.Button
    Friend WithEvents cboDate As System.Windows.Forms.ComboBox
    Friend WithEvents rdoShowByDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdoShowAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoShowByDifficulty As System.Windows.Forms.RadioButton
    Friend WithEvents btnNewPuzzle As System.Windows.Forms.Button
    Friend WithEvents btnPlaySelected As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblPuzzlesOnDay As System.Windows.Forms.Label
    Friend WithEvents cboPuzzlesOnDate As System.Windows.Forms.ComboBox
End Class
