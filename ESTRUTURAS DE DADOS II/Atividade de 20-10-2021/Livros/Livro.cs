using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Livro
    {
       int isbn;                               
       string titulo;                            
       string autor;                          
       string editora;
       private List<Exemplar> exemplares;

        public object Isbn { get; internal set; }
        public int Isbn1 { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        internal List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public Livro(int isbn, string titulo, string autor, string editora, List<Exemplar> exemplares)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = exemplares;


        }
        public Livro(int isbn)
        {
            this.isbn = isbn;
        }


        public void AdicionarExemplar(Exemplar exemplar)
        {
            exemplar.Tombo = exemplares.Count + 1;
            exemplares.Add(exemplar);
        }
        public int QtdeExemplares()
        {
            return exemplares.Count;
        }
        public int QtdeDisponiveis()
        {
            int qtdDisponiveis = 0;
            foreach (Exemplar exemplar in exemplares)
            {
                if (exemplar.Disponivel())
                {
                    qtdDisponiveis++;
                }
            }
            return qtdDisponiveis;
        }
        public int QtdeEmprestimos()
        {
            int qtdeEmprestimosTotal = 0;
            foreach (Exemplar exemplar in exemplares)
            {
                qtdeEmprestimosTotal += exemplar.QtdeEmprestimos();
            }
            return qtdeEmprestimosTotal;
        }
        public double PercDisponibilidade()
        {
            return (QtdeDisponiveis() / (double)QtdeExemplares()) * 100;
        }

    }
}
