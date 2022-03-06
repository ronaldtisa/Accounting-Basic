Imports System.Data.SQLite
Imports System.IO

Public Class MainForm
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Exit Sub
        Else
            Dim Initiate As New Initiate
            Initiate.createDatabase()
        End If
        Return

    End Sub
    ''================================================================================================
    ''refresh 
    Public Sub refreshAlldatagrid()
        '' UpdateTable(ds)
        ''rebind the DGV
        ''  dgv_items.DataSource = GetData()
    End Sub

    Public Sub MainformShow() Handles MyBase.Shown
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
        RecCount = CInt(oCmd.ExecuteScalar)
        If RecCount = 0 Then
            ' Table is empty
            DatabaseMake.Show()
        End If
        Timer1.Start()
        Main_Page_Inventory()
        Main_Page_Supplier()
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

    Public Sub Main_Page_Inventory()
        ''INVENTORY======================================================================================================
        Using SLITECONNECTION_M As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
            Using SLITECOMMAND As SQLiteCommand = New SQLiteCommand("Select Code, ProductName, Company_Id, Quantity, UnitPrice from Inventory", SLITECONNECTION_M)
                SLITECOMMAND.CommandType = CommandType.Text
                Using DTA As SQLiteDataAdapter = New SQLiteDataAdapter(SLITECOMMAND)
                    Using DATATABLE As New DataTable
                        Try
                            DTA.Fill(DATATABLE)
                            DataGrid_Main_Inventory.DataSource = DATATABLE
                        Catch ex As Exception

                        End Try



                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub Main_Page_Supplier()
        ''SUPPLIER=======================================================================================================
        Using SLITECONNECTION_M As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
            Using SLITECOMMAND As SQLiteCommand = New SQLiteCommand("Select Company_Id, CompanyName, CompanyTelephone From Supplier", SLITECONNECTION_M)
                SLITECOMMAND.CommandType = CommandType.Text
                Using DTA As SQLiteDataAdapter = New SQLiteDataAdapter(SLITECOMMAND)
                    Using DATATABLE As New DataTable
                        Try
                            DTA.Fill(DATATABLE)
                            DataGrid_Main_Supplier.DataSource = DATATABLE
                        Catch ex As Exception
                        End Try

                    End Using
                End Using
            End Using
        End Using
    End Sub
    ''=====================================================================================================================================
    ''========================== MAIN PAGE INVENTORY + SUPPLIER VIEW CODE END==============================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_Inventory.Show()
    End Sub
    Private Sub Supplier_add_supplier_Click(sender As Object, e As EventArgs) Handles Supplier_add_supplier.Click
        Add_Supplier.Show()
    End Sub

    ''=====================================================================================================================================
    ''========================== INVENTORY CONTROL CODE ===================================================================================
    Private Sub TabPage_updateItem_Click(sender As Object, e As EventArgs) Handles TabPage_updateItem.GotFocus
        DGV_Inventory_Update.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Inventory_Update.Columns.Clear()

        'Add Columns.
        Dim Item_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Item_Id.Name = "Item_Id"
        Item_Id.HeaderText = "Item ID"
        Item_Id.DataPropertyName = "Item_Id"
        Item_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(0, Item_Id)

        Dim name As DataGridViewColumn = New DataGridViewTextBoxColumn()
        name.HeaderText = "ProductName"
        name.Name = "Product Name"
        name.DataPropertyName = "ProductName"
        name.Width = 100
        DGV_Inventory_Update.Columns.Insert(1, name)

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.Name = "Company_Id"
        Company_Id.HeaderText = "Company Id"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(2, Company_Id)

        Dim Address As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Address.Name = "Address"
        Address.HeaderText = "Address"
        Address.DataPropertyName = "Address"
        Address.Width = 100
        DGV_Inventory_Update.Columns.Insert(3, Address)

        'Bind the DataGridView.
        DGV_Inventory_Update.DataSource = Nothing
        Using con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)

            Using cmd As SQLiteCommand = New SQLiteCommand("SELECT Item_Id, Code , ProductName, Company_Id, Address, Telephone, Quantity, UnitPrice, UnitTax From Inventory", con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As DataTable = New DataTable()
                        sda.Fill(dt)
                        DGV_Inventory_Update.DataSource = dt
                    End Using
                End Using
            End Using
        End Using

        'Add the Button Column.
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Update"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Update.Columns.Insert(4, buttonColumn)
    End Sub

    Private Sub DGV_Inventory_Update_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Inventory_Update.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim row As DataGridViewRow = DGV_Inventory_Update.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete Customer ID: {0}", row.Cells("CustomerId").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SQLiteConnection(ConnectionSTR)
                    Using cmd As New SQLiteCommand("DELETE FROM Customers WHERE CustomerId = @CustomerId", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@CustomerId", row.Cells("CustomerId").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.TabPage_deleteItem.Refresh()
            End If
        End If
    End Sub
    Private Sub TabPage_deleteItem_Click(sender As Object, e As EventArgs) Handles TabPage_deleteItem.GotFocus
        DGV_Inventory_Update.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Inventory_Update.Columns.Clear()

        'Add Columns.
        Dim Item_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Item_Id.Name = "Item_Id"
        Item_Id.HeaderText = "Item ID"
        Item_Id.DataPropertyName = "Item_Id"
        Item_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(0, Item_Id)

        Dim name As DataGridViewColumn = New DataGridViewTextBoxColumn()
        name.HeaderText = "ProductName"
        name.Name = "Product Name"
        name.DataPropertyName = "ProductName"
        name.Width = 100
        DGV_Inventory_Update.Columns.Insert(1, name)

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.Name = "Company_Id"
        Company_Id.HeaderText = "Company Id"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(2, Company_Id)

        Dim Address As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Address.Name = "Address"
        Address.HeaderText = "Address"
        Address.DataPropertyName = "Address"
        Address.Width = 100
        DGV_Inventory_Update.Columns.Insert(3, Address)

        'Bind the DataGridView.
        DGV_Inventory_Update.DataSource = Nothing
        Using con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)

            Using cmd As SQLiteCommand = New SQLiteCommand("SELECT Item_Id, Code , ProductName, Company_Id, Address, Telephone, Quantity, UnitPrice, UnitTax From Inventory", con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As DataTable = New DataTable()
                        sda.Fill(dt)
                        DGV_Inventory_Update.DataSource = dt
                    End Using
                End Using
            End Using
        End Using

        'Add the Button Column.
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Update"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Update.Columns.Insert(4, buttonColumn)
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Inventory_Delete.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim row As DataGridViewRow = DGV_Inventory_Update.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete Customer ID: {0}", row.Cells("CustomerId").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SQLiteConnection(ConnectionSTR)
                    Using cmd As New SQLiteCommand("DELETE FROM Customers WHERE CustomerId = @CustomerId", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@CustomerId", row.Cells("CustomerId").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.TabPage_deleteItem.Refresh()
            End If
        End If
    End Sub
    Dim con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_itemcode.TextChanged
        sql = "SELECT * FROM Inventory WHERE Code LIKE '%" & inventory_update_search_itemcode.Text & "%'"
        searchData(sql, DGV_Inventory_Update)
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "Updatebutton"
        buttonColumn.Text = "Update"

        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Update.Columns.Insert(4, buttonColumn)
    End Sub
    Private Sub inventory_update_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_ItemName.TextChanged
        sql = "SELECT * FROM Inventory WHERE ProductName LIKE '%" & inventory_update_search_ItemName.Text & "%'"
        searchData(sql, DGV_Inventory_Update)
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Update"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Update.Columns.Insert(4, buttonColumn)
    End Sub
    Private Sub inventory_delete_search_ItemCode_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemCode.TextChanged
        sql = "SELECT * FROM Inventory WHERE Code LIKE '%" & inventory_delete_search_ItemCode.Text & "%'"
        searchData(sql, DGV_Inventory_Delete)
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Delete.Columns.Insert(4, buttonColumn)
    End Sub
    Private Sub inventory_delete_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemName.TextChanged
        sql = "SELECT * FROM Inventory WHERE ProductName LIKE '%" & inventory_delete_search_ItemName.Text & "%'"
        searchData(sql, DGV_Inventory_Delete)
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Inventory_Delete.Columns.Insert(4, buttonColumn)
    End Sub
    Private Sub searchData(sql As String, dtg As DataGridView)
        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DatabaseMake.Show()
    End Sub

    ''=====================================================================================================================================
    ''========================== INVENTORY CONTROL CODE END================================================================================

    ''=====================================================================================================================================
    ''========================== SUPPLIER CONTROL CODE START================================================================================
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtbx_supplier_update.TextChanged
        sql = "SELECT * FROM Supplier WHERE CompanyName LIKE '%" & txtbx_supplier_update.Text & "%'"
        search_update_supplier(sql, DGV_Supplier_Update)

    End Sub
    Private Sub search_update_supplier(sql As String, dtg As DataGridView)
        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        buttonColumn.DataPropertyName = "buttonColumn"
        DGV_Supplier_Update.Columns.Insert(0, buttonColumn)
        da.Dispose()
    End Sub

    Private Sub txtbx_supplier_delete_TextChanged(sender As Object, e As EventArgs) Handles txtbx_supplier_delete.TextChanged
        sql = "SELECT * FROM Supplier WHERE CompanyName LIKE '%" & txtbx_supplier_update.Text & "%'"
        search_delete_supplier(sql, DGV_Supplier_Delete)
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        DGV_Supplier_Delete.Columns.Insert(0, buttonColumn)
    End Sub
    Private Sub search_delete_supplier(sql As String, dtg As DataGridView)
        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 60
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Delete"
        buttonColumn.UseColumnTextForButtonValue = True
        buttonColumn.DataPropertyName = "buttonColumn"
        DGV_Supplier_Update.Columns.Insert(0, buttonColumn)
        da.Dispose()
    End Sub


End Class
