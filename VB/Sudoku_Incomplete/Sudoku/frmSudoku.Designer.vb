<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSudoku
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
        Me.BtnSolve = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt1A = New System.Windows.Forms.TextBox()
        Me.txt1B = New System.Windows.Forms.TextBox()
        Me.txt1C = New System.Windows.Forms.TextBox()
        Me.txt1D = New System.Windows.Forms.TextBox()
        Me.txt1E = New System.Windows.Forms.TextBox()
        Me.txt1F = New System.Windows.Forms.TextBox()
        Me.txt1G = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl9I = New System.Windows.Forms.Label()
        Me.lbl9H = New System.Windows.Forms.Label()
        Me.lbl9G = New System.Windows.Forms.Label()
        Me.lbl9F = New System.Windows.Forms.Label()
        Me.lbl9E = New System.Windows.Forms.Label()
        Me.lbl9D = New System.Windows.Forms.Label()
        Me.lbl9C = New System.Windows.Forms.Label()
        Me.lbl8I = New System.Windows.Forms.Label()
        Me.lbl9B = New System.Windows.Forms.Label()
        Me.lbl8H = New System.Windows.Forms.Label()
        Me.lbl8G = New System.Windows.Forms.Label()
        Me.lbl8F = New System.Windows.Forms.Label()
        Me.lbl8E = New System.Windows.Forms.Label()
        Me.lbl8D = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl8C = New System.Windows.Forms.Label()
        Me.lbl7I = New System.Windows.Forms.Label()
        Me.lbl8B = New System.Windows.Forms.Label()
        Me.lbl7H = New System.Windows.Forms.Label()
        Me.lbl7G = New System.Windows.Forms.Label()
        Me.lbl7F = New System.Windows.Forms.Label()
        Me.lbl7E = New System.Windows.Forms.Label()
        Me.lbl7D = New System.Windows.Forms.Label()
        Me.lbl8A = New System.Windows.Forms.Label()
        Me.lbl7C = New System.Windows.Forms.Label()
        Me.lbl4I = New System.Windows.Forms.Label()
        Me.lbl7B = New System.Windows.Forms.Label()
        Me.lbl4H = New System.Windows.Forms.Label()
        Me.lbl4G = New System.Windows.Forms.Label()
        Me.lbl4F = New System.Windows.Forms.Label()
        Me.lbl4E = New System.Windows.Forms.Label()
        Me.lbl4D = New System.Windows.Forms.Label()
        Me.lbl7A = New System.Windows.Forms.Label()
        Me.lbl6I = New System.Windows.Forms.Label()
        Me.lbl4C = New System.Windows.Forms.Label()
        Me.lbl6H = New System.Windows.Forms.Label()
        Me.lbl6G = New System.Windows.Forms.Label()
        Me.lbl6F = New System.Windows.Forms.Label()
        Me.lbl6E = New System.Windows.Forms.Label()
        Me.lbl6D = New System.Windows.Forms.Label()
        Me.lbl4B = New System.Windows.Forms.Label()
        Me.lbl3I = New System.Windows.Forms.Label()
        Me.lbl6C = New System.Windows.Forms.Label()
        Me.lbl3H = New System.Windows.Forms.Label()
        Me.lbl3G = New System.Windows.Forms.Label()
        Me.lbl6B = New System.Windows.Forms.Label()
        Me.lbl3F = New System.Windows.Forms.Label()
        Me.lbl3E = New System.Windows.Forms.Label()
        Me.lbl3D = New System.Windows.Forms.Label()
        Me.lbl4A = New System.Windows.Forms.Label()
        Me.lbl5I = New System.Windows.Forms.Label()
        Me.lbl3C = New System.Windows.Forms.Label()
        Me.lbl5H = New System.Windows.Forms.Label()
        Me.lbl5G = New System.Windows.Forms.Label()
        Me.lbl3B = New System.Windows.Forms.Label()
        Me.lbl5F = New System.Windows.Forms.Label()
        Me.lbl5E = New System.Windows.Forms.Label()
        Me.lbl5D = New System.Windows.Forms.Label()
        Me.lbl6A = New System.Windows.Forms.Label()
        Me.lbl2I = New System.Windows.Forms.Label()
        Me.lbl5C = New System.Windows.Forms.Label()
        Me.lbl2H = New System.Windows.Forms.Label()
        Me.lbl2G = New System.Windows.Forms.Label()
        Me.lbl5B = New System.Windows.Forms.Label()
        Me.lbl2F = New System.Windows.Forms.Label()
        Me.lbl2E = New System.Windows.Forms.Label()
        Me.lbl2D = New System.Windows.Forms.Label()
        Me.lbl3A = New System.Windows.Forms.Label()
        Me.lbl1I = New System.Windows.Forms.Label()
        Me.lbl2C = New System.Windows.Forms.Label()
        Me.lbl1H = New System.Windows.Forms.Label()
        Me.lbl1G = New System.Windows.Forms.Label()
        Me.lbl2B = New System.Windows.Forms.Label()
        Me.lbl1F = New System.Windows.Forms.Label()
        Me.lbl1E = New System.Windows.Forms.Label()
        Me.lbl1D = New System.Windows.Forms.Label()
        Me.lbl5A = New System.Windows.Forms.Label()
        Me.lbl1C = New System.Windows.Forms.Label()
        Me.lbl1B = New System.Windows.Forms.Label()
        Me.lbl2A = New System.Windows.Forms.Label()
        Me.lbl1A = New System.Windows.Forms.Label()
        Me.lblColumnI = New System.Windows.Forms.Label()
        Me.lblColumnH = New System.Windows.Forms.Label()
        Me.lblColumnG = New System.Windows.Forms.Label()
        Me.lblColumnF = New System.Windows.Forms.Label()
        Me.lblColumnE = New System.Windows.Forms.Label()
        Me.txt9A = New System.Windows.Forms.TextBox()
        Me.txt8A = New System.Windows.Forms.TextBox()
        Me.txt7A = New System.Windows.Forms.TextBox()
        Me.txt9I = New System.Windows.Forms.TextBox()
        Me.txt8I = New System.Windows.Forms.TextBox()
        Me.txt7I = New System.Windows.Forms.TextBox()
        Me.txt9H = New System.Windows.Forms.TextBox()
        Me.txt8H = New System.Windows.Forms.TextBox()
        Me.txt7H = New System.Windows.Forms.TextBox()
        Me.txt9G = New System.Windows.Forms.TextBox()
        Me.txt8G = New System.Windows.Forms.TextBox()
        Me.txt7G = New System.Windows.Forms.TextBox()
        Me.txt9B = New System.Windows.Forms.TextBox()
        Me.txt8B = New System.Windows.Forms.TextBox()
        Me.txt7B = New System.Windows.Forms.TextBox()
        Me.txt9F = New System.Windows.Forms.TextBox()
        Me.txt8F = New System.Windows.Forms.TextBox()
        Me.txt7F = New System.Windows.Forms.TextBox()
        Me.txt9C = New System.Windows.Forms.TextBox()
        Me.txt8C = New System.Windows.Forms.TextBox()
        Me.txt9E = New System.Windows.Forms.TextBox()
        Me.txt7C = New System.Windows.Forms.TextBox()
        Me.txt8E = New System.Windows.Forms.TextBox()
        Me.txt9D = New System.Windows.Forms.TextBox()
        Me.txt7E = New System.Windows.Forms.TextBox()
        Me.txt8D = New System.Windows.Forms.TextBox()
        Me.txt7D = New System.Windows.Forms.TextBox()
        Me.txt6A = New System.Windows.Forms.TextBox()
        Me.txt6I = New System.Windows.Forms.TextBox()
        Me.txt6H = New System.Windows.Forms.TextBox()
        Me.txt6G = New System.Windows.Forms.TextBox()
        Me.txt6B = New System.Windows.Forms.TextBox()
        Me.txt6F = New System.Windows.Forms.TextBox()
        Me.txt6C = New System.Windows.Forms.TextBox()
        Me.txt6E = New System.Windows.Forms.TextBox()
        Me.txt6D = New System.Windows.Forms.TextBox()
        Me.lblColumnD = New System.Windows.Forms.Label()
        Me.lblColumnC = New System.Windows.Forms.Label()
        Me.lblColumnB = New System.Windows.Forms.Label()
        Me.lblColumnA = New System.Windows.Forms.Label()
        Me.lblRow1 = New System.Windows.Forms.Label()
        Me.lblRow9 = New System.Windows.Forms.Label()
        Me.lblRow8 = New System.Windows.Forms.Label()
        Me.lblRow7 = New System.Windows.Forms.Label()
        Me.lblRow6 = New System.Windows.Forms.Label()
        Me.lblRow5 = New System.Windows.Forms.Label()
        Me.lblRow4 = New System.Windows.Forms.Label()
        Me.lblRow3 = New System.Windows.Forms.Label()
        Me.lblRow2 = New System.Windows.Forms.Label()
        Me.txt5A = New System.Windows.Forms.TextBox()
        Me.txt5I = New System.Windows.Forms.TextBox()
        Me.txt5H = New System.Windows.Forms.TextBox()
        Me.txt5G = New System.Windows.Forms.TextBox()
        Me.txt5B = New System.Windows.Forms.TextBox()
        Me.txt5F = New System.Windows.Forms.TextBox()
        Me.txt5C = New System.Windows.Forms.TextBox()
        Me.txt5E = New System.Windows.Forms.TextBox()
        Me.txt5D = New System.Windows.Forms.TextBox()
        Me.txt4A = New System.Windows.Forms.TextBox()
        Me.txt4I = New System.Windows.Forms.TextBox()
        Me.txt4H = New System.Windows.Forms.TextBox()
        Me.txt4G = New System.Windows.Forms.TextBox()
        Me.txt4B = New System.Windows.Forms.TextBox()
        Me.txt4F = New System.Windows.Forms.TextBox()
        Me.txt4C = New System.Windows.Forms.TextBox()
        Me.txt4E = New System.Windows.Forms.TextBox()
        Me.txt4D = New System.Windows.Forms.TextBox()
        Me.txt3A = New System.Windows.Forms.TextBox()
        Me.txt2A = New System.Windows.Forms.TextBox()
        Me.txt3I = New System.Windows.Forms.TextBox()
        Me.txt2I = New System.Windows.Forms.TextBox()
        Me.txt1I = New System.Windows.Forms.TextBox()
        Me.txt3H = New System.Windows.Forms.TextBox()
        Me.txt2H = New System.Windows.Forms.TextBox()
        Me.txt1H = New System.Windows.Forms.TextBox()
        Me.txt3G = New System.Windows.Forms.TextBox()
        Me.txt2G = New System.Windows.Forms.TextBox()
        Me.txt3B = New System.Windows.Forms.TextBox()
        Me.txt2B = New System.Windows.Forms.TextBox()
        Me.txt3F = New System.Windows.Forms.TextBox()
        Me.txt2F = New System.Windows.Forms.TextBox()
        Me.txt3C = New System.Windows.Forms.TextBox()
        Me.txt3E = New System.Windows.Forms.TextBox()
        Me.txt2C = New System.Windows.Forms.TextBox()
        Me.txt2E = New System.Windows.Forms.TextBox()
        Me.txt3D = New System.Windows.Forms.TextBox()
        Me.txt2D = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSolve
        '
        Me.BtnSolve.Enabled = False
        Me.BtnSolve.Location = New System.Drawing.Point(46, 418)
        Me.BtnSolve.Name = "BtnSolve"
        Me.BtnSolve.Size = New System.Drawing.Size(75, 23)
        Me.BtnSolve.TabIndex = 0
        Me.BtnSolve.Text = "Solve"
        Me.BtnSolve.UseVisualStyleBackColor = True
        Me.BtnSolve.Visible = False
        '
        'txt1A
        '
        Me.txt1A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1A.Enabled = False
        Me.txt1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1A.Location = New System.Drawing.Point(46, 38)
        Me.txt1A.MaxLength = 1
        Me.txt1A.Name = "txt1A"
        Me.txt1A.Size = New System.Drawing.Size(38, 39)
        Me.txt1A.TabIndex = 1
        Me.txt1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1B
        '
        Me.txt1B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1B.Enabled = False
        Me.txt1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1B.Location = New System.Drawing.Point(84, 38)
        Me.txt1B.MaxLength = 1
        Me.txt1B.Name = "txt1B"
        Me.txt1B.Size = New System.Drawing.Size(39, 39)
        Me.txt1B.TabIndex = 2
        Me.txt1B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1C
        '
        Me.txt1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1C.Enabled = False
        Me.txt1C.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1C.Location = New System.Drawing.Point(123, 38)
        Me.txt1C.MaxLength = 1
        Me.txt1C.Name = "txt1C"
        Me.txt1C.Size = New System.Drawing.Size(39, 39)
        Me.txt1C.TabIndex = 2
        Me.txt1C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1D
        '
        Me.txt1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1D.Enabled = False
        Me.txt1D.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1D.Location = New System.Drawing.Point(164, 38)
        Me.txt1D.MaxLength = 1
        Me.txt1D.Name = "txt1D"
        Me.txt1D.Size = New System.Drawing.Size(39, 39)
        Me.txt1D.TabIndex = 2
        Me.txt1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1E
        '
        Me.txt1E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1E.Enabled = False
        Me.txt1E.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1E.Location = New System.Drawing.Point(203, 38)
        Me.txt1E.MaxLength = 1
        Me.txt1E.Name = "txt1E"
        Me.txt1E.Size = New System.Drawing.Size(39, 39)
        Me.txt1E.TabIndex = 2
        Me.txt1E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1F
        '
        Me.txt1F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1F.Enabled = False
        Me.txt1F.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1F.Location = New System.Drawing.Point(242, 38)
        Me.txt1F.MaxLength = 1
        Me.txt1F.Name = "txt1F"
        Me.txt1F.Size = New System.Drawing.Size(39, 39)
        Me.txt1F.TabIndex = 2
        Me.txt1F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1G
        '
        Me.txt1G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1G.Enabled = False
        Me.txt1G.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1G.Location = New System.Drawing.Point(283, 38)
        Me.txt1G.MaxLength = 1
        Me.txt1G.Name = "txt1G"
        Me.txt1G.Size = New System.Drawing.Size(39, 39)
        Me.txt1G.TabIndex = 2
        Me.txt1G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.lbl9I)
        Me.Panel1.Controls.Add(Me.lbl9H)
        Me.Panel1.Controls.Add(Me.lbl9G)
        Me.Panel1.Controls.Add(Me.lbl9F)
        Me.Panel1.Controls.Add(Me.lbl9E)
        Me.Panel1.Controls.Add(Me.lbl9D)
        Me.Panel1.Controls.Add(Me.lbl9C)
        Me.Panel1.Controls.Add(Me.lbl8I)
        Me.Panel1.Controls.Add(Me.lbl9B)
        Me.Panel1.Controls.Add(Me.lbl8H)
        Me.Panel1.Controls.Add(Me.lbl8G)
        Me.Panel1.Controls.Add(Me.lbl8F)
        Me.Panel1.Controls.Add(Me.lbl8E)
        Me.Panel1.Controls.Add(Me.lbl8D)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl8C)
        Me.Panel1.Controls.Add(Me.lbl7I)
        Me.Panel1.Controls.Add(Me.lbl8B)
        Me.Panel1.Controls.Add(Me.lbl7H)
        Me.Panel1.Controls.Add(Me.lbl7G)
        Me.Panel1.Controls.Add(Me.lbl7F)
        Me.Panel1.Controls.Add(Me.lbl7E)
        Me.Panel1.Controls.Add(Me.lbl7D)
        Me.Panel1.Controls.Add(Me.lbl8A)
        Me.Panel1.Controls.Add(Me.lbl7C)
        Me.Panel1.Controls.Add(Me.lbl4I)
        Me.Panel1.Controls.Add(Me.lbl7B)
        Me.Panel1.Controls.Add(Me.lbl4H)
        Me.Panel1.Controls.Add(Me.lbl4G)
        Me.Panel1.Controls.Add(Me.lbl4F)
        Me.Panel1.Controls.Add(Me.lbl4E)
        Me.Panel1.Controls.Add(Me.lbl4D)
        Me.Panel1.Controls.Add(Me.lbl7A)
        Me.Panel1.Controls.Add(Me.lbl6I)
        Me.Panel1.Controls.Add(Me.lbl4C)
        Me.Panel1.Controls.Add(Me.lbl6H)
        Me.Panel1.Controls.Add(Me.lbl6G)
        Me.Panel1.Controls.Add(Me.lbl6F)
        Me.Panel1.Controls.Add(Me.lbl6E)
        Me.Panel1.Controls.Add(Me.lbl6D)
        Me.Panel1.Controls.Add(Me.lbl4B)
        Me.Panel1.Controls.Add(Me.lbl3I)
        Me.Panel1.Controls.Add(Me.lbl6C)
        Me.Panel1.Controls.Add(Me.lbl3H)
        Me.Panel1.Controls.Add(Me.lbl3G)
        Me.Panel1.Controls.Add(Me.lbl6B)
        Me.Panel1.Controls.Add(Me.lbl3F)
        Me.Panel1.Controls.Add(Me.lbl3E)
        Me.Panel1.Controls.Add(Me.lbl3D)
        Me.Panel1.Controls.Add(Me.lbl4A)
        Me.Panel1.Controls.Add(Me.lbl5I)
        Me.Panel1.Controls.Add(Me.lbl3C)
        Me.Panel1.Controls.Add(Me.lbl5H)
        Me.Panel1.Controls.Add(Me.lbl5G)
        Me.Panel1.Controls.Add(Me.lbl3B)
        Me.Panel1.Controls.Add(Me.lbl5F)
        Me.Panel1.Controls.Add(Me.lbl5E)
        Me.Panel1.Controls.Add(Me.lbl5D)
        Me.Panel1.Controls.Add(Me.lbl6A)
        Me.Panel1.Controls.Add(Me.lbl2I)
        Me.Panel1.Controls.Add(Me.lbl5C)
        Me.Panel1.Controls.Add(Me.lbl2H)
        Me.Panel1.Controls.Add(Me.lbl2G)
        Me.Panel1.Controls.Add(Me.lbl5B)
        Me.Panel1.Controls.Add(Me.lbl2F)
        Me.Panel1.Controls.Add(Me.lbl2E)
        Me.Panel1.Controls.Add(Me.lbl2D)
        Me.Panel1.Controls.Add(Me.lbl3A)
        Me.Panel1.Controls.Add(Me.lbl1I)
        Me.Panel1.Controls.Add(Me.lbl2C)
        Me.Panel1.Controls.Add(Me.lbl1H)
        Me.Panel1.Controls.Add(Me.lbl1G)
        Me.Panel1.Controls.Add(Me.lbl2B)
        Me.Panel1.Controls.Add(Me.lbl1F)
        Me.Panel1.Controls.Add(Me.lbl1E)
        Me.Panel1.Controls.Add(Me.lbl1D)
        Me.Panel1.Controls.Add(Me.lbl5A)
        Me.Panel1.Controls.Add(Me.lbl1C)
        Me.Panel1.Controls.Add(Me.lbl1B)
        Me.Panel1.Controls.Add(Me.lbl2A)
        Me.Panel1.Controls.Add(Me.lbl1A)
        Me.Panel1.Controls.Add(Me.lblColumnI)
        Me.Panel1.Controls.Add(Me.lblColumnH)
        Me.Panel1.Controls.Add(Me.lblColumnG)
        Me.Panel1.Controls.Add(Me.lblColumnF)
        Me.Panel1.Controls.Add(Me.lblColumnE)
        Me.Panel1.Controls.Add(Me.txt9A)
        Me.Panel1.Controls.Add(Me.txt8A)
        Me.Panel1.Controls.Add(Me.txt7A)
        Me.Panel1.Controls.Add(Me.txt9I)
        Me.Panel1.Controls.Add(Me.txt8I)
        Me.Panel1.Controls.Add(Me.txt7I)
        Me.Panel1.Controls.Add(Me.txt9H)
        Me.Panel1.Controls.Add(Me.txt8H)
        Me.Panel1.Controls.Add(Me.txt7H)
        Me.Panel1.Controls.Add(Me.txt9G)
        Me.Panel1.Controls.Add(Me.txt8G)
        Me.Panel1.Controls.Add(Me.txt7G)
        Me.Panel1.Controls.Add(Me.txt9B)
        Me.Panel1.Controls.Add(Me.txt8B)
        Me.Panel1.Controls.Add(Me.txt7B)
        Me.Panel1.Controls.Add(Me.txt9F)
        Me.Panel1.Controls.Add(Me.txt8F)
        Me.Panel1.Controls.Add(Me.txt7F)
        Me.Panel1.Controls.Add(Me.txt9C)
        Me.Panel1.Controls.Add(Me.txt8C)
        Me.Panel1.Controls.Add(Me.txt9E)
        Me.Panel1.Controls.Add(Me.txt7C)
        Me.Panel1.Controls.Add(Me.txt8E)
        Me.Panel1.Controls.Add(Me.txt9D)
        Me.Panel1.Controls.Add(Me.txt7E)
        Me.Panel1.Controls.Add(Me.txt8D)
        Me.Panel1.Controls.Add(Me.txt7D)
        Me.Panel1.Controls.Add(Me.txt6A)
        Me.Panel1.Controls.Add(Me.txt6I)
        Me.Panel1.Controls.Add(Me.txt6H)
        Me.Panel1.Controls.Add(Me.txt6G)
        Me.Panel1.Controls.Add(Me.txt6B)
        Me.Panel1.Controls.Add(Me.txt6F)
        Me.Panel1.Controls.Add(Me.txt6C)
        Me.Panel1.Controls.Add(Me.txt6E)
        Me.Panel1.Controls.Add(Me.txt6D)
        Me.Panel1.Controls.Add(Me.lblColumnD)
        Me.Panel1.Controls.Add(Me.lblColumnC)
        Me.Panel1.Controls.Add(Me.lblColumnB)
        Me.Panel1.Controls.Add(Me.lblColumnA)
        Me.Panel1.Controls.Add(Me.lblRow1)
        Me.Panel1.Controls.Add(Me.lblRow9)
        Me.Panel1.Controls.Add(Me.lblRow8)
        Me.Panel1.Controls.Add(Me.lblRow7)
        Me.Panel1.Controls.Add(Me.lblRow6)
        Me.Panel1.Controls.Add(Me.lblRow5)
        Me.Panel1.Controls.Add(Me.lblRow4)
        Me.Panel1.Controls.Add(Me.lblRow3)
        Me.Panel1.Controls.Add(Me.lblRow2)
        Me.Panel1.Controls.Add(Me.txt5A)
        Me.Panel1.Controls.Add(Me.txt5I)
        Me.Panel1.Controls.Add(Me.txt5H)
        Me.Panel1.Controls.Add(Me.txt5G)
        Me.Panel1.Controls.Add(Me.txt5B)
        Me.Panel1.Controls.Add(Me.txt5F)
        Me.Panel1.Controls.Add(Me.txt5C)
        Me.Panel1.Controls.Add(Me.txt5E)
        Me.Panel1.Controls.Add(Me.txt5D)
        Me.Panel1.Controls.Add(Me.txt4A)
        Me.Panel1.Controls.Add(Me.txt4I)
        Me.Panel1.Controls.Add(Me.txt4H)
        Me.Panel1.Controls.Add(Me.txt4G)
        Me.Panel1.Controls.Add(Me.txt4B)
        Me.Panel1.Controls.Add(Me.txt4F)
        Me.Panel1.Controls.Add(Me.txt4C)
        Me.Panel1.Controls.Add(Me.txt4E)
        Me.Panel1.Controls.Add(Me.txt4D)
        Me.Panel1.Controls.Add(Me.txt3A)
        Me.Panel1.Controls.Add(Me.txt2A)
        Me.Panel1.Controls.Add(Me.txt1A)
        Me.Panel1.Controls.Add(Me.txt3I)
        Me.Panel1.Controls.Add(Me.txt2I)
        Me.Panel1.Controls.Add(Me.txt1I)
        Me.Panel1.Controls.Add(Me.txt3H)
        Me.Panel1.Controls.Add(Me.txt2H)
        Me.Panel1.Controls.Add(Me.txt1H)
        Me.Panel1.Controls.Add(Me.txt3G)
        Me.Panel1.Controls.Add(Me.txt2G)
        Me.Panel1.Controls.Add(Me.txt1G)
        Me.Panel1.Controls.Add(Me.txt3B)
        Me.Panel1.Controls.Add(Me.txt2B)
        Me.Panel1.Controls.Add(Me.txt1B)
        Me.Panel1.Controls.Add(Me.txt3F)
        Me.Panel1.Controls.Add(Me.txt2F)
        Me.Panel1.Controls.Add(Me.txt1F)
        Me.Panel1.Controls.Add(Me.txt3C)
        Me.Panel1.Controls.Add(Me.txt3E)
        Me.Panel1.Controls.Add(Me.txt2C)
        Me.Panel1.Controls.Add(Me.txt2E)
        Me.Panel1.Controls.Add(Me.txt3D)
        Me.Panel1.Controls.Add(Me.txt1C)
        Me.Panel1.Controls.Add(Me.txt2D)
        Me.Panel1.Controls.Add(Me.txt1E)
        Me.Panel1.Controls.Add(Me.txt1D)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 399)
        Me.Panel1.TabIndex = 3
        '
        'lbl9I
        '
        Me.lbl9I.AutoSize = True
        Me.lbl9I.Location = New System.Drawing.Point(373, 370)
        Me.lbl9I.Name = "lbl9I"
        Me.lbl9I.Size = New System.Drawing.Size(19, 13)
        Me.lbl9I.TabIndex = 43
        Me.lbl9I.Text = "99"
        Me.lbl9I.Visible = False
        '
        'lbl9H
        '
        Me.lbl9H.AutoSize = True
        Me.lbl9H.Location = New System.Drawing.Point(331, 370)
        Me.lbl9H.Name = "lbl9H"
        Me.lbl9H.Size = New System.Drawing.Size(19, 13)
        Me.lbl9H.TabIndex = 43
        Me.lbl9H.Text = "89"
        Me.lbl9H.Visible = False
        '
        'lbl9G
        '
        Me.lbl9G.AutoSize = True
        Me.lbl9G.Location = New System.Drawing.Point(292, 370)
        Me.lbl9G.Name = "lbl9G"
        Me.lbl9G.Size = New System.Drawing.Size(19, 13)
        Me.lbl9G.TabIndex = 43
        Me.lbl9G.Text = "79"
        Me.lbl9G.Visible = False
        '
        'lbl9F
        '
        Me.lbl9F.AutoSize = True
        Me.lbl9F.Location = New System.Drawing.Point(251, 370)
        Me.lbl9F.Name = "lbl9F"
        Me.lbl9F.Size = New System.Drawing.Size(19, 13)
        Me.lbl9F.TabIndex = 43
        Me.lbl9F.Text = "69"
        Me.lbl9F.Visible = False
        '
        'lbl9E
        '
        Me.lbl9E.AutoSize = True
        Me.lbl9E.Location = New System.Drawing.Point(212, 370)
        Me.lbl9E.Name = "lbl9E"
        Me.lbl9E.Size = New System.Drawing.Size(19, 13)
        Me.lbl9E.TabIndex = 43
        Me.lbl9E.Text = "59"
        Me.lbl9E.Visible = False
        '
        'lbl9D
        '
        Me.lbl9D.AutoSize = True
        Me.lbl9D.Location = New System.Drawing.Point(173, 370)
        Me.lbl9D.Name = "lbl9D"
        Me.lbl9D.Size = New System.Drawing.Size(19, 13)
        Me.lbl9D.TabIndex = 43
        Me.lbl9D.Text = "49"
        Me.lbl9D.Visible = False
        '
        'lbl9C
        '
        Me.lbl9C.AutoSize = True
        Me.lbl9C.Location = New System.Drawing.Point(132, 370)
        Me.lbl9C.Name = "lbl9C"
        Me.lbl9C.Size = New System.Drawing.Size(19, 13)
        Me.lbl9C.TabIndex = 43
        Me.lbl9C.Text = "39"
        Me.lbl9C.Visible = False
        '
        'lbl8I
        '
        Me.lbl8I.AutoSize = True
        Me.lbl8I.Location = New System.Drawing.Point(373, 331)
        Me.lbl8I.Name = "lbl8I"
        Me.lbl8I.Size = New System.Drawing.Size(19, 13)
        Me.lbl8I.TabIndex = 43
        Me.lbl8I.Text = "98"
        Me.lbl8I.Visible = False
        '
        'lbl9B
        '
        Me.lbl9B.AutoSize = True
        Me.lbl9B.Location = New System.Drawing.Point(93, 370)
        Me.lbl9B.Name = "lbl9B"
        Me.lbl9B.Size = New System.Drawing.Size(19, 13)
        Me.lbl9B.TabIndex = 43
        Me.lbl9B.Text = "29"
        Me.lbl9B.Visible = False
        '
        'lbl8H
        '
        Me.lbl8H.AutoSize = True
        Me.lbl8H.Location = New System.Drawing.Point(331, 331)
        Me.lbl8H.Name = "lbl8H"
        Me.lbl8H.Size = New System.Drawing.Size(19, 13)
        Me.lbl8H.TabIndex = 43
        Me.lbl8H.Text = "88"
        Me.lbl8H.Visible = False
        '
        'lbl8G
        '
        Me.lbl8G.AutoSize = True
        Me.lbl8G.Location = New System.Drawing.Point(292, 331)
        Me.lbl8G.Name = "lbl8G"
        Me.lbl8G.Size = New System.Drawing.Size(19, 13)
        Me.lbl8G.TabIndex = 43
        Me.lbl8G.Text = "78"
        Me.lbl8G.Visible = False
        '
        'lbl8F
        '
        Me.lbl8F.AutoSize = True
        Me.lbl8F.Location = New System.Drawing.Point(251, 331)
        Me.lbl8F.Name = "lbl8F"
        Me.lbl8F.Size = New System.Drawing.Size(19, 13)
        Me.lbl8F.TabIndex = 43
        Me.lbl8F.Text = "68"
        Me.lbl8F.Visible = False
        '
        'lbl8E
        '
        Me.lbl8E.AutoSize = True
        Me.lbl8E.Location = New System.Drawing.Point(212, 331)
        Me.lbl8E.Name = "lbl8E"
        Me.lbl8E.Size = New System.Drawing.Size(19, 13)
        Me.lbl8E.TabIndex = 43
        Me.lbl8E.Text = "58"
        Me.lbl8E.Visible = False
        '
        'lbl8D
        '
        Me.lbl8D.AutoSize = True
        Me.lbl8D.Location = New System.Drawing.Point(173, 331)
        Me.lbl8D.Name = "lbl8D"
        Me.lbl8D.Size = New System.Drawing.Size(19, 13)
        Me.lbl8D.TabIndex = 43
        Me.lbl8D.Text = "48"
        Me.lbl8D.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "19"
        Me.Label8.Visible = False
        '
        'lbl8C
        '
        Me.lbl8C.AutoSize = True
        Me.lbl8C.Location = New System.Drawing.Point(132, 331)
        Me.lbl8C.Name = "lbl8C"
        Me.lbl8C.Size = New System.Drawing.Size(19, 13)
        Me.lbl8C.TabIndex = 43
        Me.lbl8C.Text = "38"
        Me.lbl8C.Visible = False
        '
        'lbl7I
        '
        Me.lbl7I.AutoSize = True
        Me.lbl7I.Location = New System.Drawing.Point(373, 293)
        Me.lbl7I.Name = "lbl7I"
        Me.lbl7I.Size = New System.Drawing.Size(19, 13)
        Me.lbl7I.TabIndex = 42
        Me.lbl7I.Text = "97"
        Me.lbl7I.Visible = False
        '
        'lbl8B
        '
        Me.lbl8B.AutoSize = True
        Me.lbl8B.Location = New System.Drawing.Point(93, 331)
        Me.lbl8B.Name = "lbl8B"
        Me.lbl8B.Size = New System.Drawing.Size(19, 13)
        Me.lbl8B.TabIndex = 43
        Me.lbl8B.Text = "28"
        Me.lbl8B.Visible = False
        '
        'lbl7H
        '
        Me.lbl7H.AutoSize = True
        Me.lbl7H.Location = New System.Drawing.Point(331, 293)
        Me.lbl7H.Name = "lbl7H"
        Me.lbl7H.Size = New System.Drawing.Size(19, 13)
        Me.lbl7H.TabIndex = 42
        Me.lbl7H.Text = "87"
        Me.lbl7H.Visible = False
        '
        'lbl7G
        '
        Me.lbl7G.AutoSize = True
        Me.lbl7G.Location = New System.Drawing.Point(292, 293)
        Me.lbl7G.Name = "lbl7G"
        Me.lbl7G.Size = New System.Drawing.Size(19, 13)
        Me.lbl7G.TabIndex = 42
        Me.lbl7G.Text = "77"
        Me.lbl7G.Visible = False
        '
        'lbl7F
        '
        Me.lbl7F.AutoSize = True
        Me.lbl7F.Location = New System.Drawing.Point(251, 293)
        Me.lbl7F.Name = "lbl7F"
        Me.lbl7F.Size = New System.Drawing.Size(19, 13)
        Me.lbl7F.TabIndex = 42
        Me.lbl7F.Text = "67"
        Me.lbl7F.Visible = False
        '
        'lbl7E
        '
        Me.lbl7E.AutoSize = True
        Me.lbl7E.Location = New System.Drawing.Point(212, 293)
        Me.lbl7E.Name = "lbl7E"
        Me.lbl7E.Size = New System.Drawing.Size(19, 13)
        Me.lbl7E.TabIndex = 42
        Me.lbl7E.Text = "57"
        Me.lbl7E.Visible = False
        '
        'lbl7D
        '
        Me.lbl7D.AutoSize = True
        Me.lbl7D.Location = New System.Drawing.Point(173, 293)
        Me.lbl7D.Name = "lbl7D"
        Me.lbl7D.Size = New System.Drawing.Size(19, 13)
        Me.lbl7D.TabIndex = 42
        Me.lbl7D.Text = "47"
        Me.lbl7D.Visible = False
        '
        'lbl8A
        '
        Me.lbl8A.AutoSize = True
        Me.lbl8A.Location = New System.Drawing.Point(53, 331)
        Me.lbl8A.Name = "lbl8A"
        Me.lbl8A.Size = New System.Drawing.Size(19, 13)
        Me.lbl8A.TabIndex = 43
        Me.lbl8A.Text = "18"
        Me.lbl8A.Visible = False
        '
        'lbl7C
        '
        Me.lbl7C.AutoSize = True
        Me.lbl7C.Location = New System.Drawing.Point(132, 293)
        Me.lbl7C.Name = "lbl7C"
        Me.lbl7C.Size = New System.Drawing.Size(19, 13)
        Me.lbl7C.TabIndex = 42
        Me.lbl7C.Text = "37"
        Me.lbl7C.Visible = False
        '
        'lbl4I
        '
        Me.lbl4I.AutoSize = True
        Me.lbl4I.Location = New System.Drawing.Point(373, 174)
        Me.lbl4I.Name = "lbl4I"
        Me.lbl4I.Size = New System.Drawing.Size(19, 13)
        Me.lbl4I.TabIndex = 43
        Me.lbl4I.Text = "94"
        Me.lbl4I.Visible = False
        '
        'lbl7B
        '
        Me.lbl7B.AutoSize = True
        Me.lbl7B.Location = New System.Drawing.Point(93, 293)
        Me.lbl7B.Name = "lbl7B"
        Me.lbl7B.Size = New System.Drawing.Size(19, 13)
        Me.lbl7B.TabIndex = 42
        Me.lbl7B.Text = "27"
        Me.lbl7B.Visible = False
        '
        'lbl4H
        '
        Me.lbl4H.AutoSize = True
        Me.lbl4H.Location = New System.Drawing.Point(331, 174)
        Me.lbl4H.Name = "lbl4H"
        Me.lbl4H.Size = New System.Drawing.Size(19, 13)
        Me.lbl4H.TabIndex = 43
        Me.lbl4H.Text = "84"
        Me.lbl4H.Visible = False
        '
        'lbl4G
        '
        Me.lbl4G.AutoSize = True
        Me.lbl4G.Location = New System.Drawing.Point(292, 174)
        Me.lbl4G.Name = "lbl4G"
        Me.lbl4G.Size = New System.Drawing.Size(19, 13)
        Me.lbl4G.TabIndex = 43
        Me.lbl4G.Text = "74"
        Me.lbl4G.Visible = False
        '
        'lbl4F
        '
        Me.lbl4F.AutoSize = True
        Me.lbl4F.Location = New System.Drawing.Point(251, 174)
        Me.lbl4F.Name = "lbl4F"
        Me.lbl4F.Size = New System.Drawing.Size(19, 13)
        Me.lbl4F.TabIndex = 43
        Me.lbl4F.Text = "64"
        Me.lbl4F.Visible = False
        '
        'lbl4E
        '
        Me.lbl4E.AutoSize = True
        Me.lbl4E.Location = New System.Drawing.Point(212, 174)
        Me.lbl4E.Name = "lbl4E"
        Me.lbl4E.Size = New System.Drawing.Size(19, 13)
        Me.lbl4E.TabIndex = 43
        Me.lbl4E.Text = "54"
        Me.lbl4E.Visible = False
        '
        'lbl4D
        '
        Me.lbl4D.AutoSize = True
        Me.lbl4D.Location = New System.Drawing.Point(173, 174)
        Me.lbl4D.Name = "lbl4D"
        Me.lbl4D.Size = New System.Drawing.Size(19, 13)
        Me.lbl4D.TabIndex = 43
        Me.lbl4D.Text = "44"
        Me.lbl4D.Visible = False
        '
        'lbl7A
        '
        Me.lbl7A.AutoSize = True
        Me.lbl7A.Location = New System.Drawing.Point(53, 293)
        Me.lbl7A.Name = "lbl7A"
        Me.lbl7A.Size = New System.Drawing.Size(19, 13)
        Me.lbl7A.TabIndex = 42
        Me.lbl7A.Text = "17"
        Me.lbl7A.Visible = False
        '
        'lbl6I
        '
        Me.lbl6I.AutoSize = True
        Me.lbl6I.Location = New System.Drawing.Point(373, 251)
        Me.lbl6I.Name = "lbl6I"
        Me.lbl6I.Size = New System.Drawing.Size(19, 13)
        Me.lbl6I.TabIndex = 43
        Me.lbl6I.Text = "96"
        Me.lbl6I.Visible = False
        '
        'lbl4C
        '
        Me.lbl4C.AutoSize = True
        Me.lbl4C.Location = New System.Drawing.Point(132, 174)
        Me.lbl4C.Name = "lbl4C"
        Me.lbl4C.Size = New System.Drawing.Size(19, 13)
        Me.lbl4C.TabIndex = 43
        Me.lbl4C.Text = "34"
        Me.lbl4C.Visible = False
        '
        'lbl6H
        '
        Me.lbl6H.AutoSize = True
        Me.lbl6H.Location = New System.Drawing.Point(331, 251)
        Me.lbl6H.Name = "lbl6H"
        Me.lbl6H.Size = New System.Drawing.Size(19, 13)
        Me.lbl6H.TabIndex = 43
        Me.lbl6H.Text = "86"
        Me.lbl6H.Visible = False
        '
        'lbl6G
        '
        Me.lbl6G.AutoSize = True
        Me.lbl6G.Location = New System.Drawing.Point(292, 251)
        Me.lbl6G.Name = "lbl6G"
        Me.lbl6G.Size = New System.Drawing.Size(19, 13)
        Me.lbl6G.TabIndex = 43
        Me.lbl6G.Text = "76"
        Me.lbl6G.Visible = False
        '
        'lbl6F
        '
        Me.lbl6F.AutoSize = True
        Me.lbl6F.Location = New System.Drawing.Point(251, 251)
        Me.lbl6F.Name = "lbl6F"
        Me.lbl6F.Size = New System.Drawing.Size(19, 13)
        Me.lbl6F.TabIndex = 43
        Me.lbl6F.Text = "66"
        Me.lbl6F.Visible = False
        '
        'lbl6E
        '
        Me.lbl6E.AutoSize = True
        Me.lbl6E.Location = New System.Drawing.Point(212, 251)
        Me.lbl6E.Name = "lbl6E"
        Me.lbl6E.Size = New System.Drawing.Size(19, 13)
        Me.lbl6E.TabIndex = 43
        Me.lbl6E.Text = "56"
        Me.lbl6E.Visible = False
        '
        'lbl6D
        '
        Me.lbl6D.AutoSize = True
        Me.lbl6D.Location = New System.Drawing.Point(173, 251)
        Me.lbl6D.Name = "lbl6D"
        Me.lbl6D.Size = New System.Drawing.Size(19, 13)
        Me.lbl6D.TabIndex = 43
        Me.lbl6D.Text = "46"
        Me.lbl6D.Visible = False
        '
        'lbl4B
        '
        Me.lbl4B.AutoSize = True
        Me.lbl4B.Location = New System.Drawing.Point(93, 174)
        Me.lbl4B.Name = "lbl4B"
        Me.lbl4B.Size = New System.Drawing.Size(19, 13)
        Me.lbl4B.TabIndex = 43
        Me.lbl4B.Text = "24"
        Me.lbl4B.Visible = False
        '
        'lbl3I
        '
        Me.lbl3I.AutoSize = True
        Me.lbl3I.Location = New System.Drawing.Point(373, 133)
        Me.lbl3I.Name = "lbl3I"
        Me.lbl3I.Size = New System.Drawing.Size(19, 13)
        Me.lbl3I.TabIndex = 42
        Me.lbl3I.Text = "93"
        Me.lbl3I.Visible = False
        '
        'lbl6C
        '
        Me.lbl6C.AutoSize = True
        Me.lbl6C.Location = New System.Drawing.Point(132, 251)
        Me.lbl6C.Name = "lbl6C"
        Me.lbl6C.Size = New System.Drawing.Size(19, 13)
        Me.lbl6C.TabIndex = 43
        Me.lbl6C.Text = "36"
        Me.lbl6C.Visible = False
        '
        'lbl3H
        '
        Me.lbl3H.AutoSize = True
        Me.lbl3H.Location = New System.Drawing.Point(331, 133)
        Me.lbl3H.Name = "lbl3H"
        Me.lbl3H.Size = New System.Drawing.Size(19, 13)
        Me.lbl3H.TabIndex = 42
        Me.lbl3H.Text = "83"
        Me.lbl3H.Visible = False
        '
        'lbl3G
        '
        Me.lbl3G.AutoSize = True
        Me.lbl3G.Location = New System.Drawing.Point(292, 133)
        Me.lbl3G.Name = "lbl3G"
        Me.lbl3G.Size = New System.Drawing.Size(19, 13)
        Me.lbl3G.TabIndex = 42
        Me.lbl3G.Text = "73"
        Me.lbl3G.Visible = False
        '
        'lbl6B
        '
        Me.lbl6B.AutoSize = True
        Me.lbl6B.Location = New System.Drawing.Point(93, 251)
        Me.lbl6B.Name = "lbl6B"
        Me.lbl6B.Size = New System.Drawing.Size(19, 13)
        Me.lbl6B.TabIndex = 43
        Me.lbl6B.Text = "26"
        Me.lbl6B.Visible = False
        '
        'lbl3F
        '
        Me.lbl3F.AutoSize = True
        Me.lbl3F.Location = New System.Drawing.Point(251, 133)
        Me.lbl3F.Name = "lbl3F"
        Me.lbl3F.Size = New System.Drawing.Size(19, 13)
        Me.lbl3F.TabIndex = 42
        Me.lbl3F.Text = "63"
        Me.lbl3F.Visible = False
        '
        'lbl3E
        '
        Me.lbl3E.AutoSize = True
        Me.lbl3E.Location = New System.Drawing.Point(212, 133)
        Me.lbl3E.Name = "lbl3E"
        Me.lbl3E.Size = New System.Drawing.Size(19, 13)
        Me.lbl3E.TabIndex = 42
        Me.lbl3E.Text = "53"
        Me.lbl3E.Visible = False
        '
        'lbl3D
        '
        Me.lbl3D.AutoSize = True
        Me.lbl3D.Location = New System.Drawing.Point(173, 133)
        Me.lbl3D.Name = "lbl3D"
        Me.lbl3D.Size = New System.Drawing.Size(19, 13)
        Me.lbl3D.TabIndex = 42
        Me.lbl3D.Text = "43"
        Me.lbl3D.Visible = False
        '
        'lbl4A
        '
        Me.lbl4A.AutoSize = True
        Me.lbl4A.Location = New System.Drawing.Point(53, 174)
        Me.lbl4A.Name = "lbl4A"
        Me.lbl4A.Size = New System.Drawing.Size(19, 13)
        Me.lbl4A.TabIndex = 43
        Me.lbl4A.Text = "14"
        Me.lbl4A.Visible = False
        '
        'lbl5I
        '
        Me.lbl5I.AutoSize = True
        Me.lbl5I.Location = New System.Drawing.Point(373, 212)
        Me.lbl5I.Name = "lbl5I"
        Me.lbl5I.Size = New System.Drawing.Size(19, 13)
        Me.lbl5I.TabIndex = 42
        Me.lbl5I.Text = "95"
        Me.lbl5I.Visible = False
        '
        'lbl3C
        '
        Me.lbl3C.AutoSize = True
        Me.lbl3C.Location = New System.Drawing.Point(132, 133)
        Me.lbl3C.Name = "lbl3C"
        Me.lbl3C.Size = New System.Drawing.Size(19, 13)
        Me.lbl3C.TabIndex = 42
        Me.lbl3C.Text = "33"
        Me.lbl3C.Visible = False
        '
        'lbl5H
        '
        Me.lbl5H.AutoSize = True
        Me.lbl5H.Location = New System.Drawing.Point(331, 212)
        Me.lbl5H.Name = "lbl5H"
        Me.lbl5H.Size = New System.Drawing.Size(19, 13)
        Me.lbl5H.TabIndex = 42
        Me.lbl5H.Text = "85"
        Me.lbl5H.Visible = False
        '
        'lbl5G
        '
        Me.lbl5G.AutoSize = True
        Me.lbl5G.Location = New System.Drawing.Point(292, 212)
        Me.lbl5G.Name = "lbl5G"
        Me.lbl5G.Size = New System.Drawing.Size(19, 13)
        Me.lbl5G.TabIndex = 42
        Me.lbl5G.Text = "75"
        Me.lbl5G.Visible = False
        '
        'lbl3B
        '
        Me.lbl3B.AutoSize = True
        Me.lbl3B.Location = New System.Drawing.Point(93, 133)
        Me.lbl3B.Name = "lbl3B"
        Me.lbl3B.Size = New System.Drawing.Size(19, 13)
        Me.lbl3B.TabIndex = 42
        Me.lbl3B.Text = "23"
        Me.lbl3B.Visible = False
        '
        'lbl5F
        '
        Me.lbl5F.AutoSize = True
        Me.lbl5F.Location = New System.Drawing.Point(251, 212)
        Me.lbl5F.Name = "lbl5F"
        Me.lbl5F.Size = New System.Drawing.Size(19, 13)
        Me.lbl5F.TabIndex = 42
        Me.lbl5F.Text = "65"
        Me.lbl5F.Visible = False
        '
        'lbl5E
        '
        Me.lbl5E.AutoSize = True
        Me.lbl5E.Location = New System.Drawing.Point(212, 212)
        Me.lbl5E.Name = "lbl5E"
        Me.lbl5E.Size = New System.Drawing.Size(19, 13)
        Me.lbl5E.TabIndex = 42
        Me.lbl5E.Text = "55"
        Me.lbl5E.Visible = False
        '
        'lbl5D
        '
        Me.lbl5D.AutoSize = True
        Me.lbl5D.Location = New System.Drawing.Point(173, 212)
        Me.lbl5D.Name = "lbl5D"
        Me.lbl5D.Size = New System.Drawing.Size(19, 13)
        Me.lbl5D.TabIndex = 42
        Me.lbl5D.Text = "45"
        Me.lbl5D.Visible = False
        '
        'lbl6A
        '
        Me.lbl6A.AutoSize = True
        Me.lbl6A.Location = New System.Drawing.Point(53, 251)
        Me.lbl6A.Name = "lbl6A"
        Me.lbl6A.Size = New System.Drawing.Size(19, 13)
        Me.lbl6A.TabIndex = 43
        Me.lbl6A.Text = "16"
        Me.lbl6A.Visible = False
        '
        'lbl2I
        '
        Me.lbl2I.AutoSize = True
        Me.lbl2I.Location = New System.Drawing.Point(373, 94)
        Me.lbl2I.Name = "lbl2I"
        Me.lbl2I.Size = New System.Drawing.Size(19, 13)
        Me.lbl2I.TabIndex = 43
        Me.lbl2I.Text = "92"
        Me.lbl2I.Visible = False
        '
        'lbl5C
        '
        Me.lbl5C.AutoSize = True
        Me.lbl5C.Location = New System.Drawing.Point(132, 212)
        Me.lbl5C.Name = "lbl5C"
        Me.lbl5C.Size = New System.Drawing.Size(19, 13)
        Me.lbl5C.TabIndex = 42
        Me.lbl5C.Text = "35"
        Me.lbl5C.Visible = False
        '
        'lbl2H
        '
        Me.lbl2H.AutoSize = True
        Me.lbl2H.Location = New System.Drawing.Point(331, 94)
        Me.lbl2H.Name = "lbl2H"
        Me.lbl2H.Size = New System.Drawing.Size(19, 13)
        Me.lbl2H.TabIndex = 43
        Me.lbl2H.Text = "82"
        Me.lbl2H.Visible = False
        '
        'lbl2G
        '
        Me.lbl2G.AutoSize = True
        Me.lbl2G.Location = New System.Drawing.Point(292, 94)
        Me.lbl2G.Name = "lbl2G"
        Me.lbl2G.Size = New System.Drawing.Size(19, 13)
        Me.lbl2G.TabIndex = 43
        Me.lbl2G.Text = "72"
        Me.lbl2G.Visible = False
        '
        'lbl5B
        '
        Me.lbl5B.AutoSize = True
        Me.lbl5B.Location = New System.Drawing.Point(93, 212)
        Me.lbl5B.Name = "lbl5B"
        Me.lbl5B.Size = New System.Drawing.Size(19, 13)
        Me.lbl5B.TabIndex = 42
        Me.lbl5B.Text = "25"
        Me.lbl5B.Visible = False
        '
        'lbl2F
        '
        Me.lbl2F.AutoSize = True
        Me.lbl2F.Location = New System.Drawing.Point(251, 94)
        Me.lbl2F.Name = "lbl2F"
        Me.lbl2F.Size = New System.Drawing.Size(19, 13)
        Me.lbl2F.TabIndex = 43
        Me.lbl2F.Text = "62"
        Me.lbl2F.Visible = False
        '
        'lbl2E
        '
        Me.lbl2E.AutoSize = True
        Me.lbl2E.Location = New System.Drawing.Point(212, 94)
        Me.lbl2E.Name = "lbl2E"
        Me.lbl2E.Size = New System.Drawing.Size(19, 13)
        Me.lbl2E.TabIndex = 43
        Me.lbl2E.Text = "52"
        Me.lbl2E.Visible = False
        '
        'lbl2D
        '
        Me.lbl2D.AutoSize = True
        Me.lbl2D.Location = New System.Drawing.Point(173, 94)
        Me.lbl2D.Name = "lbl2D"
        Me.lbl2D.Size = New System.Drawing.Size(19, 13)
        Me.lbl2D.TabIndex = 43
        Me.lbl2D.Text = "42"
        Me.lbl2D.Visible = False
        '
        'lbl3A
        '
        Me.lbl3A.AutoSize = True
        Me.lbl3A.Location = New System.Drawing.Point(53, 133)
        Me.lbl3A.Name = "lbl3A"
        Me.lbl3A.Size = New System.Drawing.Size(19, 13)
        Me.lbl3A.TabIndex = 42
        Me.lbl3A.Text = "13"
        Me.lbl3A.Visible = False
        '
        'lbl1I
        '
        Me.lbl1I.AutoSize = True
        Me.lbl1I.Location = New System.Drawing.Point(373, 55)
        Me.lbl1I.Name = "lbl1I"
        Me.lbl1I.Size = New System.Drawing.Size(19, 13)
        Me.lbl1I.TabIndex = 42
        Me.lbl1I.Text = "91"
        Me.lbl1I.Visible = False
        '
        'lbl2C
        '
        Me.lbl2C.AutoSize = True
        Me.lbl2C.Location = New System.Drawing.Point(132, 94)
        Me.lbl2C.Name = "lbl2C"
        Me.lbl2C.Size = New System.Drawing.Size(19, 13)
        Me.lbl2C.TabIndex = 43
        Me.lbl2C.Text = "32"
        Me.lbl2C.Visible = False
        '
        'lbl1H
        '
        Me.lbl1H.AutoSize = True
        Me.lbl1H.Location = New System.Drawing.Point(331, 55)
        Me.lbl1H.Name = "lbl1H"
        Me.lbl1H.Size = New System.Drawing.Size(19, 13)
        Me.lbl1H.TabIndex = 42
        Me.lbl1H.Text = "81"
        Me.lbl1H.Visible = False
        '
        'lbl1G
        '
        Me.lbl1G.AutoSize = True
        Me.lbl1G.Location = New System.Drawing.Point(292, 55)
        Me.lbl1G.Name = "lbl1G"
        Me.lbl1G.Size = New System.Drawing.Size(19, 13)
        Me.lbl1G.TabIndex = 42
        Me.lbl1G.Text = "71"
        Me.lbl1G.Visible = False
        '
        'lbl2B
        '
        Me.lbl2B.AutoSize = True
        Me.lbl2B.Location = New System.Drawing.Point(93, 94)
        Me.lbl2B.Name = "lbl2B"
        Me.lbl2B.Size = New System.Drawing.Size(19, 13)
        Me.lbl2B.TabIndex = 43
        Me.lbl2B.Text = "22"
        Me.lbl2B.Visible = False
        '
        'lbl1F
        '
        Me.lbl1F.AutoSize = True
        Me.lbl1F.Location = New System.Drawing.Point(251, 55)
        Me.lbl1F.Name = "lbl1F"
        Me.lbl1F.Size = New System.Drawing.Size(19, 13)
        Me.lbl1F.TabIndex = 42
        Me.lbl1F.Text = "61"
        Me.lbl1F.Visible = False
        '
        'lbl1E
        '
        Me.lbl1E.AutoSize = True
        Me.lbl1E.Location = New System.Drawing.Point(212, 55)
        Me.lbl1E.Name = "lbl1E"
        Me.lbl1E.Size = New System.Drawing.Size(19, 13)
        Me.lbl1E.TabIndex = 42
        Me.lbl1E.Text = "51"
        Me.lbl1E.Visible = False
        '
        'lbl1D
        '
        Me.lbl1D.AutoSize = True
        Me.lbl1D.Location = New System.Drawing.Point(173, 55)
        Me.lbl1D.Name = "lbl1D"
        Me.lbl1D.Size = New System.Drawing.Size(19, 13)
        Me.lbl1D.TabIndex = 42
        Me.lbl1D.Text = "41"
        Me.lbl1D.Visible = False
        '
        'lbl5A
        '
        Me.lbl5A.AutoSize = True
        Me.lbl5A.Location = New System.Drawing.Point(53, 212)
        Me.lbl5A.Name = "lbl5A"
        Me.lbl5A.Size = New System.Drawing.Size(19, 13)
        Me.lbl5A.TabIndex = 42
        Me.lbl5A.Text = "15"
        Me.lbl5A.Visible = False
        '
        'lbl1C
        '
        Me.lbl1C.AutoSize = True
        Me.lbl1C.Location = New System.Drawing.Point(132, 55)
        Me.lbl1C.Name = "lbl1C"
        Me.lbl1C.Size = New System.Drawing.Size(19, 13)
        Me.lbl1C.TabIndex = 42
        Me.lbl1C.Text = "31"
        Me.lbl1C.Visible = False
        '
        'lbl1B
        '
        Me.lbl1B.AutoSize = True
        Me.lbl1B.Location = New System.Drawing.Point(93, 55)
        Me.lbl1B.Name = "lbl1B"
        Me.lbl1B.Size = New System.Drawing.Size(19, 13)
        Me.lbl1B.TabIndex = 42
        Me.lbl1B.Text = "21"
        Me.lbl1B.Visible = False
        '
        'lbl2A
        '
        Me.lbl2A.AutoSize = True
        Me.lbl2A.Location = New System.Drawing.Point(53, 94)
        Me.lbl2A.Name = "lbl2A"
        Me.lbl2A.Size = New System.Drawing.Size(19, 13)
        Me.lbl2A.TabIndex = 43
        Me.lbl2A.Text = "12"
        Me.lbl2A.Visible = False
        '
        'lbl1A
        '
        Me.lbl1A.AutoSize = True
        Me.lbl1A.Location = New System.Drawing.Point(53, 55)
        Me.lbl1A.Name = "lbl1A"
        Me.lbl1A.Size = New System.Drawing.Size(19, 13)
        Me.lbl1A.TabIndex = 42
        Me.lbl1A.Text = "11"
        Me.lbl1A.Visible = False
        '
        'lblColumnI
        '
        Me.lblColumnI.AutoSize = True
        Me.lblColumnI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnI.Location = New System.Drawing.Point(371, 6)
        Me.lblColumnI.Name = "lblColumnI"
        Me.lblColumnI.Size = New System.Drawing.Size(17, 25)
        Me.lblColumnI.TabIndex = 23
        Me.lblColumnI.Text = "I"
        '
        'lblColumnH
        '
        Me.lblColumnH.AutoSize = True
        Me.lblColumnH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnH.Location = New System.Drawing.Point(329, 6)
        Me.lblColumnH.Name = "lblColumnH"
        Me.lblColumnH.Size = New System.Drawing.Size(27, 25)
        Me.lblColumnH.TabIndex = 23
        Me.lblColumnH.Text = "H"
        '
        'lblColumnG
        '
        Me.lblColumnG.AutoSize = True
        Me.lblColumnG.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnG.Location = New System.Drawing.Point(290, 6)
        Me.lblColumnG.Name = "lblColumnG"
        Me.lblColumnG.Size = New System.Drawing.Size(28, 25)
        Me.lblColumnG.TabIndex = 23
        Me.lblColumnG.Text = "G"
        '
        'lblColumnF
        '
        Me.lblColumnF.AutoSize = True
        Me.lblColumnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnF.Location = New System.Drawing.Point(249, 6)
        Me.lblColumnF.Name = "lblColumnF"
        Me.lblColumnF.Size = New System.Drawing.Size(25, 25)
        Me.lblColumnF.TabIndex = 23
        Me.lblColumnF.Text = "F"
        '
        'lblColumnE
        '
        Me.lblColumnE.AutoSize = True
        Me.lblColumnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnE.Location = New System.Drawing.Point(210, 6)
        Me.lblColumnE.Name = "lblColumnE"
        Me.lblColumnE.Size = New System.Drawing.Size(26, 25)
        Me.lblColumnE.TabIndex = 41
        Me.lblColumnE.Text = "E"
        '
        'txt9A
        '
        Me.txt9A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9A.Enabled = False
        Me.txt9A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9A.Location = New System.Drawing.Point(46, 353)
        Me.txt9A.MaxLength = 1
        Me.txt9A.Name = "txt9A"
        Me.txt9A.Size = New System.Drawing.Size(38, 38)
        Me.txt9A.TabIndex = 32
        Me.txt9A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8A
        '
        Me.txt8A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8A.Enabled = False
        Me.txt8A.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8A.Location = New System.Drawing.Point(46, 314)
        Me.txt8A.MaxLength = 1
        Me.txt8A.Name = "txt8A"
        Me.txt8A.Size = New System.Drawing.Size(38, 39)
        Me.txt8A.TabIndex = 32
        Me.txt8A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7A
        '
        Me.txt7A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7A.Enabled = False
        Me.txt7A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7A.Location = New System.Drawing.Point(46, 276)
        Me.txt7A.MaxLength = 1
        Me.txt7A.Name = "txt7A"
        Me.txt7A.Size = New System.Drawing.Size(38, 38)
        Me.txt7A.TabIndex = 32
        Me.txt7A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9I
        '
        Me.txt9I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9I.Enabled = False
        Me.txt9I.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9I.Location = New System.Drawing.Point(361, 353)
        Me.txt9I.MaxLength = 1
        Me.txt9I.Name = "txt9I"
        Me.txt9I.Size = New System.Drawing.Size(39, 38)
        Me.txt9I.TabIndex = 38
        Me.txt9I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8I
        '
        Me.txt8I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8I.Enabled = False
        Me.txt8I.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8I.Location = New System.Drawing.Point(361, 314)
        Me.txt8I.MaxLength = 1
        Me.txt8I.Name = "txt8I"
        Me.txt8I.Size = New System.Drawing.Size(39, 39)
        Me.txt8I.TabIndex = 38
        Me.txt8I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7I
        '
        Me.txt7I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7I.Enabled = False
        Me.txt7I.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7I.Location = New System.Drawing.Point(361, 276)
        Me.txt7I.MaxLength = 1
        Me.txt7I.Name = "txt7I"
        Me.txt7I.Size = New System.Drawing.Size(39, 38)
        Me.txt7I.TabIndex = 38
        Me.txt7I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9H
        '
        Me.txt9H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9H.Enabled = False
        Me.txt9H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9H.Location = New System.Drawing.Point(322, 353)
        Me.txt9H.MaxLength = 1
        Me.txt9H.Name = "txt9H"
        Me.txt9H.Size = New System.Drawing.Size(39, 38)
        Me.txt9H.TabIndex = 37
        Me.txt9H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8H
        '
        Me.txt8H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8H.Enabled = False
        Me.txt8H.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8H.Location = New System.Drawing.Point(322, 314)
        Me.txt8H.MaxLength = 1
        Me.txt8H.Name = "txt8H"
        Me.txt8H.Size = New System.Drawing.Size(39, 39)
        Me.txt8H.TabIndex = 37
        Me.txt8H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7H
        '
        Me.txt7H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7H.Enabled = False
        Me.txt7H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7H.Location = New System.Drawing.Point(322, 276)
        Me.txt7H.MaxLength = 1
        Me.txt7H.Name = "txt7H"
        Me.txt7H.Size = New System.Drawing.Size(39, 38)
        Me.txt7H.TabIndex = 37
        Me.txt7H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9G
        '
        Me.txt9G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9G.Enabled = False
        Me.txt9G.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9G.Location = New System.Drawing.Point(283, 353)
        Me.txt9G.MaxLength = 1
        Me.txt9G.Name = "txt9G"
        Me.txt9G.Size = New System.Drawing.Size(39, 38)
        Me.txt9G.TabIndex = 40
        Me.txt9G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8G
        '
        Me.txt8G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8G.Enabled = False
        Me.txt8G.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8G.Location = New System.Drawing.Point(283, 314)
        Me.txt8G.MaxLength = 1
        Me.txt8G.Name = "txt8G"
        Me.txt8G.Size = New System.Drawing.Size(39, 39)
        Me.txt8G.TabIndex = 40
        Me.txt8G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7G
        '
        Me.txt7G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7G.Enabled = False
        Me.txt7G.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7G.Location = New System.Drawing.Point(283, 276)
        Me.txt7G.MaxLength = 1
        Me.txt7G.Name = "txt7G"
        Me.txt7G.Size = New System.Drawing.Size(39, 38)
        Me.txt7G.TabIndex = 40
        Me.txt7G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9B
        '
        Me.txt9B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9B.Enabled = False
        Me.txt9B.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9B.Location = New System.Drawing.Point(84, 353)
        Me.txt9B.MaxLength = 1
        Me.txt9B.Name = "txt9B"
        Me.txt9B.Size = New System.Drawing.Size(39, 38)
        Me.txt9B.TabIndex = 39
        Me.txt9B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8B
        '
        Me.txt8B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8B.Enabled = False
        Me.txt8B.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8B.Location = New System.Drawing.Point(84, 314)
        Me.txt8B.MaxLength = 1
        Me.txt8B.Name = "txt8B"
        Me.txt8B.Size = New System.Drawing.Size(39, 39)
        Me.txt8B.TabIndex = 39
        Me.txt8B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7B
        '
        Me.txt7B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7B.Enabled = False
        Me.txt7B.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7B.Location = New System.Drawing.Point(84, 276)
        Me.txt7B.MaxLength = 1
        Me.txt7B.Name = "txt7B"
        Me.txt7B.Size = New System.Drawing.Size(39, 38)
        Me.txt7B.TabIndex = 39
        Me.txt7B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9F
        '
        Me.txt9F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9F.Enabled = False
        Me.txt9F.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9F.Location = New System.Drawing.Point(242, 353)
        Me.txt9F.MaxLength = 1
        Me.txt9F.Name = "txt9F"
        Me.txt9F.Size = New System.Drawing.Size(39, 38)
        Me.txt9F.TabIndex = 34
        Me.txt9F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8F
        '
        Me.txt8F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8F.Enabled = False
        Me.txt8F.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8F.Location = New System.Drawing.Point(242, 314)
        Me.txt8F.MaxLength = 1
        Me.txt8F.Name = "txt8F"
        Me.txt8F.Size = New System.Drawing.Size(39, 39)
        Me.txt8F.TabIndex = 34
        Me.txt8F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7F
        '
        Me.txt7F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7F.Enabled = False
        Me.txt7F.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7F.Location = New System.Drawing.Point(242, 276)
        Me.txt7F.MaxLength = 1
        Me.txt7F.Name = "txt7F"
        Me.txt7F.Size = New System.Drawing.Size(39, 38)
        Me.txt7F.TabIndex = 34
        Me.txt7F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9C
        '
        Me.txt9C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9C.Enabled = False
        Me.txt9C.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9C.Location = New System.Drawing.Point(123, 353)
        Me.txt9C.MaxLength = 1
        Me.txt9C.Name = "txt9C"
        Me.txt9C.Size = New System.Drawing.Size(39, 38)
        Me.txt9C.TabIndex = 33
        Me.txt9C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8C
        '
        Me.txt8C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8C.Enabled = False
        Me.txt8C.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8C.Location = New System.Drawing.Point(123, 314)
        Me.txt8C.MaxLength = 1
        Me.txt8C.Name = "txt8C"
        Me.txt8C.Size = New System.Drawing.Size(39, 39)
        Me.txt8C.TabIndex = 33
        Me.txt8C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9E
        '
        Me.txt9E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9E.Enabled = False
        Me.txt9E.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9E.Location = New System.Drawing.Point(203, 353)
        Me.txt9E.MaxLength = 1
        Me.txt9E.Name = "txt9E"
        Me.txt9E.Size = New System.Drawing.Size(39, 38)
        Me.txt9E.TabIndex = 36
        Me.txt9E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7C
        '
        Me.txt7C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7C.Enabled = False
        Me.txt7C.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7C.Location = New System.Drawing.Point(123, 276)
        Me.txt7C.MaxLength = 1
        Me.txt7C.Name = "txt7C"
        Me.txt7C.Size = New System.Drawing.Size(39, 38)
        Me.txt7C.TabIndex = 33
        Me.txt7C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8E
        '
        Me.txt8E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8E.Enabled = False
        Me.txt8E.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8E.Location = New System.Drawing.Point(203, 314)
        Me.txt8E.MaxLength = 1
        Me.txt8E.Name = "txt8E"
        Me.txt8E.Size = New System.Drawing.Size(39, 39)
        Me.txt8E.TabIndex = 36
        Me.txt8E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9D
        '
        Me.txt9D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt9D.Enabled = False
        Me.txt9D.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9D.Location = New System.Drawing.Point(164, 353)
        Me.txt9D.MaxLength = 1
        Me.txt9D.Name = "txt9D"
        Me.txt9D.Size = New System.Drawing.Size(39, 38)
        Me.txt9D.TabIndex = 35
        Me.txt9D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7E
        '
        Me.txt7E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7E.Enabled = False
        Me.txt7E.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7E.Location = New System.Drawing.Point(203, 276)
        Me.txt7E.MaxLength = 1
        Me.txt7E.Name = "txt7E"
        Me.txt7E.Size = New System.Drawing.Size(39, 38)
        Me.txt7E.TabIndex = 36
        Me.txt7E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8D
        '
        Me.txt8D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt8D.Enabled = False
        Me.txt8D.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8D.Location = New System.Drawing.Point(164, 314)
        Me.txt8D.MaxLength = 1
        Me.txt8D.Name = "txt8D"
        Me.txt8D.Size = New System.Drawing.Size(39, 39)
        Me.txt8D.TabIndex = 35
        Me.txt8D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7D
        '
        Me.txt7D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt7D.Enabled = False
        Me.txt7D.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7D.Location = New System.Drawing.Point(164, 276)
        Me.txt7D.MaxLength = 1
        Me.txt7D.Name = "txt7D"
        Me.txt7D.Size = New System.Drawing.Size(39, 38)
        Me.txt7D.TabIndex = 35
        Me.txt7D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6A
        '
        Me.txt6A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6A.Enabled = False
        Me.txt6A.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6A.Location = New System.Drawing.Point(46, 234)
        Me.txt6A.MaxLength = 1
        Me.txt6A.Name = "txt6A"
        Me.txt6A.Size = New System.Drawing.Size(38, 39)
        Me.txt6A.TabIndex = 23
        Me.txt6A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6I
        '
        Me.txt6I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6I.Enabled = False
        Me.txt6I.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6I.Location = New System.Drawing.Point(361, 234)
        Me.txt6I.MaxLength = 1
        Me.txt6I.Name = "txt6I"
        Me.txt6I.Size = New System.Drawing.Size(39, 39)
        Me.txt6I.TabIndex = 29
        Me.txt6I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6H
        '
        Me.txt6H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6H.Enabled = False
        Me.txt6H.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6H.Location = New System.Drawing.Point(322, 234)
        Me.txt6H.MaxLength = 1
        Me.txt6H.Name = "txt6H"
        Me.txt6H.Size = New System.Drawing.Size(39, 39)
        Me.txt6H.TabIndex = 28
        Me.txt6H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6G
        '
        Me.txt6G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6G.Enabled = False
        Me.txt6G.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6G.Location = New System.Drawing.Point(283, 234)
        Me.txt6G.MaxLength = 1
        Me.txt6G.Name = "txt6G"
        Me.txt6G.Size = New System.Drawing.Size(39, 39)
        Me.txt6G.TabIndex = 31
        Me.txt6G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6B
        '
        Me.txt6B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6B.Enabled = False
        Me.txt6B.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6B.Location = New System.Drawing.Point(84, 234)
        Me.txt6B.MaxLength = 1
        Me.txt6B.Name = "txt6B"
        Me.txt6B.Size = New System.Drawing.Size(39, 39)
        Me.txt6B.TabIndex = 30
        Me.txt6B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6F
        '
        Me.txt6F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6F.Enabled = False
        Me.txt6F.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6F.Location = New System.Drawing.Point(242, 234)
        Me.txt6F.MaxLength = 1
        Me.txt6F.Name = "txt6F"
        Me.txt6F.Size = New System.Drawing.Size(39, 39)
        Me.txt6F.TabIndex = 25
        Me.txt6F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6C
        '
        Me.txt6C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6C.Enabled = False
        Me.txt6C.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6C.Location = New System.Drawing.Point(123, 234)
        Me.txt6C.MaxLength = 1
        Me.txt6C.Name = "txt6C"
        Me.txt6C.Size = New System.Drawing.Size(39, 39)
        Me.txt6C.TabIndex = 24
        Me.txt6C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6E
        '
        Me.txt6E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6E.Enabled = False
        Me.txt6E.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6E.Location = New System.Drawing.Point(203, 234)
        Me.txt6E.MaxLength = 1
        Me.txt6E.Name = "txt6E"
        Me.txt6E.Size = New System.Drawing.Size(39, 39)
        Me.txt6E.TabIndex = 27
        Me.txt6E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6D
        '
        Me.txt6D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt6D.Enabled = False
        Me.txt6D.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6D.Location = New System.Drawing.Point(164, 234)
        Me.txt6D.MaxLength = 1
        Me.txt6D.Name = "txt6D"
        Me.txt6D.Size = New System.Drawing.Size(39, 39)
        Me.txt6D.TabIndex = 26
        Me.txt6D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblColumnD
        '
        Me.lblColumnD.AutoSize = True
        Me.lblColumnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnD.Location = New System.Drawing.Point(171, 6)
        Me.lblColumnD.Name = "lblColumnD"
        Me.lblColumnD.Size = New System.Drawing.Size(27, 25)
        Me.lblColumnD.TabIndex = 22
        Me.lblColumnD.Text = "D"
        '
        'lblColumnC
        '
        Me.lblColumnC.AutoSize = True
        Me.lblColumnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnC.Location = New System.Drawing.Point(130, 6)
        Me.lblColumnC.Name = "lblColumnC"
        Me.lblColumnC.Size = New System.Drawing.Size(27, 25)
        Me.lblColumnC.TabIndex = 22
        Me.lblColumnC.Text = "C"
        '
        'lblColumnB
        '
        Me.lblColumnB.AutoSize = True
        Me.lblColumnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnB.Location = New System.Drawing.Point(91, 6)
        Me.lblColumnB.Name = "lblColumnB"
        Me.lblColumnB.Size = New System.Drawing.Size(26, 25)
        Me.lblColumnB.TabIndex = 22
        Me.lblColumnB.Text = "B"
        '
        'lblColumnA
        '
        Me.lblColumnA.AutoSize = True
        Me.lblColumnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnA.Location = New System.Drawing.Point(51, 6)
        Me.lblColumnA.Name = "lblColumnA"
        Me.lblColumnA.Size = New System.Drawing.Size(26, 25)
        Me.lblColumnA.TabIndex = 22
        Me.lblColumnA.Text = "A"
        '
        'lblRow1
        '
        Me.lblRow1.AutoSize = True
        Me.lblRow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow1.Location = New System.Drawing.Point(9, 46)
        Me.lblRow1.Name = "lblRow1"
        Me.lblRow1.Size = New System.Drawing.Size(24, 25)
        Me.lblRow1.TabIndex = 22
        Me.lblRow1.Text = "1"
        '
        'lblRow9
        '
        Me.lblRow9.AutoSize = True
        Me.lblRow9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow9.Location = New System.Drawing.Point(9, 361)
        Me.lblRow9.Name = "lblRow9"
        Me.lblRow9.Size = New System.Drawing.Size(24, 25)
        Me.lblRow9.TabIndex = 22
        Me.lblRow9.Text = "9"
        '
        'lblRow8
        '
        Me.lblRow8.AutoSize = True
        Me.lblRow8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow8.Location = New System.Drawing.Point(9, 322)
        Me.lblRow8.Name = "lblRow8"
        Me.lblRow8.Size = New System.Drawing.Size(24, 25)
        Me.lblRow8.TabIndex = 22
        Me.lblRow8.Text = "8"
        '
        'lblRow7
        '
        Me.lblRow7.AutoSize = True
        Me.lblRow7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow7.Location = New System.Drawing.Point(9, 284)
        Me.lblRow7.Name = "lblRow7"
        Me.lblRow7.Size = New System.Drawing.Size(24, 25)
        Me.lblRow7.TabIndex = 22
        Me.lblRow7.Text = "7"
        '
        'lblRow6
        '
        Me.lblRow6.AutoSize = True
        Me.lblRow6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow6.Location = New System.Drawing.Point(9, 243)
        Me.lblRow6.Name = "lblRow6"
        Me.lblRow6.Size = New System.Drawing.Size(24, 25)
        Me.lblRow6.TabIndex = 22
        Me.lblRow6.Text = "6"
        '
        'lblRow5
        '
        Me.lblRow5.AutoSize = True
        Me.lblRow5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow5.Location = New System.Drawing.Point(9, 204)
        Me.lblRow5.Name = "lblRow5"
        Me.lblRow5.Size = New System.Drawing.Size(24, 25)
        Me.lblRow5.TabIndex = 22
        Me.lblRow5.Text = "5"
        '
        'lblRow4
        '
        Me.lblRow4.AutoSize = True
        Me.lblRow4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow4.Location = New System.Drawing.Point(9, 165)
        Me.lblRow4.Name = "lblRow4"
        Me.lblRow4.Size = New System.Drawing.Size(24, 25)
        Me.lblRow4.TabIndex = 22
        Me.lblRow4.Text = "4"
        '
        'lblRow3
        '
        Me.lblRow3.AutoSize = True
        Me.lblRow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow3.Location = New System.Drawing.Point(9, 124)
        Me.lblRow3.Name = "lblRow3"
        Me.lblRow3.Size = New System.Drawing.Size(24, 25)
        Me.lblRow3.TabIndex = 22
        Me.lblRow3.Text = "3"
        '
        'lblRow2
        '
        Me.lblRow2.AutoSize = True
        Me.lblRow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow2.Location = New System.Drawing.Point(9, 85)
        Me.lblRow2.Name = "lblRow2"
        Me.lblRow2.Size = New System.Drawing.Size(24, 25)
        Me.lblRow2.TabIndex = 22
        Me.lblRow2.Text = "2"
        '
        'txt5A
        '
        Me.txt5A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5A.Enabled = False
        Me.txt5A.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5A.Location = New System.Drawing.Point(46, 195)
        Me.txt5A.MaxLength = 1
        Me.txt5A.Name = "txt5A"
        Me.txt5A.Size = New System.Drawing.Size(38, 39)
        Me.txt5A.TabIndex = 12
        Me.txt5A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5I
        '
        Me.txt5I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5I.Enabled = False
        Me.txt5I.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5I.Location = New System.Drawing.Point(361, 195)
        Me.txt5I.MaxLength = 1
        Me.txt5I.Name = "txt5I"
        Me.txt5I.Size = New System.Drawing.Size(39, 39)
        Me.txt5I.TabIndex = 18
        Me.txt5I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5H
        '
        Me.txt5H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5H.Enabled = False
        Me.txt5H.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5H.Location = New System.Drawing.Point(322, 195)
        Me.txt5H.MaxLength = 1
        Me.txt5H.Name = "txt5H"
        Me.txt5H.Size = New System.Drawing.Size(39, 39)
        Me.txt5H.TabIndex = 17
        Me.txt5H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5G
        '
        Me.txt5G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5G.Enabled = False
        Me.txt5G.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5G.Location = New System.Drawing.Point(283, 195)
        Me.txt5G.MaxLength = 1
        Me.txt5G.Name = "txt5G"
        Me.txt5G.Size = New System.Drawing.Size(39, 39)
        Me.txt5G.TabIndex = 20
        Me.txt5G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5B
        '
        Me.txt5B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5B.Enabled = False
        Me.txt5B.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5B.Location = New System.Drawing.Point(84, 195)
        Me.txt5B.MaxLength = 1
        Me.txt5B.Name = "txt5B"
        Me.txt5B.Size = New System.Drawing.Size(39, 39)
        Me.txt5B.TabIndex = 19
        Me.txt5B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5F
        '
        Me.txt5F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5F.Enabled = False
        Me.txt5F.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5F.Location = New System.Drawing.Point(242, 195)
        Me.txt5F.MaxLength = 1
        Me.txt5F.Name = "txt5F"
        Me.txt5F.Size = New System.Drawing.Size(39, 39)
        Me.txt5F.TabIndex = 14
        Me.txt5F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5C
        '
        Me.txt5C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5C.Enabled = False
        Me.txt5C.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5C.Location = New System.Drawing.Point(123, 195)
        Me.txt5C.MaxLength = 1
        Me.txt5C.Name = "txt5C"
        Me.txt5C.Size = New System.Drawing.Size(39, 39)
        Me.txt5C.TabIndex = 13
        Me.txt5C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5E
        '
        Me.txt5E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5E.Enabled = False
        Me.txt5E.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5E.Location = New System.Drawing.Point(203, 195)
        Me.txt5E.MaxLength = 1
        Me.txt5E.Name = "txt5E"
        Me.txt5E.Size = New System.Drawing.Size(39, 39)
        Me.txt5E.TabIndex = 16
        Me.txt5E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5D
        '
        Me.txt5D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5D.Enabled = False
        Me.txt5D.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5D.Location = New System.Drawing.Point(164, 195)
        Me.txt5D.MaxLength = 1
        Me.txt5D.Name = "txt5D"
        Me.txt5D.Size = New System.Drawing.Size(39, 39)
        Me.txt5D.TabIndex = 15
        Me.txt5D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4A
        '
        Me.txt4A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4A.Enabled = False
        Me.txt4A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4A.Location = New System.Drawing.Point(46, 157)
        Me.txt4A.MaxLength = 1
        Me.txt4A.Name = "txt4A"
        Me.txt4A.Size = New System.Drawing.Size(38, 38)
        Me.txt4A.TabIndex = 3
        Me.txt4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4I
        '
        Me.txt4I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4I.Enabled = False
        Me.txt4I.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4I.Location = New System.Drawing.Point(361, 157)
        Me.txt4I.MaxLength = 1
        Me.txt4I.Name = "txt4I"
        Me.txt4I.Size = New System.Drawing.Size(39, 38)
        Me.txt4I.TabIndex = 9
        Me.txt4I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4H
        '
        Me.txt4H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4H.Enabled = False
        Me.txt4H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4H.Location = New System.Drawing.Point(322, 157)
        Me.txt4H.MaxLength = 1
        Me.txt4H.Name = "txt4H"
        Me.txt4H.Size = New System.Drawing.Size(39, 38)
        Me.txt4H.TabIndex = 8
        Me.txt4H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4G
        '
        Me.txt4G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4G.Enabled = False
        Me.txt4G.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4G.Location = New System.Drawing.Point(283, 157)
        Me.txt4G.MaxLength = 1
        Me.txt4G.Name = "txt4G"
        Me.txt4G.Size = New System.Drawing.Size(39, 38)
        Me.txt4G.TabIndex = 11
        Me.txt4G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4B
        '
        Me.txt4B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4B.Enabled = False
        Me.txt4B.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4B.Location = New System.Drawing.Point(84, 157)
        Me.txt4B.MaxLength = 1
        Me.txt4B.Name = "txt4B"
        Me.txt4B.Size = New System.Drawing.Size(39, 38)
        Me.txt4B.TabIndex = 10
        Me.txt4B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4F
        '
        Me.txt4F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4F.Enabled = False
        Me.txt4F.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4F.Location = New System.Drawing.Point(242, 157)
        Me.txt4F.MaxLength = 1
        Me.txt4F.Name = "txt4F"
        Me.txt4F.Size = New System.Drawing.Size(39, 38)
        Me.txt4F.TabIndex = 5
        Me.txt4F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4C
        '
        Me.txt4C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4C.Enabled = False
        Me.txt4C.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4C.Location = New System.Drawing.Point(123, 157)
        Me.txt4C.MaxLength = 1
        Me.txt4C.Name = "txt4C"
        Me.txt4C.Size = New System.Drawing.Size(39, 38)
        Me.txt4C.TabIndex = 4
        Me.txt4C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4E
        '
        Me.txt4E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4E.Enabled = False
        Me.txt4E.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4E.Location = New System.Drawing.Point(203, 157)
        Me.txt4E.MaxLength = 1
        Me.txt4E.Name = "txt4E"
        Me.txt4E.Size = New System.Drawing.Size(39, 38)
        Me.txt4E.TabIndex = 7
        Me.txt4E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4D
        '
        Me.txt4D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4D.Enabled = False
        Me.txt4D.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4D.Location = New System.Drawing.Point(164, 157)
        Me.txt4D.MaxLength = 1
        Me.txt4D.Name = "txt4D"
        Me.txt4D.Size = New System.Drawing.Size(39, 38)
        Me.txt4D.TabIndex = 6
        Me.txt4D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3A
        '
        Me.txt3A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3A.Enabled = False
        Me.txt3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3A.Location = New System.Drawing.Point(46, 116)
        Me.txt3A.MaxLength = 1
        Me.txt3A.Name = "txt3A"
        Me.txt3A.Size = New System.Drawing.Size(38, 38)
        Me.txt3A.TabIndex = 1
        Me.txt3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2A
        '
        Me.txt2A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2A.Enabled = False
        Me.txt2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2A.Location = New System.Drawing.Point(46, 77)
        Me.txt2A.MaxLength = 1
        Me.txt2A.Name = "txt2A"
        Me.txt2A.Size = New System.Drawing.Size(38, 39)
        Me.txt2A.TabIndex = 1
        Me.txt2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3I
        '
        Me.txt3I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3I.Enabled = False
        Me.txt3I.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3I.Location = New System.Drawing.Point(361, 116)
        Me.txt3I.MaxLength = 1
        Me.txt3I.Name = "txt3I"
        Me.txt3I.Size = New System.Drawing.Size(39, 38)
        Me.txt3I.TabIndex = 2
        Me.txt3I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2I
        '
        Me.txt2I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2I.Enabled = False
        Me.txt2I.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2I.Location = New System.Drawing.Point(361, 77)
        Me.txt2I.MaxLength = 1
        Me.txt2I.Name = "txt2I"
        Me.txt2I.Size = New System.Drawing.Size(39, 39)
        Me.txt2I.TabIndex = 2
        Me.txt2I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1I
        '
        Me.txt1I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1I.Enabled = False
        Me.txt1I.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1I.Location = New System.Drawing.Point(361, 38)
        Me.txt1I.MaxLength = 1
        Me.txt1I.Name = "txt1I"
        Me.txt1I.Size = New System.Drawing.Size(39, 39)
        Me.txt1I.TabIndex = 2
        Me.txt1I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3H
        '
        Me.txt3H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3H.Enabled = False
        Me.txt3H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3H.Location = New System.Drawing.Point(322, 116)
        Me.txt3H.MaxLength = 1
        Me.txt3H.Name = "txt3H"
        Me.txt3H.Size = New System.Drawing.Size(39, 38)
        Me.txt3H.TabIndex = 2
        Me.txt3H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2H
        '
        Me.txt2H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2H.Enabled = False
        Me.txt2H.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2H.Location = New System.Drawing.Point(322, 77)
        Me.txt2H.MaxLength = 1
        Me.txt2H.Name = "txt2H"
        Me.txt2H.Size = New System.Drawing.Size(39, 39)
        Me.txt2H.TabIndex = 2
        Me.txt2H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1H
        '
        Me.txt1H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1H.Enabled = False
        Me.txt1H.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1H.Location = New System.Drawing.Point(322, 38)
        Me.txt1H.MaxLength = 1
        Me.txt1H.Name = "txt1H"
        Me.txt1H.Size = New System.Drawing.Size(39, 39)
        Me.txt1H.TabIndex = 2
        Me.txt1H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3G
        '
        Me.txt3G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3G.Enabled = False
        Me.txt3G.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3G.Location = New System.Drawing.Point(283, 116)
        Me.txt3G.MaxLength = 1
        Me.txt3G.Name = "txt3G"
        Me.txt3G.Size = New System.Drawing.Size(39, 38)
        Me.txt3G.TabIndex = 2
        Me.txt3G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2G
        '
        Me.txt2G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2G.Enabled = False
        Me.txt2G.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2G.Location = New System.Drawing.Point(283, 77)
        Me.txt2G.MaxLength = 1
        Me.txt2G.Name = "txt2G"
        Me.txt2G.Size = New System.Drawing.Size(39, 39)
        Me.txt2G.TabIndex = 2
        Me.txt2G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3B
        '
        Me.txt3B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3B.Enabled = False
        Me.txt3B.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3B.Location = New System.Drawing.Point(84, 116)
        Me.txt3B.MaxLength = 1
        Me.txt3B.Name = "txt3B"
        Me.txt3B.Size = New System.Drawing.Size(39, 38)
        Me.txt3B.TabIndex = 2
        Me.txt3B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2B
        '
        Me.txt2B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2B.Enabled = False
        Me.txt2B.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2B.Location = New System.Drawing.Point(84, 77)
        Me.txt2B.MaxLength = 1
        Me.txt2B.Name = "txt2B"
        Me.txt2B.Size = New System.Drawing.Size(39, 39)
        Me.txt2B.TabIndex = 2
        Me.txt2B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3F
        '
        Me.txt3F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3F.Enabled = False
        Me.txt3F.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3F.Location = New System.Drawing.Point(242, 116)
        Me.txt3F.MaxLength = 1
        Me.txt3F.Name = "txt3F"
        Me.txt3F.Size = New System.Drawing.Size(39, 38)
        Me.txt3F.TabIndex = 2
        Me.txt3F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2F
        '
        Me.txt2F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2F.Enabled = False
        Me.txt2F.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2F.Location = New System.Drawing.Point(242, 77)
        Me.txt2F.MaxLength = 1
        Me.txt2F.Name = "txt2F"
        Me.txt2F.Size = New System.Drawing.Size(39, 39)
        Me.txt2F.TabIndex = 2
        Me.txt2F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3C
        '
        Me.txt3C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3C.Enabled = False
        Me.txt3C.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3C.Location = New System.Drawing.Point(123, 116)
        Me.txt3C.MaxLength = 1
        Me.txt3C.Name = "txt3C"
        Me.txt3C.Size = New System.Drawing.Size(39, 38)
        Me.txt3C.TabIndex = 2
        Me.txt3C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3E
        '
        Me.txt3E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3E.Enabled = False
        Me.txt3E.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3E.Location = New System.Drawing.Point(203, 116)
        Me.txt3E.MaxLength = 1
        Me.txt3E.Name = "txt3E"
        Me.txt3E.Size = New System.Drawing.Size(39, 38)
        Me.txt3E.TabIndex = 2
        Me.txt3E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2C
        '
        Me.txt2C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2C.Enabled = False
        Me.txt2C.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2C.Location = New System.Drawing.Point(123, 77)
        Me.txt2C.MaxLength = 1
        Me.txt2C.Name = "txt2C"
        Me.txt2C.Size = New System.Drawing.Size(39, 39)
        Me.txt2C.TabIndex = 2
        Me.txt2C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2E
        '
        Me.txt2E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2E.Enabled = False
        Me.txt2E.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2E.Location = New System.Drawing.Point(203, 77)
        Me.txt2E.MaxLength = 1
        Me.txt2E.Name = "txt2E"
        Me.txt2E.Size = New System.Drawing.Size(39, 39)
        Me.txt2E.TabIndex = 2
        Me.txt2E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3D
        '
        Me.txt3D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3D.Enabled = False
        Me.txt3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3D.Location = New System.Drawing.Point(164, 116)
        Me.txt3D.MaxLength = 1
        Me.txt3D.Name = "txt3D"
        Me.txt3D.Size = New System.Drawing.Size(39, 38)
        Me.txt3D.TabIndex = 2
        Me.txt3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2D
        '
        Me.txt2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2D.Enabled = False
        Me.txt2D.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2D.Location = New System.Drawing.Point(164, 77)
        Me.txt2D.MaxLength = 1
        Me.txt2D.Name = "txt2D"
        Me.txt2D.Size = New System.Drawing.Size(39, 39)
        Me.txt2D.TabIndex = 2
        Me.txt2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sudoku.My.Resources.Resources.grid
        Me.PictureBox1.Location = New System.Drawing.Point(43, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 361)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimer.Location = New System.Drawing.Point(331, 418)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(78, 23)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Visible = False
        '
        'btnHint
        '
        Me.btnHint.Enabled = False
        Me.btnHint.Location = New System.Drawing.Point(150, 418)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(75, 23)
        Me.btnHint.TabIndex = 5
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        Me.btnHint.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(334, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(334, 453)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblCorrect
        '
        Me.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorrect.Enabled = False
        Me.lblCorrect.Location = New System.Drawing.Point(46, 457)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(179, 23)
        Me.lblCorrect.TabIndex = 8
        Me.lblCorrect.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(45, 418)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(427, 488)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSolve)
        Me.Name = "frmSudoku"
        Me.Text = "Sudoku"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSolve As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt1A As System.Windows.Forms.TextBox
    Friend WithEvents txt1B As System.Windows.Forms.TextBox
    Friend WithEvents txt1C As System.Windows.Forms.TextBox
    Friend WithEvents txt1D As System.Windows.Forms.TextBox
    Friend WithEvents txt1E As System.Windows.Forms.TextBox
    Friend WithEvents txt1F As System.Windows.Forms.TextBox
    Friend WithEvents txt1G As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt3A As System.Windows.Forms.TextBox
    Friend WithEvents txt2A As System.Windows.Forms.TextBox
    Friend WithEvents txt3I As System.Windows.Forms.TextBox
    Friend WithEvents txt2I As System.Windows.Forms.TextBox
    Friend WithEvents txt1I As System.Windows.Forms.TextBox
    Friend WithEvents txt3H As System.Windows.Forms.TextBox
    Friend WithEvents txt2H As System.Windows.Forms.TextBox
    Friend WithEvents txt1H As System.Windows.Forms.TextBox
    Friend WithEvents txt3G As System.Windows.Forms.TextBox
    Friend WithEvents txt2G As System.Windows.Forms.TextBox
    Friend WithEvents txt3B As System.Windows.Forms.TextBox
    Friend WithEvents txt2B As System.Windows.Forms.TextBox
    Friend WithEvents txt3F As System.Windows.Forms.TextBox
    Friend WithEvents txt2F As System.Windows.Forms.TextBox
    Friend WithEvents txt3C As System.Windows.Forms.TextBox
    Friend WithEvents txt3E As System.Windows.Forms.TextBox
    Friend WithEvents txt2C As System.Windows.Forms.TextBox
    Friend WithEvents txt2E As System.Windows.Forms.TextBox
    Friend WithEvents txt3D As System.Windows.Forms.TextBox
    Friend WithEvents txt2D As System.Windows.Forms.TextBox
    Friend WithEvents txt5A As System.Windows.Forms.TextBox
    Friend WithEvents txt5I As System.Windows.Forms.TextBox
    Friend WithEvents txt5H As System.Windows.Forms.TextBox
    Friend WithEvents txt5G As System.Windows.Forms.TextBox
    Friend WithEvents txt5B As System.Windows.Forms.TextBox
    Friend WithEvents txt5F As System.Windows.Forms.TextBox
    Friend WithEvents txt5C As System.Windows.Forms.TextBox
    Friend WithEvents txt5E As System.Windows.Forms.TextBox
    Friend WithEvents txt5D As System.Windows.Forms.TextBox
    Friend WithEvents txt4A As System.Windows.Forms.TextBox
    Friend WithEvents txt4I As System.Windows.Forms.TextBox
    Friend WithEvents txt4H As System.Windows.Forms.TextBox
    Friend WithEvents txt4G As System.Windows.Forms.TextBox
    Friend WithEvents txt4B As System.Windows.Forms.TextBox
    Friend WithEvents txt4F As System.Windows.Forms.TextBox
    Friend WithEvents txt4C As System.Windows.Forms.TextBox
    Friend WithEvents txt4E As System.Windows.Forms.TextBox
    Friend WithEvents txt4D As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRow1 As System.Windows.Forms.Label
    Friend WithEvents lblRow2 As System.Windows.Forms.Label
    Friend WithEvents txt6A As System.Windows.Forms.TextBox
    Friend WithEvents txt6I As System.Windows.Forms.TextBox
    Friend WithEvents txt6H As System.Windows.Forms.TextBox
    Friend WithEvents txt6G As System.Windows.Forms.TextBox
    Friend WithEvents txt6B As System.Windows.Forms.TextBox
    Friend WithEvents txt6F As System.Windows.Forms.TextBox
    Friend WithEvents txt6C As System.Windows.Forms.TextBox
    Friend WithEvents txt6E As System.Windows.Forms.TextBox
    Friend WithEvents txt6D As System.Windows.Forms.TextBox
    Friend WithEvents lblRow6 As System.Windows.Forms.Label
    Friend WithEvents lblRow5 As System.Windows.Forms.Label
    Friend WithEvents lblRow4 As System.Windows.Forms.Label
    Friend WithEvents lblRow3 As System.Windows.Forms.Label
    Friend WithEvents txt9A As System.Windows.Forms.TextBox
    Friend WithEvents txt8A As System.Windows.Forms.TextBox
    Friend WithEvents txt7A As System.Windows.Forms.TextBox
    Friend WithEvents txt9I As System.Windows.Forms.TextBox
    Friend WithEvents txt8I As System.Windows.Forms.TextBox
    Friend WithEvents txt7I As System.Windows.Forms.TextBox
    Friend WithEvents txt9H As System.Windows.Forms.TextBox
    Friend WithEvents txt8H As System.Windows.Forms.TextBox
    Friend WithEvents txt7H As System.Windows.Forms.TextBox
    Friend WithEvents txt9G As System.Windows.Forms.TextBox
    Friend WithEvents txt8G As System.Windows.Forms.TextBox
    Friend WithEvents txt7G As System.Windows.Forms.TextBox
    Friend WithEvents txt9B As System.Windows.Forms.TextBox
    Friend WithEvents txt8B As System.Windows.Forms.TextBox
    Friend WithEvents txt7B As System.Windows.Forms.TextBox
    Friend WithEvents txt9F As System.Windows.Forms.TextBox
    Friend WithEvents txt8F As System.Windows.Forms.TextBox
    Friend WithEvents txt7F As System.Windows.Forms.TextBox
    Friend WithEvents txt9C As System.Windows.Forms.TextBox
    Friend WithEvents txt8C As System.Windows.Forms.TextBox
    Friend WithEvents txt9E As System.Windows.Forms.TextBox
    Friend WithEvents txt7C As System.Windows.Forms.TextBox
    Friend WithEvents txt8E As System.Windows.Forms.TextBox
    Friend WithEvents txt9D As System.Windows.Forms.TextBox
    Friend WithEvents txt7E As System.Windows.Forms.TextBox
    Friend WithEvents txt8D As System.Windows.Forms.TextBox
    Friend WithEvents txt7D As System.Windows.Forms.TextBox
    Friend WithEvents lblColumnC As System.Windows.Forms.Label
    Friend WithEvents lblColumnB As System.Windows.Forms.Label
    Friend WithEvents lblColumnA As System.Windows.Forms.Label
    Friend WithEvents lblRow9 As System.Windows.Forms.Label
    Friend WithEvents lblRow8 As System.Windows.Forms.Label
    Friend WithEvents lblRow7 As System.Windows.Forms.Label
    Friend WithEvents lblColumnD As System.Windows.Forms.Label
    Friend WithEvents lblColumnI As System.Windows.Forms.Label
    Friend WithEvents lblColumnH As System.Windows.Forms.Label
    Friend WithEvents lblColumnG As System.Windows.Forms.Label
    Friend WithEvents lblColumnF As System.Windows.Forms.Label
    Friend WithEvents lblColumnE As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbl9B As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl8B As System.Windows.Forms.Label
    Friend WithEvents lbl8A As System.Windows.Forms.Label
    Friend WithEvents lbl7B As System.Windows.Forms.Label
    Friend WithEvents lbl7A As System.Windows.Forms.Label
    Friend WithEvents lbl4B As System.Windows.Forms.Label
    Friend WithEvents lbl6B As System.Windows.Forms.Label
    Friend WithEvents lbl4A As System.Windows.Forms.Label
    Friend WithEvents lbl3B As System.Windows.Forms.Label
    Friend WithEvents lbl6A As System.Windows.Forms.Label
    Friend WithEvents lbl5B As System.Windows.Forms.Label
    Friend WithEvents lbl3A As System.Windows.Forms.Label
    Friend WithEvents lbl2B As System.Windows.Forms.Label
    Friend WithEvents lbl5A As System.Windows.Forms.Label
    Friend WithEvents lbl1B As System.Windows.Forms.Label
    Friend WithEvents lbl2A As System.Windows.Forms.Label
    Friend WithEvents lbl1A As System.Windows.Forms.Label
    Friend WithEvents lbl9C As System.Windows.Forms.Label
    Friend WithEvents lbl8C As System.Windows.Forms.Label
    Friend WithEvents lbl7C As System.Windows.Forms.Label
    Friend WithEvents lbl4C As System.Windows.Forms.Label
    Friend WithEvents lbl6C As System.Windows.Forms.Label
    Friend WithEvents lbl3C As System.Windows.Forms.Label
    Friend WithEvents lbl5C As System.Windows.Forms.Label
    Friend WithEvents lbl2C As System.Windows.Forms.Label
    Friend WithEvents lbl1C As System.Windows.Forms.Label
    Friend WithEvents lbl9D As System.Windows.Forms.Label
    Friend WithEvents lbl8D As System.Windows.Forms.Label
    Friend WithEvents lbl7D As System.Windows.Forms.Label
    Friend WithEvents lbl4D As System.Windows.Forms.Label
    Friend WithEvents lbl6D As System.Windows.Forms.Label
    Friend WithEvents lbl3D As System.Windows.Forms.Label
    Friend WithEvents lbl5D As System.Windows.Forms.Label
    Friend WithEvents lbl2D As System.Windows.Forms.Label
    Friend WithEvents lbl1D As System.Windows.Forms.Label
    Friend WithEvents lbl9E As System.Windows.Forms.Label
    Friend WithEvents lbl8E As System.Windows.Forms.Label
    Friend WithEvents lbl7E As System.Windows.Forms.Label
    Friend WithEvents lbl4E As System.Windows.Forms.Label
    Friend WithEvents lbl6E As System.Windows.Forms.Label
    Friend WithEvents lbl3E As System.Windows.Forms.Label
    Friend WithEvents lbl5E As System.Windows.Forms.Label
    Friend WithEvents lbl2E As System.Windows.Forms.Label
    Friend WithEvents lbl1E As System.Windows.Forms.Label
    Friend WithEvents lbl9F As System.Windows.Forms.Label
    Friend WithEvents lbl8F As System.Windows.Forms.Label
    Friend WithEvents lbl7F As System.Windows.Forms.Label
    Friend WithEvents lbl4F As System.Windows.Forms.Label
    Friend WithEvents lbl6F As System.Windows.Forms.Label
    Friend WithEvents lbl3F As System.Windows.Forms.Label
    Friend WithEvents lbl5F As System.Windows.Forms.Label
    Friend WithEvents lbl2F As System.Windows.Forms.Label
    Friend WithEvents lbl1F As System.Windows.Forms.Label
    Friend WithEvents lbl9G As System.Windows.Forms.Label
    Friend WithEvents lbl8G As System.Windows.Forms.Label
    Friend WithEvents lbl7G As System.Windows.Forms.Label
    Friend WithEvents lbl4G As System.Windows.Forms.Label
    Friend WithEvents lbl6G As System.Windows.Forms.Label
    Friend WithEvents lbl3G As System.Windows.Forms.Label
    Friend WithEvents lbl5G As System.Windows.Forms.Label
    Friend WithEvents lbl2G As System.Windows.Forms.Label
    Friend WithEvents lbl1G As System.Windows.Forms.Label
    Friend WithEvents lbl9H As System.Windows.Forms.Label
    Friend WithEvents lbl8H As System.Windows.Forms.Label
    Friend WithEvents lbl7H As System.Windows.Forms.Label
    Friend WithEvents lbl4H As System.Windows.Forms.Label
    Friend WithEvents lbl6H As System.Windows.Forms.Label
    Friend WithEvents lbl3H As System.Windows.Forms.Label
    Friend WithEvents lbl5H As System.Windows.Forms.Label
    Friend WithEvents lbl2H As System.Windows.Forms.Label
    Friend WithEvents lbl1H As System.Windows.Forms.Label
    Friend WithEvents lbl9I As System.Windows.Forms.Label
    Friend WithEvents lbl8I As System.Windows.Forms.Label
    Friend WithEvents lbl7I As System.Windows.Forms.Label
    Friend WithEvents lbl4I As System.Windows.Forms.Label
    Friend WithEvents lbl6I As System.Windows.Forms.Label
    Friend WithEvents lbl3I As System.Windows.Forms.Label
    Friend WithEvents lbl5I As System.Windows.Forms.Label
    Friend WithEvents lbl2I As System.Windows.Forms.Label
    Friend WithEvents lbl1I As System.Windows.Forms.Label

End Class
