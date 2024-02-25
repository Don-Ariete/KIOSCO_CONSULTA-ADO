using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KioscoConsulta
{
    public partial class PantallaMain : Form
    {
        public PantallaMain()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_TecladoNumerico FrmTecladoNumerico=new Pantalla_TecladoNumerico();
            FrmTecladoNumerico.Show();
        }

        private void PantallaMain_Load(object sender, EventArgs e)
        {

            string dia= DateTime.Now.Day.ToString();
            string mes = MesToTexto(int.Parse(DateTime.Now.Month.ToString()));
            string anno=DateTime.Now.Year.ToString();
            label3.Text = dia + " de " + mes + " del " + anno;
        }

        private string MesToTexto(int mes)
        {
            DateTimeFormatInfo formatoFecha= CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(mes);


            return nombreMes.ToLower();
        }
    }
}
