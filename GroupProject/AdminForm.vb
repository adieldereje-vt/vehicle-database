Imports System.Data
Imports System.Data.SqlClient
Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms



Public Class Form2
    ' ADO.NET connection string
    Dim connectionString As String = "Data Source=DESKTOP-1AC8NGN\SQLEXPRESS01;Trusted_Connection=true;Initial Catalog=invoices;Persist Security Info=True;User ID=base;Password=***********"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        InitializePlotView()
    End Sub

    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            Try

                connection.Open()


                Dim sqlQuery As String = "SELECT name, mpg, cylinders, displacement, horsepower, [price (usd)], acceleration, model_year, origin FROM dbo.project"


                Dim command As New SqlCommand(sqlQuery, connection)


                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()


                adapter.Fill(table)


                AdminDataGridView.DataSource = table

            Catch ex As Exception

                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub AddEntry_Click(sender As Object, e As EventArgs) Handles AddEntry.Click
        ' Collect data from textboxes using the correct names
        Dim name As String = nameTextBox.Text
        Dim mpg As Decimal = Decimal.Parse(mpgTextBox.Text)
        Dim cylinders As Integer = Integer.Parse(cylinderTextBox.Text)
        Dim displacement As Integer = Integer.Parse(displacementTextBox.Text)
        Dim horsepower As Integer = Integer.Parse(horsepowerTextBox.Text)
        Dim price As Integer = Integer.Parse(priceTextBox.Text)
        Dim acceleration As Decimal = Decimal.Parse(accelerationTextBox.Text)
        Dim model_year As Integer = Integer.Parse(model_yearTextBox.Text)
        Dim origin As String = originTextBox.Text

        ' Insert data into the database
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "INSERT INTO dbo.project (name, mpg, cylinders, displacement, horsepower, [price (usd)], acceleration, model_year, origin) " &
                                "VALUES (@name, @mpg, @cylinders, @displacement, @horsepower, @price, @acceleration, @model_year, @origin)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@mpg", mpg)
                    command.Parameters.AddWithValue("@cylinders", cylinders)
                    command.Parameters.AddWithValue("@displacement", displacement)
                    command.Parameters.AddWithValue("@horsepower", horsepower)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@acceleration", acceleration)
                    command.Parameters.AddWithValue("@model_year", model_year)
                    command.Parameters.AddWithValue("@origin", origin)

                    command.ExecuteNonQuery()
                End Using

                ' Optionally, clear the textboxes or give a success message
                ClearTextBoxes()
                MessageBox.Show("Data added successfully!")

            Catch ex As Exception
                ' Display an error message if something goes wrong
                MessageBox.Show("An error occurred while inserting data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ClearTextBoxes()
        ' Clear all textboxes after insertion
        nameTextBox.Clear()
        mpgTextBox.Clear()
        cylinderTextBox.Clear()
        displacementTextBox.Clear()
        horsepowerTextBox.Clear()
        priceTextBox.Clear()
        accelerationTextBox.Clear()
        model_yearTextBox.Clear()
        originTextBox.Clear()
    End Sub

    Private Sub LogOutButtom_Click(sender As Object, e As EventArgs) Handles LogOutButtom.Click

        Me.Close()
        Form1.Show()
    End Sub

    Private Sub InitializePlotView()
        ' Create a new PlotView control
        Dim plotView As New PlotView()
        plotView.Location = New Point(65, 100)
        plotView.Size = New Size(600, 400)

        ' Create a new PlotModel with a title
        Dim plotModel As New PlotModel() With {.Title = "Average Vehicle Prices Over Years"}

        ' Create a LineSeries for the plot
        Dim lineSeries As New LineSeries()

        ' Retrieve and add data points to the line series
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                ' SQL query to calculate average prices by model_year
                Dim command As New SqlCommand("SELECT model_year, AVG([price (usd)]) AS AvgPrice FROM dbo.project GROUP BY model_year ORDER BY model_year", connection)
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    ' Assuming model_year and price are stored as integers in your database
                    Dim year As Double = Convert.ToDouble(reader("model_year"))
                    Dim avgPrice As Double = Convert.ToDouble(reader("AvgPrice"))

                    ' Add data points to the line series
                    lineSeries.Points.Add(New DataPoint(year, avgPrice))
                End While
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading chart data: " & ex.Message)
            End Try
        End Using

        ' Add the LineSeries to the PlotModel
        plotModel.Series.Add(lineSeries)

        ' Set the model to the plot view
        plotView.Model = plotModel

        ' Add the plot view to the form's controls
        Me.Controls.Add(plotView)
    End Sub

End Class
