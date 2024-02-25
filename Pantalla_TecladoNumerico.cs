using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoConsulta
{
    public partial class Pantalla_TecladoNumerico : Form
    {
        public Pantalla_TecladoNumerico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "1";
        }

        private void Tecla2_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "2";
        }

        private void Tecla3_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "3";
        }

        private void Tecla4_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "4";
        }

        private void Tecla5_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "5";
        }

        private void Tecla6_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "6";
        }

        private void Tecla7_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "7";
        }

        private void Tecla8_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "8";
        }

        private void Tecla9_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "9";
        }

        private void Tecla0_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = Tbvisor.Text + "0";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Tbvisor.Text = "";
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string valor=Tbvisor.Text;
            Tbvisor.Text = "";
            this.Close();
        }
    }
}
