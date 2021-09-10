using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace eAgenda.Dominio.ContatoModule
{
    /// <summary>
    /// Classe para a criação do registro Contato, que herda de EntidadeBase e implementa IEquetable
    /// </summary>
    public class Contato : EntidadeBase, IEquatable<Contato>
    {   
        /// <summary>
        /// Construtor do Contato
        /// </summary>
        /// <param name="nome">Nome do contato</param>
        /// <param name="email">Email do Contato</param>
        /// <param name="telefone">Telefone do contato</param>
        /// <param name="empresa">Empresa do Contato</param>
        /// <param name="cargo">Cargo do Contato</param>
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public string Nome { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Cargo { get; }
        public string Empresa { get; }

        /// <summary>
        /// Método de validação dos campos do contato
        /// </summary>
        /// <returns>Retorna uma string com o resultado da validação</returns>
        public override string Validar()
        {
            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";

            if (Telefone.Length < 7)
                resultadoValidacao = "O campo Telefone está inválido";

            if (templateEmail.IsMatch(Email) == false)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Email está inválido";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Contato);
        }

        public bool Equals(Contato other)
        {
            return other != null
                && Id == other.Id
                && Nome == other.Nome
                && Email == other.Email
                && Telefone == other.Telefone
                && Cargo == other.Cargo
                && Empresa == other.Empresa;
        }

        public override int GetHashCode()
        {
            int hashCode = 1695060689;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cargo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Empresa);
            return hashCode;
        }
    }
}
