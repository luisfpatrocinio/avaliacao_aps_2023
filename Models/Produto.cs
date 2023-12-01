namespace LuisFPatrocinio.Models;

public class Produto{
    public int Id {get; set;}
    public string? Descricao {get; set;}
    public string PathImagem {get; set;}
    public decimal Preco {get; set;}
    public int Quantidade {get; set;}
    public Categoria Categoria {get; set;}


}