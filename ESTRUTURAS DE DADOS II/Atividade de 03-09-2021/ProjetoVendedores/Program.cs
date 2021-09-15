using System;

namespace ProjetoVendedores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int opSelecionada;

            Vendedores vendedores = new Vendedores();

            Console.WriteLine("0. Sair \n1.Cadastrar vendedor \n2.Consultar vendedor \n3.Excluir vendedor \n4.Registrar venda \n5.Listar vendedores\n");
            opSelecionada = int.Parse(Console.ReadLine());

            while (!sair)
            {

               


                switch (opSelecionada)
                {
                    case 0:
                        sair = true;
                        break;
                    case 1:
                        cadastrarVendedor(vendedores);
                        break;
                    case 2:
                        consultarVendedor(vendedores);
                        break;
                    case 3:
                        excluirVendedor(vendedores);
                        break;
                    case 4:
                        registrarVenda(vendedores);
                        break;
                    case 5:
                        listarVendedores(vendedores);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha uma opção informada a cima.");
                        break;
                }
            }

            void cadastrarVendedor(Vendedores vendedores)
            {
                Console.WriteLine("\nId do vendedor: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do vendedor: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Percentual de comissão do vendedor (0-100)%: ");
                double percComissao = double.Parse(Console.ReadLine());

                Console.WriteLine(vendedores.addVendedor(new Vendedor(id, nome, percComissao)) ? "Vendedor adicionado com sucesso." : "Não foi possível adicionar o vendedor, atingiu o limite máximo de vendedores cadastrado.");
            }

            void consultarVendedor(Vendedores vendedores)
            {
                Console.WriteLine("\n Para pesquisar um vendedor digite o seu Id: ");
                int id = int.Parse(Console.ReadLine());

                Vendedor vAchado = vendedores.searchVendedor(new Vendedor(id, "", 0));

                if (vAchado.Id == -1)
                {
                    Console.WriteLine("Vendedor não localizado.");
                    return;
                }

                Console.WriteLine($"\nId: {vAchado.Id} \nNome: {vAchado.Nome} \nValor total das vendas: R$ {vAchado.valorVendas()} \nValor da comissão: R$ {vAchado.valorComissao()}");
                Console.WriteLine("Valor médio das vendas diárias: ");
                int dia = 1;
                foreach (Venda venda in vAchado.AsVendas)
                {
                    if (venda.Valor > 0)
                    {
                        Console.WriteLine($"{dia}° dia: {venda.valorMedio()}");
                    }
                    dia++;
                }
            }

            void excluirVendedor(Vendedores vendedores)
            {
                Console.WriteLine("\nPara deletar um vendedor digite o seu Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine(vendedores.delVendedor(new Vendedor(id, "", 0)) ? "Vendedor deletado com sucesso." : "Não foi possível deletar o vendedor.");
            }

            void registrarVenda(Vendedores vendedores)
            {
                int dia;

                Console.WriteLine("\nDigite o id do vendedor: ");
                int id = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Digite o dia (1-31): ");
                    dia = int.Parse(Console.ReadLine());
                } while (dia < 1 || dia > 31);

                Console.WriteLine("Digite a quantidade de vendas: ");
                int qtde = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de venda do dia: ");
                double valor = double.Parse(Console.ReadLine());

                Vendedor v = vendedores.searchVendedor(new Vendedor(id, "", 0));
                if (v.Id == -1)
                {
                    Console.WriteLine("Vendedor não localizado.");
                    return;
                }

                v.registrarVenda(dia, new Venda(qtde, valor));
                Console.WriteLine("Venda registrada com sucesso.");
            }

            void listarVendedores(Vendedores vendedores)
            {
                foreach (Vendedor v in vendedores.OsVendedores)
                {
                    if (v.Id != -1)
                    {
                        Console.WriteLine($"\nId: {v.Id} \nNome: {v.Nome} \nValor total das vendas: R$ {v.valorVendas()} \nValor da comissão: R$ {v.valorComissao()}");
                    }
                }

                Console.WriteLine($"\nValor total das vendas de todos os vendedores: {vendedores.valorVendas()}");
                Console.WriteLine($"Valor total das comissões de todos os vendedores: {vendedores.valorComissao()}");
            }
        }
    }
}

