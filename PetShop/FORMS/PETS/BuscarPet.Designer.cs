namespace PetShop.FORMS.PETS
{
    partial class BuscarPet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPet));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDono = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnEditar = new MetroFramework.Controls.MetroTile();
            this.dtGridPet = new System.Windows.Forms.DataGridView();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "Nome:";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(67, 14);
            this.txtId.MaxLength = 80;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(155, 23);
            this.txtId.TabIndex = 58;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Dono:";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(67, 52);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(155, 23);
            this.txtNome.TabIndex = 60;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(24, 19);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "ID:";
            // 
            // txtDono
            // 
            // 
            // 
            // 
            this.txtDono.CustomButton.Image = null;
            this.txtDono.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtDono.CustomButton.Name = "";
            this.txtDono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDono.CustomButton.TabIndex = 1;
            this.txtDono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDono.CustomButton.UseSelectable = true;
            this.txtDono.CustomButton.Visible = false;
            this.txtDono.Lines = new string[0];
            this.txtDono.Location = new System.Drawing.Point(67, 90);
            this.txtDono.MaxLength = 80;
            this.txtDono.Name = "txtDono";
            this.txtDono.PasswordChar = '\0';
            this.txtDono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDono.SelectedText = "";
            this.txtDono.SelectionLength = 0;
            this.txtDono.SelectionStart = 0;
            this.txtDono.ShortcutsEnabled = true;
            this.txtDono.Size = new System.Drawing.Size(155, 23);
            this.txtDono.TabIndex = 62;
            this.txtDono.UseSelectable = true;
            this.txtDono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(144, 122);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 38);
            this.btnBuscar.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.TileImage")));
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveControl = null;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(144, 285);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 38);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnEditar.TabIndex = 65;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.TileImage")));
            this.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.UseTileImage = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dtGridPet
            // 
            this.dtGridPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPet.Location = new System.Drawing.Point(228, 3);
            this.dtGridPet.Name = "dtGridPet";
            this.dtGridPet.Size = new System.Drawing.Size(567, 323);
            this.dtGridPet.TabIndex = 66;
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(762, 293);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnClear.TabIndex = 67;
            this.btnClear.TabStop = false;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BuscarPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtGridPet);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtId);
            this.Name = "BuscarPet";
            this.Size = new System.Drawing.Size(798, 329);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDono;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroTile btnEditar;
        private System.Windows.Forms.DataGridView dtGridPet;
        private MetroFramework.Controls.MetroTile btnClear;
    }
}
