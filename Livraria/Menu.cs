using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Menu
    {

        ControlPessoa controlePessoa;
        ControlLivro controlLivro;
        ControlReserva controlReserva;
        ControlCompra controlCompra;
        public int opcao;
        public Menu()
        {
            controlePessoa = new ControlPessoa();
            controlLivro = new ControlLivro();
            controlReserva = new ControlReserva();
            controlCompra = new ControlCompra();
            opcao = 0;

        }// fim do menu


        public void EscolherControl()
        {

            Console.WriteLine("\n\nMenu - Geral" +
                              "\n0. Sair" +
                              "\n1. Pessoa" +
                              "\n2. Livro" +
                              "\n3. Reserva" +
                              "\n4. Compra" +
                              "\nEscolha uma das opções acima: ");
            opcao = Convert.ToInt32(Console.ReadLine());

        }//fim do escolher

        public void OperacaoMenu()
        {
            do
            {
                EscolherControl();//chamar o texto do menu
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        controlePessoa.Operacao();
                        break;

                    case 2:
                        controlLivro.Operacao();
                        break;

                    case 3:
                        controlReserva.Operacao();

                        break;

                    case 4:
                        controlCompra.Operacao();

                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;



                }//fim do switch
            } while (opcao != 0);
        }//fim do menu
    }// fim da classe
}//fim do projeto
