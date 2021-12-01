Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class clsPuzzleData

    Private objDataReader As OleDbDataReader
    Private objCommand As OleDbCommand
    Private objDS As New DataSet
    Dim mstrSQL As String
    Dim mstrCN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Puzzles.accdb; Persist Security Info=False;"

    ' Declare Variables
    Private mintDifficulty As Integer
    Private mintPuzzleID As Integer
    Private mintColRow As Integer
    Private mintCellValue As Integer
    Private mblnVisible As Boolean


    ' Public Properties
    Public Property Difficulty As Integer
        Get
            Return mintDifficulty
        End Get
        Set(intValue As Integer)
            mintDifficulty = intValue
        End Set
    End Property

    Public Property PuzzleID As Integer
        Get
            Return mintPuzzleID
        End Get
        Set(intValue As Integer)
            mintPuzzleID = intValue
        End Set
    End Property

    Public Property ColRow As Integer
        Get
            Return mintColRow
        End Get
        Set(intValue As Integer)
            mintColRow = intValue
        End Set
    End Property

    Public Property CellValue As Integer
        Get
            Return mintCellValue
        End Get
        Set(intValue As Integer)
            mintCellValue = intValue
        End Set
    End Property

    Public Property CellVisible As Boolean
        Get
            Return mblnVisible
        End Get
        Set(blnValue As Boolean)
            mblnVisible = blnValue
        End Set
    End Property

    Public Sub GetPuzzleDataByDifficulty()
        ' Open the database
        Dim objConnection As New OleDbConnection(mstrCN)

        ' Declare Variables

        ' Define SQL
        Dim strSQL As String = "SELECT ColRow, CellValue, Visible From Puzzle, PuzzleCell, Difficulty " & _
            "Where Difficulty.DifficultyID = '" & mintDifficulty & "' " & _
            "And Difficulty.DifficultyID = Puzzle.DifficultyID And Puzzle.PuzzleID = PuzzleCell.PuzzleID AND ColRow = " & mintColRow & ""

        ' Create Command object
        Dim objCmd As New OleDbCommand(strSQL, objConnection)
        objCmd.Connection.Open()

        ' Create Reader object
        Dim objReader As OleDbDataReader

        ' Execute Reader
        objReader = objCmd.ExecuteReader

        ' Use Results
        If objReader.Read Then
            MessageBox.Show(objReader.Item("CellValue").ToString)
            mintCellValue = CInt(objReader.Item("CellValue"))
            If CBool(objReader.Item("Visible")) = True Then
                mblnVisible = True
            Else
                mblnVisible = False
            End If
        End If



            ' Close Database
            objCmd.Dispose()
            objReader.Close()
            objConnection.Close()
            objConnection.Dispose()
    End Sub
End Class
