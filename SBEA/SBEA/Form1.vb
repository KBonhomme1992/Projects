Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports ADODB
Imports System.Configuration
Imports System.Collections.Specialized

Public Class Form1
    Inherits System.Windows.Forms.Form



    Private BindingSource As New BindingSource()
    Private DataAdapter As New SqlDataAdapter()



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        FillGrid()

        MessageBox.Show("Done")

    End Sub

    Private Shared Function GetAppSettings() As Specialized.NameValueCollection
        Return Configuration.ConfigurationSettings.AppSettings
    End Function

    Private Function GetData(ByRef ListOfKeys, ByRef ListOfIPs)

        Dim SiteName, XMLGen, ReportGen, DSQGen
        Dim XMLGenRes = "", ReportGenRes = "", DSQGenRes = ""

        Dim dbConn As New ADODB.Connection
        Dim RSXML As New ADODB.Recordset
        Dim RSReport As New ADODB.Recordset
        Dim RSDSQ As New ADODB.Recordset

        dbConn.Open("provider=sqloledb;data source=10.104.102.47;initial catalog=Omnilabs_HHR;user id=CortexAdmin;password=9ijn;")

        SiteName = ""
        XMLGen = "SELECT  SUM(XMLGenQueue) AS XMLGenQueue
                 FROM (SELECT COUNT(1) AS XMLGenQueue, 0 AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/XmlGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, COUNT(1) AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/ReportGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, 0 AS RepGenQueue, COUNT(1) AS DSQGenQueue
               FROM [dbo].[//Processing/DSQGenerator/TargetQueue] WITH (NOLOCK)) T1;"

        ReportGen = "SELECT  SUM(RepGenQueue) As ReportGenQueue
                 FROM (SELECT COUNT(1) AS XMLGenQueue, 0 AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/XmlGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, COUNT(1) AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/ReportGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, 0 AS RepGenQueue, COUNT(1) AS DSQGenQueue
               FROM [dbo].[//Processing/DSQGenerator/TargetQueue] WITH (NOLOCK)) T1;"

        DSQGen = "SELECT SUM(DSQGenQueue) AS DSQGenQueue
                 FROM (SELECT COUNT(1) AS XMLGenQueue, 0 AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/XmlGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, COUNT(1) AS RepGenQueue, 0 AS DSQGenQueue
                  FROM [dbo].[//Processing/ReportGenerator/TargetQueue] WITH (NOLOCK)
              UNION
              SELECT 0 AS XMLGenQueue, 0 AS RepGenQueue, COUNT(1) AS DSQGenQueue
               FROM [dbo].[//Processing/DSQGenerator/TargetQueue] WITH (NOLOCK)) T1;"

        Try
            RSXML.Open(XMLGen, dbConn)
            XMLGenRes = RSXML.Fields(0).Value

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


        Try
            RSReport.Open(ReportGen, dbConn)
            ReportGenRes = RSReport.Fields(0).Value
        Catch ex As Exception

        End Try


        Try
            RSDSQ.Open(DSQGen, dbConn)
            DSQGenRes = RSDSQ.Fields(0).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim Result


        If (XMLGenRes IsNot Nothing And ReportGenRes IsNot Nothing And DSQGenRes IsNot Nothing) Or (XMLGenRes = "" And ReportGenRes = "" And DSQGenRes = "") Then


            Result = XMLGenRes.ToString + "-" + ReportGenRes.ToString + "-" + DSQGenRes.ToString
        Else

            Result = Nothing

        End If


        Return Result


        dbConn = Nothing
        RSXML = Nothing
        RSReport = Nothing
        RSDSQ = Nothing
        XMLGen = Nothing
        ReportGen = Nothing
        DSQGen = Nothing
        SiteName = Nothing
        Result = Nothing
        XMLGenRes = Nothing
        ReportGenRes = Nothing
        DSQGenRes = Nothing


    End Function

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        FillGrid()
    End Sub

    Private Sub FillGrid()

        Dim SiteName
        Dim XML
        Dim Report
        Dim DSQ
        Dim Splited
        Dim ListofKeys As New List(Of String)
        Dim ListOfIPs As New List(Of String)

        Dim col1 As New DataGridViewTextBoxColumn
        col1.DataPropertyName = "Sitename"
        col1.HeaderText = "Sitename"
        col1.Name = "Sitename"
        DataGridView1.Columns.Add(col1)


        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "XMLGen"
        col2.HeaderText = "XMLGen"
        col2.Name = "XMLGen"
        DataGridView1.Columns.Add(col2)



        Dim col3 As New DataGridViewTextBoxColumn
        col3.DataPropertyName = "ReportGen"
        col3.HeaderText = "ReportGen"
        col3.Name = "ReportGen"
        DataGridView1.Columns.Add(col3)



        Dim col4 As New DataGridViewTextBoxColumn
        col4.DataPropertyName = "DSQGen"
        col4.HeaderText = "DSQGen"
        col4.Name = "DSQGen"
        DataGridView1.Columns.Add(col4)




        GetAllIPs(ListofKeys, ListOfIPs)


        For x = 0 To ListofKeys.Count - 1

            SiteName = ListofKeys(x).ToString
            MessageBox.Show(ListOfIPs(x))


            If GetData(ListofKeys, ListOfIPs) IsNot Nothing Then



                Splited = Split(GetData(ListofKeys, ListOfIPs), "-")
                XML = Splited(0)
                Report = Splited(1)
                DSQ = Splited(2)






            Else

                XML = "No connection available"
                    Report = "No connection available"
                    DSQ = "No Connection Available"

                End If

            MessageBox.Show(SiteName + " test" + XML + " " + Report + " " + DSQ)




            'Dim Row1() As String = New String() {"SiteTest", XML, Report, DSQ}

            '    MsgBox(Row1(0))

            '    DataGridView1.Rows.Add(Row1)







            '    XML = Nothing
            '    Report = Nothing
            '    DSQ = Nothing

            '    x += 1
            'Next


        Next
    End Sub


    Private Sub GetAllIPs(ByRef ListOfKeys, ByRef ListOfIPs)

        Dim ActIP



        Dim AppSettings = ConfigurationSettings.AppSettings

        For Each key In AppSettings.AllKeys

            ListofKeys.Add(key)

        Next


        For x = 0 To ListOfKeys.Count() - 1

            ActIP = Configuration.ConfigurationSettings.AppSettings.Get(ListOfKeys(x))
            ListOfIPs.Add(ActIP.ToString)

        Next









    End Sub


End Class

