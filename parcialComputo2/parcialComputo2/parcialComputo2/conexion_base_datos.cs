using System;
using System.Data;
using System.Data.SqlClient;

namespace parcialComputo2
{
    public class Conexion_base_datos
    {
        // Cadena de conexión para la base de datos del proyecto
        public static SqlConnection Conectar()
        {
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\usuarios_usss081226.mdf;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static void procesar(string query)
        {
            SqlConnection conexion = Conectar();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Método crearDs
        public static DataSet crearDs()
        {
            SqlConnection conexion = Conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM usuarios", conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "usuarios");
            conexion.Close();
            return ds;
        }

        // Método de mantenimiento para insertar
        public static void mantenimiento_usuarios_usss081226(string usuario, string clave, string nombre, string direccion, string telefono)
        {
            string consulta = "INSERT INTO usuarios (usuario, clave, nombre, dirección, teléfono) VALUES ('" + usuario + "', '" + clave + "', '" + nombre + "', '" + direccion + "', '" + telefono + "')";
            procesar(consulta);
        }

        // Modificar un usuario existente
        public static void modificar_usuario(int idUsuario, string usuario, string clave, string nombre, string direccion, string telefono)
        {
            string consulta = "UPDATE usuarios SET usuario = '" + usuario + "', clave = '" + clave + "', nombre = '" + nombre + "', dirección = '" + direccion + "', teléfono = '" + telefono + "' WHERE idUsuario = " + idUsuario;
            procesar(consulta);
        }

        // Eliminar un usuario por su ID
        public static void eliminar_usuario(int idUsuario)
        {
            string consulta = "DELETE FROM usuarios WHERE idUsuario = " + idUsuario;
            procesar(consulta);
        }
    }
}