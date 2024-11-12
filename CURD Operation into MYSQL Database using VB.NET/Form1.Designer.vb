<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txt_prono = New TextBox()
        txt_proname = New TextBox()
        txt_price = New TextBox()
        combo_progroup = New ComboBox()
        exp_datepicker = New DateTimePicker()
        status_checkbox = New CheckBox()
        btn_save = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        btn_clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        txt_search = New TextBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_prono
        ' 
        txt_prono.Location = New Point(30, 58)
        txt_prono.Name = "txt_prono"
        txt_prono.Size = New Size(245, 27)
        txt_prono.TabIndex = 0
        ' 
        ' txt_proname
        ' 
        txt_proname.Location = New Point(30, 119)
        txt_proname.Name = "txt_proname"
        txt_proname.Size = New Size(245, 27)
        txt_proname.TabIndex = 0
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(30, 174)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(245, 27)
        txt_price.TabIndex = 0
        ' 
        ' combo_progroup
        ' 
        combo_progroup.FormattingEnabled = True
        combo_progroup.Items.AddRange(New Object() {"SWEETS", "COOL DRINKS", "FOODS"})
        combo_progroup.Location = New Point(30, 243)
        combo_progroup.Name = "combo_progroup"
        combo_progroup.Size = New Size(245, 28)
        combo_progroup.TabIndex = 1
        ' 
        ' exp_datepicker
        ' 
        exp_datepicker.Location = New Point(30, 311)
        exp_datepicker.Name = "exp_datepicker"
        exp_datepicker.Size = New Size(245, 27)
        exp_datepicker.TabIndex = 2
        ' 
        ' status_checkbox
        ' 
        status_checkbox.AutoSize = True
        status_checkbox.Location = New Point(32, 358)
        status_checkbox.Name = "status_checkbox"
        status_checkbox.Size = New Size(93, 24)
        status_checkbox.TabIndex = 3
        status_checkbox.Text = "Available"
        status_checkbox.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.FlatStyle = FlatStyle.Flat
        btn_save.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(52, 397)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(96, 51)
        btn_save.TabIndex = 4
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.DarkOrange
        btn_update.FlatStyle = FlatStyle.Flat
        btn_update.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_update.ForeColor = Color.White
        btn_update.Location = New Point(161, 397)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(96, 51)
        btn_update.TabIndex = 4
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_delete.ForeColor = Color.White
        btn_delete.Location = New Point(52, 467)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(96, 51)
        btn_delete.TabIndex = 4
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.DarkSlateGray
        btn_clear.FlatStyle = FlatStyle.Flat
        btn_clear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_clear.ForeColor = Color.White
        btn_clear.Location = New Point(161, 467)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(96, 51)
        btn_clear.TabIndex = 4
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 5
        Label1.Text = "Product No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 5
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 5
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 5
        Label4.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 5
        Label5.Text = "Expired Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(294, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(611, 399)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 133
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 79
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Expired Date"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 114
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 55
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(294, 58)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(323, 27)
        txt_search.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 5
        Label6.Text = "Search"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 533)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(btn_clear)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_save)
        Controls.Add(status_checkbox)
        Controls.Add(exp_datepicker)
        Controls.Add(combo_progroup)
        Controls.Add(txt_price)
        Controls.Add(txt_search)
        Controls.Add(txt_proname)
        Controls.Add(txt_prono)
        Cursor = Cursors.Hand
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CURD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prono As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents combo_progroup As ComboBox
    Friend WithEvents exp_datepicker As DateTimePicker
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn

End Class
