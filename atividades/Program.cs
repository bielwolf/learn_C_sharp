class ProdutoRestaurante
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> pedidos = new List<Pedido>();

}

class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade{ get; set; }
}

class Cardapio
{
    public List<ProdutoRestaurante> itens = new List<ProdutoRestaurante>();
}

class Restaurante
{
    public Cardapio cardapio { get; set; } = new Cardapio();
    public List<Mesa> mesas = new List<Mesa>();
}