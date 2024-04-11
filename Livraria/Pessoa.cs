using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Pessoa
    {
        //Encapsulamento = Deixar as variavéis privadas
        private long CPF;
        private string nome;
        private string endereco;
        private string telefone;
        private DateTime dtNascimento;
        private string login;
        private string senha;
        private string situacao; //Ativo ou Inativo
        private string posicao; //Atendente ou Administardor ou Cliente

        //Método Construtor
        public Pessoa() 
        {
            ModificarCPF = 0;
            ModificarNome = "";
            ModificarEndereco = "";
            ModificarTelefone = "";
            ModificarDtNascimento = new DateTime(); //00/00/0000 00:00:00
            ModificarLogin = "";
            ModificarSenha = "";
            ModificarSituacao = "";
            ModificarPosicao = "";
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

        public string ModificarEndereco
        {
            get { return endereco; }
            set { this.endereco = value; }

        }//Fim do Modificar

        public string ModificarTelefone
        {
            get { return telefone; }
            set { this.telefone = value; }

        }//Fim do Modificar

        public DateTime ModificarDtNascimento
        {
            get { return dtNascimento; }
            set { this.dtNascimento = value; }

        }//Fim do Modificar

        public string ModificarLogin
        {
            get { return login; }
            set { this.login = value; }

        }//Fim do Modificar

        public string ModificarSenha
        {
            get { return senha; }
            set { this.senha = value; }

        }//Fim do Modificar

        public string ModificarSituacao
        {
            get { return situacao; }
            set { this.situacao = value; }

        }//Fim do Modificar

        public string ModificarPosicao
        {
            get { return posicao; }
            set { this.posicao = value; }

        }//Fim do Modificar

        //Métodos - CRUD
        public void Cadastrar(long CPF, string nome, string telefone, string endereco, DateTime dtNascimento, string login, string senha, string posicao) 
        {

            ModificarCPF = CPF;
            ModificarNome = nome;
            ModificarTelefone = telefone;
            ModificarEndereco = endereco;
            ModificarDtNascimento = dtNascimento;
            ModificarLogin = login;
            ModificarSenha = senha;
            ModificarSituacao = "Ativo";
            ModificarPosicao = posicao;       
        
        }// Fim do Void

        public string ConsultarIndividual(long CPF) 
        {
            string consulta = "";
            if (ModificarCPF == CPF)
            {
                consulta = "\nNome: " + ModificarNome + "\nTelefone: " + ModificarTelefone + "\nData de Nascimento: " + ModificarDtNascimento + "\nLogin: " + ModificarLogin + "\nSenha: " + ModificarSenha + "\nSituação: " + ModificarSituacao + "\nPosição: " + ModificarPosicao;

            }
            else 
            {
                consulta = "Número de CPF não é válido!";
            }

            return consulta;

        }// Fim do Método

        public void AtualizarNome(long CPF, string nome) 
        { 
        
            if(ModificarCPF == CPF) 
            { 
            
                ModificarNome = nome;

            }
        }

        public void AtualizarTelefone(long CPF, string telefone)
        {

            if (ModificarCPF == CPF)
            {

                ModificarTelefone = telefone;

            }
        }

        public void AtualizarDataNascimento(long CPF, DateTime dtNascimento )
        {

            if (ModificarCPF == CPF)
            {

                ModificarDtNascimento = dtNascimento;

            }
        }

        public void AtualizarEndereco(long CPF, string endereco)
        {

            if (ModificarCPF == CPF)
            {

                ModificarEndereco = endereco;

            }
        }

        public void AtualizarSenha(long CPF, string senha)
        {

            if (ModificarCPF == CPF)
            {

                ModificarSenha = senha;

            }
        }

        public void AtualizarPosicao(long CPF, string posicao)
        {

            if (ModificarCPF == CPF)
            {

                ModificarPosicao = posicao;

            }
        }

        public void AtualizarSituacao(long CPF, string situacao)
        {

            if (ModificarCPF == CPF)
            {

                ModificarSituacao = situacao;

            }
        }

        public void Excluir(long CPF) 
        { 
            if(ModificarCPF == CPF) 
            {

                ModificarSituacao = "Inativo";
            
            }
        }//Fim do Método

    }// Fim da classe

}// Fim do Namespace
