using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgroMVC.Models
{
    public class VeiculosImplementos
    {
        //atributos da classe
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitarioAtual { get; set; }
        public double ValorResidual { get; set; }
        public int DuracaoAdicionalAnos { get; set; }
        public double Depreciacao { get; set; }
        public double ValorTotal { get; set; }
        public double GastosReforma { get; set; }



        //contrutor vazio
        public VeiculosImplementos()
        {

        }


    }
}
