Imports System.Data.OleDb
Imports System.Data
Module db
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public rd As OleDbDataReader
    Public Data As String

    Public Sub connection()
        Dim Path As String
        Path = ".\db.accdb;"
        Data = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Path & ";"
        conn = New OleDbConnection(Data)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub isiGrid()
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM data", conn)
        da.Fill(ds, "data")
    End Sub
    Public Sub jalankanSql(ByVal sql As String)
        cmd = New OleDbCommand
        connection()
        Try
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Data Tersimpan", MsgBoxStyle.Information, "Simpan")
        Catch ex As Exception
        End Try
    End Sub
End Module
