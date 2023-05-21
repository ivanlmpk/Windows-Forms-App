<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gerenciador
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Gerenciador))
        Upload = New Button()
        DataGridView1 = New DataGridView()
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        NomeDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DescricaoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        StatusDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CaminhoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DocumentoBindingSource = New BindingSource(components)
        OpenFileDialog1 = New OpenFileDialog()
        AplicacaoContextBindingSource = New BindingSource(components)
        Label1 = New Label()
        btnDownload = New Button()
        btnExcluir = New Button()
        btnEditar = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DocumentoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(AplicacaoContextBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Upload
        ' 
        Upload.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Upload.Location = New Point(357, 79)
        Upload.Name = "Upload"
        Upload.Size = New Size(174, 37)
        Upload.TabIndex = 0
        Upload.Text = "Upload"
        Upload.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, NomeDataGridViewTextBoxColumn, DescricaoDataGridViewTextBoxColumn, StatusDataGridViewTextBoxColumn, CaminhoDataGridViewTextBoxColumn})
        DataGridView1.DataSource = DocumentoBindingSource
        DataGridView1.Location = New Point(79, 156)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(762, 372)
        DataGridView1.TabIndex = 2
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "Id"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn" ' 
        ' NomeDataGridViewTextBoxColumn
        ' 
        NomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn" ' 
        ' DescricaoDataGridViewTextBoxColumn
        ' 
        DescricaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn" ' 
        ' StatusDataGridViewTextBoxColumn
        ' 
        StatusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn" ' 
        ' CaminhoDataGridViewTextBoxColumn
        ' 
        CaminhoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CaminhoDataGridViewTextBoxColumn.DataPropertyName = "Caminho"
        CaminhoDataGridViewTextBoxColumn.HeaderText = "Caminho"
        CaminhoDataGridViewTextBoxColumn.Name = "CaminhoDataGridViewTextBoxColumn" ' 
        ' DocumentoBindingSource
        ' 
        DocumentoBindingSource.DataSource = GetType(Documento)
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1" ' 
        ' AplicacaoContextBindingSource
        ' 
        AplicacaoContextBindingSource.DataSource = GetType(AplicacaoContext)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(316, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 24)
        Label1.TabIndex = 3
        Label1.Text = "Gerenciador de Arquivos 1.0 2023" ' 
        ' btnDownload
        ' 
        btnDownload.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDownload.Location = New Point(79, 560)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(210, 39)
        btnDownload.TabIndex = 4
        btnDownload.Text = "Download"
        btnDownload.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnExcluir.Location = New Point(631, 560)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(210, 39)
        btnExcluir.TabIndex = 5
        btnExcluir.Text = "Deletar"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditar.Location = New Point(357, 560)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(210, 39)
        btnEditar.TabIndex = 6
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(794, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Gerenciador
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(925, 651)
        Controls.Add(PictureBox1)
        Controls.Add(btnEditar)
        Controls.Add(btnExcluir)
        Controls.Add(btnDownload)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Upload)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Gerenciador"
        Text = " "
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DocumentoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(AplicacaoContextBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Upload As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DocumentoBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaminhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AplicacaoContextBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
