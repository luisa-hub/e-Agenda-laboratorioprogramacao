using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.Common;


namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

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

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

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

        private static string AppendSelectIdentity(this string sql)
        {
            if(banco == "sqlite")
                return sql + ";SELECT LAST_INSERT_ROWID()";

            else
                return sql + ";SELECT SCOPE_IDENTITY()";
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

    }
}
