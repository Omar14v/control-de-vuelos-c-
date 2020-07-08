using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.BO;
using System.Data.SqlClient;
using System.Data;

namespace Ejemplo.DAO
{
    class UsuarioDAO:ConexionSQL
    {

        SqlCommand cmd;

        public int Agregar(UsuarioBO objeus)
        {
            cmd = new SqlCommand("insert into VUELOS (ciudad1, ciudad2, tipo, fecha1, fecha2, estado, hora1, hora2) values (@ciudad1, @ciudad2, @tipo, @fecha1, @fecha2, @estado, @hora1, @hora2)");
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = objeus.tipo;
            cmd.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = objeus.fecha1;
            cmd.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = objeus.fecha2;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = objeus.estado;
            cmd.Parameters.Add("@hora1", SqlDbType.VarChar).Value = objeus.hora1;
            cmd.Parameters.Add("@hora2", SqlDbType.VarChar).Value = objeus.hora2;
            cmd.Parameters.Add("@ciudad1", SqlDbType.VarChar).Value = objeus.ciudad1;
            cmd.Parameters.Add("@ciudad2", SqlDbType.VarChar).Value = objeus.ciudad2;
            cmd.CommandType = CommandType.Text;
            return EjecutarComando(cmd);
        }

        public int Modificar(UsuarioBO objeus)
        {
            cmd = new SqlCommand("update VUELOS set ciudad1=@ciudad1, ciudad2=@ciudad2, tipo=@tipo, fecha1=@fecha2, estado=@estado, hora1=@hora2, hora2=@hora2 where codigo=@codigo");
            
            cmd.Parameters.Add("@ciudad1", SqlDbType.VarChar).Value = objeus.ciudad1;
            cmd.Parameters.Add("@ciudad2", SqlDbType.VarChar).Value = objeus.ciudad2;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = objeus.tipo;
            cmd.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = objeus.fecha1;
            cmd.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = objeus.fecha2;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = objeus.estado;
            cmd.Parameters.Add("@hora1", SqlDbType.VarChar).Value = objeus.hora1;
            cmd.Parameters.Add("@hora2", SqlDbType.VarChar).Value = objeus.hora2;
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objeus.codigo;

            cmd.CommandType = CommandType.Text;
            return EjecutarComando(cmd);
        }

        public int Eliminar(UsuarioBO objeus)
        {
            cmd = new SqlCommand("delete from VUELOS where codigo=@codigo");
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objeus.codigo;
            cmd.CommandType = CommandType.Text;
            return EjecutarComando(cmd);

        }


        ///Mostrar datos de la tabla
        ///
        public DataSet MostrarDatos()
        {
            cmd = new SqlCommand("select codigo 'Código', ciudad1 'Ciudad Origen', ciudad2 'Ciudad Destino', tipo 'Tipo', fecha1 'Fecha Origen', fecha2 'Fecha Destino', estado 'Estado del Vuelo', hora1 'Hora Despegue', hora2 'Hora Aterrizaje' from VUELOS");
            cmd.CommandType = CommandType.Text;
            return EjecutarSentencia(cmd);
        }

    }
}
