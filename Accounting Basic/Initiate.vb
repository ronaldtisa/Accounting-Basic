Imports System.Data.SQLite
Imports System.IO
Imports System.Windows
Imports Accounting_Basic
Public Class Initiate

    Private Const tblsupplier As String = "Create table 'Supplier'( 'Company_Id' INT,'Registration' NCHAR, 'CompanyName' NCHAR, 'CompanyAddress' NCHAR, 'CompanyTelephone' NCHAR, 'CashFLOW' NUM, PRIMARY KEY( Company_Id, CompanyName ));"
    Private Const tblsales As String = "Create table 'Sales'( 'Id_Receipt' INT, 'Date' NUM, 'Item_Id' NCHAR, PRIMARY KEY( Id_Receipt ));"
    Private Const createInventory As String = "CREATE TABLE 'Inventory'( 'Item_Id' INT, 'Code' NCHAR, 'ProductName' NCHAR,'Company_Id' NCHAR, 'Address' NCHAR, 'Telephone' NCHAR, 'Quantity' NCHAR NULL, 'UnitPrice'NUM NULL, 'UnitTax' NUM NULL, PRIMARY KEY( Item_Id ));"
    Private Const tblManagement As String = "Create table 'Management' ( 'Id_UserName' NCHAR, 'ContactNumber' NCHAR, 'Address' NCHAR, 'Duty' NCHAR, PRIMARY KEY ( Id_UserName ));"
    Private Const Login As String = "Create table 'Security' ('Log_Id' INT, 'Name' NCHAR, 'Password' NCHAR, Primary Key(Log_Id))"
    Private Const Company As String = "Create table 'MyCompany'('MyCompany_Id' Int, 'CompanyName' Nchar, 'CompanyRegistration' NChar, 'CompanyAddress' Nchar, 'CompanyTelephone' Nchar, 'Tax' NCHAR, 'Currency' NCHAR, Primary Key( MyCompany_Id ) )"

    Public Sub createDatabase()
        Dim file As String = "ACCOUNTBOOK.db"
        Dim folder As String = "C:\Account Basic"
        Dim fullPath As String = System.IO.Path.Combine(folder, file)
        Dim connectionString As String = String.Format("Data Source={0}", fullPath)
        Dim result As DialogResult
        '' ================================================================================
        '' create database
        Using servercon As New SQLiteConnection(connectionString)
            servercon.Open()
            Dim cmd As New SQLiteCommand(createInventory, servercon)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Dim message2 As String = "Failed creating Inventory list"
                result = MessageBox.Show(message2)
            End Try
        End Using
        ''=========================================================
        Using servercon As New SQLiteConnection(connectionString)
            Using servercom = New SQLiteCommand(tblsupplier, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                Catch ex As Exception
                    result = MessageBox.Show("Failed creating supplier list")
                End Try
            End Using
        End Using
        ''=========================================================
        Using servercon As New SQLiteConnection(connectionString)
            Using servercom = New SQLiteCommand(tblsales, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                Catch ex As Exception
                    result = MessageBox.Show("error creating sales list")
                End Try
            End Using
        End Using
        ''=========================================================
        Using servercon As New SQLiteConnection(connectionString)
            Using servercom = New SQLiteCommand(Login, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                Catch ex As Exception
                    result = MessageBox.Show("error creating login list")
                End Try
            End Using
        End Using

        ''=========================================================
        Using servercon As New SQLiteConnection(connectionString)
            Using servercom = New SQLiteCommand(Company, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                Catch ex As Exception
                    result = MessageBox.Show("error creating Company Detail")
                End Try
            End Using
        End Using
        ''=========================================================
        Using servercon As New SQLiteConnection(connectionString)
            Using servercom = New SQLiteCommand(tblManagement, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                Catch ex As Exception
                    result = MessageBox.Show("error creating management list")
                End Try
                servercon.Close()
            End Using
        End Using

    End Sub
End Class
