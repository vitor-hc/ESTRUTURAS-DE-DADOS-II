using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Emprestimo
    {


       
        private DateTime dtEmprestimo = DateTime.MinValue;
        private DateTime dtDevolucao = DateTime.MinValue;
        
        public Emprestimo(DateTime dtEmprestimo)
        {
            this.dtEmprestimo = dtEmprestimo;
        }
        
        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }
        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }
    }
}
