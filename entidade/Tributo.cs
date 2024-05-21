using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaJJM.entidade
{
    internal class Tributo
    {
        public int? ID { get; set; }
        public string Nome { get; set;}
        public int porcentagem { get; set;}

        public Tributo(int? iD, string nome, int porcentagem)
        {
            ID = iD;
            Nome = nome;
            this.porcentagem = porcentagem;
        }
        public string inserir()
        {

            return "Cadastrado com sucesso";
        }
    }
}
