Imports System.Data.SqlClient
Public Class Companies
    Private connection As SqlConnection
    Private command As SqlCommand
    Private dataAdapter As SqlDataAdapter
    Private dataReader As SqlDataReader

    Private sql As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection = New SqlConnection("Server=db-develop-s4e.csjhouhm11g4.us-east-1.rds.amazonaws.com;
                            Database=sample-s4e; User Id=admin; Password=pdQGyuW>J#;")

            sql = "INSERT INTO companies (Nome,cnpj)
                VALUES (@nome, @cnpj)"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@nome", inputNome.Text)
            command.Parameters.AddWithValue("@cnpj", inputCnpj.Text)

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

            sql = "SELECT * FROM companies WHERE ativo = 1"

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

            sql = "SELECT * FROM companies WHERE ID = @ID AND ativo = 1"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ID", inputId.Text)

            connection.Open()
            dataReader = command.ExecuteReader

            Do While dataReader.Read
                inputNome.Text = dataReader("nome")
                inputCnpj.Text = dataReader("cnpj")
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

            sql = "UPDATE companies SET nome = @nome, cnpj = @cnpj WHERE id = @id"

            command = New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@id", inputId.Text)
            command.Parameters.AddWithValue("@nome", inputNome.Text)
            command.Parameters.AddWithValue("@cnpj", inputCnpj.Text)

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

            sql = "UPDATE companies SET ativo = 0 WHERE id = @id"
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