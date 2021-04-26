using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelo
{
    //Classe que define informações sobre um Funcionario.
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public Endereco End { get; set; }


        public Funcionario(string Nome, string Cpf, string Senha, string Celular, string Genero, string Email, Endereco End)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Senha = Senha;
            this.Celular = Celular;
            this.Genero = Genero;
            this.Email = Email;
            this.End = End;
        }
    }
}
