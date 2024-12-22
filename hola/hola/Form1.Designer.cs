namespace hola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            numbreToolStripMenuItem = new ToolStripMenuItem();
            rNCToolStripMenuItem = new ToolStripMenuItem();
            direccionToolStripMenuItem = new ToolStripMenuItem();
            telefonoToolStripMenuItem = new ToolStripMenuItem();
            correoToolStripMenuItem = new ToolStripMenuItem();
            ciudadToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            pToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            nombreToolStripMenuItem1 = new ToolStripMenuItem();
            rNCToolStripMenuItem1 = new ToolStripMenuItem();
            direccionToolStripMenuItem1 = new ToolStripMenuItem();
            telefonoToolStripMenuItem1 = new ToolStripMenuItem();
            correoToolStripMenuItem1 = new ToolStripMenuItem();
            ciudadToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            nombreToolStripMenuItem2 = new ToolStripMenuItem();
            categoriaToolStripMenuItem1 = new ToolStripMenuItem();
            precioToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Sylfaen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl.Location = new Point(81, 197);
            lbl.Name = "lbl";
            lbl.Size = new Size(645, 39);
            lbl.TabIndex = 0;
            lbl.Text = "Sistema de gestion de inventario y proveedores .";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem, productosToolStripMenuItem, toolStripSeparator1 });
            mantenimientoToolStripMenuItem.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(94, 21);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator3, numbreToolStripMenuItem, rNCToolStripMenuItem, direccionToolStripMenuItem, telefonoToolStripMenuItem, correoToolStripMenuItem, ciudadToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(118, 6);
            toolStripSeparator3.Visible = false;
            // 
            // numbreToolStripMenuItem
            // 
            numbreToolStripMenuItem.Name = "numbreToolStripMenuItem";
            numbreToolStripMenuItem.Size = new Size(121, 22);
            numbreToolStripMenuItem.Text = "Numbre";
            // 
            // rNCToolStripMenuItem
            // 
            rNCToolStripMenuItem.Name = "rNCToolStripMenuItem";
            rNCToolStripMenuItem.Size = new Size(121, 22);
            rNCToolStripMenuItem.Text = "RNC";
            // 
            // direccionToolStripMenuItem
            // 
            direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            direccionToolStripMenuItem.Size = new Size(121, 22);
            direccionToolStripMenuItem.Text = "Direccion";
            // 
            // telefonoToolStripMenuItem
            // 
            telefonoToolStripMenuItem.Name = "telefonoToolStripMenuItem";
            telefonoToolStripMenuItem.Size = new Size(121, 22);
            telefonoToolStripMenuItem.Text = "Telefono";
            // 
            // correoToolStripMenuItem
            // 
            correoToolStripMenuItem.Name = "correoToolStripMenuItem";
            correoToolStripMenuItem.Size = new Size(121, 22);
            correoToolStripMenuItem.Text = "Correo";
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(121, 22);
            ciudadToolStripMenuItem.Text = "Ciudad";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem, categoriaToolStripMenuItem, pToolStripMenuItem, stockToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // nombreToolStripMenuItem
            // 
            nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            nombreToolStripMenuItem.Size = new Size(124, 22);
            nombreToolStripMenuItem.Text = "Nombre";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(124, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // pToolStripMenuItem
            // 
            pToolStripMenuItem.Name = "pToolStripMenuItem";
            pToolStripMenuItem.Size = new Size(124, 22);
            pToolStripMenuItem.Text = "Precio";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(124, 22);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem1, productosToolStripMenuItem1, toolStripSeparator4 });
            reportesToolStripMenuItem.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(64, 21);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, nombreToolStripMenuItem1, rNCToolStripMenuItem1, direccionToolStripMenuItem1, telefonoToolStripMenuItem1, correoToolStripMenuItem1, ciudadToolStripMenuItem1 });
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(180, 22);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(118, 6);
            // 
            // nombreToolStripMenuItem1
            // 
            nombreToolStripMenuItem1.Name = "nombreToolStripMenuItem1";
            nombreToolStripMenuItem1.Size = new Size(121, 22);
            nombreToolStripMenuItem1.Text = "Nombre";
            // 
            // rNCToolStripMenuItem1
            // 
            rNCToolStripMenuItem1.Name = "rNCToolStripMenuItem1";
            rNCToolStripMenuItem1.Size = new Size(121, 22);
            rNCToolStripMenuItem1.Text = "RNC";
            // 
            // direccionToolStripMenuItem1
            // 
            direccionToolStripMenuItem1.Name = "direccionToolStripMenuItem1";
            direccionToolStripMenuItem1.Size = new Size(121, 22);
            direccionToolStripMenuItem1.Text = "Direccion";
            // 
            // telefonoToolStripMenuItem1
            // 
            telefonoToolStripMenuItem1.Name = "telefonoToolStripMenuItem1";
            telefonoToolStripMenuItem1.Size = new Size(121, 22);
            telefonoToolStripMenuItem1.Text = "Telefono";
            // 
            // correoToolStripMenuItem1
            // 
            correoToolStripMenuItem1.Name = "correoToolStripMenuItem1";
            correoToolStripMenuItem1.Size = new Size(121, 22);
            correoToolStripMenuItem1.Text = "Correo";
            // 
            // ciudadToolStripMenuItem1
            // 
            ciudadToolStripMenuItem1.Name = "ciudadToolStripMenuItem1";
            ciudadToolStripMenuItem1.Size = new Size(121, 22);
            ciudadToolStripMenuItem1.Text = "Ciudad";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem2, categoriaToolStripMenuItem1, precioToolStripMenuItem, stockToolStripMenuItem1 });
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(180, 22);
            productosToolStripMenuItem1.Text = "Productos";
            // 
            // nombreToolStripMenuItem2
            // 
            nombreToolStripMenuItem2.Name = "nombreToolStripMenuItem2";
            nombreToolStripMenuItem2.Size = new Size(124, 22);
            nombreToolStripMenuItem2.Text = "Nombre";
            // 
            // categoriaToolStripMenuItem1
            // 
            categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            categoriaToolStripMenuItem1.Size = new Size(124, 22);
            categoriaToolStripMenuItem1.Text = "Categoria";
            // 
            // precioToolStripMenuItem
            // 
            precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            precioToolStripMenuItem.Size = new Size(124, 22);
            precioToolStripMenuItem.Text = "Precio";
            // 
            // stockToolStripMenuItem1
            // 
            stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            stockToolStripMenuItem1.Size = new Size(124, 22);
            stockToolStripMenuItem1.Text = "Stock";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(43, 21);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Formulario Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem numbreToolStripMenuItem;
        private ToolStripMenuItem rNCToolStripMenuItem;
        private ToolStripMenuItem direccionToolStripMenuItem;
        private ToolStripMenuItem telefonoToolStripMenuItem;
        private ToolStripMenuItem correoToolStripMenuItem;
        private ToolStripMenuItem ciudadToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem1;
        private ToolStripMenuItem rNCToolStripMenuItem1;
        private ToolStripMenuItem direccionToolStripMenuItem1;
        private ToolStripMenuItem telefonoToolStripMenuItem1;
        private ToolStripMenuItem correoToolStripMenuItem1;
        private ToolStripMenuItem ciudadToolStripMenuItem1;
        private ToolStripMenuItem nombreToolStripMenuItem2;
        private ToolStripMenuItem categoriaToolStripMenuItem1;
        private ToolStripMenuItem precioToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem1;
    }
}
