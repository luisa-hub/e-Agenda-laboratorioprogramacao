using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.ContatoModule
{
    /// <summary>
    /// Classe responsável pelo Controle de Contatos, que herda os métodos do Controlador Base. Possui métodos de Inserção, Exclusão, Edição, entre outros. 
    /// </summary>
    public class ControladorContato : Controlador<Contato>
    {
        #region Queries
        private const string sqlInserirContato =
            @"INSERT INTO TBCONTATO 
	                (
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                ) 
	                VALUES
	                (
                        @NOME, 
                        @EMAIL,
                        @TELEFONE,
		                @CARGO, 
		                @EMPRESA
	                )";

        private const string sqlEditarContato =
            @"UPDATE TBCONTATO
                    SET
                        [NOME] = @NOME,
		                [EMAIL] = @EMAIL, 
		                [TELEFONE] = @TELEFONE,
                        [CARGO] = @CARGO,
                        [EMPRESA] = @EMPRESA
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirContato =
            @"DELETE 
	                FROM
                        TBCONTATO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarContatoPorId =
            @"SELECT
                        [ID],
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                FROM
                        TBCONTATO
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarTodosContatos =
            @"SELECT
                        [ID],
		                [NOME], 
		                [EMAIL], 
		                [TELEFONE],
                        [CARGO], 
		                [EMPRESA]
	                FROM
                        TBCONTATO ORDER BY CARGO;";

        private const string sqlExisteContato =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCONTATO]
            WHERE 
                [ID] = @ID";
        #endregion

        /// <summary>
        /// Valida o registro do contato antes de adicioná-lo ao banco.
        /// </summary>
        /// <param name="registro">Registro que seja inserir</param>
        /// <returns> Retorna o resulta da Validação. </returns>
        public override string InserirNovo(Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirContato, ObtemParametrosContato(registro));
            }

            return resultadoValidacao;
        }


        /// <summary>
        /// Edita o registro no banco de dados depois de validar. 
        /// </summary>
        /// <param name="id">Id do registro que deseja editar</param>
        /// <param name="registro">Novo registro</param>
        /// <returns>Retorna o resultado da validação.</returns>
        public override string Editar(int id, Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarContato, ObtemParametrosContato(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Exclui um registro com base no id. 
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns>Retorna true caso tenha conseguido excluir. </returns>
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirContato, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se o registro existe no banco com base no id.
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns>Retorna true se o registro existir</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteContato, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona registro do banco de dados com base no id.
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns>Retorna um contato</returns>
        public override Contato SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarContatoPorId, ConverterEmContato, AdicionarParametro("ID", id));
        }


        /// <summary>
        /// Seleciona todos os registros dos contatos. 
        /// </summary>
        /// <returns>retorna uma Lista de Contatos</returns>
        public override List<Contato> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosContatos, ConverterEmContato);
        }

        
        /// <summary>
        /// Obtém parâmetros de um contato específico.
        /// </summary>
        /// <param name="contato">Registro do tipo Contato</param>
        /// <returns>Retorna um dicionário de string e objeto</returns>
        private Dictionary<string, object> ObtemParametrosContato(Contato contato)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", contato.Id);
            parametros.Add("NOME", contato.Nome);
            parametros.Add("EMAIL", contato.Email);
            parametros.Add("TELEFONE", contato.Telefone);
            parametros.Add("CARGO", contato.Cargo);
            parametros.Add("EMPRESA", contato.Empresa);

            return parametros;
        }

        /// <summary>
        /// Converte do banco de dados um registro para Contato.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Retorna um contato</returns>
        private Contato ConverterEmContato(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string cargo = Convert.ToString(reader["CARGO"]);
            string empresa = Convert.ToString(reader["EMPRESA"]);

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            contato.Id = id;

            return contato;
        }



    }
}
