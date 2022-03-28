Imports System.Data.SQLite
Imports System.IO

Public Class MainForm

    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        ''==================================================================================================
        ''================= FOLDER DIRECTORY CHECK =========================================================
        Dim file As String = "ACCOUNTBOOK.db"
        Dim folder As String = "C:\Account Basic"
        Dim fullPath As String = System.IO.Path.Combine(folder, file)
        If folderPub(folder) Then
            Exit Sub
        Else
            Dim di As DirectoryInfo = Directory.CreateDirectory(folder)
        End If
        If duplicateDataBase(fullPath) Then
            load2()
            Exit Sub
        Else
            Dim Initiate As New Initiate
            Initiate.createDatabase()
        End If

        Return
    End Sub
    Public Sub MainformShow(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim str As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"
        Dim strSQL As String
        Dim con As New SQLiteConnection(str)
        Dim oCmd As New SQLiteCommand(con)
        Dim RecCount As Integer
        ' SQL Statement
        strSQL = "SELECT COUNT(*) AS RecCount FROM MyCompany"
        con.Open()
        ' Execute SQL statement
        oCmd.CommandText = strSQL
        Try
            RecCount = CInt(oCmd.ExecuteScalar)
        Catch ex As Exception

        End Try

        If RecCount = 0 Then
            ' Table is empty
            DatabaseMake.Show()
        Else
            mycompanyinfo()
        End If
        Timer1.Start()
        Me.load2()

    End Sub

    Public Sub mycompanyinfo() '' load company info to form
        Using SLiteCon As New SQLiteConnection(ConnectionSTR)
            SLiteCon.Open()
            Dim sliteCom As New SQLiteCommand("Select CompanyName, CompanyRegistration from MyCompany", SLiteCon)
            Dim dataadapt As SQLiteDataReader = sliteCom.ExecuteReader

            While dataadapt.Read
                TextBox1_mycompanyname.Text = dataadapt("CompanyName") '' Int change to string data
                TextBox2_registration_no.Text = dataadapt("CompanyRegistration")

            End While
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Today As Object
        Today = Now
        Time_stat.Text = Format(Today, "dd / MMMM / yyyy h:mm:ss tt")

    End Sub
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function
    Private Function folderPub(folder As String) As Boolean
        Return System.IO.Directory.Exists(folder)
    End Function
    ''=======================================================================================================================
    ''========================== MAIN PAGE INVENTORY + SUPPLIER VIEW =========================================================================

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DatabaseMake.Show()
    End Sub

    Private Sub Button_Add_Item_Form_Click(sender As Object, e As EventArgs) Handles Button_Add_Item_Form.Click
        Add_Inventory.Show()
    End Sub

    Private Sub Button_Update_Item_Click(sender As Object, e As EventArgs) Handles Button_Update_Item.Click
        UpdateItemView.Show()
    End Sub

    Private Sub Button_Delete_Item_Record_Click(sender As Object, e As EventArgs) Handles Button_Delete_Item_Record.Click
        DeleteItemView.Show()
    End Sub

    Private Sub Supplier_add_supplier_Click_1(sender As Object, e As EventArgs) Handles Supplier_add_supplier.Click
        Add_Supplier.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateSupplierView.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteSupplierView.Show()
    End Sub

    Public Sub load2()
        'Hide the last blank line.
        DataGrid_Main_Inventory.AllowUserToAddRows = False

        'Clear Columns.
        DataGrid_Main_Inventory.Columns.Clear()
        Dim name As DataGridViewColumn = New DataGridViewTextBoxColumn()
        name.HeaderText = "Code"
        name.Name = "Code"
        name.DataPropertyName = "Code"
        name.Width = 50
        DataGrid_Main_Inventory.Columns.Insert(0, name)


        Dim ProductName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        ProductName.HeaderText = "Product Name"
        ProductName.Name = "Product Name"
        ProductName.DataPropertyName = "ProductName"
        ProductName.Width = 200
        DataGrid_Main_Inventory.Columns.Insert(1, ProductName)

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.HeaderText = "Company ID"
        Company_Id.Name = "CompanyID"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DataGrid_Main_Inventory.Columns.Insert(2, Company_Id)
        DataGrid_Main_Inventory.Columns("CompanyID").ValueType = GetType(String)

        Dim Item_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Item_Id.HeaderText = "Item ID"
        Item_Id.Name = "ItemID"
        Item_Id.DataPropertyName = "Item_Id"
        Item_Id.Width = 50
        DataGrid_Main_Inventory.Columns.Insert(3, Item_Id)
        DataGrid_Main_Inventory.Columns("ItemID").ValueType = GetType(String)
        DataGrid_Main_Inventory.Columns("ItemID").DefaultCellStyle.Format = ""

        Dim Quantity As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.DataPropertyName = "Quantity"
        Quantity.Width = 50
        DataGrid_Main_Inventory.Columns.Insert(4, Quantity)

        Dim UnitPrice As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitPrice.HeaderText = "Unit Price"
        UnitPrice.Name = "UnitPrice"
        UnitPrice.DataPropertyName = "UnitPrice"
        UnitPrice.Width = 50
        DataGrid_Main_Inventory.Columns.Insert(5, UnitPrice)
        DataGrid_Main_Inventory.Columns("UnitPrice").ValueType = GetType(FormatNumber)
        DataGrid_Main_Inventory.Columns("UnitPrice").DefaultCellStyle.Format = "N2"

        Dim UnitTax As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitTax.HeaderText = "Unit Tax"
        UnitTax.Name = "Unit Tax"
        UnitTax.DataPropertyName = "UnitTax"
        UnitTax.Width = 50
        DataGrid_Main_Inventory.Columns.Insert(6, UnitTax)

        DataGrid_Main_Inventory.DataSource = Nothing

        Using Con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
            Using cmd As SQLiteCommand = New SQLiteCommand("Select Item_Id, Code, ProductName, Company_Id, Quantity, UnitPrice, UnitTax FROM Inventory", Con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As DataTable = New DataTable()
                        Try
                            Con.Open()
                            sda.Fill(dt)
                            DataGrid_Main_Inventory.DataSource = dt
                        Catch ex As Exception
                        End Try
                    End Using
                End Using
            End Using
        End Using
        Me.Refresh()
    End Sub

    Public Sub load3()
        Using Cons As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
            Using cmds As SQLiteCommand = New SQLiteCommand("Select Company_Id, Registration, CompanyName, CompanyAddress, CompanyTelephone from Supplier", Cons)
                cmds.CommandType = CommandType.Text
                Using sdas As SQLiteDataAdapter = New SQLiteDataAdapter(cmds)
                    Using dts As DataTable = New DataTable()
                        Try
                            Cons.Open()
                            sdas.Fill(dts)
                            DataGrid_Main_Supplier.DataSource = dts
                        Catch ex As Exception
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub MainForm_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        load2()
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Name = "supplier" Then
            load3()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Refresh()
    End Sub
End Class

