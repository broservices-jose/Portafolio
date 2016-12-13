using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDiagramaClase
{
    public partial class Vehiculosregistrado : Form
    {
        public Vehiculosregistrado()
        {
            InitializeComponent();
            consultar();
            dgvvehiculor.Columns[0].Visible = false;
        }

        private void consultar()
        {
            dgvvehiculor.DataSource = new Vehiculo().consultar();
        }

        string id;
        DataSet registros = new DataSet();
        string[] btnnext;
        string[] comboboxText;
        int j = 0;
        int cantidadregistro;
        private void button1_Click(object sender, EventArgs e)
        {
            Pasar.ro.txtmatriculave.Text = dgvvehiculor.CurrentRow.Cells[0].Value.ToString();
            Pasar.ro.txtvehiculoveh.Text = dgvvehiculor.CurrentRow.Cells[3].Value.ToString();
            Pasar.ro.txtchasis.Text = dgvvehiculor.CurrentRow.Cells[1].Value.ToString();
            Pasar.ro.txttraccionve.Text = dgvvehiculor.CurrentRow.Cells[8].Value.ToString();
            Pasar.ro.txttransimisionveh.Text = dgvvehiculor.CurrentRow.Cells[9].Value.ToString();
            Pasar.ro.txtplacaveh.Text = dgvvehiculor.CurrentRow.Cells[2].Value.ToString();
            Pasar.ro.txtmodeloveh.Text = dgvvehiculor.CurrentRow.Cells[4].Value.ToString();
            Pasar.ro.txtanioveh.Text = dgvvehiculor.CurrentRow.Cells[6].Value.ToString();
            Pasar.ro.txtcolorve.Text = dgvvehiculor.CurrentRow.Cells[7].Value.ToString();
            Pasar.ro.cbcombustibleve.Text = dgvvehiculor.CurrentRow.Cells[10].Value.ToString();
            

            this.Close();
        }

        private void dgvvehiculor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroOrden ro = new RegistroOrden();
            foreach (Form cr in Application.OpenForms)
            {
                if (ro.Name == "RegistroOrden")
                {
                    ro = (RegistroOrden)cr;
                    ro.txtmatriculave.Text = dgvvehiculor.CurrentRow.Cells[0].Value.ToString();
                    ro.txtvehiculoveh.Text = dgvvehiculor.CurrentRow.Cells[1].Value.ToString();
                    ro.txttraccionve.Text = dgvvehiculor.CurrentRow.Cells[2].Value.ToString();
                    ro.cbcombustibleve.Text = dgvvehiculor.CurrentRow.Cells[3].Value.ToString();
                    ro.txtvehiculoveh.Text = dgvvehiculor.CurrentRow.Cells[4].Value.ToString();
                    ro.txtchasis.Text = dgvvehiculor.CurrentRow.Cells[5].Value.ToString();
                    ro.txttransimisionveh.Text = dgvvehiculor.CurrentRow.Cells[6].Value.ToString();
                    ro.txtplacaveh.Text = dgvvehiculor.CurrentRow.Cells[7].Value.ToString();
                    ro.txtmodeloveh.Text = dgvvehiculor.CurrentRow.Cells[8].Value.ToString();
                    ro.txtanioveh.Text = dgvvehiculor.CurrentRow.Cells[9].Value.ToString();
                    ro.txtcolorve.Text = dgvvehiculor.CurrentRow.Cells[10].Value.ToString();

                    registros = new Imagen().numeroregistro();
                    cantidadregistro = registros.Tables[0].Rows.Count;
                    for (int i = 0; i < cantidadregistro; i++)
                    {
                        btnnext[i] = (registros.Tables[0].Rows[i]["imagen"].ToString());
                        comboboxText[i] = (registros.Tables[0].Rows[i]["Id"].ToString());


                    }
                    registros.Clear();

                    this.Close();
                    break;
                }

            }
        }

        
    }
}
