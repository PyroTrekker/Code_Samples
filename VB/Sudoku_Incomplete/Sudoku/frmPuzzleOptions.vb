Public Class frmPuzzleOptions

    ' Declare Variables
    Dim mintDifficulty As Integer

    Private Sub btnShowScores_Click(sender As System.Object, e As System.EventArgs) Handles btnShowScores.Click
        ' Scores Function is currently disabled
    End Sub

    Private Sub btnPlaySelected_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaySelected.Click
        ' Play Selected is currently disabled

    End Sub

    Private Sub btnNewPuzzle_Click(sender As System.Object, e As System.EventArgs) Handles btnNewPuzzle.Click

        ' Get selected difficulty
        If rdoEasy.Checked = True Then
            mintDifficulty = 1
        ElseIf rdoMedium.Checked = True Then
            mintDifficulty = 2
        ElseIf rdoHard.Checked = True Then
            mintDifficulty = 3
        ElseIf rdoVeryHard.Checked = True Then
            mintDifficulty = 4
        ElseIf rdoEasy.Checked = True Then
            mintDifficulty = 5
        End If

        ' Open Game
        Dim objSudoku As New frmSudoku
        objSudoku.Difficulty = mintDifficulty
        frmSudoku.Show()
        Me.Close()
    End Sub

    Private Sub frmPuzzleOptions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class