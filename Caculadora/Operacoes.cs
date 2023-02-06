using Caculadora.basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculadora
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multipicacao Multipicacao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multipicacao = new Multipicacao();
            this.Divisao = new Divisao();
        }
    }
}
