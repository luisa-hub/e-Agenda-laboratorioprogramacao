using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.CompromissoModule
{
    /// <summary>
    /// Controlador de Compromisso que herda do Compromisso Genérico. Possui funções de Inserir, Editar e Excluir, entre outras.
    /// </summary>
    public class ControladorCompromisso : Controlador<Compromisso>
    {
        #region Queries
        private const string sqlInserirCompromisso =
            @"INSERT INTO [TBCOMPROMISSO]
                (
                    [LOCAL],       
                    [DATA], 
                    [ASSUNTO],
                    [HORAINICIO],                    
                    [HORATERMINO],                                                           
                    [ID_CONTATO],
                    [LINK]            
                )
            VALUES
                (
                    @LOCAL,
                    @DATA,
                    @ASSUNTO,
                    @HORAINICIO,
                    @HORATERMINO,
                    @ID_CONTATO,
                    @LINK
                )";

        private const string sqlEditarCompromisso =
            @" UPDATE [TBCOMPROMISSO]
                SET 
                    [LOCAL] = @LOCAL, 
                    [DATA] = @DATA, 
                    [ASSUNTO] = @ASSUNTO,
                    [HORAINICIO] = @HORAINICIO, 
                    [HORATERMINO] = @HORATERMINO,
                    [ID_CONTATO] =@ID_CONTATO,
                    [LINK] = @LINK

                WHERE [ID] = @ID";

        private const string sqlExcluirCompromisso =
            @"DELETE FROM [TBCOMPROMISSO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarTodosCompromissos =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO";

        private const string sqlSelecionarCompromissoPorId =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[ID] = @ID";

        private const string sqlSelecionarTodosCompromissosPassados =
           @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[DATA] < @DATA";

        private const string sqlSelecionarTodosCompromissosFuturos =
            @"SELECT 
                CP.[ID],       
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],             
                CP.[HORAINICIO],                    
                CP.[HORATERMINO],                                
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],       
                CT.[EMAIL],             
                CT.[TELEFONE],                    
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[DATA] BETWEEN @DATAINICIO AND @DATAFIM";

        private const string sqlExisteCompromisso =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCOMPROMISSO]
            WHERE 
                [ID] = @ID";

        #endregion

        /// <summary>
        /// Valida o registro recebido antes de inseri-lo no banco. 
        /// </summary>
        /// <param name="registro">Registro do tipo Compromisso</param>
        /// <returns>Retorna o resultado da validação em string.</returns>
        public override string InserirNovo(Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirCompromisso, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Edita um registro de compromissos depois de validar.
        /// </summary>
        /// <param name="id">Id do registro que deseja editar</param>
        /// <param name="registro">Novo registro que </param>
        /// <returns> Retorna o resultado da validação em string.</returns>
        public override string Editar(int id, Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarCompromisso, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        /// <summary>
        /// Exclui um registro baseado em seu Id.  
        /// </summary>
        /// <param name="id">Id do registro que deseja excluir</param>
        /// <returns>Retorna true caso tenha conseguido excluir.</returns>
        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirCompromisso, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se um registro existe
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns>Retorna true se o Id existe</returns>
        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteCompromisso, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Seleciona o registro por Id
        /// </summary>
        /// <param name="id">Id do registro que deseja selecionar</param>
        /// <returns></returns>
        public override Compromisso SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarCompromissoPorId, ConverterEmCompromisso, AdicionarParametro("ID", id));
        }

        /// <summary>
        /// Selecionar todos os registros.
        /// </summary>
        /// <returns> retorna uma lista de Compromisso</returns>
        public override List<Compromisso> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosCompromissos, ConverterEmCompromisso);
        }


        /// <summary>
        ///  Seleciona todos os compromissos futuros
        /// </summary>
        /// <param name="dataInicio">Data Início que deseja comparar</param>
        /// <param name="dataFim">Data Final que deseja comparar</param>
        /// <returns>Retorna uma lista de Compromisso</returns>
        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFim)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("DATAINICIO", dataInicio);
            parametros.Add("DATAFIM", dataFim);

            return Db.GetAll(sqlSelecionarTodosCompromissosFuturos, ConverterEmCompromisso, parametros);
        }

        /// <summary>
        ///  Seleciona todos os compromissos passados
        /// </summary>
        /// <param name="data">Data de comparação</param>
        /// <returns>Retorna uma lista de compromissos passados</returns>
        public List<Compromisso> SelecionarCompromissosPassados(DateTime data)
        {
            return Db.GetAll(sqlSelecionarTodosCompromissosPassados, ConverterEmCompromisso, AdicionarParametro("DATA", data));
        }


        /// <summary>
        ///  Recebe o registro do banco de dados e converte para compromisso
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Retorna um compromisso.</returns>
        private Compromisso ConverterEmCompromisso(IDataReader reader)
        {
            var assunto = Convert.ToString(reader["ASSUNTO"]);
            var local = Convert.ToString(reader["LOCAL"]);
            var link = Convert.ToString(reader["LINK"]);
            var dataDoCompromisso = Convert.ToDateTime(reader["DATA"]);
            var horaInicio = TimeSpan.FromTicks(Convert.ToInt64(reader["HORAINICIO"]));
            var horaTermino = TimeSpan.FromTicks(Convert.ToInt64(reader["HORATERMINO"]));

            var email = Convert.ToString(reader["EMAIL"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var empresa = Convert.ToString(reader["EMPRESA"]);
            var cargo = Convert.ToString(reader["CARGO"]);

            Contato contato = null;
            if (reader["ID_CONTATO"] != DBNull.Value)
            {
                contato = new Contato(nome, email, telefone, empresa, cargo);
                contato.Id = Convert.ToInt32(reader["ID_CONTATO"]);
            }

            Compromisso compromisso = new Compromisso(assunto, local, link, dataDoCompromisso, horaInicio, horaTermino, contato);
            compromisso.Id = Convert.ToInt32(reader["ID"]);

            return compromisso;
        }

        /// <summary>
        /// Obtém os parâmetros do Compromisso
        /// </summary>
        /// <param name="compromisso">Registro do tipo Compromisso</param>
        /// <returns>Retorna um dicionário</returns>
        private Dictionary<string, object> ObtemParametrosCompromisso(Compromisso compromisso)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", compromisso.Id);
            parametros.Add("ASSUNTO", compromisso.Assunto);
            parametros.Add("LOCAL", compromisso.Local);
            parametros.Add("LINK", compromisso.Link);
            parametros.Add("DATA", compromisso.Data);
            parametros.Add("HORAINICIO", compromisso.HoraInicio.Ticks);
            parametros.Add("HORATERMINO", compromisso.HoraTermino.Ticks);
            parametros.Add("ID_CONTATO", compromisso.Contato?.Id);

            return parametros;
        }
    }
}
