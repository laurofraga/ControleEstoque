namespace ProjFinal.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int FuncionarioResponsavel { get; set; }

        public Funcionario FuncionarioResponsavel { get; set; }
        public ICollection<Produto> Produtos {  get; set; }
    }
}
