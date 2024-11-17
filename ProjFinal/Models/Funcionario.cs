namespace ProjFinal.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Name { get; set; }
        public String User {  get; set; }
        public string Password { get; set; }
        public string Cargo { get; set; }
        
        public ICollection<Categoria> CategoriasResponsaveis { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}
