Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupportDataSet.vw_SupportLogForExcel' table. You can move, or remove it, as needed.
        Me.Vw_SupportLogForExcelTableAdapter.Fill(Me.SupportDataSet.vw_SupportLogForExcel)

    End Sub

End Class
