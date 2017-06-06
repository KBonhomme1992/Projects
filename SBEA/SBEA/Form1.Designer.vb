Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

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
        Me.SBEAS = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SBEAS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SBEAS
        '
        Me.SBEAS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SBEAS.Controls.Add(Me.BtnExit)
        Me.SBEAS.Controls.Add(Me.BtnRefresh)
        Me.SBEAS.Controls.Add(Me.DataGridView1)
        Me.SBEAS.Location = New System.Drawing.Point(13, 13)
        Me.SBEAS.Name = "SBEAS"
        Me.SBEAS.Size = New System.Drawing.Size(1085, 658)
        Me.SBEAS.TabIndex = 0
        Me.SBEAS.TabStop = False
        Me.SBEAS.Text = "SBEAS"
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Location = New System.Drawing.Point(805, 604)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.Location = New System.Drawing.Point(148, 605)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 1
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1067, 543)
        Me.DataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 683)
        Me.Controls.Add(Me.SBEAS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SBEAS.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SBEAS As GroupBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
