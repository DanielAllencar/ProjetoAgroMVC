using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgroMVC.Models
{
    public class BenfeitoriasMelhoramentos
    {
        //atributos da classe
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitarioEstadoAtual { get; set; }
        public double ValorResidualInvestimento { get; set; }
        public int DuracaoAdicionalAnos { get; set; }
        public double Depreciacao { get; set; }
        public double ValorTotal { get; set; }





    }
}
