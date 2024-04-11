using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivro
    {
        Livro model;//conectar com a classe livro
        private int opcao;
        public ControlLivro()
        {
            model = new Livro();//Acesso a todos os métodos da classe livro
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
                "\n2. Consultar Titulo" +
                "\n3. Atualizar Autor" +
                "\n4. Atualizar Editora" +
                "\n5. Atualizar Genero" +
                "\n6. Atualizar ISBN" +
                "\n7. Atualizar Quantidade" +
                "\n8. Atualizar Preço" +
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

                    Console.WriteLine("Informe o título: ");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Informe o autor: ");
                    string autor = Console.ReadLine();

                    Console.WriteLine("Informe a editora: ");
                    string editora = Console.ReadLine();

                    Console.WriteLine("Informe o genero: ");
                    string genero = Console.ReadLine();

                    Console.WriteLine("Informe o ISBN: ");
                    long ISBN = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a quantidade de livros: ");
                    string quantidade = Console.ReadLine();

                    Console.WriteLine("Informe o preço: ");
                    string preco = Console.ReadLine();

                    //Chamar o método cadastrar
                    model.Cadastrar(codigo, titulo, autor, editora, genero, ISBN, quantidade, preco);
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

                    Console.WriteLine("Informe um novo autor: ");
                    titulo = Console.ReadLine();

                    //Atualizar
                    model.AtualizarAutor(codigo, titulo);

                    break;

                case 4:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo autor: ");
                    autor = Console.ReadLine();

                    //Atualizar
                    model.AtualizarAutor(codigo, autor);

                    break;

                case 5:
                    Console.WriteLine("Informe o código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova editora: ");
                    editora = Console.ReadLine();

                    //Atualizar
                    model.AtualizarEditora(codigo, editora);
                    break;

                case 6:
                    Console.WriteLine("Informe um código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo genero: ");
                    genero = Console.ReadLine();

                    //Atualizar
                    model.AtualizarGenero(codigo, genero);
                    break;

                case 7:
                    Console.WriteLine("Informe um código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo número de ISBN: ");
                    ISBN = Convert.ToInt64(Console.ReadLine());

                    //Atualizar
                    model.AtualizarISBN(codigo, ISBN);
                    break;


                case 8:
                    Console.WriteLine("Informe um código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova quantidade: ");
                    quantidade = Console.ReadLine();

                    //Ataulizar
                    model.AtualizarQuantidade(codigo, quantidade);

                    break;

                case 9:
                    Console.WriteLine("Informe um código: ");
                    codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma posição: ");
                    preco = Console.ReadLine();

                    //Atualizar
                    model.AtualizarPreco(codigo, preco);
                    break;

                case 10:
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
