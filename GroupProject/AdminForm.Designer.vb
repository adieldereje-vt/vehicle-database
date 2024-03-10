<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        AdminDataGridView = New DataGridView()
        SubmitButton = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        nameTextBox = New TextBox()
        mpgTextBox = New TextBox()
        cylinderTextBox = New TextBox()
        displacementTextBox = New TextBox()
        horsepowerTextBox = New TextBox()
        priceTextBox = New TextBox()
        accelerationTextBox = New TextBox()
        model_yearTextBox = New TextBox()
        originTextBox = New TextBox()
        AddEntry = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        LogOutButtom = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        CType(AdminDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AdminDataGridView
        ' 
        AdminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdminDataGridView.Location = New Point(125, 76)
        AdminDataGridView.Name = "AdminDataGridView"
        AdminDataGridView.RowTemplate.Height = 25
        AdminDataGridView.Size = New Size(739, 346)
        AdminDataGridView.TabIndex = 0
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(923, 378)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(206, 44)
        SubmitButton.TabIndex = 1
        SubmitButton.Text = "Add Entry"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' nameTextBox
        ' 
        nameTextBox.Location = New Point(905, 100)
        nameTextBox.Name = "nameTextBox"
        nameTextBox.Size = New Size(152, 23)
        nameTextBox.TabIndex = 2
        ' 
        ' mpgTextBox
        ' 
        mpgTextBox.Location = New Point(905, 138)
        mpgTextBox.Name = "mpgTextBox"
        mpgTextBox.Size = New Size(152, 23)
        mpgTextBox.TabIndex = 3
        ' 
        ' cylinderTextBox
        ' 
        cylinderTextBox.Location = New Point(905, 190)
        cylinderTextBox.Name = "cylinderTextBox"
        cylinderTextBox.Size = New Size(152, 23)
        cylinderTextBox.TabIndex = 4
        ' 
        ' displacementTextBox
        ' 
        displacementTextBox.Location = New Point(905, 240)
        displacementTextBox.Name = "displacementTextBox"
        displacementTextBox.Size = New Size(155, 23)
        displacementTextBox.TabIndex = 5
        ' 
        ' horsepowerTextBox
        ' 
        horsepowerTextBox.Location = New Point(905, 284)
        horsepowerTextBox.Name = "horsepowerTextBox"
        horsepowerTextBox.Size = New Size(152, 23)
        horsepowerTextBox.TabIndex = 6
        ' 
        ' priceTextBox
        ' 
        priceTextBox.Location = New Point(905, 326)
        priceTextBox.Name = "priceTextBox"
        priceTextBox.Size = New Size(152, 23)
        priceTextBox.TabIndex = 7
        ' 
        ' accelerationTextBox
        ' 
        accelerationTextBox.Location = New Point(905, 365)
        accelerationTextBox.Name = "accelerationTextBox"
        accelerationTextBox.Size = New Size(152, 23)
        accelerationTextBox.TabIndex = 8
        ' 
        ' model_yearTextBox
        ' 
        model_yearTextBox.Location = New Point(905, 405)
        model_yearTextBox.Name = "model_yearTextBox"
        model_yearTextBox.Size = New Size(152, 23)
        model_yearTextBox.TabIndex = 9
        ' 
        ' originTextBox
        ' 
        originTextBox.Location = New Point(905, 444)
        originTextBox.Name = "originTextBox"
        originTextBox.Size = New Size(152, 23)
        originTextBox.TabIndex = 10
        ' 
        ' AddEntry
        ' 
        AddEntry.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddEntry.Location = New Point(902, 487)
        AddEntry.Name = "AddEntry"
        AddEntry.Size = New Size(155, 33)
        AddEntry.TabIndex = 11
        AddEntry.Text = "Add Entry"
        AddEntry.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(855, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 14)
        Label1.TabIndex = 12
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(861, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 14)
        Label2.TabIndex = 13
        Label2.Text = "MPG:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(833, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 14)
        Label3.TabIndex = 14
        Label3.Text = "Cylinders:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(807, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 14)
        Label4.TabIndex = 15
        Label4.Text = "Displacement:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(814, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 14)
        Label5.TabIndex = 16
        Label5.Text = "Horsepower:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(820, 329)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 14)
        Label6.TabIndex = 17
        Label6.Text = "Price (USD):"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(814, 365)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 14)
        Label7.TabIndex = 18
        Label7.Text = "Acceleration:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(820, 408)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 14)
        Label8.TabIndex = 19
        Label8.Text = "Model Year:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(781, 447)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 14)
        Label9.TabIndex = 20
        Label9.Text = "Country Of Oirgin:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(333, 35)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 33)
        Label10.TabIndex = 21
        Label10.Text = "Admin Panel"
        ' 
        ' LogOutButtom
        ' 
        LogOutButtom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LogOutButtom.Location = New Point(12, 519)
        LogOutButtom.Name = "LogOutButtom"
        LogOutButtom.Size = New Size(101, 33)
        LogOutButtom.TabIndex = 22
        LogOutButtom.Text = "Log Out"
        LogOutButtom.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1126, 564)
        Controls.Add(LogOutButtom)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(AddEntry)
        Controls.Add(originTextBox)
        Controls.Add(model_yearTextBox)
        Controls.Add(accelerationTextBox)
        Controls.Add(priceTextBox)
        Controls.Add(horsepowerTextBox)
        Controls.Add(displacementTextBox)
        Controls.Add(cylinderTextBox)
        Controls.Add(mpgTextBox)
        Controls.Add(nameTextBox)
        Controls.Add(Label10)
        Name = "Form2"
        Text = "Form2"
        CType(AdminDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AdminDataGridView As DataGridView
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents mpgTextBox As TextBox
    Friend WithEvents cylinderTextBox As TextBox
    Friend WithEvents displacementTextBox As TextBox
    Friend WithEvents horsepowerTextBox As TextBox
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents accelerationTextBox As TextBox
    Friend WithEvents model_yearTextBox As TextBox
    Friend WithEvents originTextBox As TextBox
    Friend WithEvents AddEntry As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LogOutButtom As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker

End Class
