Public Class frmSudoku

    Private mintDifficulty As Integer

    ' Declare variables
    Dim mintCellValue As Integer
    Dim mintColRow As Integer
    Dim mblnVisible As Boolean

    Public Property Difficulty As Integer
        Get
            Return mintDifficulty
        End Get
        Set(value As Integer)
            mintDifficulty = value
        End Set
    End Property

    Private Sub frmSudoku_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim objPuzzleData As New clsPuzzleData

        ' Send difficulty to clsPuzzleData
        objPuzzleData.Difficulty = mintDifficulty

        ' Populate fields
        objPuzzleData.GetPuzzleDataByDifficulty()
        GetRow1A()

    End Sub
    Private Sub GetRow1A()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1A.Text)
        objPuzzleData.ColRow = mintColRow
        mintCellValue = objPuzzleData.CellValue
        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = False Then
            txt1A.Enabled = True

        Else
            txt1A.Text = mintCellValue.ToString
        End If
    End Sub

    Private Sub GetRow1B()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1B.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1B.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1B.Enabled = False
        End If
    End Sub

    Private Sub GetRow1C()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1C.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1C.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1C.Enabled = False
        End If
    End Sub

    Private Sub GetRow1D()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1D.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1D.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1D.Enabled = False
        End If
    End Sub

    Private Sub GetRow1E()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1E.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1E.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1E.Enabled = False
        End If
    End Sub

    Private Sub GetRow1F()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1F.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1F.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1F.Enabled = False
        End If
    End Sub

    Private Sub GetRow1G()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1G.Text)
        objPuzzleData.ColRow = mintColRow
        mintCellValue = objPuzzleData.CellValue
        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = False Then
            txt1G.Enabled = True

        Else
            txt1G.Text = mintCellValue.ToString
        End If
    End Sub

    Private Sub GetRow1H()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1H.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1H.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1H.Enabled = False
        End If
    End Sub

    Private Sub GetRow1I()
        Dim objPuzzleData As New clsPuzzleData

        mintColRow = CInt(lbl1I.Text)

        objPuzzleData.ColRow = mintColRow

        mintCellValue = objPuzzleData.CellValue

        txt1I.Text = mintCellValue.ToString

        mblnVisible = objPuzzleData.CellVisible

        If mblnVisible = True Then
            txt1I.Enabled = False
        End If
    End Sub


    Private Sub BtnSolve_Click(sender As System.Object, e As System.EventArgs) Handles BtnSolve.Click

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnStart.Visible = False
        ' btnHint.Enabled = True
        BtnSolve.Enabled = True
        BtnSolve.Visible = True

        ' Time function is currently unavailable
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        BtnSolve.Enabled = False
        btnHint.Enabled = False
        btnQuit.Enabled = False
        btnQuit.Visible = False
        btnExit.Visible = True
        btnExit.Enabled = True
    End Sub



    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHint_Click(sender As System.Object, e As System.EventArgs) Handles btnHint.Click
        ' Hint is currently unavailable
    End Sub

 
End Class
