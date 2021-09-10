using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.Common;


namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);


    /// <summary>
    /// Classe responsável por Inserir, Editar, Deletar, entre outros métodos responsáveis pela interação com o banco de dados
    /// </summary>
    public static class Db
    {
        private static readonly string banco = "";
        private static readonly string connectionString = "";
        private static readonly DbProviderFactory comandoFactory;

        static Db()
        {
            banco = ConfigurationManager.AppSettings["bancoparausar"].ToLower().Trim();
            connectionString = ConfigurationManager.ConnectionStrings[banco].ConnectionString;
           

            comandoFactory = DbProviderFactories.GetFactory(
                ConfigurationManager.ConnectionStrings[banco].ProviderName);

        }

       


        /// <summary>
        /// Inserir registro no banco de dados
        /// </summary>
        /// <param name="sql">Query em SQL para inserção do registro</param>
        /// <param name="parameters">Parâmetros do registro</param>
        /// <returns>Retorna Id</returns>
        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            DbConnection connection = comandoFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = comandoFactory.CreateCommand();
            command.CommandText = sql.AppendSelectIdentity();
            command.Connection = connection;
            command.SetParameters(parameters);

            connection.Open();
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return id;
            
               
                  }

        /// <summary>
        /// Método para edição dos registros do banco de dados
        /// </summary>
        /// <param name="sql">Query SQL para edição</param>
        /// <param name="parameters">Parâmetros do registro</param>
        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            DbConnection connection = comandoFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = comandoFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);
            

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();        

          


        }

        /// <summary>
        /// Método para excluir registro do banco de dados
        /// </summary>
        /// <param name="sql">Query SQL do comando</param>
        /// <param name="parameters">Parâmetros do Registro</param>
        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        /// <summary>
        /// Pega todos os registros de acordo com o comando
        /// </summary>
        /// <typeparam name="T">Registro genérico</typeparam>
        /// <param name="sql">Query SQL</param>
        /// <param name="convert">Converter registro</param>
        /// <param name="parameters">Parâmetros do registro</param>
        /// <returns> Retorna uma lista de registros</returns>
        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            DbConnection connection = comandoFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = comandoFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);          

            connection.Open();

            var list = new List<T>();

            var reader = command.ExecuteReader();

            while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }
            reader.Close();

            connection.Close();
            return list;                   


        }

        /// <summary>
        ///  Procura um registro específico com base na Query
        /// </summary>
        /// <typeparam name="T">Registro genérico</typeparam>
        /// <param name="sql">Query SQL do comando</param>
        /// <param name="convert">Conversão dos registros</param>
        /// <param name="parameters">Parâmetros dos registros</param>
        /// <returns>Retorna um registro específico</returns>
        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {

            DbConnection connection = comandoFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = comandoFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);
            

           connection.Open();

           T t = default;

           using (var reader = command.ExecuteReader())
                {

                    if (reader.Read())
                        t = convert(reader);
                }

           connection.Close();
           return t; 
           
        }

        /// <summary>
        /// Verifica se existe registro
        /// </summary>
        /// <param name="sql">Query SQL com o comando</param>
        /// <param name="parameters">Parâmetros do registro</param>
        /// <returns>Retorna true se existe registro especificado</returns>
        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            DbConnection connection = comandoFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = comandoFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;

            command.SetParameters(parameters);

            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;


        }

        /// <summary>
        /// Define os parâmetros do comando
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        private static void SetParameters(this DbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

                          
                foreach (var parameter in parameters)
                {
                    string name = parameter.Key;

                    object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                    DbParameter dbParameter = comandoFactory.CreateParameter();
                    dbParameter.Value = value;
                    dbParameter.ParameterName = name;

                    command.Parameters.Add(dbParameter);
                }
            
            
        }


        /// <summary>
        /// String de autoincremento pode ser diferente dependendo do banco utilizado. 
        /// </summary>
        /// <param name="sql">QUERY Sql que será adicionado o valor</param>
        /// <returns> Retorna string de auto-incremento no banco de dados.</returns>
        private static string AppendSelectIdentity(this string sql)
        {
              return sql + ";SELECT SCOPE_IDENTITY()";
        }


        /// <summary>
        /// Verifica se é null ou vazio
        /// </summary>
        /// <param name="value">Recebe um objeto</param>
        /// <returns>Retorna true se for null ou vazio</returns>
        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

    }
}
