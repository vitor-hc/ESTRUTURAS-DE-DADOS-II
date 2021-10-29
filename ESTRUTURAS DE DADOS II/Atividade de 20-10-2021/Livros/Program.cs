using System;
using System.Collections.Generic;

namespace Livros
{
    class Program
    {

        static Livros acervo = new();
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int op;
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Pesquisar Livro (sintético)");
                Console.WriteLine("3. Pesquisar Livro (analítico)");
                Console.WriteLine("4. Adicionar exemplar");
                Console.WriteLine("5. Registrar empréstimo");
                Console.WriteLine("6. Registrar devolução");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());
                if (op > 6)
                {
                    Console.WriteLine("Opcao invalida!");
                }
                Console.WriteLine("");
                    switch (op)
                    {

                        case 0:
                            break;
                        case 1:
                            AdicionarLivro();
                            break;
                        case 2:
                            PesquisaSintetica();
                            break;
                        case 3:
                            PesquisaAnalitica();
                            break;
                        case 4:
                            AdicionarExemplar();
                            break;
                        case 5:
                            RegistrarEmprestimo();
                            break;
                        case 6:
                            RegistrarDevolucao();
                            break;
                    }
               
            }
            while (op != 0);
        }
       
       
        private static void AdicionarLivro()
        {
            Console.Write("Digite o ISBN: ");
            int isbnNovo = int.Parse(Console.ReadLine());
            Console.Write("Digite o Titulo: ");
            string tituloNovo = Console.ReadLine();
            Console.Write("Digite o Autor: ");
            string autorNovo = Console.ReadLine();
            Console.Write("Digite o Editora: ");
            string editoraNovo = Console.ReadLine();
            List<Exemplar> exemplaresNovo = new();
            acervo.Adicionar(new Livro(isbnNovo, tituloNovo, autorNovo, editoraNovo, exemplaresNovo));
        }
        private static Livro Pesquisa()
        {
            Console.Write("Digite o ISBN: ");
            int isbnPesquisa = int.Parse(Console.ReadLine());
            Livro livroPesquisado = acervo.Pesquisar(new Livro(isbnPesquisa));
            if (livroPesquisado == null)
            {
                Console.WriteLine("Livro nao existe no acervo");
                return null;
            }
            else
            {
                return livroPesquisado;
            }
        }
        private static Livro PesquisaSintetica()
        {
            Livro livroPesquisado = Pesquisa();
            Console.WriteLine("----- {0} ----- por {1} - {2}", livroPesquisado.Titulo, livroPesquisado.Autor, livroPesquisado.Editora);
            Console.WriteLine("Total Exemplares: {0}", livroPesquisado.QtdeExemplares());
            Console.WriteLine("Total Exemplares Disponíveis: {0}", livroPesquisado.QtdeDisponiveis());
            Console.WriteLine("Total Emprestimos: {0}", livroPesquisado.QtdeEmprestimos());
            Console.WriteLine("Percentual de disponibilidade: {0}%", livroPesquisado.PercDisponibilidade());
            return livroPesquisado;
        }
        private static void PesquisaAnalitica()
        {
            Livro livroPesquisado = PesquisaSintetica();
            Console.WriteLine("Emprestimos: ");
            Console.WriteLine("-----------------------------------");
            foreach (Exemplar exemplar in livroPesquisado.Exemplares)
            {
                Console.WriteLine("Exemplar n.{0}", exemplar.Tombo);
                foreach (Emprestimo emprestimo in exemplar.Emprestimos)
                {
                    Console.WriteLine("Emprestimo: {0}", emprestimo.DtEmprestimo);
                    if (emprestimo.DtDevolucao == DateTime.MinValue)
                    {
                        Console.WriteLine("Em emprestimo");
                    }
                    else
                    {
                        Console.WriteLine("Devolvido: {0}", emprestimo.DtDevolucao);
                    }
                }
            }
        }
        private static void AdicionarExemplar()
        {
            Livro livroParaExemplar = Pesquisa();
            livroParaExemplar.AdicionarExemplar(new Exemplar());
            Console.WriteLine("Exemplar adicionado ao livro: {0}", livroParaExemplar.Titulo);
        }
        private static void RegistrarEmprestimo()
        {
            Livro livroParaEmprestar = Pesquisa();
            for (int i = 0; i < livroParaEmprestar.QtdeExemplares(); i++)
            {
                if (livroParaEmprestar.Exemplares[i].Emprestar())
                {
                    Console.WriteLine("Exemplar {0}/{1} Emprestado!", i + 1, livroParaEmprestar.QtdeExemplares());
                    break;
                }
            }
        }
        private static void RegistrarDevolucao()
        {
            Livro livroParaDevolver = Pesquisa();
            for (int i = 0; i < livroParaDevolver.QtdeExemplares(); i++)
            {
                if (livroParaDevolver.Exemplares[i].Devolver())
                {
                    Console.WriteLine("Exemplar Devolvido!, Disponíveis: {0}", livroParaDevolver.QtdeExemplares());
                    break;
                }
            }
        }



    }
}