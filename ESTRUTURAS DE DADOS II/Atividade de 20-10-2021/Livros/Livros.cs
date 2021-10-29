using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Livros
    {
         private List<Livro> acervo = new();
        public void Adicionar(Livro livro)
        {
            acervo.Add(livro);
        }
        public Livro Pesquisar(Livro livro)
        {
            foreach(Livro livroAdicionado in acervo)
            {
                if (livroAdicionado.Isbn == livro.Isbn)
                {
                    return livroAdicionado;
                }
            }
            return null;
        }
    }
}
