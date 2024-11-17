namespace ProjFinal.Models
{
    public class Movimentacao
    {
        public int IdMoimentacao{ get; set; }
        public int ProdutoId { get; set; }
        public string TipoMovimentacao  { get; set; }
        public int  Quantidade { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int FuncionarioId { get; set; }


        public Produto Produto { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
