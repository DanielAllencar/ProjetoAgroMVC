using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgroMVC.Models
{
    public class CulturasPermanentes
    {
        //atributos da classe
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorAtualInvestimento { get; set; }
        public double AreaHa { get; set; }
        public double VidaUtilRestante { get; set; }
        public double Exaustao { get; set; }
        public double ValorTotalArea { get; set; }
        public double Investimentos { get; set; }


    }
}
