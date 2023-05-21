Public Class UploadForm
    Private _selecionado As String
    Public ReadOnly Property Selecionado As String
        Get
            Return _selecionado
        End Get
    End Property

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

    Private Sub btnEscolherArquivo_Click(sender As Object, e As EventArgs) Handles btnEscolherArquivo.Click
        If ofdEscolherArquivo.ShowDialog() = DialogResult.OK Then
            ' Armazenando o arquivo dentro da variavel _selecionado
            _selecionado = ofdEscolherArquivo.FileName
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Verifica se o usuário já escolheu um arquivo antes de confirmar
        If Not String.IsNullOrWhiteSpace(_selecionado) Then
            _descricao = txtDescricao.Text
            _status = cboStatus.SelectedItem.ToString()
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class