Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Form1

    Dim WorkstationName
    Dim Database
    Dim Myconn As SqlConnection
    Dim mycmd As SqlCommand
    Dim Myreader As SqlDataReader
    Dim results As String




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ComboBox1
            ComboBox1.Items.Add("HHR, 10.104.102.47")
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GetName.Click

        Dim WKDB
        Dim HSite

        WorkstationName = TextBox1.Text
        Database = ComboBox1.SelectedItem
        WKDB = Split(Database, ", ")
        Database = (WKDB(1))
        HSite = "Omnilabs_" & (WKDB(0))

        Dim Connexion As New SqlConnection("Server=" + Database + ";Database=" & HSite & "; User ID=Cortexadmin; Password=9ijn")


        Connexion.Open()

        Dim Requete As String = ("Select top 1 value from mac join config On mac.workstationid = config.workstationid where mac = '" + WorkstationName + "' and parameter = 'LabelPrinterPath'")
        Dim Commande As New SqlCommand(Requete, Connexion)
        Dim Monreader As SqlDataReader = Commande.ExecuteReader()

        MsgBox(Monreader("value").ToString)










        Dim ConnectionString As String = "Server=" + Database + ";Database=" & HSite & "; User ID=Cortexadmin; Password=9ijn"
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()

        Dim comm As New SqlCommand("Select * from mac join config on mac.workstationid = config.workstationid where mac = '" + WorkstationName + "'", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader()


        Dim i As Integer


        i = 0
        While reader.Read()
            ListBox1.Items.Add(reader(i).ToString)
            i = i + 1
        End While





    End Sub

End Class
