Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pegawai As New Pegawai
        Dim pegawaiHonorer As New PegawaiHonorer
        Dim pegawaiTetap As New PegawaiTetap

        With pegawai
            .mnip = TextBox1.Text
            .mnama = TextBox2.Text
            .mjabatan = TextBox3.Text
            .malamat = TextBox4.Text
            .mgapok = TextBox5.Text

            If ComboBox2.Text = "Direktur" Then
                TextBox4.Text = 7000000
            ElseIf ComboBox2.Text = "Manager" Then
                TextBox4.Text = 3500000
            ElseIf ComboBox2.Text = "Staff" Then
                TextBox4.Text = 1500000
            Else
                TextBox4.Text = 1000000
            End If

            .mstatus = ComboBox1.Text
            If ComboBox1.Text = "Pegawai Tetap" Then
                With pegawaiTetap
                    .gapok = TextBox4.Text
                    TextBox5.Text = 2 * TextBox4.Text
                    .mtunjangantetap = TextBox5.Text
                    TextBox6.Text = 0
                    TextBox7.Text = .hitungtunjanganrumah(.mgapok)
                    TextBox8.Text = .hitunggajitetap(.mgapok, .mtunjangantetap)
                End With
            ElseIf ComboBox1.Text = "Pegawai Honorer" Then
                With pegawaiHonorer
                    .gapok = TextBox4.Text
                    TextBox5.Text = 0
                    TextBox6.Text = 25 * 15000
                    .mtunjangantransport = TextBox6.Text
                    TextBox7.Text = .hitungtunjanganrumah(.mgapok)
                    TextBox8.Text = .hitunggajihonorer(.mgapok, .mtunjangantransport)
                End With
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

End Class
