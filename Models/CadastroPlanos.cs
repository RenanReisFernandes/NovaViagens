using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNovaViagens.Models
{
    public class CadastroPlanos
    {
        [key]
        public int ID { get; set; }
        public string Plano { get; set; }
        public DateTime Adesao { get; set; }
        public string Login { get; set; }
        public int Senha { get; set; }
    }
}
