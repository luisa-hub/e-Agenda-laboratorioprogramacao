using eAgenda.Controladores.Shared;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.TarefaModule
{
    /// <summary>
    /// Contém os métodos relativos aos bancos de dados, herda os métodos de Controlador. 
    /// </summary>
    public class ControladorTarefa : Controlador<Tarefa>
    {
        #region Queries
        private const string sqlInserirTarefa =
            @"INSERT INTO [TBTAREFA]
                (
                    [TITULO],       
                    [PRIORIDADE],             
                    [DATACRIACAO],                    
                    [DATACONCLUSAO], 
                    [PERCENTUAL]            
                )
            VALUES
                (
                    @TITULO,
                    @PRIORIDADE,
                    @DATACRIACAO,
                    @DATACONCLUSAO,
                    @PERCENTUAL
                )";

        private const string sqlEditarTarefa =
            @" UPDATE [TBTAREFA]
                SET 
                    [PRIORIDADE] = @PRIORIDADE, 
                    [TITULO] = @TITULO, 
                    [DATACRIACAO] = @DATACRIACAO, 
                    [DATACONCLUSAO] = @DATACONCLUSAO,
                    [PERCENTUAL] = @PERCENTUAL

                WHERE [ID] = @ID";

        private const string sqlExcluirTarefa =
            @"DELETE FROM [TBTAREFA] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodasTarefas =
            @"SELECT 
                [ID],       
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            ORDER BY 
                T.PRIORIDADE DESC";

        private const string sqlSelecionarTarefaPorId =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],        
                [DATACRIACAO],       
                [DATACONCLUSAO],
                [PERCENTUAL]
             FROM
                [TBTAREFA]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodasTarefasConcluidas =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            WHERE 
                T.[PERCENTUAL] = 100
            ORDER BY 
                T.[PRIORIDADE] DESC";

        private const string sqlSelecionarTodasTarefasPendentes =
            @"SELECT 
                [ID],
                [TITULO],       
                [PRIORIDADE],             
                [DATACRIACAO],                    
                [DATACONCLUSAO],
                [PERCENTUAL]
            FROM
                [TBTAREFA] T
            WHERE 
                T.[PERCENTUAL] <> 100
            ORDER BY 
                T.[PRIORIDADE] DESC";

        private const string sqlExisteTarefa =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBTAREFA]
            WHERE 
                [ID] = @ID";

        #endregion

        /// <summary>
        /// Insere uma nova tarefa no banco de dados depois de validar. 
        /// </summary>
        /// <param name="registro">Recebe um registro do tipo Tarefa</param>
        /// <returns>String de validação</returns>
        public override string InserirNovo(Tarefa registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirTarefa, ObtemParametrosTarefa(registro));
            }

            return resultadoValidacao;
        }


        /// <summary>
        /// Edita no banco de dados a tarefa depois de validar. 
        /// </summary>
        /// <param name="id">Recebe o Id da tarefa que deseja editar</param>
        /// <param name="registro">Recebe um registro do tipo Tarefa</param>
        /// <returns>Retorna uma string de validação.</returns>
        public override string Editar(int id, Tarefa registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarTarefa, ObtemParametrosTarefa(registro));
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
                Db.Delete(sqlExcluirTarefa, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se o registro da tarefa existe no banco com base no id.
        /// </summary>
        /// <param name="id">Id do registro tarefa</param>
        /// <returns>Retorna true se o registro da tarefa existir</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteTarefa, AdicionarParametro("ID", id));
        }
        
        /// <summary>
        /// Seleciona todas as tarefas
        /// </summary>
        /// <returns>Retorna uma lista de tarefas</returns>
        public override List<Tarefa> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodasTarefas, ConverterEmTarefa);
        }
        
        /// <summary>
        /// Seleciona uma tarefa com base no ID
        /// </summary>
        /// <param name="id">Id da tarefa</param>
        /// <returns>Retorna uma Tarefa</returns>
        public override Tarefa SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTarefaPorId, ConverterEmTarefa, AdicionarParametro("ID", id));
        }


        /// <summary>
        /// Atualiza o percentual da tarefa
        /// </summary>
        /// <param name="id">Id da tareda</param>
        /// <param name="novoPercentual">Percentual Concluído</param>
        public string AtualizarPercentual(int id, int novoPercentual)
        {
            Tarefa tarefa = SelecionarPorId(id);            

            string validarPorcentagem = tarefa.AtualizarPercentual(novoPercentual, DateTime.Today);

           if(String.IsNullOrEmpty(validarPorcentagem))
            Editar(tarefa.Id, tarefa);

            return validarPorcentagem;
        }

       
        /// <summary>
        /// Seleciona todas as tarefas concluídas
        /// </summary>
        /// <returns>Retorna uma lista de tarefas</returns>        
        public List<Tarefa> SelecionarTodasTarefasConcluidas()
        {
            return Db.GetAll(sqlSelecionarTodasTarefasConcluidas, ConverterEmTarefa);
        }

        /// <summary>
        /// Seleciona todas as tarefas pendentes
        /// </summary>
        /// <returns>Retorna uma lista com todas as tarefas</returns>
        public List<Tarefa> SelecionarTodasTarefasPendentes()
        {
            return Db.GetAll(sqlSelecionarTodasTarefasPendentes, ConverterEmTarefa);
        }

        /// <summary>
        /// Converte valor do banco em tarefa
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Retorna um registro do tipo tarefa</returns>
        private Tarefa ConverterEmTarefa(IDataReader reader)
        {
            var titulo = Convert.ToString(reader["TITULO"]);
            var prioridade = Convert.ToInt32(reader["PRIORIDADE"]);
            var dataCriacao = Convert.ToDateTime(reader["DATACRIACAO"]);
            int percentual = Convert.ToInt32(reader["PERCENTUAL"]);

            Tarefa tarefa = new Tarefa(titulo, dataCriacao, (PrioridadeEnum)prioridade);

            DateTime dataConclusao = DateTime.MinValue;

            if (reader["DATACONCLUSAO"] != DBNull.Value)            
                dataConclusao = Convert.ToDateTime(reader["DATACONCLUSAO"]);            

            tarefa.Id = Convert.ToInt32(reader["ID"]);                            
            tarefa.AtualizarPercentual(percentual, dataConclusao);

            return tarefa;
        }

        /// <summary>
        /// Obtém parâmetros de uma tarefa
        /// </summary>
        /// <param name="tarefa">Tarefa que deseja obter parâmetros</param>
        /// <returns>Dicionário de string e objetos</returns>
        private Dictionary<string, object> ObtemParametrosTarefa(Tarefa tarefa)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", tarefa.Id);
            parametros.Add("TITULO", tarefa.Titulo);
            parametros.Add("PRIORIDADE", tarefa.Prioridade.Chave);
            parametros.Add("DATACRIACAO", tarefa.DataCriacao);
            parametros.Add("DATACONCLUSAO", tarefa.DataConclusao);
            parametros.Add("PERCENTUAL", tarefa.Percentual);

            return parametros;
        }


    }
}