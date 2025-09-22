namespace APICatalogo.Models;

public class Categoria
{
    //Atenção: como será mapeado para o banco de dados, é necessário ter a propriedade Id primeiro
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }
    public ICollection<Produto>? Produtos { get; set; }
}
