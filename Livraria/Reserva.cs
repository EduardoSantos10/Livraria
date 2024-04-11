using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Reserva
    {


        //Encapsulamento = Deixar as variavéis privadas
        private long codigo;
        private string livro;
        private string pessoa;
        private string qtde;
        

        //Método Construtor
        public Reserva()
        {
            ModificarCodigo = 0;
            ModificarLivro = "";
            ModificarPessoa = "";
            ModificarQtde = "";
            
        }// Fim do Construtor

        //Métodos Modificadores = Gets e Sets
        public long ModificarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }

        }//Fim do Modificar

        public string ModificarLivro
        {
            get { return livro; }
            set { this.livro = value; }

        }//Fim do Modificar

        public string ModificarPessoa
        {
            get { return pessoa; }
            set { this.pessoa = value; }

        }//Fim do Modificar

        public string ModificarQtde
        {
            get { return qtde; }
            set { this.qtde = value; }

        }//Fim do Modificar


        //Métodos - CRUD
        public void Cadastrar(long codigo, string livro, string pessoa, string qtde)
        {

            ModificarCodigo = codigo;
            ModificarLivro = livro;
            ModificarPessoa = pessoa;
            ModificarQtde = qtde;

        }// Fim do Void

        public string ConsultarEstoque(long codigo)
        {
            string consulta = "";
            if (ModificarCodigo == codigo)
            {
                consulta = "\nCodigo: " + ModificarCodigo + "\nLivro: " + ModificarLivro + "\nPessoa: " + ModificarPessoa + "\nQtde: " + ModificarQtde;

            }
            else
            {
                consulta = "Número do código não é válido!";
            }

            return consulta;

        }// Fim do Método

        public void ConsultarLivro(long codigo, string livro)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarLivro = livro;

            }
        }

        public void ConsultarPessoa(long codigo, string pessoa)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarPessoa = pessoa;

            }
        }

        public void VerificarQuantidade(long codigo, string qtde)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarQtde = qtde;

            }
        }

        public void Excluir(long codigo)
        {
            if (ModificarCodigo == codigo)
            {

                ModificarQtde = "";

            }
        }//Fim do Método

    }
}
