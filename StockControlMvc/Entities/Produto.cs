namespace StockControlMvc.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; } 
    }
}
