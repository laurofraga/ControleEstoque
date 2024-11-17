namespace ProjFinal.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Preco { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public int FornecedorId { get; set; }

        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}
