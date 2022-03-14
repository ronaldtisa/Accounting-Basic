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
                    Using DATATABLE As New DataView
                        Try

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

    End Sub

    Private Sub DGV_Inventory_Update_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Inventory_Update.CellContentClick
        Dim row As DataGridViewRow
        row = DGV_Inventory_Update.Rows(e.RowIndex)
        Dim gridsender = DirectCast(sender, DataGridView)
        If TypeOf gridsender.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
            Try
                Dim UpdateItemView As New UpdateItemView
                If row.Cells(7).Value Is Nothing Then '' cell id
                    UpdateItemView.Update_Winform_TextBox_Item_ID.Text = "No ID?"
                Else
                    UpdateItemView.Update_Winform_TextBox_Item_ID.Text = row.Cells(7).Value.ToString
                End If

                If row.Cells(2).Value Is Nothing Then '' cell code CORRECT
                    UpdateItemView.Update_Winform_TextBox_ItemCode.Text = "No Item Code?"
                Else
                    UpdateItemView.Update_Winform_TextBox_ItemCode.Text = row.Cells(2).Value.ToString
                End If

                If row.Cells(3).Value Is Nothing Then '' cell product CORRECT
                    UpdateItemView.Update_Winform_TextBox_ItemName.Text = "No Product Name?"
                Else
                    UpdateItemView.Update_Winform_TextBox_ItemName.Text = row.Cells(3).Value.ToString
                End If

                If row.Cells(4).Value Is Nothing Then '' cell compabny CORRECT
                    UpdateItemView.Update_Winform_TextBoxID.Text = "No Company Name?"
                Else
                    UpdateItemView.TextBox_Address.Text = row.Cells(4).Value.ToString
                End If

                If row.Cells(8).Value Is Nothing Then '' cell address
                    UpdateItemView.Update_Winform_TextBoxID.Text = "No Address?"
                Else
                    UpdateItemView.TextBox_Address.Text = row.Cells(8).Value.ToString
                End If

                If row.Cells(1).Value Is Nothing Then ''cell telephone
                    UpdateItemView.Update_Winform_TextBoxID.Text = "No Telephone?"
                Else
                    UpdateItemView.Update_Winform_TextBoxTelephone.Text = row.Cells(1).Value.ToString
                End If

                If row.Cells(5).Value Is Nothing Then '' ''cell quantity
                    UpdateItemView.Update_Winform_TextBox_Total_Unit.Text = "No quantity?"
                Else
                    UpdateItemView.Update_Winform_TextBox_Total_Unit.Text = row.Cells(5).Value.ToString
                End If

                If row.Cells(6).Value Is Nothing Then ''cell unitprice
                    UpdateItemView.Update_Winform_TextBox_Unit_Price.Text = "No Unit Price?"
                Else
                    UpdateItemView.Update_Winform_TextBox_Unit_Price.Text = row.Cells(6).Value.ToString
                End If

                If row.Cells(9).Value Is Nothing Then ''cell unittax
                Else
                    UpdateItemView.Update_TextBox_UNITAZX.Text = row.Cells(9).Value.ToString
                End If

                Try
                    UpdateItemView.Show()
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub TabPage_deleteItem_Click(sender As Object, e As EventArgs) Handles TabPage_deleteItem.GotFocus

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
    Dim sql2 As String
    ''================================================================================================
    ''=============================== Inventory update delete search control ================================
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_itemcode.TextChanged
        sql = "SELECT Code, ProductName, Company_Id,  Quantity, UnitPrice, Item_Id,Address, UnitTax Telephone FROM Inventory WHERE Code LIKE '%" & inventory_update_search_itemcode.Text & "%'"
        inventory_update_search_item()
    End Sub
    Private Sub inventory_update_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_ItemName.TextChanged
        sql = "SELECT Code, ProductName, Company_Id,  Quantity, UnitPrice, Item_Id,Address, UnitTax Telephone FROM Inventory WHERE ProductName LIKE '%" & inventory_update_search_ItemName.Text & "%'"
        inventory_update_search_item()
    End Sub

    Private Sub inventory_update_search_item()
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
            DGV_Inventory_Update.DataSource = dt
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        ''  Dim value1 As String = Convert.ToString(dt.Rows(i)("Quantity"))
        ''  Dim value2 As String = Convert.ToString(dt.Rows(i)("UnitPrice"))
        ''  dt.Rows(i)("TotalValue") = value1 * value2
        da.Dispose()

    End Sub


    ''DELETE CONTROL
    Private Sub inventory_delete_search_ItemCode_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemCode.TextChanged
        sql2 = "SELECT Code, ProductName, Company_Id,  Quantity, UnitPrice, Item_Id,Address, UnitTax Telephone FROM Inventory WHERE Code Like '%" & inventory_delete_search_ItemCode.Text & "%'"
        searchData2()
    End Sub
    Private Sub inventory_delete_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemName.TextChanged
        sql2 = "SELECT Code, ProductName, Company_Id,  Quantity, UnitPrice, Item_Id,Address, UnitTax Telephone FROM Inventory WHERE ProductName Like '%" & inventory_delete_search_ItemName.Text & "%'"
        searchData2()
    End Sub
    Dim dtdelete As DataTable
    Dim dadelete As SQLiteDataAdapter
    Private Sub searchData2()
        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql2
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            DGV_Inventory_Delete.DataSource = dt
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        da.Dispose()
    End Sub
    ''================================================================================================
    ''=============================== Inventory update delete search control End=============================

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
        sql = "SELECT * FROM Supplier"
        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            ''   dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                ''.Fill(dt)
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
            ''    dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                ''         .Fill(dt)
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



    Private Sub InventoryControl_tab1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InventoryControl_tab1.SelectedIndexChanged, InventoryControl_tab1.Enter
        If InventoryControl_tab1.SelectedTab Is InventoryControl_tab1.TabPages("TabPage_addItem") Then
            Using con As New SQLiteConnection(ConnectionSTR)
                Using com As New SQLiteCommand("Select Code, ProductName, Company_Id, Quantity, UnitPrice, UnitTax from Inventory", con)
                    com.CommandType = CommandType.Text
                    Using da As New SQLiteDataAdapter(com)
                        Using dtIn As New DataTable
                            con.Open()
                            com.ExecuteNonQuery()
                            da.Fill(dtIn)
                            DataGrid_Main_Inventory.DataSource = dtIn

                        End Using
                    End Using
                End Using
            End Using
        End If
        If InventoryControl_tab1.SelectedTab Is InventoryControl_tab1.TabPages("TabPage_updateItem") Then

        End If

    End Sub

    Private Sub SupplierRecord_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierRecord.SelectedIndexChanged
        If SupplierRecord.SelectedTab Is SupplierRecord.TabPages("AddSupplier") Then
            Using con As New SQLiteConnection(ConnectionSTR)
                Using com As New SQLiteCommand("Select Company_Id, Registration, CompanyName, CompanyAddress, CompanyTelephone from Supplier", con)
                    com.CommandType = CommandType.Text
                    Using da As New SQLiteDataAdapter(com)
                        Using dtIn As New DataTable
                            con.Open()
                            com.ExecuteNonQuery()
                            da.Fill(dtIn)
                            DataGrid_Main_Supplier.DataSource = dtIn

                        End Using
                    End Using
                End Using
            End Using
        End If

        If SupplierRecord.SelectedTab Is SupplierRecord.TabPages("TabPage_UpdateSupplier") Then

        End If

        If SupplierRecord.SelectedTab Is SupplierRecord.TabPages("TabPage_DeleteSuppler") Then

        End If
    End Sub
End Class
