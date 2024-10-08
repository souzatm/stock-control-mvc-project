namespace StockControlMvc.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
