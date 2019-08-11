using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFuncionarios.Models
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string[] Endereco { get; set; }
        public DateTime DtRegistro { get; set; }
        public DateTime DtAtualizacao { get; set; }


        public Funcionario(int id, string nome, string cargo, string setor, string endereco, DateTime dtRegistro, DateTime dtAtual)
        {
            //Atribui a string de enredeço recebida a um Array
            string[] str = new string[] { endereco };

            //Define as propriedades da classe de funcionário com os valores recebidos
            this.Matricula = id;
            this.Nome = nome;
            this.Cargo = cargo;
            this.Setor = setor;
            this.Endereco = str;
            this.DtRegistro = dtRegistro;
            this.DtAtualizacao = dtAtual;

        }
        


}
}