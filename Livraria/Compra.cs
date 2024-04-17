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
        Pessoa pes;
        Livro liv;
        private long CPF;
        private string nome;
        private string livro;
        private string quantidade;
        private long pUnit;
        private long pTotal;

        //Método Construtor
        public Compra()
        {
            liv = new Livro();
            pes = new Pessoa();
            ModificarCPF = 0;
            ModificarNome = "";
            ModificarLivro = "";
            ModificarQuantidade = "";
            ModificarPunit = 0;
            ModificarPtotal = 0;
           
        }// Fim do Construtor

        //Métodos Modificadores = Gets e Sets
        public long ModificarCPF
        {
            get { return CPF; }
            set { this.CPF = value; }

        }//Fim do Modificar

        public string ModificarNome
        {
            get { return nome; }
            set { this.nome = value; }

        }//Fim do Modificar

        public string ModificarLivro
        {
            get { return livro; }
            set { this.livro = value; }

        }//Fim do Modificar

        public string ModificarQuantidade
        {
            get { return quantidade; }
            set { this.quantidade = value; }

        }//Fim do Modificar

        public long ModificarPunit
        {
            get { return pUnit; }
            set { this.pUnit = value; }

        }//Fim do Modificar

        public string ModificarPtotal 
        { 
        
            get { return pTotal; }
            set { this.pUnit = valeu; }
        
        
        }

        //Métodos - CRUD
        public void Cadastrar(long codigo, string codigoPessoa, string codigoLivro, string codigoQuantidade, long total)
        {

            ModificarCodigo = codigo;
            ModificarCodigoPessoa = codigoPessoa;
            ModificarCodigoLivro = codigoLivro;
            ModificarCodigoQuantidade = codigoQuantidade;
            ModificarTotal = total;

        }// Fim do Void

        public string ConsultarCodigo(long codigo)
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

        public void AtualizarTotal(long codigo, long total)
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

                ModificarTotal = 0;

            }
        }//Fim do Método

    }
}
