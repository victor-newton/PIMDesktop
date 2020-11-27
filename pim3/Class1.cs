using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace pim3
{
    public sealed class Session
    {

        private static volatile Session instance;
        private static object sync = new Object();

        private Session() { }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }

        }
        public string UserID { get; set; }

    }

    public static class Variaveis
    {
        public static string conexao = "Data Source=DESKTOP;Initial Catalog=UniCript;Integrated Security=True";
    }

    public static class Funcoes
    {
        public static string FormataDataAmericana(DateTime DataBR)
        {
            int dia = DataBR.Day, mes = DataBR.Month, ano = DataBR.Year;
            string DataUS = mes + "/" + dia + "/" + ano +" "+ DataBR.Hour + ":" + DataBR.Minute + ":" + DataBR.Second;
            return DataUS;
        }

    }

    public class SQLFunctions
    {
        public static int ExecutaComando(string comando)
        {
            try
            {
                SqlConnection SqlConInsert = new SqlConnection(Variaveis.conexao);
                SqlCommand Insere = new SqlCommand(comando, SqlConInsert);
                Insere.CommandType = CommandType.Text;
                SqlConInsert.Open();
                Insere.ExecuteNonQuery();
            }
            catch (Exception ex) //Caso retorne algum erro
            {
                return 1;
            }
            return 0;
        }

        public static DataTable GetInfos(string consulta)
        {
            DataTable Consulta = new DataTable();

            SqlConnection sqlConn = new SqlConnection(Variaveis.conexao);
            SqlCommand cmd = new SqlCommand(consulta, sqlConn); //Cria o comando SQL
            sqlConn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //Executa o comando sql para fazer a select de dados
            Consulta.Load(reader);

            return Consulta;
        }
    }
}