using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Exemplar
    {
       
        private int tombo;
        private List<Emprestimo> emprestimos = new();
        

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }
        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
            set { emprestimos = value; }
        }
       
        public bool Emprestar()
        {
            if (Disponivel())
            {
                emprestimos.Add(new Emprestimo(DateTime.Now));
                return true;
            }
            return false;
        }
        public bool Devolver()
        {
            if (!Disponivel())
            {
                emprestimos.Last().DtDevolucao = DateTime.Now;
                return true;
            }
            return false;
        }
        public bool Disponivel()
        {
            if (emprestimos.Count != 0 && emprestimos.Last().DtDevolucao == DateTime.MinValue)
            {
                return false;
            }
            return true;
        }
        public int QtdeEmprestimos()
        {
            return emprestimos.Count;
        }
        
    }
}
