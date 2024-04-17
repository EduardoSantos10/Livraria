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
                "\n0. Cadastrar Código" +
                "\n1. Consultar Reposição" +
                "\n2. Atualizar Pessoa" +
                "\n3. Atualizar Quantidade" +
                "\n4. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            menu();//Mostrar o menu
            switch (ModificarOpcao)
            {

                case 0:
                    Console.WriteLine("Informe o Código: ");
                    long codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("30 Dias para Reposição");
                    

                    Console.WriteLine("Sua Mercadoria Está Indisponivel no Momento ");
                    

                    Console.WriteLine("50 Livros está se encaminhando para reposição");
                    Console.ReadLine();

                    //Chamar o método cadastrar
                    model.Cadastrar(codigo);
                    break;

                case 1:
                    Console.WriteLine("Informe o codigo que deseja consultar: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarEstoque(codigo));
                    break;

                case 2:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome do livro: ");
                    Console.ReadLine();

                    //Atualizar
                    model.ConsultarReposicao(codigo);

                    break;

                case 3:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome da pessoa: ");
                    Console.ReadLine();

                    //Atualizar
                    model.ConsultarPessoa(codigo);

                    break;

                case 4:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade: ");
                    Console.ReadLine();

                    //Atualizar
                    model.VerificarQuantidade(codigo);
                    break;

                default:

                    Console.WriteLine("Escolha uma opção válida: ");
                    break;

            }//fim do switch

        }//fim da operacao
    }
}
