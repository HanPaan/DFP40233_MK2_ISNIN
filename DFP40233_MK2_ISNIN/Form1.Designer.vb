﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblNama = New Label()
        lblNoTel = New Label()
        lblAlamat = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        lblNegeri = New Label()
        ComboBox1 = New ComboBox()
        lblJantina = New Label()
        rdbLelaki = New RadioButton()
        rdbPerempuan = New RadioButton()
        lblKaedahPembayaran = New Label()
        rdbCash = New RadioButton()
        rdbCashless = New RadioButton()
        lblPerisa = New Label()
        ckbMilo = New CheckBox()
        ckbKopi = New CheckBox()
        ckbCoklat = New CheckBox()
        ckbStrawberi = New CheckBox()
        ckbPisang = New CheckBox()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        dgvMaklumat = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnUpdate = New Button()
        BtnRead = New Button()
        BtnDelete = New Button()
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(305, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 35)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(58, 101)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama:"
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(54, 144)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(56, 20)
        lblNoTel.TabIndex = 2
        lblNoTel.Text = "No. tel:"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(50, 183)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(60, 20)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(116, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(337, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(116, 141)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(337, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(116, 183)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(337, 71)
        TextBox3.TabIndex = 6
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(53, 276)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(57, 20)
        lblNegeri.TabIndex = 7
        lblNegeri.Text = "Negeri:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(116, 276)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(143, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(566, 101)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(58, 20)
        lblJantina.TabIndex = 9
        lblJantina.Text = "Jantina:"
        ' 
        ' rdbLelaki
        ' 
        rdbLelaki.AutoSize = True
        rdbLelaki.Location = New Point(630, 101)
        rdbLelaki.Name = "rdbLelaki"
        rdbLelaki.Size = New Size(68, 24)
        rdbLelaki.TabIndex = 10
        rdbLelaki.TabStop = True
        rdbLelaki.Text = "Lelaki"
        rdbLelaki.UseVisualStyleBackColor = True
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.AutoSize = True
        rdbPerempuan.Location = New Point(630, 131)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(104, 24)
        rdbPerempuan.TabIndex = 11
        rdbPerempuan.TabStop = True
        rdbPerempuan.Text = "Perempuan"
        rdbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' lblKaedahPembayaran
        ' 
        lblKaedahPembayaran.AutoSize = True
        lblKaedahPembayaran.Location = New Point(475, 183)
        lblKaedahPembayaran.Name = "lblKaedahPembayaran"
        lblKaedahPembayaran.Size = New Size(149, 20)
        lblKaedahPembayaran.TabIndex = 12
        lblKaedahPembayaran.Text = "Kaedah pembayaran:"
        ' 
        ' rdbCash
        ' 
        rdbCash.AutoSize = True
        rdbCash.Location = New Point(630, 181)
        rdbCash.Name = "rdbCash"
        rdbCash.Size = New Size(61, 24)
        rdbCash.TabIndex = 13
        rdbCash.TabStop = True
        rdbCash.Text = "Cash"
        rdbCash.UseVisualStyleBackColor = True
        ' 
        ' rdbCashless
        ' 
        rdbCashless.AutoSize = True
        rdbCashless.Location = New Point(630, 211)
        rdbCashless.Name = "rdbCashless"
        rdbCashless.Size = New Size(85, 24)
        rdbCashless.TabIndex = 14
        rdbCashless.TabStop = True
        rdbCashless.Text = "Cashless"
        rdbCashless.UseVisualStyleBackColor = True
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(574, 276)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(50, 20)
        lblPerisa.TabIndex = 15
        lblPerisa.Text = "Perisa:"
        ' 
        ' ckbMilo
        ' 
        ckbMilo.AutoSize = True
        ckbMilo.Location = New Point(630, 272)
        ckbMilo.Name = "ckbMilo"
        ckbMilo.Size = New Size(61, 24)
        ckbMilo.TabIndex = 16
        ckbMilo.Text = "Milo"
        ckbMilo.UseVisualStyleBackColor = True
        ' 
        ' ckbKopi
        ' 
        ckbKopi.AutoSize = True
        ckbKopi.Location = New Point(630, 302)
        ckbKopi.Name = "ckbKopi"
        ckbKopi.Size = New Size(62, 24)
        ckbKopi.TabIndex = 17
        ckbKopi.Text = "Kopi"
        ckbKopi.UseVisualStyleBackColor = True
        ' 
        ' ckbCoklat
        ' 
        ckbCoklat.AutoSize = True
        ckbCoklat.Location = New Point(630, 332)
        ckbCoklat.Name = "ckbCoklat"
        ckbCoklat.Size = New Size(73, 24)
        ckbCoklat.TabIndex = 18
        ckbCoklat.Text = "Coklat"
        ckbCoklat.UseVisualStyleBackColor = True
        ' 
        ' ckbStrawberi
        ' 
        ckbStrawberi.AutoSize = True
        ckbStrawberi.Location = New Point(739, 272)
        ckbStrawberi.Name = "ckbStrawberi"
        ckbStrawberi.Size = New Size(94, 24)
        ckbStrawberi.TabIndex = 19
        ckbStrawberi.Text = "Strawberi"
        ckbStrawberi.UseVisualStyleBackColor = True
        ' 
        ' ckbPisang
        ' 
        ckbPisang.AutoSize = True
        ckbPisang.Location = New Point(739, 302)
        ckbPisang.Name = "ckbPisang"
        ckbPisang.Size = New Size(74, 24)
        ckbPisang.TabIndex = 20
        ckbPisang.Text = "Pisang"
        ckbPisang.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(60, 336)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(50, 20)
        lblTarikh.TabIndex = 21
        lblTarikh.Text = "Tarikh:"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(116, 336)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(337, 27)
        dtpTarikh.TabIndex = 22
        ' 
        ' dgvMaklumat
        ' 
        dgvMaklumat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaklumat.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgvMaklumat.Location = New Point(116, 394)
        dgvMaklumat.Name = "dgvMaklumat"
        dgvMaklumat.RowHeadersWidth = 51
        dgvMaklumat.Size = New Size(424, 79)
        dgvMaklumat.TabIndex = 23
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Bil."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No. tel"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(574, 394)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 24
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(719, 394)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 25
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(574, 444)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 26
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(719, 444)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 27
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 538)
        Controls.Add(BtnDelete)
        Controls.Add(BtnRead)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnCreate)
        Controls.Add(dgvMaklumat)
        Controls.Add(dtpTarikh)
        Controls.Add(lblTarikh)
        Controls.Add(ckbPisang)
        Controls.Add(ckbStrawberi)
        Controls.Add(ckbCoklat)
        Controls.Add(ckbKopi)
        Controls.Add(ckbMilo)
        Controls.Add(lblPerisa)
        Controls.Add(rdbCashless)
        Controls.Add(rdbCash)
        Controls.Add(lblKaedahPembayaran)
        Controls.Add(rdbPerempuan)
        Controls.Add(rdbLelaki)
        Controls.Add(lblJantina)
        Controls.Add(ComboBox1)
        Controls.Add(lblNegeri)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTel)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents rdbLelaki As RadioButton
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents lblKaedahPembayaran As Label
    Friend WithEvents rdbCash As RadioButton
    Friend WithEvents rdbCashless As RadioButton
    Friend WithEvents lblPerisa As Label
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents ckbCoklat As CheckBox
    Friend WithEvents ckbStrawberi As CheckBox
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvMaklumat As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnDelete As Button

End Class
