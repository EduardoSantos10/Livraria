using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Compra
    {
        //Encapsulamento = Deixar as variavéis privadas
        private long codigo;
        private string codigoPessoa;
        private string codigoLivro;
        private string codigoQuantidade;
        private string total;

        //Método Construtor
        public Compra()
        {
            ModificarCodigo = 0;
            ModificarCodigoPessoa = "";
            ModificarCodigoLivro = "";
            ModificarCodigoQuantidade = "";
            ModificarTotal = "";
           
        }// Fim do Construtor

        //Métodos Modificadores = Gets e Sets
        public long ModificarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }

        }//Fim do Modificar

        public string ModificarCodigoPessoa
        {
            get { return codigoPessoa; }
            set { this.codigoPessoa = value; }

        }//Fim do Modificar

        public string ModificarCodigoLivro
        {
            get { return codigoLivro; }
            set { this.codigoLivro = value; }

        }//Fim do Modificar

        public string ModificarCodigoQuantidade
        {
            get { return codigoQuantidade; }
            set { this.codigoQuantidade = value; }

        }//Fim do Modificar

        public string ModificarTotal
        {
            get { return total; }
            set { this.total = value; }

        }//Fim do Modificar

        //Métodos - CRUD
        public void Cadastrar(long codigo, string codigoPessoa, string codigoLivro, string codigoQuantidade, string total)
        {

            ModificarCodigo = codigo;
            ModificarCodigoPessoa = codigoPessoa;
            ModificarCodigoLivro = codigoLivro;
            ModificarCodigoQuantidade = codigoQuantidade;
            ModificarTotal = total;

        }// Fim do Void

        public string ConsultarIndividual(long codigo)
        {
            string consulta = "";
            if (ModificarCodigo == codigo)
            {
                consulta = "\nPessoa: " + ModificarCodigoPessoa + "\nLivro: " + ModificarCodigoLivro + "\nQuantidade: " + ModificarCodigoQuantidade + "\nTotal: " + ModificarTotal;

            }
            else
            {
                consulta = "Número de código não é válido!";
            }

            return consulta;

        }// Fim do Método

        public void AtualizarComprador(long codigo, string codigoPessoa)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarCodigoPessoa = codigoPessoa;

            }
        }

        public void AtualizarLivro(long codigo, string codigoLivro)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarCodigoLivro = codigoLivro;

            }
        }

        public void AtualizarQuantidade(long codigo, string codigoQuantidade)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarCodigoQuantidade = codigoQuantidade;

            }
        }

        public void AtualizarTotal(long codigo, string total)
        {

            if (ModificarCodigo == codigo)
            {

                ModificarTotal = total;

            }
        }

        public void Excluir(long codigo)
        {
            if (ModificarCodigo == codigo)
            {

                ModificarTotal = "Inativo";

            }
        }//Fim do Método

    }
}
