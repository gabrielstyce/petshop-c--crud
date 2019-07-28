namespace PetShop.FORMS.CLIENTES
{
    partial class ClienteMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteMenu));
            this.btnBuscarConsulta = new MetroFramework.Controls.MetroTile();
            this.btnNovaConsulta = new MetroFramework.Controls.MetroTile();
            this.btnBack = new System.Windows.Forms.Button();
            this.buscarCliente1 = new PetShop.FORMS.CLIENTES.BuscarCliente();
            this.newCliente1 = new PetShop.FORMS.CLIENTES.NewCliente();
            this.SuspendLayout();
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.ActiveControl = null;
            this.btnBuscarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsulta.Location = new System.Drawing.Point(31, 63);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(125, 111);
            this.btnBuscarConsulta.Style = MetroFramework.MetroColorStyle.Green;
            this.btnBuscarConsulta.TabIndex = 1;
            this.btnBuscarConsulta.Text = "Buscar Cliente";
            this.btnBuscarConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarConsulta.TileImage")));
            this.btnBuscarConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBuscarConsulta.UseSelectable = true;
            this.btnBuscarConsulta.UseTileImage = true;
            this.btnBuscarConsulta.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.ActiveControl = null;
            this.btnNovaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaConsulta.Location = new System.Drawing.Point(162, 63);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(125, 111);
            this.btnNovaConsulta.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNovaConsulta.TabIndex = 2;
            this.btnNovaConsulta.Text = "Novo Cliente";
            this.btnNovaConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnNovaConsulta.TileImage")));
            this.btnNovaConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovaConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNovaConsulta.UseSelectable = true;
            this.btnNovaConsulta.UseTileImage = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // buscarCliente1
            // 
            this.buscarCliente1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarCliente1.BackColor = System.Drawing.Color.White;
            this.buscarCliente1.Location = new System.Drawing.Point(31, 180);
            this.buscarCliente1.MinimumSize = new System.Drawing.Size(798, 329);
            this.buscarCliente1.Name = "buscarCliente1";
            this.buscarCliente1.Size = new System.Drawing.Size(798, 329);
            this.buscarCliente1.TabIndex = 17;
            this.buscarCliente1.Visible = false;
            // 
            // newCliente1
            // 
            this.newCliente1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCliente1.BackColor = System.Drawing.Color.White;
            this.newCliente1.Location = new System.Drawing.Point(31, 180);
            this.newCliente1.MinimumSize = new System.Drawing.Size(798, 329);
            this.newCliente1.Name = "newCliente1";
            this.newCliente1.Size = new System.Drawing.Size(798, 329);
            this.newCliente1.TabIndex = 16;
            this.newCliente1.Visible = false;
            // 
            // ClienteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.buscarCliente1);
            this.Controls.Add(this.newCliente1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBuscarConsulta);
            this.Controls.Add(this.btnNovaConsulta);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "ClienteMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnBuscarConsulta;
        private MetroFramework.Controls.MetroTile btnNovaConsulta;
        private System.Windows.Forms.Button btnBack;
        private NewCliente newCliente1;
        private BuscarCliente buscarCliente1;
    }
}