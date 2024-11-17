namespace ProjFinal.Models
{
    public class Fornecedor
    {
        public int IdFonecedor { get; set; }
        public string Name { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
