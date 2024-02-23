using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoConsulta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaAcceso());
        }

    }

    public class DB_conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-6KVNJDB\\SQLEXPRESS; DataBase=NOMINA; integrated Security = true; ");
        public SqlConnection AbrirConexion()
        { 
            if (Conexion.State== ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


    }




}
