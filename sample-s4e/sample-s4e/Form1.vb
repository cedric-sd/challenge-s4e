Imports System.Data.SqlClient

Public Class Form1
    Private connection As SqlConnection
    Private command As SqlCommand
    Private dataAdapter As SqlDataAdapter
    Private dataReader As SqlDataReader

    Private sql As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "INSERT INTO associates (Nome,cpf,data_nascimento)
                VALUES (@nome, @cpf, @data_nascimento)"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@nome", inputNome.Text)
            command.Parameters.AddWithValue("@cpf", inputCpf.Text)
            command.Parameters.AddWithValue("@data_nascimento", inputData.Value)

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "SELECT * FROM associates WHERE ativo = 1"

            command = New SqlCommand(sql, connection)
            dataAdapter = New SqlDataAdapter(sql, connection)

            connection.Open()
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet)

            dataList.DataSource = dataSet.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
        End Try
    End Sub

    Private Sub btnGetById_Click(sender As Object, e As EventArgs) Handles btnGetById.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "SELECT * FROM associates WHERE ID = @ID AND ativo = 1"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ID", inputId.Text)

            connection.Open()
            dataReader = command.ExecuteReader

            Do While dataReader.Read
                inputNome.Text = dataReader("nome")
                inputCpf.Text = dataReader("cpf")
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            dataReader = Nothing
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "UPDATE associates SET nome = @nome, cpf = @cpf, data_nascimento = @data_nascimento 
                    WHERE id = @id"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@id", inputId.Text)
            command.Parameters.AddWithValue("@nome", inputNome.Text)
            command.Parameters.AddWithValue("@cpf", inputCpf.Text)
            command.Parameters.AddWithValue("@data_nascimento", inputData.Value)

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "UPDATE associates SET ativo = 0 WHERE id = @id"
            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@id", inputId.Text)

            If inputId.Text <> "" Then
                connection.Open()
                command.ExecuteNonQuery()
            Else
                MessageBox.Show("Nenhum id encontrado")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
        End Try
    End Sub
End Class
