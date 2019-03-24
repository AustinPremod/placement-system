Imports System.Data.OleDb
Public Class companyadd

    Private Sub CompanyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompanyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompanyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub companyadd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        company.Show()
    End Sub

    Private Sub companyadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.DatabaseDataSet.company)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database.accdb"
            Dim connection As New OleDbConnection(con)
            connection.Open()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO company VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')", connection)
            cmd.ExecuteNonQuery()
            MsgBox("company Registered Successfully")
            connection.Close()
        Catch ex As Exception
            MsgBox("An Error connecting Database  :" & vbCrLf & ex.Message)
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "n" Then
            TextBox7.Text = 0
            TextBox7.Enabled = False
        Else
            TextBox7.Enabled = True
        End If
    End Sub
End Class