Option Strict On
Option Explicit On

Imports System.Data.OleDb
Public Class frmLogin
    Private objDataReader As OleDbDataReader
    Private objCommand As OleDbCommand
    Private objDS As New DataSet
    Dim mstrSQL As String
    Dim mstrCN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Puzzles.accdb; Persist Security Info=False;"

    Private Sub LoginSignUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objUserLRInfo As New clsUserLoginRegisterInfo
        objUserLRInfo.GetUsernameAndPassword()

    End Sub

    Private Sub btnOpenFrmRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenFrmRegister.Click
        ' Register Button is currently Disabled
        ' Instantiate New Form
        Dim objRegister As New frmRegister

        'Open 2nd Form, hide 1st form, then show the 1st form when the 2nd form closes
        Me.Hide()
        objRegister.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        ' Declare Variables
        Dim strUsername As String = Me.txtUsername.Text
        Dim strPassword As String = Me.txtPassword.Text

        Dim objLRInfo As New clsUserLoginRegisterInfo
        objLRInfo.UserName = strUsername
        objLRInfo.Password = strPassword

        objLRInfo.GetUsernameAndPassword()

        ' Validate Login
        If objLRInfo.blnUserName = True Then
            If objLRInfo.blnPassword = True Then
                frmPuzzleOptions.Show()
                Me.Close()
            Else
                MessageBox.Show("Error: The Password or Username you entered is incorrect")
            End If
        Else
            MessageBox.Show("Error: The Password or Username you entered is incorrect")
        End If
    End Sub
End Class