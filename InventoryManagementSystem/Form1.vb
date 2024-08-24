Public Class Form1
    Private Sub ts_Transaction_Click(sender As Object, e As EventArgs) Handles ts_Transaction.Click
        With frm_transaction
            .Show()
            .Focus()

        End With

    End Sub

    Private Sub ts_StockMaster_Click(sender As Object, e As EventArgs) Handles ts_StockMaster.Click
        With frm_StockMaster
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Customer_Click(sender As Object, e As EventArgs) Handles ts_Suplier.Click
        With frm_suplier
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_ManageUser_Click(sender As Object, e As EventArgs) Handles ts_ManageUser.Click
        With frm_user
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Setting_Click(sender As Object, e As EventArgs) Handles ts_Setting.Click
        With frm_settings
            .Show()
            .Focus()
        End With
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ts_Login.Click


        With LoginForm1
            If ts_Login.Text = "INICIAR SESIÓN" Then
                .Show()
                .Focus()
            Else
                ts_Login.Text = "INICIAR SESIÓN"
                ts_Login.Image = My.Resources.candado__1_
                enable_disable(False)
            End If

        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enable_disable(False)
    End Sub

    Private Sub ts_Customer_Click_1(sender As Object, e As EventArgs) Handles ts_Customer.Click
        With frm_customer
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With Creditos
            .Show()
            .Focus()
        End With
    End Sub
End Class
