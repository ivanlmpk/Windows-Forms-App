Imports Microsoft.EntityFrameworkCore

Public Class AplicacaoContext
    Inherits DbContext

    Public Property Documentos As DbSet(Of Documento)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=GerenciadorDB;User Id=sa;Password=1q2w3e4r@#$;")
    End Sub
End Class
