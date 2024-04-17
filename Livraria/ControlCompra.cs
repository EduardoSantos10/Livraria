using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlCompra
    {
        Compra model;//conectar com a classe livro
        private int opcao;
        public ControlCompra()
        {
            model = new Compra();//Acesso a todos os métodos da classe livro
            ModificarOpcao = 0;
        }//fim do construtor
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do modificação

        public void menu()
        {
            Console.WriteLine("Menu - Compra" +
                "\nEscolha uma das opções abaixo: " +
                "\n0. Cadastrar Código" +
                "\n1. Consultar Pessoa" +
                "\n2. Atualizar Livro" +
                "\n3. Atualizar Quantidade" +
                "\n4. Mostrar Total");
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

                    Console.WriteLine("Informe o titular: ");
                    string codigoPessoa = Console.ReadLine();

                    Console.WriteLine("Informe o autor: ");
                    string codigoLivro = Console.ReadLine();

                    Console.WriteLine("Informe a editora: ");
                    string codigoQuantidade = Console.ReadLine();

                    Console.WriteLine("Informe o genero: ");
                    long total = Convert.ToInt64(Console.ReadLine());


                    //Chamar o método cadastrar
                    model.Cadastrar(codigo, codigoPessoa, codigoLivro, codigoQuantidade, total);
                    break;

                case 1:
                    Console.WriteLine("Informe o codigo que deseja consultar: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarCodigo(codigo));
                    break;

                case 2:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo autor: ");
                    codigoPessoa = Console.ReadLine();

                    //Atualizar
                    model.AtualizarComprador(codigo, codigoPessoa);

                    break;

                case 3:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nome do livro: ");
                    codigoLivro = Console.ReadLine();

                    //Atualizar
                    model.AtualizarLivro(codigo, codigoLivro);

                    break;

                case 4:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova editora: ");
                    codigoQuantidade = Console.ReadLine();

                    //Atualizar
                    model.AtualizarQuantidade(codigo, codigoQuantidade);
                    break;

                case 5:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o total: ");
                    total = Convert.ToInt64(Console.ReadLine());

                    //Atualizar
                    model.AtualizarTotal(codigo, total);
                    break;

                case 6:
                    Console.WriteLine("Informe um CPF: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    model.Excluir(codigo);
                    break;

                default:

                    Console.WriteLine("Escolha uma opção válida: ");
                    break;

            }//fim do switch

        }//fim da operacao
    }
}
