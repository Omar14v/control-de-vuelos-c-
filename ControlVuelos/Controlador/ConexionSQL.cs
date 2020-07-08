using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.DAO
{
    class ConexionSQL
    {
        SqlConnection con;


        SqlCommand ComandoSQL;
        SqlDataAdapter Adaptador;

        DataSet DataSetAdaptador;

        public SqlConnection establecerConexion()
        {
            string cs = @"Server=localhost\SQLEXPRESS;Database=Aerodb;Trusted_Connection=True;";
            con = new SqlConnection(cs);
            return con;
        }
        public SqlConnection establecerConexion(string conexionString)
        {
            string cs = conexionString;
            con = new SqlConnection(cs);
            return con;
        }
        public void abrirConexion() { con.Open(); }
        public void cerrarConexion() { con.Close(); }

        public int EjecutarComando(SqlCommand SqlComando)
        {
            // INSERT, DELETE, UPDATE
            ComandoSQL = new SqlCommand();
            ComandoSQL = SqlComando;
            ComandoSQL.Connection = this.establecerConexion();
            this.abrirConexion();
            int codigo = 0; codigo = Convert.ToInt32(ComandoSQL.ExecuteScalar());
            this.cerrarConexion();
            return codigo;
        }
        public DataSet EjecutarSentencia(SqlCommand SqlComando)
        {
            Adaptador = new SqlDataAdapter();
            ComandoSQL = new SqlCommand();
            DataSetAdaptador = new DataSet();
            ComandoSQL = SqlComando;
            ComandoSQL.Connection = this.establecerConexion();
            this.abrirConexion();
            Adaptador.SelectCommand = ComandoSQL;
            Adaptador.Fill(DataSetAdaptador);
            this.cerrarConexion();
            return DataSetAdaptador;
        }


    }
}
