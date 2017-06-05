<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoftwareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedTechDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwSupportLogForExcelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupportDataSet = New Dash.SupportDataSet()
        Me.Vw_SupportLogForExcelTableAdapter = New Dash.SupportDataSetTableAdapters.vw_SupportLogForExcelTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSupportLogForExcelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NotesDataGridViewTextBoxColumn, Me.IDOrderDataGridViewTextBoxColumn, Me.LogIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SoftwareDataGridViewTextBoxColumn, Me.ReceivedDateDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.AssignedTechDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwSupportLogForExcelBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1078, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'IDOrderDataGridViewTextBoxColumn
        '
        Me.IDOrderDataGridViewTextBoxColumn.DataPropertyName = "ID_Order"
        Me.IDOrderDataGridViewTextBoxColumn.HeaderText = "ID_Order"
        Me.IDOrderDataGridViewTextBoxColumn.Name = "IDOrderDataGridViewTextBoxColumn"
        '
        'LogIDDataGridViewTextBoxColumn
        '
        Me.LogIDDataGridViewTextBoxColumn.DataPropertyName = "Log ID"
        Me.LogIDDataGridViewTextBoxColumn.HeaderText = "Log ID"
        Me.LogIDDataGridViewTextBoxColumn.Name = "LogIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'SoftwareDataGridViewTextBoxColumn
        '
        Me.SoftwareDataGridViewTextBoxColumn.DataPropertyName = "Software"
        Me.SoftwareDataGridViewTextBoxColumn.HeaderText = "Software"
        Me.SoftwareDataGridViewTextBoxColumn.Name = "SoftwareDataGridViewTextBoxColumn"
        '
        'ReceivedDateDataGridViewTextBoxColumn
        '
        Me.ReceivedDateDataGridViewTextBoxColumn.DataPropertyName = "Received Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.HeaderText = "Received Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.Name = "ReceivedDateDataGridViewTextBoxColumn"
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'AssignedTechDataGridViewTextBoxColumn
        '
        Me.AssignedTechDataGridViewTextBoxColumn.DataPropertyName = "Assigned Tech"
        Me.AssignedTechDataGridViewTextBoxColumn.HeaderText = "Assigned Tech"
        Me.AssignedTechDataGridViewTextBoxColumn.Name = "AssignedTechDataGridViewTextBoxColumn"
        Me.AssignedTechDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwSupportLogForExcelBindingSource
        '
        Me.VwSupportLogForExcelBindingSource.DataMember = "vw_SupportLogForExcel"
        Me.VwSupportLogForExcelBindingSource.DataSource = Me.SupportDataSet
        '
        'SupportDataSet
        '
        Me.SupportDataSet.DataSetName = "SupportDataSet"
        Me.SupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_SupportLogForExcelTableAdapter
        '
        Me.Vw_SupportLogForExcelTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 359)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSupportLogForExcelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SupportDataSet As SupportDataSet
    Friend WithEvents VwSupportLogForExcelBindingSource As BindingSource
    Friend WithEvents Vw_SupportLogForExcelTableAdapter As SupportDataSetTableAdapters.vw_SupportLogForExcelTableAdapter
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoftwareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignedTechDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
