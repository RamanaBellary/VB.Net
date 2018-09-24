Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading

Public Class Form1
    Private connectionString As String
    Private sda As SqlDataAdapter
    Private ds As DataSet
    Private con As SqlConnection
    Private tran As SqlTransaction

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = ConfigurationManager.ConnectionStrings("SampleDB").ConnectionString
        con = New SqlConnection(connectionString)
        btnLoad.Enabled = True
        btnUpdate.Enabled = False
        btnRollback.Enabled = False
        btnCommit.Enabled = False
        'UsingDataAdapter()
        'UsingStoredProcedure()
        'UsingSqlCommandBuilder()
    End Sub

    Private Sub Form1_Closing(sender As Object, args As EventArgs) Handles MyBase.FormClosing
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub UsingDataAdapter()
        Try
            Using sda = New SqlDataAdapter("select * from tCustomers", con)
                Dim ds As New DataSet
                sda.Fill(ds)
                dgv1.DataSource = ds.Tables(0)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UsingStoredProcedure()
        Try
            Dim cmd As New SqlCommand("GetCustomer", con)
            cmd.Parameters.AddWithValue("@CustomerID", 1)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            'Dim source As New BindingSource
            'source.DataSource = cmd.ExecuteReader()
            'DataGridView1.DataSource = source
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader)
            dgv1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UsingSqlCommandBuilder()
        If con.State = ConnectionState.Closed Then
            con.Open()
            tran = con.BeginTransaction()
        End If
        Dim sqlCmd = New SqlCommand("select * from tCustomers", con, tran)
        sda = New SqlDataAdapter(sqlCmd)
        ds = New DataSet
        sda.Fill(ds)
        dgv1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim scb As New SqlCommandBuilder(sda)
        sda.Update(ds)
        btnRollback.Enabled = True
        btnCommit.Enabled = True
        btnUpdate.Enabled = False
        btnLoad.Enabled = False
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Try
            tran.Commit()
            con.Close()
            btnLoad.Enabled = True
            btnUpdate.Enabled = False
            btnCommit.Enabled = False
            btnRollback.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRollback_Click(sender As Object, e As EventArgs) Handles btnRollback.Click
        Try
            tran.Rollback()
            con.Close()
            btnLoad.Enabled = True
            btnUpdate.Enabled = False
            btnRollback.Enabled = False
            btnCommit.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        UsingSqlCommandBuilder()
        btnLoad.Enabled = False
        btnRollback.Enabled = False
        btnCommit.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnBulkCopy_Click(sender As Object, e As EventArgs) Handles btnBulkCopy.Click
        bulkCopy()
        lblStatus.Text = "Bulk Copying.."
    End Sub

    Private Async Sub bulkCopy()
        Await Task.Run(Sub()
                           Try
                               Thread.Sleep(5000)
                               Dim dt As New DataTable
                               dt.Columns.Add("CustomerName")
                               dt.Columns.Add("Age")
                               dt.Columns.Add("Address")
                               dt.Columns.Add("Gender")
                               Dim dr As DataRow = dt.NewRow()
                               dr("CustomerName") = "Ramana"
                               dr("Age") = 34
                               dr("Address") = "Bangalore"
                               dr("Gender") = "M"
                               dt.Rows.Add(dr)

                               dr = dt.NewRow()
                               dr("CustomerName") = "Mounika"
                               dr("Age") = 24
                               dr("Address") = "Bangalore"
                               dr("Gender") = "F"
                               dt.Rows.Add(dr)

                               Using bulkCopy As New SqlBulkCopy(con)
                                   bulkCopy.DestinationTableName = "tCustomers"
                                   bulkCopy.ColumnMappings.Add("CustomerName", "CustomerName")
                                   bulkCopy.ColumnMappings.Add("Age", "Age")
                                   bulkCopy.ColumnMappings.Add("Address", "Address")
                                   bulkCopy.ColumnMappings.Add("Gender", "Gender")

                                   If con.State = ConnectionState.Closed Then
                                       con.Open()
                                   End If
                                   bulkCopy.WriteToServerAsync(dt)
                                   lblStatus.Invoke(Sub()
                                                        lblStatus.Text = "Done with bulk copy.."
                                                        Refresh()
                                                    End Sub)

                               End Using
                           Catch ex As Exception
                               MessageBox.Show(ex.Message)
                           End Try
                       End Sub)

    End Sub
End Class
