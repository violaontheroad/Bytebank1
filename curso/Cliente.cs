using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class Cliente
    { 
        public Cliente(string cpf, string nome, string profissao)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Profissão = profissao;
        }    
        private string cpf;
        private string nome { get; set; }
        private string profissao { get; set; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Profissão { get => profissao; set => profissao = value; }
    }
}
