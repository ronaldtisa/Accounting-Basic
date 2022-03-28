Imports System.Data.SQLite

Public Class DeleteSupplierView
    Dim con As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim sql2 As String
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"

    Private Sub txtbx_supplier_delete_TextChanged(sender As Object, e As EventArgs) Handles txtbx_supplier_delete.TextChanged
        sql = "SELECT * FROM Supplier WHERE CompanyName LIKE '%" & txtbx_supplier_delete.Text & "%'"
        search_delete_supplier()
    End Sub
    Private Sub search_delete_supplier()

        DGV_Supplier_Delete.AllowUserToAddRows = False

        'Clear Columns.
        DGV_Supplier_Delete.Columns.Clear()

        Dim Company_Id As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Company_Id.HeaderText = "Company ID"
        Company_Id.Name = "Company ID"
        Company_Id.DataPropertyName = "Company_Id"
        Company_Id.Width = 100
        DGV_Supplier_Delete.Columns.Insert(0, Company_Id)


        Dim Registration As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Registration.HeaderText = "Registration"
        Registration.Name = "Registration"
        Registration.DataPropertyName = "Registration"
        Registration.Width = 100
        DGV_Supplier_Delete.Columns.Insert(1, Registration)

        Dim CompanyName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyName.HeaderText = "Company Name"
        CompanyName.Name = "Company Name"
        CompanyName.DataPropertyName = "CompanyName"
        CompanyName.Width = 100
        DGV_Supplier_Delete.Columns.Insert(2, CompanyName)


        Dim CompanyAddress As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyAddress.HeaderText = "Company Address"
        CompanyAddress.Name = "CompanyAddress"
        CompanyAddress.DataPropertyName = "CompanyAddress"
        CompanyAddress.Width = 100
        DGV_Supplier_Delete.Columns.Insert(3, CompanyAddress)


        Dim CompanyTelephone As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyTelephone.HeaderText = "Company Telephone"
        CompanyTelephone.Name = "CompanyTelephone"
        CompanyTelephone.DataPropertyName = "CompanyTelephone"
        CompanyTelephone.Width = 100
        DGV_Supplier_Delete.Columns.Insert(4, CompanyTelephone)

        Dim CashFLOW As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CashFLOW.HeaderText = "Cash"
        CashFLOW.Name = "CashFLOW"
        CashFLOW.DataPropertyName = "CashFLOW"
        CashFLOW.Width = 100
        DGV_Supplier_Delete.Columns.Insert(5, CashFLOW)

        DGV_Supplier_Delete.DataSource = Nothing
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
            DGV_Supplier_Delete.DataSource = dt
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
        DGV_Supplier_Delete.Columns.Insert(6, buttonColumn)

    End Sub

    Private Sub Delete_Supplier_Button_Click(sender As Object, e As EventArgs) Handles Delete_Supplier_Button.Click
        Dim rindex As Integer

        Dim row As DataGridViewRow
        row = DGV_Supplier_Delete.Rows(rindex)
        If MessageBox.Show(String.Format("Do you want to delete This Item?: {0}", row.Cells("Code").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using con As New SQLiteConnection(ConnectionSTR)
                    Using cmd As New SQLiteCommand("DELETE FROM Supplier where CompanyName = @CompanyName", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@CompanyName", row.Cells("CompanyName").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.Refresh()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub DGV_Supplier_Delete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Supplier_Delete.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim row As DataGridViewRow
        row = DGV_Supplier_Delete.Rows(index)
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