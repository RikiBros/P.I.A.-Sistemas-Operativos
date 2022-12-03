using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace Clases1
{
    public class Usuario{
        ConexionBD conectar;
        private DataTable grid_usuarios()
        {
            DataTable tabla = new DataTable();
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("SELECT idUsuario as id,Nombre,Contraseña");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();

            return tabla;

        }
        public void grid_usuarios(GridView grid)
        {
            grid.DataSource = grid_usuarios();
            grid.DataBind();
        }
        public int crear(string nombre, string contra)
        {
            int no = 0;
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = string.Format("INSERT INTO usuario(Nombre,Contraseña) VALUES ('{0}','{1}')", nombre,contra);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return no;
        }
    }
}
