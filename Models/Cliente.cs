using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNovaViagens.Models
{
    public class Cliente
    {
        [key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public string email { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public string Plano { get; set; }
        public string Login { get; set; }
        public int Senha { get; set; }
    }
}
