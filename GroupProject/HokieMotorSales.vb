Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HokieMotorSales
    'ADO.NET connection
    Dim connectionString As String = "Data Source=DESKTOP-1AC8NGN\SQLEXPRESS01;Trusted_Connection=true;Initial Catalog=invoices;Persist Security Info=True;User ID=base;Password=***********"

    Public Class Vehicle
        Public Property name As String
        Public Property mpg As Decimal
        Public Property cylinders As Integer
        Public Property displacement As Integer
        Public Property horsepower As Integer
        Public Property price As Integer
        Public Property acceleration As Decimal
        Public Property model_year As Integer
        Public Property origin As String

        ' Constructor
        Public Sub New(_name As String, _mpg As Decimal, _cylinders As Integer, _displacement As Integer, _horsepower As Integer, _price As Integer, _acceleration As Decimal, _model_year As Integer, _origin As String)
            name = _name
            mpg = _mpg
            cylinders = _cylinders
            displacement = _displacement
            horsepower = _horsepower
            price = _price
            acceleration = _acceleration
            model_year = _model_year
            origin = _origin
        End Sub


    End Class


    'method for loading data from sql server
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            Try
                ' Open the database connection
                connection.Open()

                ' SQL query to select data from your table

                Dim sqlQuery As String = "SELECT name, mpg, cylinders, displacement, horsepower, [price (usd)], acceleration, model_year, origin FROM dbo.project"

                ' Create a command object with the SQL query and connection
                Dim command As New SqlCommand(sqlQuery, connection)

                ' Create a data adapter to fill a DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                ' Fill the DataTable with data from the database
                adapter.Fill(table)

                ' Set the DataGridView's DataSource to the filled DataTable
                InventoryGrid.DataSource = table

            Catch ex As Exception
                ' Display an error message if something goes wrong
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private OriginalTable As New DataTable("OriginalTable")

    Private Inventory As DataGridViewRowCollection
    Private Sub HokieMotorSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        'populate the mpg combo box 
        MPGComboBox.Items.Add("10 - 15")
        MPGComboBox.Items.Add("16 - 20")
        MPGComboBox.Items.Add("21 - 25")
        MPGComboBox.Items.Add("26 - 30")
        MPGComboBox.Items.Add("30+")

        'populate the cylinder combo box 
        CylinderComboBox.Items.Add("4")
        CylinderComboBox.Items.Add("6")
        CylinderComboBox.Items.Add("8")

        'populate Horsepower combo box 
        HPComboBox.Items.Add("50 - 100")
        HPComboBox.Items.Add("101 - 150")
        HPComboBox.Items.Add("151 - 200")
        HPComboBox.Items.Add("200+")

        'populate country combo box
        CountryComboBox.Items.Add("USA")
        CountryComboBox.Items.Add("Europe")
        CountryComboBox.Items.Add("Japan")

        ' populate the Year ComboBox
        For year As Integer = 1970 To 1982
            YearComboBox.Items.Add(year)
        Next



    End Sub

    Private Sub clearFilterButton_Click(sender As Object, e As EventArgs) Handles clearFilterButton.Click
        ' Reset the data grid filter
        If TypeOf InventoryGrid.DataSource Is DataTable Then
            ' Get the table from the source
            Dim dataTable As DataTable = DirectCast(InventoryGrid.DataSource, DataTable)

            ' Clear the filter
            dataTable.DefaultView.RowFilter = String.Empty
        End If

        ' Clear text fields
        brandTextBox.Text = ""
        budget.Text = ""

        ' Reset combo boxes to their default state
        MPGComboBox.SelectedIndex = -1
        CylinderComboBox.SelectedIndex = -1
        HPComboBox.SelectedIndex = -1
        CountryComboBox.SelectedIndex = -1
        YearComboBox.SelectedIndex = -1
    End Sub


    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        'all the combo boxes and text boxes on the right of the UI
        Dim brandName As String = brandTextBox.Text.Trim().ToUpper()
        Dim mpgSelection As String = If(MPGComboBox.SelectedItem IsNot Nothing, MPGComboBox.SelectedItem.ToString(), String.Empty)
        Dim cylinderSelection As String = If(CylinderComboBox.SelectedItem IsNot Nothing, CylinderComboBox.SelectedItem.ToString(), String.Empty)
        Dim hpSelection As String = If(HPComboBox.SelectedItem IsNot Nothing, HPComboBox.SelectedItem.ToString(), String.Empty)
        Dim countrySelection As String = If(CountryComboBox.SelectedItem IsNot Nothing, CountryComboBox.SelectedItem.ToString(), String.Empty)
        Dim yearSelection As String = If(YearComboBox.SelectedItem IsNot Nothing, YearComboBox.SelectedItem.ToString(), String.Empty)
        Dim budgetValue As String = budget.Text.Trim()

        ' Check if the brand name exists in the original, unfiltered data
        Dim brandNameExists As Boolean = False
        If TypeOf InventoryGrid.DataSource Is DataTable Then
            Dim dataTable As DataTable = DirectCast(InventoryGrid.DataSource, DataTable)

            ' Create a temporary view of the original DataTable for brand name existence check
            Dim tempView As New DataView(dataTable)
            tempView.RowFilter = "Convert(name, 'System.String') LIKE '" + brandName + "%'"

            If tempView.Count > 0 Then
                brandNameExists = True
            End If
        End If

        ' If the brand name does not exist and is not empty, show a popup and exit the subroutine
        If Not String.IsNullOrEmpty(brandName) AndAlso Not brandNameExists Then
            MessageBox.Show("Invalid brand name entered. Please clear the filter and try again.", "Invalid Entry")
            Return
        End If




        If TypeOf InventoryGrid.DataSource Is DataTable Then
            Dim dataTable As DataTable = DirectCast(InventoryGrid.DataSource, DataTable)
            Dim filterExpression As String = ""



            ' Filter for brand name
            If Not String.IsNullOrEmpty(brandName) Then
                filterExpression = "Convert(name, 'System.String') LIKE '" + brandName + "%'"
            End If

            ' Add MPG filter if selected
            If Not String.IsNullOrEmpty(mpgSelection) Then
                Select Case mpgSelection
                    Case "10 - 15"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "mpg >= 10 AND mpg <= 15"
                    Case "16 - 20"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "mpg >= 16 AND mpg <= 20"
                    Case "21 - 25"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "mpg >= 21 AND mpg <= 25"
                    Case "26 - 30"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "mpg >= 26 AND mpg <= 30"
                    Case "30+"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "mpg > 30"
                End Select
            End If

            ' Add Cylinder filter if selected
            If Not String.IsNullOrEmpty(cylinderSelection) Then
                Dim cylinderFilter As String = "cylinders = " & cylinderSelection
                filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & cylinderFilter
            End If

            ' Add Horsepower filter if selected
            If Not String.IsNullOrEmpty(hpSelection) Then
                Select Case hpSelection
                    Case "50 - 100"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "horsepower >= 50 AND horsepower <= 100"
                    Case "101 - 150"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "horsepower >= 101 AND horsepower <= 150"
                    Case "151 - 200"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "horsepower >= 151 AND horsepower <= 200"
                    Case "200+"
                        filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & "horsepower > 200"
                End Select
            End If
            ' Add Country filter if selected
            If Not String.IsNullOrEmpty(countrySelection) Then
                ' case insensitive
                Dim countryFilter As String = "origin = '" & countrySelection.ToLower() & "'"
                filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & countryFilter
            End If

            ' Add Year filter if selected
            If Not String.IsNullOrEmpty(yearSelection) Then
                ' use last 2 digits to compare. Example: 1970 -> 70
                Dim yearFilter As String = "model_year = '" & yearSelection.Substring(2, 2) & "'"
                filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & yearFilter
            End If

            ' Validate budget input
            If Not String.IsNullOrEmpty(budgetValue) AndAlso Not IsNumeric(budgetValue) Then
                MessageBox.Show("Please enter a valid number for the budget.", "Invalid Budget")
                Return
            End If

            ' Add Budget filter if input is a valid number
            If Not String.IsNullOrEmpty(budgetValue) Then
                Dim budgetFilter As String = "[price (usd)] <= " & budgetValue
                filterExpression &= If(String.IsNullOrEmpty(filterExpression), "", " AND ") & budgetFilter
            End If

            ' Apply the filter
            dataTable.DefaultView.RowFilter = filterExpression

            ' Check if any vehicles are available under the specified budget
            If dataTable.DefaultView.Count = 0 AndAlso Not String.IsNullOrEmpty(budgetValue) Then
                MessageBox.Show("There are no vehicles under this price. Please try again.", "No Vehicles Found")
                Return
            End If
        End If


    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()


        Form1.Show()
    End Sub
End Class