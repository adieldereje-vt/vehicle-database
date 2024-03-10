<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HokieMotorSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        InventoryGrid = New DataGridView()
        MPG = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CylinderComboBox = New ComboBox()
        HPComboBox = New ComboBox()
        MPGComboBox = New ComboBox()
        CountryComboBox = New ComboBox()
        YearComboBox = New ComboBox()
        brandTextBox = New TextBox()
        Label5 = New Label()
        searchButton = New Button()
        Label6 = New Label()
        budget = New TextBox()
        clearFilterButton = New Button()
        inventoryLbl = New Label()
        ImageList1 = New ImageList(components)
        BindingSource1 = New BindingSource(components)
        LogOutButton = New Button()
        CType(InventoryGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InventoryGrid
        ' 
        InventoryGrid.BackgroundColor = SystemColors.ControlLight
        InventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InventoryGrid.GridColor = Color.SteelBlue
        InventoryGrid.Location = New Point(26, 42)
        InventoryGrid.Name = "InventoryGrid"
        InventoryGrid.RowHeadersWidth = 62
        InventoryGrid.RowTemplate.Height = 25
        InventoryGrid.Size = New Size(745, 311)
        InventoryGrid.TabIndex = 0
        ' 
        ' MPG
        ' 
        MPG.AutoSize = True
        MPG.Location = New Point(821, 61)
        MPG.Name = "MPG"
        MPG.Size = New Size(36, 15)
        MPG.TabIndex = 1
        MPG.Text = "MPG:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(803, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 2
        Label1.Text = "Cylinders:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(803, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 3
        Label2.Text = "Horsepower:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(821, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 4
        Label3.Text = "Country:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(803, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 5
        Label4.Text = "Model Year:"
        ' 
        ' CylinderComboBox
        ' 
        CylinderComboBox.FormattingEnabled = True
        CylinderComboBox.Location = New Point(877, 103)
        CylinderComboBox.Name = "CylinderComboBox"
        CylinderComboBox.Size = New Size(115, 23)
        CylinderComboBox.TabIndex = 8
        ' 
        ' HPComboBox
        ' 
        HPComboBox.FormattingEnabled = True
        HPComboBox.Location = New Point(877, 145)
        HPComboBox.Name = "HPComboBox"
        HPComboBox.Size = New Size(115, 23)
        HPComboBox.TabIndex = 9
        ' 
        ' MPGComboBox
        ' 
        MPGComboBox.FormattingEnabled = True
        MPGComboBox.Location = New Point(876, 61)
        MPGComboBox.Name = "MPGComboBox"
        MPGComboBox.Size = New Size(115, 23)
        MPGComboBox.TabIndex = 10
        ' 
        ' CountryComboBox
        ' 
        CountryComboBox.FormattingEnabled = True
        CountryComboBox.Location = New Point(877, 188)
        CountryComboBox.Name = "CountryComboBox"
        CountryComboBox.Size = New Size(115, 23)
        CountryComboBox.TabIndex = 11
        ' 
        ' YearComboBox
        ' 
        YearComboBox.FormattingEnabled = True
        YearComboBox.Location = New Point(877, 236)
        YearComboBox.Name = "YearComboBox"
        YearComboBox.Size = New Size(115, 23)
        YearComboBox.TabIndex = 12
        ' 
        ' brandTextBox
        ' 
        brandTextBox.Location = New Point(877, 19)
        brandTextBox.Name = "brandTextBox"
        brandTextBox.Size = New Size(114, 23)
        brandTextBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(821, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 14
        Label5.Text = "Brand:"
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.WhiteSmoke
        searchButton.Location = New Point(880, 331)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(111, 22)
        searchButton.TabIndex = 15
        searchButton.Text = "Search "
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(821, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 16
        Label6.Text = "Budget:"
        ' 
        ' budget
        ' 
        budget.Location = New Point(877, 276)
        budget.Name = "budget"
        budget.Size = New Size(115, 23)
        budget.TabIndex = 17
        ' 
        ' clearFilterButton
        ' 
        clearFilterButton.BackColor = Color.WhiteSmoke
        clearFilterButton.Location = New Point(881, 370)
        clearFilterButton.Name = "clearFilterButton"
        clearFilterButton.Size = New Size(111, 23)
        clearFilterButton.TabIndex = 18
        clearFilterButton.Text = "Clear FIlter"
        clearFilterButton.UseVisualStyleBackColor = False
        ' 
        ' inventoryLbl
        ' 
        inventoryLbl.AutoSize = True
        inventoryLbl.Font = New Font("Constantia", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        inventoryLbl.ForeColor = Color.DarkBlue
        inventoryLbl.Location = New Point(282, 9)
        inventoryLbl.Name = "inventoryLbl"
        inventoryLbl.Size = New Size(229, 33)
        inventoryLbl.TabIndex = 19
        inventoryLbl.Text = "Hokie Motor Sales"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' LogOutButton
        ' 
        LogOutButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LogOutButton.Location = New Point(26, 382)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(98, 25)
        LogOutButton.TabIndex = 20
        LogOutButton.Text = "Log Out"
        LogOutButton.UseVisualStyleBackColor = True
        ' 
        ' HokieMotorSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(1029, 427)
        Controls.Add(LogOutButton)
        Controls.Add(inventoryLbl)
        Controls.Add(clearFilterButton)
        Controls.Add(budget)
        Controls.Add(Label6)
        Controls.Add(searchButton)
        Controls.Add(Label5)
        Controls.Add(brandTextBox)
        Controls.Add(YearComboBox)
        Controls.Add(CountryComboBox)
        Controls.Add(MPGComboBox)
        Controls.Add(HPComboBox)
        Controls.Add(CylinderComboBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MPG)
        Controls.Add(InventoryGrid)
        Name = "HokieMotorSales"
        Text = "Form1"
        CType(InventoryGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InventoryGrid As DataGridView
    Friend WithEvents MPG As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CylinderComboBox As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MPGComboBox As ComboBox
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents brandTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents budget As TextBox
    Friend WithEvents clearFilterButton As Button
    Friend WithEvents inventoryLbl As Label
    Friend WithEvents HPComboBox As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents LogOutButton As Button
End Class
