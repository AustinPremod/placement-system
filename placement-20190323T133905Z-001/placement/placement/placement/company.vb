
Imports System.Data.OleDb
Public Class company

    Private Sub company_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.DatabaseDataSet.company)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        companyadd.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            CompanyBindingSource.EndEdit()
            CompanyTableAdapter.Update(DatabaseDataSet.company)
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            CompanyBindingSource.RemoveCurrent()
            CompanyTableAdapter.Update(DatabaseDataSet.company)
            MsgBox("Removed Successfully")
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            ds.Tables.Add(dt)
            Dim Command As String
            Dim connection As New OleDbConnection(con)
            Command = "select * from company where compname ='" & TextBox1.Text & "'"
            da = New OleDbDataAdapter(Command, connection)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub
End Class