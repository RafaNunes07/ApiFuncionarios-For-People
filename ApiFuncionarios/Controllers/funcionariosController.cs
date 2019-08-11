using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiFuncionarios.Models;

namespace ApiFuncionarios.Controllers
{
    [RoutePrefix("api/funcionarios")]
    public class funcionariosController : ApiController
    {
        //Cria uma Lista de Funcionários
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        //Inicializa a lista de funcionários com valor pré definido
        public funcionariosController()
        {
            if (funcionarios.Count == 0)
            {
                funcionarios.Add(new Funcionario(1, "Rafael", "Analista", "Desenvolvimento", "Rua Gonçalves Baldaia, 127", DateTime.Now, DateTime.Now));
            }    
        }

        //Chamada para retornar a lista completa de funcionários 
        [HttpGet]
        [Route("list")]
        public List<Funcionario> Listar()
        {
            return funcionarios;
        }

        //Chamada que retorna um funcionário a partir de um ID
        [HttpGet]
        [Route("show")]
        public Funcionario Consultar(int id)
        {
            int index = funcionarios.FindIndex(p => p.Matricula == id);
            //Valida se o ID passado foi encontrado na lista de funcionários
            if (index == -1)
            {
                throw new ArgumentNullException("Não Encontrado");
            }
            Funcionario func = funcionarios.Where(n => n.Matricula == id).Select(n => n).FirstOrDefault();

            return func;
        }

        //Chamada para cadastrar um funcionário, sendo necessário os argumentos Nome, Cargo, Setor e Endereço
        [HttpPost]
        [Route("create")]
        public void Cadastrar(string nome, string cargo, string setor, string endereco)
        {
            //Valida se algum argumento está em branco ou é nulo
            if (!string.IsNullOrEmpty(nome) & !string.IsNullOrEmpty(cargo) & !string.IsNullOrEmpty(setor) & !string.IsNullOrEmpty(endereco))
            {
                //Conta quantos funcionários possui a lista e incremente o ID
                int ProximoID = funcionarios.Count + 1;
                funcionarios.Add(new Funcionario(ProximoID, nome, cargo, setor, endereco, DateTime.Now, DateTime.Now));
            }
            else throw new ArgumentNullException("Não Encontrado");
        }

        //Chamada para deletar um funcionário da lista, com base no ID passado como argumento
        [HttpDelete]
        [Route("destroy")]
        public void Destroy(int id)
        {
            int index = funcionarios.FindIndex(p => p.Matricula == id);
            //Valida se o ID passado como argumento está na lista de funcionários
            if (index == -1)
            {
                throw new ArgumentNullException("Não Encontrado");
            }
            //Atribui os valores correspondentes ao ID para uma variável
            Funcionario func = funcionarios.Where(n => n.Matricula == id).Select(n => n).FirstOrDefault();
            //Remove da lista de funcionários
            funcionarios.Remove(func);
        }

        //Chamada para atualizar um funcionário na lista, com base em um ID passado como argumento 
        [HttpPut]
        [Route("update")]
        public void AlterarFuncionario(int id, string nome, string cargo, string setor, string endereco)
        {

            int index = funcionarios.FindIndex(p => p.Matricula == id);
            //Valida se o ID está na lista de funcionários
            if (index == -1)
            {
                throw new ArgumentNullException("Não Encontrado");
            }
            //Atualiza os dados de Nome, Cargo, Setor e Endereço do ID informado
            Funcionario aux = funcionarios.Where(n => n.Matricula == id).Select(n => n).First();
            aux.Nome = nome;
            aux.Cargo = cargo;
            aux.Setor = setor;
            aux.DtAtualizacao = DateTime.Now;
            aux.Endereco[0] = endereco;
            funcionarios.RemoveAt(index);
            funcionarios.Add(aux);
        }
    }
}
