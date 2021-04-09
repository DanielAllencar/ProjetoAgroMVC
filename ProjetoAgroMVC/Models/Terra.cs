using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgroMVC.Models
{
    public class Terra
    {
        //atributos da classe
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double QtdArea { get; set; }
        public double ValorUnitarioArea { get; set; }
        public double ValorTotalArea { get; set; }



        //construtor vazio
        public Terra()
        {

        }

    }
}
