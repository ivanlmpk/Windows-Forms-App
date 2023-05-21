<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnEscolherArquivo = New Button()
        ofdEscolherArquivo = New OpenFileDialog()
        txtDescricao = New TextBox()
        cboStatus = New ComboBox()
        btnConfirmar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' btnEscolherArquivo
        ' 
        btnEscolherArquivo.Font = New Font("Yu Gothic", 9.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEscolherArquivo.Location = New Point(28, 31)
        btnEscolherArquivo.Name = "btnEscolherArquivo"
        btnEscolherArquivo.Size = New Size(206, 26)
        btnEscolherArquivo.TabIndex = 0
        btnEscolherArquivo.Text = "Escolher arquivo..."
        btnEscolherArquivo.UseVisualStyleBackColor = True
        ' 
        ' ofdEscolherArquivo
        ' 
        ofdEscolherArquivo.FileName = "..."' 
        ' txtDescricao
        ' 
        txtDescricao.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtDescricao.Location = New Point(28, 82)
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(596, 23)
        txtDescricao.TabIndex = 1
        txtDescricao.Text = "Descrição..."' 
        ' cboStatus
        ' 
        cboStatus.Font = New Font("Yu Gothic", 8.75F, FontStyle.Bold, GraphicsUnit.Point)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Aprovado", "Reprovado", "Pendente"})
        cboStatus.Location = New Point(503, 34)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(121, 24)
        cboStatus.TabIndex = 2
        cboStatus.Text = "Aprovado"' 
        ' btnConfirmar
        ' 
        btnConfirmar.Font = New Font("Yu Gothic", 10.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirmar.Location = New Point(28, 150)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(172, 39)
        btnConfirmar.TabIndex = 3
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Yu Gothic", 10.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.Location = New Point(451, 150)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(173, 39)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' UploadForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(656, 217)
        Controls.Add(btnCancelar)
        Controls.Add(btnConfirmar)
        Controls.Add(cboStatus)
        Controls.Add(txtDescricao)
        Controls.Add(btnEscolherArquivo)
        Name = "UploadForm"
        Text = "Selecione o seu arquivo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEscolherArquivo As Button
    Friend WithEvents ofdEscolherArquivo As OpenFileDialog
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
End Class
