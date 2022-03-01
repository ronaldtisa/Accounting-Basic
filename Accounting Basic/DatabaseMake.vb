Imports System.IO
Imports System.Windows
Imports System.Data.SQLite

Public Class DatabaseMake
    Private Const tblsupplier As String = "Create table 'Supplier'( 'Company_Id' INT,'Registration' NCHAR, 'CompanyName' NCHAR, 'CompanyAddress' NCHAR, 'CompanyTelephone' NCHAR, PRIMARY KEY( Company_Id, CompanyName ));"
    Private Const tblsales As String = "Create table 'Sales'( 'Id_Receipt' INT, 'Date' NUM, 'Item_Id' NCHAR, PRIMARY KEY( Id_Receipt ));"
    Private Const createInventory As String = "CREATE TABLE 'Inventory'( 'Item_Id' INT, 'Code' NCHAR, 'ProductName' NCHAR,'Company_Id' NCHAR, 'Address' NCHAR, 'Telephone' NCHAR, 'Quantity' NCHAR NULL, 'UnitPrice'NUM NULL, 'UnitTax' NUM NULL, PRIMARY KEY( Item_Id ));"
    Private Const tblManagement As String = "Create table 'Management' ( 'Id_UserName' NCHAR, 'ContactNumber' NCHAR, 'Address' NCHAR, 'Duty' NCHAR, PRIMARY KEY ( Id_UserName ));"
    Private Const Login As String = "Create table 'Security' ('Log_Id' INT, 'Name' NCHAR, 'Password' NCHAR, Primary Key(Log_Id))"
    Private Const Company As String = "Create table 'MyCompany'('MyCompany_Id' Int, 'CompanyName' Nchar, 'CompanyRegistration' NChar, 'CompanyAddress' Nchar, 'CompanyTelephone' Nchar, Primary Key( MyCompany_Id ) )"
    Dim result As DialogResult
    ''where to store file
    ''named database
    ''combine database file together
    ''create connection string - using sql
    ' Specify the directory you want to manipulate.
    Private Sub DatabaseMake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = "c:\Accounting Basic"
        ' Determine whether the directory exists.
        If Directory.Exists(path) Then
            Dim message As String = "That path exists already. Use folder? This process is irreversible!"
            Dim caption As String = "Old data detected"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo

            result = MessageBox.Show(message, caption, button)
            If MsgBoxResult.Yes Then
                ' Try to create the directory.
                Dim di As DirectoryInfo = Directory.CreateDirectory(path)
                Dim message3 As String = "Folder path created."
                Dim caption3 As String = "Success"
                Dim button3 As MessageBoxButtons = MessageBoxButtons.OK
                result = MessageBox.Show(message3, caption3, button3)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        createDatabase()
    End Sub
    ''create boolean value
    ''return value if file exist or not
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Dim servercom As New SQLiteCommand
    ''===========================================================
    ''important
    Dim fname As String
    Public Sub createDatabase()
        Dim Dlocation As String = "c:\Accounting Basic"

        Dim fullPath As String = System.IO.Path.Combine(Dlocation, fname)
        Dim connectionString As String = String.Format("Data Source={0}", fullPath)
        Dim result As DialogResult
        '' ================================================================================
        '' create database
        If Not duplicateDataBase(fullPath) Then
            Using servercon As New SQLiteConnection(connectionString)
                servercon.Open()
                Dim cmd As New SQLiteCommand(createInventory, servercon)
                Try
                    cmd.ExecuteNonQuery()
                    Dim message1 As String = "Success creating Inventory"
                    result = MessageBox.Show(message1)
                Catch ex As Exception
                    Dim message2 As String = "Failed creating Inventory list"
                    result = MessageBox.Show(message2)
                End Try
            End Using
            ''============= 2 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblsupplier, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    result = MessageBox.Show("Success creating supplier list")
                Catch ex As Exception
                    result = MessageBox.Show("Failed creating supplier list")
                End Try
            End Using
            ''============= 3 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblsales, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    result = MessageBox.Show("Success creating sales list")
                Catch ex As Exception
                    result = MessageBox.Show("error creating sales list")
                End Try
            End Using
            ''============= 4 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(Login, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    result = MessageBox.Show("Success creating login list")
                Catch ex As Exception
                    result = MessageBox.Show("error creating login list")
                End Try
            End Using

            ''============= 5 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(Company, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    result = MessageBox.Show("Success creating Company Detail")
                Catch ex As Exception
                    result = MessageBox.Show("error creating Company Detail")
                End Try
            End Using
            ''============= 6 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblManagement, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    result = MessageBox.Show("Success creating management list")
                Catch ex As Exception
                    result = MessageBox.Show("error creating management list")
                End Try
                servercon.Close()
            End Using
        End If
        write() ''go next control
    End Sub

    ''====================================================================
    ''write company name to database and other value
    Public Sub write()
        Dim comtext As String
        Dim CompanyId As String
        CompanyId = "CN001"
        Dim connectionSTR As String = "Data Source = c:\Accounting Basic\" + fname
        Using writecon As New SQLiteConnection(connectionSTR)

            Using writecom As New SQLiteCommand("Insert into MyCompany (MyCompany_Id, CompanyName ) Values('" + CompanyId + "','" + AutoDbName.Text & ".db" + "')", writecon)
                writecon.Open()
                Try
                    writecom.ExecuteNonQuery()
                    result = MessageBox.Show("Task Completed. You can now close this window to continue")
                Catch ex As Exception
                End Try
            End Using
        End Using
    End Sub
    ''===================================================

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CompanyName.TextChanged
        '' split and create auto name for database
        Dim str As String
        Dim texboxValue As String
        texboxValue = CompanyName.Text
        str = texboxValue.Split(" ").First()
        AutoDbName.Text = "SLite_" & str
    End Sub

    Private Sub AutoDbName_TextChanged(sender As Object, e As EventArgs) Handles AutoDbName.TextChanged
        fname = AutoDbName.Text & ".db"
    End Sub
End Class
