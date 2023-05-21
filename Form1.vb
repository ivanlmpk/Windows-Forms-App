Imports System.IO

Public Class Gerenciador
    Private Sub btnUpload(sender As Object, e As EventArgs) Handles Upload.Click
        Dim uploadForm = New UploadForm()

        If uploadForm.ShowDialog() = DialogResult.OK Then
            'Obtém o nome do arquivo
            Dim nomeArquivo = Path.GetFileName(uploadForm.Selecionado)

            'Cria o diretório "Arquivos" se ele ainda não existir
            Dim diretorio = Path.Combine(Application.StartupPath, "Arquivos")
            If Not Directory.Exists(diretorio) Then
                Directory.CreateDirectory(diretorio)
            End If

            'Define o caminho de destino do arquivo
            Dim destino = Path.Combine(diretorio, nomeArquivo)

            'Copia o arquivo para o destino
            File.Copy(uploadForm.Selecionado, destino)

            'Salva os detalhes do arquivo no banco de dados
            Using db = New AplicacaoContext()
                Dim doc = New Documento() With {
                .Nome = nomeArquivo,
                .Descricao = uploadForm.Descricao,
                .Status = uploadForm.Status,
                .Caminho = destino
            }
                db.Documentos.Add(doc)
                db.SaveChanges()
            End Using

            Using db = New AplicacaoContext()
                AtualizarListaDocumentos(db)
            End Using
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub AtualizarListaDocumentos(db As AplicacaoContext)
        DataGridView1.DataSource = db.Documentos.ToList()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db = New AplicacaoContext()
            AtualizarListaDocumentos(db)
        End Using

        Dim toolTip1 As New ToolTip()

        toolTip1.InitialDelay = 100
        toolTip1.ReshowDelay = 100
        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(Me.PictureBox1, "Sistema para gerenciamento de arquivos." & vbCrLf & "Você poderá salvar qualquer arquivo com segurança e ter acesso a ele no momento que quiser.")
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim id = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)

        Using db = New AplicacaoContext()
            Dim doc = db.Documentos.Find(id)

            Dim saveFileDialog = New SaveFileDialog()
            saveFileDialog.FileName = doc.Nome
            saveFileDialog.Filter = "All Files|*.*"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                File.Copy(doc.Caminho, saveFileDialog.FileName)

                MessageBox.Show("Download concluído com sucesso!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim id = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)

        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir este arquivo?", "Confirmação de Exclusão", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Using db = New AplicacaoContext()
                Dim doc = db.Documentos.Find(id)
                db.Documentos.Remove(doc)
                db.SaveChanges()
                File.Delete(doc.Caminho)
            End Using

            MessageBox.Show("Arquivo excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Using db = New AplicacaoContext()
                AtualizarListaDocumentos(db)
            End Using
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim id = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)

        Using db = New AplicacaoContext()
            ' Encontra o documento correspondente no banco de dados
            Dim doc = db.Documentos.Find(id)
            If doc IsNot Nothing Then
                ' Cria uma instância do formulário de edição
                Dim editForm = New EditForm(doc.Descricao, doc.Status)
                If editForm.ShowDialog() = DialogResult.OK Then
                    ' Atualiza a descrição e o status do documento
                    doc.Descricao = editForm.Descricao
                    doc.Status = editForm.Status
                    ' Salva as alterações no banco de dados
                    db.SaveChanges()

                    ' Atualiza a lista de documentos
                    AtualizarListaDocumentos(db)
                End If
            End If
        End Using
    End Sub

End Class
