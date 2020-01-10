Imports System.Data.OleDb
Public Class FormData
    Dim DataID As String
    Dim DataAdd As Boolean

    Private Sub DataGridViewData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewData.CellClick
        isiTextBox()
        aktif()
        CheckBoxAdd.Enabled = False
        CheckBoxUpdate.Enabled = True
        CheckBoxDelete.Enabled = True
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
        CheckBoxAdd.Enabled = True
        CheckBoxUpdate.Enabled = False
        CheckBoxDelete.Enabled=False
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
        CheckBoxUpdate.Enabled = False
        CheckBoxDelete.Enabled = False
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
        If TextBoxNama.Text = "" Or TextBoxAlamat.Text = "" Or TextBoxNoHp.Text = "" Then
            MsgBox("Data Kosong", MsgBoxStyle.Information, "Maaf")
        Else
            If DataID <> "" Then
                Dim sql As String
                Dim pesan As Integer

                pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & DataID, vbExclamation + vbYesNo, "Perhatian")
                If pesan = vbNo Then Exit Sub

                sql = "DELETE FROM [data] WHERE ID = " & DataID

                jalankanSql(sql)
                Me.Cursor = Cursors.WaitCursor
                Bersihkan()
                isiGridData()
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Bersihkan()
        aktif()
        FormDataAccount_Load(sender, e)
        TextBoxNama.Focus()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CheckBoxAdd.CheckState = CheckState.Unchecked And CheckBoxUpdate.CheckState = CheckState.Unchecked Then
            deldata()
        Else
            data()
        End If
        aktif()
        isiGridData()
    End Sub
    Private Sub aktif()
        CheckBoxAdd.CheckState = CheckState.Unchecked
        CheckBoxUpdate.CheckState = CheckState.Unchecked
        CheckBoxDelete.CheckState = CheckState.Unchecked
    End Sub

    Private Sub FormDataAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGridData()
        aktif()
        ButtonSave.Enabled = False
    End Sub

    Private Sub CheckBoxAdd_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAdd.CheckedChanged
        If CheckBoxAdd.CheckState = CheckState.Checked Then
            DataAdd = True
            CheckBoxUpdate.Enabled = False
            CheckBoxDelete.Enabled = False
            ButtonSave.Enabled = True
        Else
            CheckBoxUpdate.Enabled = True
            CheckBoxDelete.Enabled = True
        End If

    End Sub

    Private Sub CheckBoxUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUpdate.CheckedChanged
        If CheckBoxUpdate.CheckState = CheckState.Checked Then
            DataAdd = False
            CheckBoxDelete.Enabled = False
            ButtonSave.Enabled = True
        Else
            CheckBoxDelete.Enabled = True
        End If
    End Sub

    Private Sub TextBoxNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNoHp.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub CheckBoxDelete_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelete.CheckedChanged
        If CheckBoxDelete.CheckState = CheckState.Checked Then
            DataAdd = False
            CheckBoxUpdate.Enabled = False
            ButtonSave.Enabled = True
        Else
            CheckBoxUpdate.Enabled = True
        End If
    End Sub
End Class
