using KioscoConsulta.Models;
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
    public partial class PantallaAcceso : Form
    {
        AN_COMEDOR_USUARIO oUsuario = null; 

        public PantallaAcceso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            string usuarioComedor = TbUsuario.Text;

            if (CheckUser(usuarioComedor) != true)
            {
                //abrir modal usuario no valido.
                TbUsuario.Text = "";
                TbUsuario.Focus();
            }
            else
            {//abrir la otra pagina//
             //enviar código y nombre.

                PasarUsuarioForms();
                TbUsuario.Text = "";
                TbUsuario.Select();
            }

        }

        private bool CheckUser(string usuarioComedor)
        {
            bool encontrado = false;

            using (Models.DBEntities db = new Models.DBEntities())
            {
                var userExist = from d in db.AN_COMEDOR_USUARIO
                                where d.USUARIO_COMEDOR == usuarioComedor
                                && d.F_BAJA == "" && d.F_SUSPENCION == ""
                                select new {d.NUM_EMP,d.NOMBRE,d.AP_PATER,d.AP_MATER };
                if (userExist.Count() ==1)
                {
                    encontrado = true;

                    foreach (var user in userExist)
                    {
                        lblNumEmp_FA.Text = user.NUM_EMP; lblNumEmp_FA.Visible = false;
                        lblNombre_FA.Text = user.NOMBRE + " " + user.AP_PATER + " " + user.AP_MATER; lblNombre_FA.Visible = false;
                    }
                }   
            }
            return encontrado;
        }


        private void PasarUsuarioForms()
        {
            PantallaMain FrmPantallaMain = new PantallaMain();
            FrmPantallaMain.lblNombre_FM.Text = lblNombre_FA.Text;
            FrmPantallaMain.lblNumEmp_FM.Text = lblNumEmp_FA.Text;
            FrmPantallaMain.Show();
        }

    }
}
