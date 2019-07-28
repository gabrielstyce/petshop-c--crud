namespace PetShop.FORMS.FUNCIONARIO
{
    partial class CalcularSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularSalario));
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtFunId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSalario = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 36);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "ID:";
            // 
            // txtFunId
            // 
            // 
            // 
            // 
            this.txtFunId.CustomButton.Image = null;
            this.txtFunId.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.txtFunId.CustomButton.Name = "";
            this.txtFunId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFunId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFunId.CustomButton.TabIndex = 1;
            this.txtFunId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFunId.CustomButton.UseSelectable = true;
            this.txtFunId.CustomButton.Visible = false;
            this.txtFunId.Lines = new string[0];
            this.txtFunId.Location = new System.Drawing.Point(96, 36);
            this.txtFunId.MaxLength = 7;
            this.txtFunId.Name = "txtFunId";
            this.txtFunId.PasswordChar = '\0';
            this.txtFunId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFunId.SelectedText = "";
            this.txtFunId.SelectionLength = 0;
            this.txtFunId.SelectionStart = 0;
            this.txtFunId.ShortcutsEnabled = true;
            this.txtFunId.Size = new System.Drawing.Size(53, 23);
            this.txtFunId.TabIndex = 54;
            this.txtFunId.UseSelectable = true;
            this.txtFunId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFunId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFunId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFunId_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Nome:";
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
            this.txtNome.Location = new System.Drawing.Point(96, 82);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(155, 23);
            this.txtNome.TabIndex = 55;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(164, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Calcular";
            this.btnBuscar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.TileImage")));
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(266, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 62;
            this.metroLabel3.Text = "Salário:";
            // 
            // txtSalario
            // 
            // 
            // 
            // 
            this.txtSalario.CustomButton.Image = null;
            this.txtSalario.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtSalario.CustomButton.Name = "";
            this.txtSalario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalario.CustomButton.TabIndex = 1;
            this.txtSalario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalario.CustomButton.UseSelectable = true;
            this.txtSalario.CustomButton.Visible = false;
            this.txtSalario.Lines = new string[0];
            this.txtSalario.Location = new System.Drawing.Point(321, 82);
            this.txtSalario.MaxLength = 80;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PasswordChar = '\0';
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalario.SelectedText = "";
            this.txtSalario.SelectionLength = 0;
            this.txtSalario.SelectionStart = 0;
            this.txtSalario.ShortcutsEnabled = true;
            this.txtSalario.Size = new System.Drawing.Size(155, 23);
            this.txtSalario.TabIndex = 61;
            this.txtSalario.UseSelectable = true;
            this.txtSalario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CalcularSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtFunId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNome);
            this.MinimumSize = new System.Drawing.Size(530, 148);
            this.Name = "CalcularSalario";
            this.Size = new System.Drawing.Size(530, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtFunId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSalario;
    }
}
