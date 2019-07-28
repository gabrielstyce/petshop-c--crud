namespace PetShop.FORMS.PETS
{
    partial class PetsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetsMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBuscarConsulta = new MetroFramework.Controls.MetroTile();
            this.btnNovaConsulta = new MetroFramework.Controls.MetroTile();
            this.newPet2 = new PetShop.FORMS.PETS.NewPet();
            this.buscarPet2 = new PetShop.FORMS.PETS.BuscarPet();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 19;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.ActiveControl = null;
            this.btnBuscarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsulta.Location = new System.Drawing.Point(23, 63);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(114, 99);
            this.btnBuscarConsulta.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBuscarConsulta.TabIndex = 18;
            this.btnBuscarConsulta.TabStop = false;
            this.btnBuscarConsulta.Text = "Buscar Pet";
            this.btnBuscarConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarConsulta.TileImage")));
            this.btnBuscarConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBuscarConsulta.UseSelectable = true;
            this.btnBuscarConsulta.UseTileImage = true;
            this.btnBuscarConsulta.Click += new System.EventHandler(this.BtnBuscarConsulta_Click);
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.ActiveControl = null;
            this.btnNovaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaConsulta.Location = new System.Drawing.Point(143, 63);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(114, 99);
            this.btnNovaConsulta.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnNovaConsulta.TabIndex = 17;
            this.btnNovaConsulta.TabStop = false;
            this.btnNovaConsulta.Text = "Novo Pet";
            this.btnNovaConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnNovaConsulta.TileImage")));
            this.btnNovaConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovaConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNovaConsulta.UseSelectable = true;
            this.btnNovaConsulta.UseTileImage = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.BtnNovaConsulta_Click);
            // 
            // newPet2
            // 
            this.newPet2.BackColor = System.Drawing.Color.White;
            this.newPet2.Location = new System.Drawing.Point(23, 168);
            this.newPet2.MinimumSize = new System.Drawing.Size(798, 329);
            this.newPet2.Name = "newPet2";
            this.newPet2.Size = new System.Drawing.Size(798, 329);
            this.newPet2.TabIndex = 21;
            this.newPet2.Visible = false;
            // 
            // buscarPet2
            // 
            this.buscarPet2.BackColor = System.Drawing.Color.White;
            this.buscarPet2.Location = new System.Drawing.Point(23, 168);
            this.buscarPet2.MinimumSize = new System.Drawing.Size(798, 329);
            this.buscarPet2.Name = "buscarPet2";
            this.buscarPet2.Size = new System.Drawing.Size(798, 329);
            this.buscarPet2.TabIndex = 20;
            this.buscarPet2.Visible = false;
            // 
            // PetsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.newPet2);
            this.Controls.Add(this.buscarPet2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBuscarConsulta);
            this.Controls.Add(this.btnNovaConsulta);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "PetsMenu";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PetsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnBuscarConsulta;
        private MetroFramework.Controls.MetroTile btnNovaConsulta;
        private System.Windows.Forms.Button btnBack;
        private BuscarPet buscarPet2;
        private NewPet newPet2;
    }
}