# Windows-Forms-App
An Windows Forms application builded with Visual Basic, Entityframework and SQL Server to manage files.

## Gerenciador de Arquivos VB.NET
Este projeto é um aplicativo de desktop simples, escrito em Visual Basic que serve como gerenciador de arquivos. O software fornece uma interface intuitiva e fácil de usar, permitindo aos usuários gerenciar seus documentos de maneira eficiente.

### Características:
- **Upload de Arquivos**: Os usuários podem fazer upload de arquivos, que são então armazenados em um diretório local e as informações pertinentes são salvas em um banco de dados.
- **Visualização de Arquivos**: Os arquivos carregados são exibidos em um DataGridView, que fornece uma visão geral dos arquivos, incluindo nome, descrição, status e caminho do arquivo.
- **Download de Arquivos**: O aplicativo permite que os usuários baixem os arquivos, copiando-os para o diretório desejado.
- **Edição de Arquivos**: Os detalhes dos arquivos, como descrição e status, podem ser atualizados.
- **Exclusão de Arquivos**: Os usuários podem excluir arquivos, removendo-os do banco de dados e do sistema de arquivos local.

### Tecnologias Utilizadas:
O aplicativo foi desenvolvido usando Visual Basic para a interface do usuário e a lógica de negócios. O gerenciamento de dados é feito por meio do Entity Framework Core e por fim o banco de dados utilizado foi o SQL Server.

### Como Usar:
Baixe o código-fonte e abra o projeto em um ambiente de desenvolvimento que suporte VB, como o Visual Studio. Antes de iniciar a aplicação, certifique-se de configurar a string de conexão do banco de dados de acordo com o seu ambiente. Uma vez configurado, você pode compilar e executar o aplicativo.

