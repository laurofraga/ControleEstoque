namespace ProjFinal.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();  
    }
}
