Public Class EditForm

    Private _descricao As String
    Public ReadOnly Property Descricao As String
        Get
            Return _descricao
        End Get
    End Property

    Private _status As String
    Public ReadOnly Property Status As String
        Get
            Return _status
        End Get
    End Property

    Public Sub New(descricao As String, status As String)
        InitializeComponent()

        ' Preenche os campos de texto com os valores iniciais
        txtDescricao.Text = descricao
        cboStatus.SelectedItem = status
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Verifica se uma descrição foi fornecida
        If String.IsNullOrEmpty(txtDescricao.Text) Then
            MessageBox.Show("Por favor, preencha a descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Atualiza _descricao e _status com os novos valores dos campos de texto
        _descricao = txtDescricao.Text
        _status = cboStatus.SelectedItem.ToString()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

End Class