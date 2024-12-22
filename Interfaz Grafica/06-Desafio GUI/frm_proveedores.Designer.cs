namespace _06_Desafio_GUI
{
    partial class frm_proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_proveedores));
            lbl_titulo = new Label();
            lbl_raya = new Label();
            button1 = new Button();
            txt_nombre = new TextBox();
            lbl_Nombre = new Label();
            lbl_rnc = new Label();
            lbl_direccion = new Label();
            lbl_telefono = new Label();
            lbl_correo = new Label();
            lbl_ciudad = new Label();
            txt_Rnc = new TextBox();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_Correo = new TextBox();
            txt_ciudad = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dtgw_proveedores = new DataGridView();
            btnLinea2 = new Button();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            btn_edit = new Button();
            btn_elimina = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            RNC = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgw_proveedores).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.Control;
            lbl_titulo.Location = new Point(25, 9);
            lbl_titulo.Margin = new Padding(3, 0, 10, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(262, 27);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestion de Proveedores\r\n";
            // 
            // lbl_raya
            // 
            lbl_raya.AutoSize = true;
            lbl_raya.BackColor = Color.Transparent;
            lbl_raya.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_raya.ForeColor = SystemColors.ButtonHighlight;
            lbl_raya.Location = new Point(-1, 49);
            lbl_raya.Name = "lbl_raya";
            lbl_raya.Size = new Size(1645, 16);
            lbl_raya.TabIndex = 1;
            lbl_raya.Text = resources.GetString("lbl_raya.Text");
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 356);
            button1.Name = "button1";
            button1.Size = new Size(83, 38);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(150, 84);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(137, 23);
            txt_nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.Transparent;
            lbl_Nombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nombre.ForeColor = SystemColors.Control;
            lbl_Nombre.Location = new Point(25, 92);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(78, 25);
            lbl_Nombre.TabIndex = 4;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_rnc
            // 
            lbl_rnc.AutoSize = true;
            lbl_rnc.BackColor = Color.Transparent;
            lbl_rnc.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rnc.ForeColor = SystemColors.Control;
            lbl_rnc.Location = new Point(25, 130);
            lbl_rnc.Name = "lbl_rnc";
            lbl_rnc.Size = new Size(48, 25);
            lbl_rnc.TabIndex = 5;
            lbl_rnc.Text = "RNC";
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.BackColor = Color.Transparent;
            lbl_direccion.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_direccion.ForeColor = SystemColors.Control;
            lbl_direccion.Location = new Point(25, 200);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(93, 25);
            lbl_direccion.TabIndex = 6;
            lbl_direccion.Text = "Direccion";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.BackColor = Color.Transparent;
            lbl_telefono.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefono.ForeColor = SystemColors.Control;
            lbl_telefono.Location = new Point(25, 162);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(77, 23);
            lbl_telefono.TabIndex = 7;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.BackColor = Color.Transparent;
            lbl_correo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_correo.ForeColor = SystemColors.Control;
            lbl_correo.Location = new Point(25, 239);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(70, 25);
            lbl_correo.TabIndex = 8;
            lbl_correo.Text = "Correo";
            // 
            // lbl_ciudad
            // 
            lbl_ciudad.AutoSize = true;
            lbl_ciudad.BackColor = Color.Transparent;
            lbl_ciudad.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ciudad.ForeColor = SystemColors.Control;
            lbl_ciudad.Location = new Point(25, 282);
            lbl_ciudad.Name = "lbl_ciudad";
            lbl_ciudad.Size = new Size(72, 25);
            lbl_ciudad.TabIndex = 9;
            lbl_ciudad.Text = "Ciudad";
            // 
            // txt_Rnc
            // 
            txt_Rnc.Location = new Point(150, 122);
            txt_Rnc.Name = "txt_Rnc";
            txt_Rnc.Size = new Size(137, 23);
            txt_Rnc.TabIndex = 10;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(150, 162);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(137, 23);
            txt_telefono.TabIndex = 11;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(150, 200);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(137, 23);
            txt_direccion.TabIndex = 12;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(150, 239);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(137, 23);
            txt_Correo.TabIndex = 13;
            // 
            // txt_ciudad
            // 
            txt_ciudad.Location = new Point(150, 279);
            txt_ciudad.Name = "txt_ciudad";
            txt_ciudad.Size = new Size(137, 23);
            txt_ciudad.TabIndex = 14;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(123, 356);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 15;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(236, 356);
            button3.Name = "button3";
            button3.Size = new Size(75, 38);
            button3.TabIndex = 16;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // dtgw_proveedores
            // 
            dtgw_proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_proveedores.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, RNC, Telefono, Direccion, Correo });
            dtgw_proveedores.Location = new Point(345, 122);
            dtgw_proveedores.Name = "dtgw_proveedores";
            dtgw_proveedores.ReadOnly = true;
            dtgw_proveedores.Size = new Size(592, 255);
            dtgw_proveedores.TabIndex = 17;
            // 
            // btnLinea2
            // 
            btnLinea2.Location = new Point(324, 57);
            btnLinea2.Name = "btnLinea2";
            btnLinea2.Size = new Size(1, 428);
            btnLinea2.TabIndex = 18;
            btnLinea2.Text = "button4";
            btnLinea2.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = SystemColors.ButtonHighlight;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(811, 75);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(90, 32);
            btn_buscar.TabIndex = 19;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(648, 84);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(137, 23);
            txt_buscar.TabIndex = 20;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.ButtonHighlight;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(377, 403);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(93, 35);
            btn_edit.TabIndex = 22;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_elimina
            // 
            btn_elimina.BackColor = SystemColors.ButtonHighlight;
            btn_elimina.FlatStyle = FlatStyle.Flat;
            btn_elimina.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_elimina.Location = new Point(494, 403);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(93, 35);
            btn_elimina.TabIndex = 21;
            btn_elimina.Text = "Eliminar ";
            btn_elimina.UseVisualStyleBackColor = false;
            btn_elimina.Click += btn_elimina_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // RNC
            // 
            RNC.HeaderText = "RNC";
            RNC.Name = "RNC";
            RNC.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Ciudad";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // frm_proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 484);
            Controls.Add(btn_edit);
            Controls.Add(btn_elimina);
            Controls.Add(txt_buscar);
            Controls.Add(btn_buscar);
            Controls.Add(btnLinea2);
            Controls.Add(dtgw_proveedores);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_ciudad);
            Controls.Add(txt_Correo);
            Controls.Add(txt_direccion);
            Controls.Add(txt_telefono);
            Controls.Add(txt_Rnc);
            Controls.Add(lbl_ciudad);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_direccion);
            Controls.Add(lbl_rnc);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_nombre);
            Controls.Add(button1);
            Controls.Add(lbl_raya);
            Controls.Add(lbl_titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_proveedores";
            Text = "Formulario de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dtgw_proveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_raya;
        private Button button1;
        private TextBox txt_nombre;
        private Label lbl_Nombre;
        private Label lbl_rnc;
        private Label lbl_direccion;
        private Label lbl_telefono;
        private Label lbl_correo;
        private Label lbl_ciudad;
        private TextBox txt_Rnc;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_Correo;
        private TextBox txt_ciudad;
        private Button button2;
        private Button button3;
        private DataGridView dtgw_proveedores;
        private Button btnLinea2;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Button btn_edit;
        private Button btn_elimina;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn RNC;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
    }
}