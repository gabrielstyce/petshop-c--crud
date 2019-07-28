namespace PetShop
{
    partial class BuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarFuncionario));
            this.dtGridFunc = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCPF = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtFunId = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnEditar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridFunc
            // 
            this.dtGridFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFunc.Location = new System.Drawing.Point(240, 3);
            this.dtGridFunc.Name = "dtGridFunc";
            this.dtGridFunc.Size = new System.Drawing.Size(555, 323);
            this.dtGridFunc.TabIndex = 0;
            this.dtGridFunc.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "CPF:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Nome:";
            // 
            // txtCPF
            // 
            // 
            // 
            // 
            this.txtCPF.CustomButton.Image = null;
            this.txtCPF.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtCPF.CustomButton.Name = "";
            this.txtCPF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPF.CustomButton.TabIndex = 1;
            this.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPF.CustomButton.UseSelectable = true;
            this.txtCPF.CustomButton.Visible = false;
            this.txtCPF.Lines = new string[0];
            this.txtCPF.Location = new System.Drawing.Point(80, 94);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(155, 23);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.UseSelectable = true;
            this.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCPF_KeyPress);
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
            this.txtNome.Location = new System.Drawing.Point(80, 53);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(155, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 14);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "ID:";
            // 
            // txtFunId
            // 
            // 
            // 
            // 
            this.txtFunId.CustomButton.Image = null;
            this.txtFunId.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtFunId.CustomButton.Name = "";
            this.txtFunId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFunId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFunId.CustomButton.TabIndex = 1;
            this.txtFunId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFunId.CustomButton.UseSelectable = true;
            this.txtFunId.CustomButton.Visible = false;
            this.txtFunId.Lines = new string[0];
            this.txtFunId.Location = new System.Drawing.Point(80, 14);
            this.txtFunId.MaxLength = 7;
            this.txtFunId.Name = "txtFunId";
            this.txtFunId.PasswordChar = '\0';
            this.txtFunId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFunId.SelectedText = "";
            this.txtFunId.SelectionLength = 0;
            this.txtFunId.SelectionStart = 0;
            this.txtFunId.ShortcutsEnabled = true;
            this.txtFunId.Size = new System.Drawing.Size(155, 23);
            this.txtFunId.TabIndex = 1;
            this.txtFunId.UseSelectable = true;
            this.txtFunId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFunId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFunId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFunId_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(157, 126);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 38);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.TileImage")));
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(762, 293);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 55;
            this.btnClear.TabStop = false;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveControl = null;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(157, 283);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 40);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.TileImage")));
            this.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.UseTileImage = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtFunId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtGridFunc);
            this.Name = "BuscarFuncionario";
            this.Size = new System.Drawing.Size(798, 329);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridFunc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCPF;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtFunId;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnEditar;
    }
}
