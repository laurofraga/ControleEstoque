using Microsoft.AspNetCore.Identity;
namespace ProjFinal.Models
{
    public class Funcionario : IdentityUser
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public String User { get; set; }
        public string Password { get; set; }
        public string Cargo { get; set; }

        public List<Categoria> Categorias { get; set; } = new List<Categoria>();
        public List<Movimentacao> Movimentacao { get; set; } = new List<Movimentacao>();
    }
}
