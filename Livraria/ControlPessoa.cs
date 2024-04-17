using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlPessoa
    {
        Pessoa model;//conectar com a classe pessoa
        private int opcao;
        public ControlPessoa()
        {
            model = new Pessoa();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        }//fim do construtor
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do modificação

        public void menu()
        {
            Console.WriteLine("Menu - Pessoa" +
                "Escolha uma das opções abaixo: " +
                "\n0. Cadastrar Pessoa" +
                "\n1. Consultar Pessoa" +
                "\n2. Atualizar Nome" +
                "\n3. Atualizar Telefone" +
                "\n4. Atualizar Endereço" +
                "\n5. Atualizar Data de Nascimento" +
                "\n6. Atualizar Senha" +
                "\n7. Atualizar Situação" +
                "\n8. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            menu();//Mostrar o menu
            switch (ModificarOpcao)
            {

                case 0:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o seu telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe o seu endereço: ");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Informe sua data de nascimento: ");
                    DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe seu Login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe sua senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe seu cargo: ");
                    string cargo = Console.ReadLine();

                    //Chamar o método cadastrar
                    model.Cadastrar(CPF, nome, telefone, endereco, dtNascimento, login, senha, cargo);
                    break;

                case 1:
                    Console.WriteLine("Informe o CPF que deseja consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarIndividual(CPF));
                    break;

                case 2:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo nome: ");
                    nome = Console.ReadLine();

                    //Atualizar
                    model.AtualizarNome(CPF, nome);

                    break;

                case 3:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo telefone: ");
                    telefone = Console.ReadLine();

                    //Atualizar
                    model.AtualizarNome(CPF, telefone);
                    break;

                case 4:
                    Console.WriteLine("Informe um CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe um novo endereço: ");
                    endereco = Console.ReadLine();

                    //Atualizar
                    model.AtualizarNome(CPF, endereco);
                    break;

                case 5:
                    Console.WriteLine("Informe um CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova data de nascimento: ");
                    dtNascimento = Convert.ToDateTime(Console.ReadLine());

                    //Atualizar
                    model.AtualizarDataNascimento(CPF, dtNascimento);
                    break;


                case 6:
                    Console.WriteLine("Informe um CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova senha: ");
                    senha = Console.ReadLine();

                    //Ataulizar
                    model.AtualizarSenha(CPF, senha);

                    break;

                case 7:
                    Console.WriteLine("Informe um CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma posição: ");
                    cargo = Console.ReadLine();

                    //Atualizar
                    model.AtualizarPosicao(CPF, cargo);
                    break;

                case 8:
                    Console.WriteLine("Informe um CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    model.Excluir(CPF);
                    break;

                default:

                    Console.WriteLine("Escolha uma opção válida: ");
                    break;

            }//fim do switch

        }//fim da operacao

    }// fim da classe

}    
