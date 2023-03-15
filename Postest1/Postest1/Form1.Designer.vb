<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtJumlah = New TextBox()
        btnClear = New Button()
        btnKonversi = New Button()
        Label5 = New Label()
        txtHasil = New TextBox()
        cbSatuan = New ComboBox()
        cbKonversi = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(171, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 25)
        Label1.TabIndex = 0
        Label1.Text = "PROGRAM KONVERSI SATUAN PANJANG"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(50, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 19)
        Label2.TabIndex = 1
        Label2.Text = "Masukan Jumlah Satuan Panjang"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(50, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 19)
        Label3.TabIndex = 2
        Label3.Text = "Pilih Satuan Panjang"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(50, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(213, 19)
        Label4.TabIndex = 3
        Label4.Text = "Pilih Satuan Panjang Konversi"' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(339, 114)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(194, 27)
        txtJumlah.TabIndex = 4
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(634, 145)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnKonversi
        ' 
        btnKonversi.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnKonversi.Location = New Point(634, 217)
        btnKonversi.Name = "btnKonversi"
        btnKonversi.Size = New Size(94, 29)
        btnKonversi.TabIndex = 8
        btnKonversi.Text = "Konversi"
        btnKonversi.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(259, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 9
        Label5.Text = "Hasil"' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(339, 333)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(194, 27)
        txtHasil.TabIndex = 10
        ' 
        ' cbSatuan
        ' 
        cbSatuan.FormattingEnabled = True
        cbSatuan.Items.AddRange(New Object() {"Pilih Satuan ", "km", "hm", "dam", "m", "dm", "cm", "mm"})
        cbSatuan.Location = New Point(339, 184)
        cbSatuan.Name = "cbSatuan"
        cbSatuan.Size = New Size(194, 28)
        cbSatuan.TabIndex = 11
        ' 
        ' cbKonversi
        ' 
        cbKonversi.FormattingEnabled = True
        cbKonversi.Items.AddRange(New Object() {"Pilih Satuan Konversi", "km", "hm", "dam", "m", "dm", "cm", "mm"})
        cbKonversi.Location = New Point(339, 243)
        cbKonversi.Name = "cbKonversi"
        cbKonversi.Size = New Size(194, 28)
        cbKonversi.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbKonversi)
        Controls.Add(cbSatuan)
        Controls.Add(txtHasil)
        Controls.Add(Label5)
        Controls.Add(btnKonversi)
        Controls.Add(btnClear)
        Controls.Add(txtJumlah)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnKonversi As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents cbKonversi As ComboBox
End Class
