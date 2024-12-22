using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Desafio_GUI
{
    public partial class frm_proveedores : Form
    {
        int Fila = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();

            prov.nombre = txt_nombre.Text;

            prov.rnc = txt_Rnc.Text;

            prov.telefono = txt_telefono.Text;

            prov.correo = txt_Correo.Text;

            prov.ciudad = txt_ciudad.Text;

            if (string.IsNullOrWhiteSpace(txt_ciudad.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                string.IsNullOrWhiteSpace(txt_Rnc.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text)||
                string.IsNullOrWhiteSpace(txt_telefono.Text)
                )
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                Fila = dtgw_proveedores.Rows.Add();

                dtgw_proveedores.Rows[Fila].Cells[0].Value = Fila.ToString();
                dtgw_proveedores.Rows[Fila].Cells[1].Value = txt_nombre.Text;
                dtgw_proveedores.Rows[Fila].Cells[2].Value = txt_Rnc.Text;
                dtgw_proveedores.Rows[Fila].Cells[3].Value = txt_telefono.Text;
                dtgw_proveedores.Rows[Fila].Cells[4].Value = txt_direccion.Text;
                dtgw_proveedores.Rows[Fila].Cells[5].Value = txt_ciudad.Text;


            }



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dtgw_proveedores.ReadOnly = false;
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (dtgw_proveedores.SelectedRows.Count > 0)
            {

                DialogResult = MessageBox.Show("Estas seguro de que deseas eliminar", "advertencia", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    dtgw_proveedores.Rows.RemoveAt(dtgw_proveedores.SelectedRows[0].Index);
                    MessageBox.Show("Registro eliminado con exito");
                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("De acuerdo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_buscar.Text);

            foreach (DataGridViewRow fila in dtgw_proveedores.Rows)
            {
                if (fila.Cells["ID"].Value != null && Convert.ToInt32(fila.Cells["ID"].Value) == id)
                {
                    fila.Selected = true;
                    return;
                }
            }

            MessageBox.Show("ID no encontrado.");
        }
    }

    class proveedores 
    {
        public string nombre {  get; set; }

        public string rnc { get; set; }

        public string telefono { get; set; }

        public  string direccion { get; set; }

        public string correo { get; set; }

        public string ciudad {  get; set; }

             
    }


}

