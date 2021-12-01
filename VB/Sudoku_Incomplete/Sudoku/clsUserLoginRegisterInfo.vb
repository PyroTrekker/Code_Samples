Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class clsUserLoginRegisterInfo

    Private objDataReader As OleDbDataReader
    Private objCommand As OleDbCommand
    Private objDS As New DataSet
    Dim mstrSQL As String
    Dim mstrCN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Puzzles.accdb; Persist Security Info=False;"

    ' Declare Variables
    Private mstrUsername As String
    Private mstrPassword As String
    Private mstrFirstName As String
    Private mstrLastName As String
    Private mstrEmail As String
    Private mblnUsername As Boolean
    Private mblnPassword As Boolean

    ' Public Properties
    Public Property UserName As String
        Get
            Return mstrUsername
        End Get
        Set(strValue As String)
            mstrUsername = strValue
        End Set
    End Property

    Public Property Password As String
        Get
            Return mstrPassword
        End Get
        Set(strValue As String)
            mstrPassword = strValue
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return mstrFirstName
        End Get
        Set(strValue As String)
            mstrFirstName = strValue
        End Set
    End Property

    Public Property LastName As String
        Get
            Return mstrLastName
        End Get
        Set(strValue As String)
            mstrLastname = strValue
        End Set
    End Property

    Public Property Email As String
        Get
            Return mstrEmail
        End Get
        Set(strValue As String)
            mstrEmail = strValue
        End Set
    End Property
    Public Property blnUserName As Boolean
        Get
            Return mblnUsername
        End Get
        Set(blnValue As Boolean)
            mblnUsername = blnValue
        End Set
    End Property
    Public Property blnPassword As Boolean
        Get
            Return mblnPassword
        End Get
        Set(blnValue As Boolean)
            mblnPassword = blnValue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrUsername = String.Empty
        mstrPassword = String.Empty
        mstrFirstName = String.Empty
        mstrLastName = String.Empty
        mstrEmail = String.Empty
    End Sub

    Public Sub GetUsernameAndPassword()
        ' Open the database
        Dim objConnection As New OleDbConnection(mstrCN)

        ' Declare Variables
        Dim strUserName As String
        Dim strPassword As String

        ' Define SQL
        Dim strSQL As String = "SELECT UserName, Password FROM SudokuUser Where UserName = '" & mstrUsername & "' And Password = '" & mstrPassword & "'"

        ' Create Command object
        Dim objCmd As New OleDbCommand(strSQL, objConnection)
        objCmd.Connection.Open()

        ' Create Reader object
        Dim objReader As OleDbDataReader

        ' Execute Reader
        objReader = objCmd.ExecuteReader

        ' Use results
        If objReader.Read Then
            strUserName = objReader.Item("UserName").ToString
            strPassword = objReader.Item("Password").ToString

            If strUserName = mstrUsername Then
                mblnUsername = True
                If strPassword = mstrPassword Then
                    mblnPassword = True
                Else
                    mblnPassword = False
                End If
            Else
                mblnUsername = False
            End If
        End If

        ' Close Database
        objCmd.Dispose()
        objReader.Close()
        objConnection.Close()
        objConnection.Dispose()
    End Sub

    
    Public Sub CreateNewUser()
        ' Open the database
        Dim objConnection As New OleDbConnection(mstrCN)

        ' Define SQL
        Dim strSQL As String = "Insert  Into  SudokuUser (UserName, Password, FirstName, LastName, Email) Values ('" & mstrUsername & "','" & mstrPassword & _
                               "','" & mstrFirstName & "','" & mstrLastName & "','" & mstrEmail & "')"

        ' Create Command object
        Dim objCmd As New OleDbCommand(strSQL, objConnection)
        objCmd.Connection.Open()

        'Execute SQL
        objCmd.ExecuteNonQuery()

        'Close Objects
        objCmd.Dispose()
        objConnection.Close()
        objConnection.Dispose()



    End Sub

End Class
