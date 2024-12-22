namespace _06_Desafio_GUI
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_proveedores proveedores = new frm_proveedores();
            proveedores.ShowDialog();
            proveedores.Parent = this;

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mProducto producto = new frm_mProducto();
            producto.ShowDialog();
            producto.Parent = this;
        }
    }
}
