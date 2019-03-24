
Imports System.Data.OleDb
Public Class jobs

    Private Sub jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            ds.Tables.Add(dt)
            Dim Command As String
            Dim connection As New OleDbConnection(con)

            Command = "select *  from student s,company c where s.tenth >= c.tenthmk and s.twelth >=c.twelthmk and s.mark >=c.mark and s.noarrears <= c.noarrears and s.placed ='n'"
            da = New OleDbDataAdapter(Command, connection)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            ds.Tables.Add(dt)
            Dim Command As String
            Dim connection As New OleDbConnection(con)

            Command = "select *  from student s,company c where s.tenth >= c.tenthmk and s.twelth >=c.twelthmk and s.mark >=c.mark and s.noarrears >= c.noarrears and s.placed ='y'"
            da = New OleDbDataAdapter(Command, connection)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            ds.Tables.Add(dt)
            Dim Command As String
            Dim connection As New OleDbConnection(con)

            Command = "select *  from student s,company c where s.tenth >= c.tenthmk and s.twelth >=c.twelthmk and s.mark >=c.mark and s.noarrears >= c.noarrears and s.placed ='n'"
            da = New OleDbDataAdapter(Command, connection)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class