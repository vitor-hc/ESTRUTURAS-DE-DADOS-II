using System;

namespace CicloEventos
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            int opSelecionada;

            Eventos eventos = new Eventos();

            Console.WriteLine("0. Sair\n1. Adicionar evento\n2. Pesquisar evento\n3. Listar eventos\n4. Adicionar participante\n5. Pesquisar participante\n6. Quantidade total de participantes nos eventos da semana\n");
            opSelecionada = int.Parse(Console.ReadLine());

            while (!sair)
            {
                switch (opSelecionada)
                {
                    case 0:
                        sair = true;
                        break;
                    case 1:
                        ;
                        break;
                    case 2:
                       ;
                        break;
                    case 3:
                        ;
                        break;
                    case 4:
                        ;
                        break;
                    case 5:
                       ;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha uma opção informada a cima.");
                        break;
                }

                void addEvento(Eventos eventos)
                {
                    Console.WriteLine("Digite o dia do evento (1=SEG, 2=TER, ..., 6=SAB):");
                    int day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Id do evento:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Descrição do evento:");
                    string descricao = Console.ReadLine();

                    Console.WriteLine("Quantidade máxima de participantes:");
                    int qtdMax = int.Parse(Console.ReadLine());

                    eventos.adicionarEvento(new Evento(id, descricao, qtdMax), day);
                    Console.WriteLine("Evento adicionado com sucesso.");
                }

                void pesqEvento(Eventos eventos)
                {
                    Console.WriteLine("Digite o id do evento que deseja procurar:");
                    int id = int.Parse(Console.ReadLine());

                    string dadosEvento = eventos.pesquisarEvento(id);
                    if (dadosEvento.Equals(""))
                    {
                        Console.WriteLine("Evento não encontrado.");
                    }
                    else
                    {
                        Console.WriteLine(dadosEvento);
                    }
                }

                void listEvento(Eventos eventos)
                {
                    string dadosEventos = eventos.listaEventos();

                    if (dadosEventos.Equals(""))
                    {
                        Console.WriteLine("Sem eventos cadastrados");
                    }
                    else
                    {
                        Console.WriteLine(dadosEventos);
                    }
                }

                void addParticipante(Eventos eventos)
                {
                    Console.WriteLine("Evento de qual dia? (1=SEG, 2=TER, ..., 6=SAB)");
                    int day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o email do participante:");
                    string email = Console.ReadLine();

                    Console.WriteLine("Digite o nome do participante:");
                    string nome = Console.ReadLine();

                    switch (eventos.inscreverParticipante(day, new Participante(email, nome)))
                    {
                        case 0:
                            Console.WriteLine("Inscrição efetuada com sucesso.");
                            break;
                        case 1:
                            Console.WriteLine("Evento lotado");
                            break;
                        case 2:
                            Console.WriteLine("Excedido limite de inscrições para o participante");
                            break;
                    }
                }

                void pesqParticipante(Eventos eventos)
                {
                    Console.WriteLine("Digite o email do participante para realizar a pesquisa:");
                    string email = Console.ReadLine();

                    string dadosParticipante = eventos.pesquisarParticipante(new Participante(email, "..."));
                    if (dadosParticipante.Equals(""))
                    {
                        Console.WriteLine("Participante não cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine(dadosParticipante);
                    }
                }

                void infQuantidade(Eventos eventos)
                {
                    Console.WriteLine($"Total de participantes: {eventos.qtdeParticipantes()}");
                }



            }

        }
    }
}
