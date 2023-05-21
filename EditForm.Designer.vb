<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        txtDescricao = New TextBox()
        cboStatus = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        btnConfirmar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Font = New Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtDescricao.Location = New Point(47, 54)
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(600, 27)
        txtDescricao.TabIndex = 0
        ' 
        ' cboStatus
        ' 
        cboStatus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Aprovado", "Reprovado", "Pendente"})
        cboStatus.Location = New Point(47, 120)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(121, 23)
        cboStatus.TabIndex = 3
        cboStatus.Text = "Aprovado"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(47, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 4
        Label1.Text = "Nova descrição:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 5
        Label2.Text = "Novo status:"' 
        ' btnConfirmar
        ' 
        btnConfirmar.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirmar.Location = New Point(47, 171)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(172, 39)
        btnConfirmar.TabIndex = 6
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancelar.Location = New Point(474, 171)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(173, 39)
        btnCancelar.TabIndex = 7
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' EditForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        ClientSize = New Size(690, 238)
        Controls.Add(btnCancelar)
        Controls.Add(btnConfirmar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboStatus)
        Controls.Add(txtDescricao)
        Name = "EditForm"
        Text = "EditForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
End Class
