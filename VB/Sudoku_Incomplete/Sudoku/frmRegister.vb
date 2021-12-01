Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class frmRegister

    Private objDataReader As OleDbDataReader
    Private objCommand As OleDbCommand
    Private objDS As New DataSet
    Dim mstrSQL As String
    Dim mstrCN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Puzzles.accdb; Persist Security Info=False;"

    Private Sub btnOpenFrmRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenFrmRegister.Click

        ' Declare Variables
        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim strEmail As String = txtEmail.Text

        Dim objLRInfo As New clsUserLoginRegisterInfo
        objLRInfo.UserName = strUsername
        objLRInfo.Password = strPassword
        objLRInfo.FirstName = strFirstName
        objLRInfo.LastName = strLastName
        objLRInfo.Email = strEmail

        objLRInfo.CreateNewUser()

    End Sub

    Private Sub frmRegister_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class