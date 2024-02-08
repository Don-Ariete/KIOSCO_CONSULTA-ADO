using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

            var builder =new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-6KVNJDB\\SQLEXPRESS";
            builder.InitialCatalog = "NOMINA";
            builder.IntegratedSecurity = true;
            //builder.IntegratedSecurity = false;
            //builder.UserID = "";
            //builder.Password = "password";
            var conectDB=builder.ToString();
        }
    }
}
