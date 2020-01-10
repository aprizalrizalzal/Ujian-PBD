Imports System.Data.OleDb
Public Class FormData
    Dim DataID As String
    Dim DataAdd As Boolean

    Private Sub DataGridViewData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewData.CellClick
        isiTextBox()
        aktif()
        If CheckBoxUpdate.CheckState = CheckState.Unchecked Then
            CheckBoxUpdate.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub isiTextBox()
        Dim i As Integer
        DataAdd = False
        i = DataGridViewData.CurrentRow.Index
        DataID = DataGridViewData.Item(0, i).Value
        TextBoxNama.Text = DataGridViewData.Item(1, i).Value
        TextBoxAlamat.Text = DataGridViewData.Item(2, i).Value
        TextBoxNoHp.Text = DataGridViewData.Item(3, i).Value
    End Sub
    Private Sub Bersihkan()
        DataAdd = False
        TextBoxNama.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxNoHp.Text = ""
        TextBoxNama.Focus()
    End Sub

    Private Sub isiGridData()
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM data", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data")
        DataGridViewData.DataSource = ds.Tables("data")
        DataGridViewData.Enabled = True
        Refresh()
    End Sub

    Private Sub data()
        If TextBoxNama.Text = "" Or TextBoxAlamat.Text = "" Or TextBoxNoHp.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong", MsgBoxStyle.Information, "Maaf")
        Else
            Dim sql As String
            Me.Cursor = Cursors.WaitCursor

            If DataAdd Then
                sql = "INSERT INTO [data] ([nama], [alamat], [nohp]) VALUES('" & TextBoxNama.Text & "', '" & TextBoxAlamat.Text & "', '" & TextBoxNoHp.Text & "')"
            Else
                sql = "UPDATE [data] SET [nama]='" & TextBoxNama.Text & "', [alamat]='" & TextBoxAlamat.Text & "', [nohp]='" & TextBoxNoHp.Text & "' WHERE ID =" & DataID & " "
            End If
            jalankanSql(sql)
            Bersihkan()
            isiGridData()
            Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub deldata()
        If DataID <> "" Then
            Dim sql As String
            Dim pesan As Integer

            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & DataID, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            sql = "DELETE FROM [accountUser] WHERE ID = " & DataID

            jalankanSql(sql)
            Me.Cursor = Cursors.WaitCursor
            Bersihkan()
            isiGridData()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        deldata()
        isiGridData()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Bersihkan()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        data()
        isiGridData()
        FormDataAccount_Load(sender, e)

    End Sub
    Private Sub aktif()
        CheckBoxAdd.Enabled = True
        CheckBoxUpdate.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxAlamat.Enabled = True
        TextBoxNoHp.Enabled = True
        CheckBoxAdd.CheckState = CheckState.Unchecked
        CheckBoxUpdate.CheckState = CheckState.Unchecked
    End Sub

    Private Sub FormDataAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGridData()
    End Sub

    Private Sub CheckBoxAdd_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAdd.CheckedChanged
        If CheckBoxAdd.CheckState = CheckState.Checked Then
            DataAdd = True
            CheckBoxUpdate.Enabled = False
        Else
            CheckBoxUpdate.Enabled = True
        End If

    End Sub

    Private Sub CheckBoxUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUpdate.CheckedChanged
        If CheckBoxUpdate.CheckState = CheckState.Checked Then
            DataAdd = False
            CheckBoxAdd.Enabled = False
        Else
            aktif()
            CheckBoxAdd.Enabled = True
        End If
    End Sub

End Class
