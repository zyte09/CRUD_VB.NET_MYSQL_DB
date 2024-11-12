Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=curd"
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_curd", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("GROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_load()
    End Sub

    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_curd`(`PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `GROUP`, `EXPDATE`, `STATUS`) VALUES (@PRODUCTNO,@PRODUCTNAME,@PRICE,@GROUP,@EXPDATE,@STATUS)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@GROUP", combo_progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datepicker.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(status_checkbox.Checked.ToString))

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Save Sucess!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub

    Public Sub clear()
        txt_prono.Clear()
        txt_proname.Clear()
        txt_price.Clear()
        combo_progroup.Text = ""
        exp_datepicker.Value = Date.Now
        status_checkbox.Checked = False

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_prono.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_proname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_progroup.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_datepicker.Value = DataGridView1.CurrentRow.Cells(4).Value
        status_checkbox.Checked = DataGridView1.CurrentRow.Cells(5).Value

        txt_prono.ReadOnly = True 'Disable Product No
        btn_save.Enabled = False

    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_curd` SET `PRODUCTNAME`=@PRODUCTNAME, `PRICE`=@PRICE, `GROUP`=@GROUP, `EXPDATE`=@EXPDATE, `STATUS`=@STATUS WHERE `PRODUCTNO`=@PRODUCTNO", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@GROUP", combo_progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datepicker.Value))
            cmd.Parameters.AddWithValue("@STATUS", CBool(status_checkbox.Checked.ToString))

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Update Sucess!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Edit()

    End Sub

    Public Sub delete()
        If MsgBox("Delete this Record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `tbl_curd` WHERE `PRODUCTNO`=@PRODUCTNO", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)

                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record Delete Sucess!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_curd WHERE PRODUCTNO LIKE '%" & txt_search.Text & "%' OR PRODUCTNAME LIKE '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("GROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
