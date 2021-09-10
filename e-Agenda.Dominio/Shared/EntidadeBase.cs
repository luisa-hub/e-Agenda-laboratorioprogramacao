using System;

namespace eAgenda.Dominio.Shared
{
    /// <summary>
    /// Classe base do Domínio da aplicação.
    /// </summary>
    public abstract class EntidadeBase
    {
        
        public int Id;

        /// <summary>
        /// Método para validar campos
        /// </summary>
        /// <returns>Retorna uma string com a validação</returns>
        public abstract string Validar();

        /// <summary>
        /// Gera quebra de linha do Resultado da Validação
        /// </summary>
        /// <param name="resultadoValidacao">Resultado da Validação dos Campos</param>
        /// <returns></returns>
        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}