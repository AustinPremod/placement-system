Imports System.Data.OleDb
Public Class students
    Dim str As String = "server=localhost;uid=root;pwd=;database=placement"

    Sub studentsload()
        

    End Sub

    Private Sub students_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub students_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DatabaseDataSet.student)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        studentadd.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            StudentBindingSource.EndEdit()
            StudentTableAdapter.Update(DatabaseDataSet.student)
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            StudentBindingSource.RemoveCurrent()
            StudentTableAdapter.Update(DatabaseDataSet.student)
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
            Command = "select * from student where nam ='" & TextBox1.Text & "'"
            da = New OleDbDataAdapter(Command, connection)
            da.Fill(dt)
            StudentDataGridView.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub


    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.Text = "QUALIFIED" Then
            Try
                Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
                Dim ds As New DataSet
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                ds.Tables.Add(dt)
                Dim Command As String
                Dim connection As New OleDbConnection(con)

                Command = "select * from student s,company c where s.tenth >= c.tenthmk and s.twelth >=c.twelthmk and s.mark >=c.mark and s.noarrears <= c.noarrears and s.placed ='n'"
                da = New OleDbDataAdapter(Command, connection)
                da.Fill(dt)
                StudentDataGridView.DataSource = dt
            Catch ex As Exception
            End Try
        ElseIf ComboBox1.Text = "NON QUALIFIED" Then
            Try
                Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
                Dim ds As New DataSet
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                ds.Tables.Add(dt)
                Dim Command As String
                Dim connection As New OleDbConnection(con)
                Command = "select *  from student s,company c where s.tenth < c.tenthmk and s.twelth < c.twelthmk and s.mark < c.mark and s.noarrears < c.noarrears or s.placed ='y'"
                da = New OleDbDataAdapter(Command, connection)
                da.Fill(dt)
                StudentDataGridView.DataSource = dt
            Catch ex As Exception
            End Try
        Else
            Try
                Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
                Dim ds As New DataSet
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                ds.Tables.Add(dt)
                Dim Command As String
                Dim connection As New OleDbConnection(con)
                Command = "select *  from student"
                da = New OleDbDataAdapter(Command, connection)
                da.Fill(dt)
                StudentDataGridView.DataSource = dt
            Catch ex As Exception
            End Try
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class