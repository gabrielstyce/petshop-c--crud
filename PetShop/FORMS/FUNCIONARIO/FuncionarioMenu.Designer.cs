namespace PetShop
{
    partial class FuncionarioMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBuscarConsulta = new MetroFramework.Controls.MetroTile();
            this.btnNovaConsulta = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.buscarFuncionario1 = new PetShop.BuscarFuncionario();
            this.newFunc1 = new PetShop.NewFunc();
            this.calcularSalario1 = new PetShop.FORMS.FUNCIONARIO.CalcularSalario();
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
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.ActiveControl = null;
            this.btnBuscarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsulta.Location = new System.Drawing.Point(29, 63);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(146, 99);
            this.btnBuscarConsulta.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBuscarConsulta.TabIndex = 1;
            this.btnBuscarConsulta.TabStop = false;
            this.btnBuscarConsulta.Text = "Buscar Funcionário";
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
            this.btnNovaConsulta.Location = new System.Drawing.Point(181, 63);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(146, 99);
            this.btnNovaConsulta.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNovaConsulta.TabIndex = 2;
            this.btnNovaConsulta.TabStop = false;
            this.btnNovaConsulta.Text = "Novo Funcioário";
            this.btnNovaConsulta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnNovaConsulta.TileImage")));
            this.btnNovaConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovaConsulta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNovaConsulta.UseSelectable = true;
            this.btnNovaConsulta.UseTileImage = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.BtnNovaConsulta_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(333, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(146, 99);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.TabStop = false;
            this.metroTile1.Text = "Calcular Salário";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // buscarFuncionario1
            // 
            this.buscarFuncionario1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarFuncionario1.BackColor = System.Drawing.Color.Transparent;
            this.buscarFuncionario1.Location = new System.Drawing.Point(29, 168);
            this.buscarFuncionario1.Name = "buscarFuncionario1";
            this.buscarFuncionario1.Size = new System.Drawing.Size(798, 329);
            this.buscarFuncionario1.TabIndex = 19;
            this.buscarFuncionario1.Visible = false;
            // 
            // newFunc1
            // 
            this.newFunc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newFunc1.BackColor = System.Drawing.Color.Transparent;
            this.newFunc1.Location = new System.Drawing.Point(29, 168);
            this.newFunc1.MinimumSize = new System.Drawing.Size(798, 329);
            this.newFunc1.Name = "newFunc1";
            this.newFunc1.Size = new System.Drawing.Size(798, 329);
            this.newFunc1.TabIndex = 18;
            this.newFunc1.Visible = false;
            // 
            // calcularSalario1
            // 
            this.calcularSalario1.BackColor = System.Drawing.Color.White;
            this.calcularSalario1.Location = new System.Drawing.Point(29, 169);
            this.calcularSalario1.MinimumSize = new System.Drawing.Size(530, 148);
            this.calcularSalario1.Name = "calcularSalario1";
            this.calcularSalario1.Size = new System.Drawing.Size(530, 148);
            this.calcularSalario1.TabIndex = 21;
            this.calcularSalario1.Visible = false;
            // 
            // FuncionarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.calcularSalario1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.buscarFuncionario1);
            this.Controls.Add(this.newFunc1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBuscarConsulta);
            this.Controls.Add(this.btnNovaConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "FuncionarioMenu";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FuncionarioMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private MetroFramework.Controls.MetroTile btnBuscarConsulta;
        private MetroFramework.Controls.MetroTile btnNovaConsulta;
        private NewFunc newFunc1;
        private BuscarFuncionario buscarFuncionario1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private FORMS.FUNCIONARIO.CalcularSalario calcularSalario1;
    }
}