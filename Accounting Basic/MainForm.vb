Imports System.Data.SQLite
Imports System.IO

Public Class MainForm
    Dim con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim sql2 As String
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
    ''=====================================================================================================================================
    ''========================== MAIN PAGE INVENTORY + SUPPLIER VIEW CODE END==============================================================
    Private Sub Supplier_add_supplier_Click(sender As Object, e As EventArgs) Handles Supplier_add_supplier.Click
        Add_Supplier.Show()
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

    '' tab control

    Private Sub InventoryControl_tab1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ''     If InventoryControl_tab1.SelectedTab Is InventoryControl_tab1.TabPages("TabPage_addItem") Then
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
        ''    End If
        ''    If InventoryControl_tab1.SelectedTab Is InventoryControl_tab1.TabPages("TabPage_updateItem") Then

        ''   End If

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
    Private Sub Button_Add_Item_Form_Click(sender As Object, e As EventArgs) Handles Button_Add_Item_Form.Click
        Add_Inventory.Show()
    End Sub

    Private Sub Button_Update_Item_Click(sender As Object, e As EventArgs) Handles Button_Update_Item.Click
        UpdateItemView.Show()
    End Sub

    Private Sub Button_Delete_Item_Record_Click(sender As Object, e As EventArgs) Handles Button_Delete_Item_Record.Click
        DeleteItemView.Show()
    End Sub
End Class
