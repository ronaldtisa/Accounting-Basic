Imports System.Data.SQLite

Public Class UpdateItemView
    Dim dgv As New MainForm
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"
    Private Sub UpdateItemView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Dim data2 As DataTable = Load_Company_List()
        '' ComboBox_Company_list.DataSource = data2
        '' ComboBox_Company_list.DisplayMember = "CompanyName"
        '' ComboBox_Company_list.ValueMember = "Company_Id"
    End Sub

    Private Sub UpdateItemView_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim dataset3 As New DataTable
        Try
            Using SLiteCon As New SQLiteConnection(ConnectionSTR)
                SLiteCon.Open()
                Dim sliteCom As New SQLiteCommand("SELECT * From Supplier where CompanyName LIKE '" + Update_item_TextBox_CompanyName.Text + "'", SLiteCon)
                Dim dataadapt As SQLiteDataReader = sliteCom.ExecuteReader
                While dataadapt.Read
                    Update_Winform_TextBox_Company_ID.Text = dataadapt("Company_Id")
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DGV_Inventory_Update_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Inventory_Update.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim row As DataGridViewRow
        row = DGV_Inventory_Update.Rows(index)
        If e.ColumnIndex = 7 Then
            Try
                Update_Winform_TextBox_Item_ID.Text = row.Cells(3).Value.ToString
                Update_Winform_TextBox_ItemCode.Text = row.Cells(0).Value.ToString
                Update_Winform_TextBox_ItemName.Text = row.Cells(1).Value.ToString
                Update_Winform_TextBox_Company_ID.Text = row.Cells(2).Value.ToString
                Update_Winform_TextBox_Total_Unit.Text = row.Cells(4).Value.ToString
                Update_Winform_TextBox_Unit_Price.Text = row.Cells(5).Value.ToString
                Update_TextBox_UNITAZX.Text = row.Cells(6).Value.ToString
                Try
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
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
    ''update control
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_itemcode.TextChanged
        sql = "SELECT Code, ProductName, Company_Id, Item_Id, Quantity, UnitPrice, UnitTax FROM Inventory WHERE Code LIKE '%" & inventory_update_search_itemcode.Text & "%'"
        inventory_update_search_item()
    End Sub
    Private Sub inventory_update_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_update_search_ItemName.TextChanged
        sql = "SELECT Code, ProductName, Company_Id, Item_Id, Quantity, UnitPrice, UnitTax FROM Inventory WHERE ProductName LIKE '%" & inventory_update_search_ItemName.Text & "%'"
        inventory_update_search_item()
    End Sub
    Private Sub inventory_update_search_item()
        'Hide the last blank line.
        DGV_Inventory_Update.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Inventory_Update.Columns.Clear()
        Dim name As DataGridViewColumn = New DataGridViewTextBoxColumn()
        name.HeaderText = "Code"
        name.Name = "Code"
        name.DataPropertyName = "Code"
        name.Width = 100
        DGV_Inventory_Update.Columns.Insert(0, name)

        Dim ProductName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        ProductName.HeaderText = "Product Name"
        ProductName.Name = "Product Name"
        ProductName.DataPropertyName = "ProductName"
        ProductName.Width = 100
        DGV_Inventory_Update.Columns.Insert(1, ProductName)

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.HeaderText = "Company ID"
        Company_Id.Name = "Company ID"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(2, Company_Id)

        Dim Item_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Item_Id.HeaderText = "Item ID"
        Item_Id.Name = "Item ID"
        Item_Id.DataPropertyName = "Item_Id"
        Item_Id.Width = 100
        DGV_Inventory_Update.Columns.Insert(3, Item_Id)

        Dim Quantity As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Quantity.HeaderText = " Quantity"
        Quantity.Name = " Quantity"
        Quantity.DataPropertyName = "Quantity"
        Quantity.Width = 100
        DGV_Inventory_Update.Columns.Insert(4, Quantity)

        Dim UnitPrice As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitPrice.HeaderText = " Unit Price"
        UnitPrice.Name = " Unit Price"
        UnitPrice.DataPropertyName = "UnitPrice"
        UnitPrice.Width = 100
        DGV_Inventory_Update.Columns.Insert(5, UnitPrice)

        Dim UnitTax As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitTax.HeaderText = " Unit Tax"
        UnitTax.Name = " Unit Tax"
        UnitTax.DataPropertyName = "UnitTax"
        UnitTax.Width = 100

        DGV_Inventory_Update.Columns.Insert(6, UnitTax)

        DGV_Inventory_Update.DataSource = Nothing
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
        Dim UpdateButton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        UpdateButton.HeaderText = ""
        UpdateButton.Name = " UpdateButton"
        UpdateButton.DataPropertyName = " UpdateButton"
        UpdateButton.Width = 60
        UpdateButton.Text = "Select"
        UpdateButton.UseColumnTextForButtonValue = True
        DGV_Inventory_Update.Columns.Insert(7, UpdateButton)
    End Sub

End Class