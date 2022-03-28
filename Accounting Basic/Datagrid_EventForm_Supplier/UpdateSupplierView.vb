Imports System.Data.SQLite

Public Class UpdateSupplierView
    Dim con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim sql2 As String
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"

    Private Sub txtbx_supplier_update_TextChanged(sender As Object, e As EventArgs) Handles txtbx_supplier_update.TextChanged
        Sql = "SELECT * FROM Supplier WHERE CompanyName LIKE '%" & txtbx_supplier_update.Text & "%'"
        search_update_supplier()
    End Sub
    Private Sub search_update_supplier()
        DGV_Supplier_Update.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Supplier_Update.Columns.Clear()

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.HeaderText = "Company ID"
        Company_Id.Name = "Company ID"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Supplier_Update.Columns.Insert(0, Company_Id)


        Dim Registration As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Registration.HeaderText = "Registration"
        Registration.Name = "Registration"
        Registration.DataPropertyName = "Registration"
        Registration.Width = 100
        DGV_Supplier_Update.Columns.Insert(1, Registration)

        Dim CompanyName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyName.HeaderText = "Company Name"
        CompanyName.Name = "Company Name"
        CompanyName.DataPropertyName = "CompanyName"
        CompanyName.Width = 100
        DGV_Supplier_Update.Columns.Insert(2, CompanyName)


        Dim CompanyAddress As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyAddress.HeaderText = "Company Address"
        CompanyAddress.Name = "CompanyAddress"
        CompanyAddress.DataPropertyName = "CompanyAddress"
        CompanyAddress.Width = 100
        DGV_Supplier_Update.Columns.Insert(3, CompanyAddress)


        Dim CompanyTelephone As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyTelephone.HeaderText = "Company Telephone"
        CompanyTelephone.Name = "CompanyTelephone"
        CompanyTelephone.DataPropertyName = "CompanyTelephone"
        CompanyTelephone.Width = 100
        DGV_Supplier_Update.Columns.Insert(4, CompanyTelephone)

        Dim CashFLOW As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CashFLOW.HeaderText = "Cash"
        CashFLOW.Name = "CashFLOW"
        CashFLOW.DataPropertyName = "CashFLOW"
        CashFLOW.Width = 100
        DGV_Supplier_Update.Columns.Insert(5, CashFLOW)

        DGV_Supplier_Update.DataSource = Nothing
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
            DGV_Supplier_Update.DataSource = dt
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
        buttonColumn.Text = "Select"
        buttonColumn.UseColumnTextForButtonValue = True
        buttonColumn.DataPropertyName = "buttonColumn"
        DGV_Supplier_Update.Columns.Insert(6, buttonColumn)

        da.Dispose()
    End Sub

    Private Sub DGV_Supplier_Update_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Supplier_Update.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim row As DataGridViewRow
        row = DGV_Supplier_Update.Rows(index)
        If e.ColumnIndex = 6 Then
            Try

                TextBox_supplier_ID.Text = row.Cells(0).Value.ToString
                TextBox_add_supplier_companyregistration.Text = row.Cells(1).Value.ToString
                TextBox_add_supplier_companyname.Text = row.Cells(2).Value.ToString
                TextBox_add_supplier_address.Text = row.Cells(3).Value.ToString
                TextBox_add_supplier_telephone.Text = row.Cells(4).Value.ToString
                TextBox_Supplier_add_cash.Text = row.Cells(5).Value.ToString

            Catch ex As Exception
            End Try
        End If
    End Sub
End Class