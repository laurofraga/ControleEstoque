﻿namespace ProjFinal.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? FuncionarioResponsavelId { get; set; }

        public Funcionario FuncionarioResponsavel  { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
