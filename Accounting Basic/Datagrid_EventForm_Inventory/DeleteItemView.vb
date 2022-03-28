Imports System.Data.SQLite

Public Class DeleteItemView
    Dim con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql2 As String
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"

    Private Sub inventory_delete_search_ItemCode_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemCode.TextChanged
        If inventory_delete_search_ItemCode.Text.Trim = "" Then
            sql2 = "SELECT Code, ProductName, Company_Id, Item_Id, Quantity, UnitPrice, UnitTax FROM Inventory"
            searchData2()
        Else
            sql2 = "SELECT Code, ProductName, Company_Id, Item_Id, Quantity, UnitPrice, UnitTax FROM Inventory WHERE Code Like '%" & inventory_delete_search_ItemCode.Text & "%'"
            searchData2()
        End If
    End Sub
    Private Sub inventory_delete_search_ItemName_TextChanged(sender As Object, e As EventArgs) Handles inventory_delete_search_ItemName.TextChanged
        If inventory_delete_search_ItemName.Text.Trim = "" Then
            Exit Sub
        End If
        sql2 = "SELECT Code, ProductName, Company_Id, Item_Id, Quantity, UnitPrice, UnitTax FROM Inventory WHERE ProductName Like '%" & inventory_delete_search_ItemName.Text & "%'"
        searchData2()
    End Sub
    Private Sub searchData2()
        'Hide the last blank line.
        DGV_Inventory_Delete.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Inventory_Delete.Columns.Clear()
        Dim name As DataGridViewColumn = New DataGridViewTextBoxColumn()
        name.HeaderText = "Code"
        name.Name = "Code"
        name.DataPropertyName = "Code"
        name.Width = 100
        DGV_Inventory_Delete.Columns.Insert(0, name)

        Dim ProductName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        ProductName.HeaderText = "Product Name"
        ProductName.Name = "Product Name"
        ProductName.DataPropertyName = "ProductName"
        ProductName.Width = 100
        DGV_Inventory_Delete.Columns.Insert(1, ProductName)

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.HeaderText = "Company ID"
        Company_Id.Name = "Company ID"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Inventory_Delete.Columns.Insert(2, Company_Id)


        Dim Item_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Item_Id.HeaderText = "Item ID"
        Item_Id.Name = "Item ID"
        Item_Id.DataPropertyName = "Item_Id"
        Item_Id.Width = 100
        DGV_Inventory_Delete.Columns.Insert(3, Item_Id)

        Dim Quantity As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Quantity.HeaderText = " Quantity"
        Quantity.Name = " Quantity"
        Quantity.DataPropertyName = "Quantity"
        Quantity.Width = 100
        DGV_Inventory_Delete.Columns.Insert(4, Quantity)

        Dim UnitPrice As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitPrice.HeaderText = " Unit Price"
        UnitPrice.Name = " Unit Price"
        UnitPrice.DataPropertyName = "UnitPrice"
        UnitPrice.Width = 100
        DGV_Inventory_Delete.Columns.Insert(5, UnitPrice)

        Dim UnitTax As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitTax.HeaderText = " Unit Tax"
        UnitTax.Name = " Unit Tax"
        UnitTax.DataPropertyName = "UnitTax"
        UnitTax.Width = 100
        DGV_Inventory_Delete.Columns.Insert(6, UnitTax)

        DGV_Inventory_Delete.DataSource = Nothing
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
        Dim DeleteButton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        DeleteButton.HeaderText = ""
        DeleteButton.Name = "DeleteButton"
        DeleteButton.DataPropertyName = "DeleteButton"
        DeleteButton.Width = 60
        DeleteButton.UseColumnTextForButtonValue = True
        DeleteButton.Text = "Select"
        DGV_Inventory_Delete.Columns.Insert(7, DeleteButton)
    End Sub

    Private Sub DGV_Inventory_Delete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Inventory_Delete.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim row As DataGridViewRow
        row = DGV_Inventory_Delete.Rows(index)
        If e.ColumnIndex = 7 Then
            Try

                TextBox_ItemCode.Text = row.Cells(0).Value.ToString
                TextBox_ItemName.Text = row.Cells(1).Value.ToString
                TextBoxID.Text = row.Cells(2).Value.ToString
                TextBox_ItemID.Text = row.Cells(3).Value.ToString
                TextBox_Total_Unit.Text = row.Cells(4).Value.ToString
                TextBox_Unit_Price.Text = row.Cells(5).Value.ToString
                ''  Update_TextBox_UNITAZX.Text = row.Cells(6).Value.ToString

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim row As DataGridViewRow
        row = DGV_Inventory_Delete.Rows(index)
        If MessageBox.Show(String.Format("Do you want to delete This Item?: {0}", row.Cells("Code").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using con As New SQLiteConnection(ConnectionSTR)
                Using cmd As New SQLiteCommand("DELETE FROM Inventory WHERE Code = @Code", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@Code", row.Cells("Code").Value)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
            Me.Refresh()
        End If
    End Sub
End Class