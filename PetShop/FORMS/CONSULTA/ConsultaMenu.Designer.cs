namespace PetShop
{
    partial class ConsultaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBuscarConsulta = new MetroFramework.Controls.MetroTile();
            this.btnNovaConsulta = new MetroFramework.Controls.MetroTile();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newConsulta1 = new PetShop.FORMS.CONSULTA.NewConsulta();
            this.buscarConsulta1 = new PetShop.FORMS.CONSULTA.BuscarConsulta();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.ActiveControl = null;
            this.btnBuscarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsulta.Location = new System.Drawing.Point(159, 63);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(125, 111);
            this.btnBuscarConsulta.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnBuscarConsulta.TabIndex = 1;
            this.btnBuscarConsulta.Text = "Buscar Consulta";
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
            this.btnNovaConsulta.Location = new System.Drawing.Point(28, 63);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(125, 111);
            this.btnNovaConsulta.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnNovaConsulta.TabIndex = 0;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnNovaConsulta.TileImage")));
            this.btnNovaConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovaConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNovaConsulta.UseSelectable = true;
            this.btnNovaConsulta.UseTileImage = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.BtnNovaConsulta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 173);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // newConsulta1
            // 
            this.newConsulta1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newConsulta1.BackColor = System.Drawing.Color.White;
            this.newConsulta1.Location = new System.Drawing.Point(28, 180);
            this.newConsulta1.Name = "newConsulta1";
            this.newConsulta1.Size = new System.Drawing.Size(799, 326);
            this.newConsulta1.TabIndex = 16;
            this.newConsulta1.Visible = false;
            // 
            // buscarConsulta1
            // 
            this.buscarConsulta1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarConsulta1.BackColor = System.Drawing.Color.White;
            this.buscarConsulta1.Location = new System.Drawing.Point(28, 185);
            this.buscarConsulta1.MinimumSize = new System.Drawing.Size(798, 329);
            this.buscarConsulta1.Name = "buscarConsulta1";
            this.buscarConsulta1.Size = new System.Drawing.Size(799, 329);
            this.buscarConsulta1.TabIndex = 17;
            this.buscarConsulta1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ConsultaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.buscarConsulta1);
            this.Controls.Add(this.newConsulta1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBuscarConsulta);
            this.Controls.Add(this.btnNovaConsulta);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "ConsultaMenu";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnNovaConsulta;
        private MetroFramework.Controls.MetroTile btnBuscarConsulta;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FORMS.CONSULTA.NewConsulta newConsulta1;
        private FORMS.CONSULTA.BuscarConsulta buscarConsulta1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}