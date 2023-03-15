Public Class Form1
    Sub Bersih()
        txtJumlah.Text = ""
        txtHasil.Text = ""
        cbSatuan.Text = ""
        cbKonversi.Text = ""

        txtHasil.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Bersih()
    End Sub

    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim inputan, hasil As Double
        inputan = Val(txtJumlah.Text)

        'km ke satuan konversi
        If (cbSatuan.Text = "km") Then
            If (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan * 10

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan * 100

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan * 1000

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan * 10000

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 100000

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 1000000
            End If

            'hm ke satuan konversi
        ElseIf (cbSatuan.Text = "hm") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 10

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan * 10

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan * 100

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan * 1000

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 10000

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 100000
            End If

            'dam ke satuan konversi
        ElseIf (cbSatuan.Text = "dam") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 100

            ElseIf (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan / 10

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan * 10

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan * 100

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 1000

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 10000
            End If

            'm ke satuan konversi
        ElseIf (cbSatuan.Text = "m") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 1000

            ElseIf (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan / 100

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan / 10

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan * 10

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 100

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 1000
            End If

            'dm ke satuan konversi
        ElseIf (cbSatuan.Text = "dm") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 10000

            ElseIf (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan / 1000

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan / 100

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan / 10

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 10

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 100
            End If

            'cm ke satuan konversi
        ElseIf (cbSatuan.Text = "cm") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 100000

            ElseIf (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan / 10000

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan / 1000

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan / 100

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan / 10

            ElseIf (cbKonversi.Text = "mm") Then
                txtHasil.Text = inputan * 10
            End If

            'mm ke satuan konversi
        ElseIf (cbSatuan.Text = "mm") Then
            If (cbKonversi.Text = "km") Then
                txtHasil.Text = inputan / 1000000

            ElseIf (cbKonversi.Text = "hm") Then
                txtHasil.Text = inputan / 100000

            ElseIf (cbKonversi.Text = "dam") Then
                txtHasil.Text = inputan / 10000

            ElseIf (cbKonversi.Text = "m") Then
                txtHasil.Text = inputan / 1000

            ElseIf (cbKonversi.Text = "dm") Then
                txtHasil.Text = inputan / 100

            ElseIf (cbKonversi.Text = "cm") Then
                txtHasil.Text = inputan * 10
            End If

        End If
    End Sub
End Class
