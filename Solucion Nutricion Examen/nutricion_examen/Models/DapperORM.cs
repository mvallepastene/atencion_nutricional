using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class DapperORM
    {

       /// <summary>
       /// para conectarnos a la base de datos, lo haremos mediante una cadena de string
       /// </summary>

        private static readonly string connectionString = @"Data Source=(LOCAL);Initial Catalog=CONTROL_NUTRI;Integrated Security=True";

        /// <summary>
        /// Metodo que ejecuta los Stored Procedires para los Insert y Delete
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                con.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }

        /// <summary>
        /// Metodo que utilizamos para el Update Insert and Delete retornando un estado (1 o 0)
        /// /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                return (int)Convert.ToInt32(con.Execute(procedureName, param, commandType: CommandType.StoredProcedure));

            }
        }
        /// <summary>
        /// Retorna Lista dependiendo el modelo... retorna al consultar con y sin parametros
        /// </summary>
        /// <typeparam name="T"></typeparam> Modelo que se le pasa al Stored Procedure para su retorno.
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                return con.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
               
            }
        }
        /// <summary>
        /// Metodo que no requiere modelo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<string> ReturnListWithOutParam(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                return con.Query<string>(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}