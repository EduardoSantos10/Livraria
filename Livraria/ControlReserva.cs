using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlReserva
    {

        Reserva model;//conectar com a classe livro
        private int opcao;
        public ControlReserva()
        {
            model = new Reserva();//Acesso a todos os métodos da classe livro
            ModificarOpcao = 0;
        }//fim do construtor
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do modificação

        public void menu()
        {
            Console.WriteLine("Menu - Livro" +
                "\nEscolha uma das opções abaixo: " +
                "\n1. Cadastrar Código" +
                "\n2. Consultar Livro" +
                "\n3. Atualizar Pessoa" +
                "\n4. Atualizar Quantidade" +
                "\n9. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            menu();//Mostrar o menu
            switch (ModificarOpcao)
            {

                case 1:
                    Console.WriteLine("Informe o Código: ");
                    long codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o livro: ");
                    string livro = Console.ReadLine();

                    Console.WriteLine("Informe a pessoa: ");
                    string pessoa = Console.ReadLine();

                    Console.WriteLine("Informe a quantidade: ");
                    string qtde = Console.ReadLine();

                    //Chamar o método cadastrar
                    model.Cadastrar(codigo, livro, pessoa, qtde);
                    break;

                case 2:
                    Console.WriteLine("Informe o codigo que deseja consultar: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarEstoque(codigo));
                    break;

                case 3:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome do livro: ");
                    livro = Console.ReadLine();

                    //Atualizar
                    model.ConsultarLivro(codigo, livro);

                    break;

                case 4:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome da pessoa: ");
                    pessoa = Console.ReadLine();

                    //Atualizar
                    model.ConsultarPessoa(codigo, pessoa);

                    break;

                case 5:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade: ");
                    qtde = Console.ReadLine();

                    //Atualizar
                    model.VerificarQuantidade(codigo, qtde);
                    break;

                default:

                    Console.WriteLine("Escolha uma opção válida: ");
                    break;

            }//fim do switch

        }//fim da operacao
    }
}
