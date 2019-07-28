namespace PetShop.FORMS.CONSULTA
{
    partial class NewConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConsulta));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtServico = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtFuncionario = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSituacao = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarFunc = new MetroFramework.Controls.MetroTile();
            this.btnBuscarPet = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.buscarFuncionario1 = new PetShop.BuscarFuncionario();
            this.newPet1 = new PetShop.FORMS.PETS.NewPet();
            this.buscarPet1 = new PetShop.FORMS.PETS.BuscarPet();
            this.btnAddServico = new MetroFramework.Controls.MetroTile();
            this.newServico1 = new PetShop.FORMS.CONSULTA.NewServico();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Servico:";
            // 
            // txtServico
            // 
            // 
            // 
            // 
            this.txtServico.CustomButton.Image = null;
            this.txtServico.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.txtServico.CustomButton.Name = "";
            this.txtServico.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServico.CustomButton.TabIndex = 1;
            this.txtServico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServico.CustomButton.UseSelectable = true;
            this.txtServico.CustomButton.Visible = false;
            this.txtServico.Lines = new string[0];
            this.txtServico.Location = new System.Drawing.Point(74, 13);
            this.txtServico.MaxLength = 80;
            this.txtServico.Name = "txtServico";
            this.txtServico.PasswordChar = '\0';
            this.txtServico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServico.SelectedText = "";
            this.txtServico.SelectionLength = 0;
            this.txtServico.SelectionStart = 0;
            this.txtServico.ShortcutsEnabled = true;
            this.txtServico.Size = new System.Drawing.Size(31, 23);
            this.txtServico.TabIndex = 56;
            this.txtServico.UseSelectable = true;
            this.txtServico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtServico_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = "Pet:";
            // 
            // txtPet
            // 
            // 
            // 
            // 
            this.txtPet.CustomButton.Image = null;
            this.txtPet.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.txtPet.CustomButton.Name = "";
            this.txtPet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPet.CustomButton.TabIndex = 1;
            this.txtPet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPet.CustomButton.UseSelectable = true;
            this.txtPet.CustomButton.Visible = false;
            this.txtPet.Lines = new string[0];
            this.txtPet.Location = new System.Drawing.Point(49, 50);
            this.txtPet.MaxLength = 80;
            this.txtPet.Name = "txtPet";
            this.txtPet.PasswordChar = '\0';
            this.txtPet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPet.SelectedText = "";
            this.txtPet.SelectionLength = 0;
            this.txtPet.SelectionStart = 0;
            this.txtPet.ShortcutsEnabled = true;
            this.txtPet.Size = new System.Drawing.Size(31, 23);
            this.txtPet.TabIndex = 75;
            this.txtPet.UseSelectable = true;
            this.txtPet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPet_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 87);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Funcionário:";
            // 
            // txtFuncionario
            // 
            // 
            // 
            // 
            this.txtFuncionario.CustomButton.Image = null;
            this.txtFuncionario.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.txtFuncionario.CustomButton.Name = "";
            this.txtFuncionario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFuncionario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFuncionario.CustomButton.TabIndex = 1;
            this.txtFuncionario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFuncionario.CustomButton.UseSelectable = true;
            this.txtFuncionario.CustomButton.Visible = false;
            this.txtFuncionario.Lines = new string[0];
            this.txtFuncionario.Location = new System.Drawing.Point(99, 87);
            this.txtFuncionario.MaxLength = 32767;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.PasswordChar = '\0';
            this.txtFuncionario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFuncionario.SelectedText = "";
            this.txtFuncionario.SelectionLength = 0;
            this.txtFuncionario.SelectionStart = 0;
            this.txtFuncionario.ShortcutsEnabled = true;
            this.txtFuncionario.Size = new System.Drawing.Size(31, 23);
            this.txtFuncionario.TabIndex = 77;
            this.txtFuncionario.UseSelectable = true;
            this.txtFuncionario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFuncionario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFuncionario_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Location = new System.Drawing.Point(112, 196);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 38);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Criar";
            this.btnAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.TileImage")));
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseTileImage = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 80;
            this.metroLabel3.Text = "Data:";
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.Lines = new string[0];
            this.txtData.Location = new System.Drawing.Point(58, 124);
            this.txtData.MaxLength = 80;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(120, 23);
            this.txtData.TabIndex = 79;
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.Enter += new System.EventHandler(this.TxtData_Enter);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtData_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Situação:";
            // 
            // txtSituacao
            // 
            // 
            // 
            // 
            this.txtSituacao.CustomButton.Image = null;
            this.txtSituacao.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtSituacao.CustomButton.Name = "";
            this.txtSituacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSituacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSituacao.CustomButton.TabIndex = 1;
            this.txtSituacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSituacao.CustomButton.UseSelectable = true;
            this.txtSituacao.CustomButton.Visible = false;
            this.txtSituacao.Lines = new string[0];
            this.txtSituacao.Location = new System.Drawing.Point(80, 161);
            this.txtSituacao.MaxLength = 80;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.PasswordChar = '\0';
            this.txtSituacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSituacao.SelectedText = "";
            this.txtSituacao.SelectionLength = 0;
            this.txtSituacao.SelectionStart = 0;
            this.txtSituacao.ShortcutsEnabled = true;
            this.txtSituacao.Size = new System.Drawing.Size(98, 23);
            this.txtSituacao.TabIndex = 81;
            this.txtSituacao.UseSelectable = true;
            this.txtSituacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSituacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscarFunc
            // 
            this.btnBuscarFunc.ActiveControl = null;
            this.btnBuscarFunc.Location = new System.Drawing.Point(147, 87);
            this.btnBuscarFunc.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarFunc.Name = "btnBuscarFunc";
            this.btnBuscarFunc.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarFunc.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnBuscarFunc.TabIndex = 83;
            this.btnBuscarFunc.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarFunc.TileImage")));
            this.btnBuscarFunc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarFunc.UseSelectable = true;
            this.btnBuscarFunc.UseTileImage = true;
            this.btnBuscarFunc.Click += new System.EventHandler(this.BtnBuscarFunc_Click);
            // 
            // btnBuscarPet
            // 
            this.btnBuscarPet.ActiveControl = null;
            this.btnBuscarPet.Location = new System.Drawing.Point(99, 50);
            this.btnBuscarPet.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarPet.Name = "btnBuscarPet";
            this.btnBuscarPet.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarPet.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnBuscarPet.TabIndex = 84;
            this.btnBuscarPet.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPet.TileImage")));
            this.btnBuscarPet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarPet.UseSelectable = true;
            this.btnBuscarPet.UseTileImage = true;
            this.btnBuscarPet.Click += new System.EventHandler(this.BtnBuscarPet_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(147, 50);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(31, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 85;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // buscarFuncionario1
            // 
            this.buscarFuncionario1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarFuncionario1.BackColor = System.Drawing.Color.White;
            this.buscarFuncionario1.Location = new System.Drawing.Point(187, 4);
            this.buscarFuncionario1.Name = "buscarFuncionario1";
            this.buscarFuncionario1.Size = new System.Drawing.Size(609, 310);
            this.buscarFuncionario1.TabIndex = 88;
            this.buscarFuncionario1.Visible = false;
            // 
            // newPet1
            // 
            this.newPet1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPet1.BackColor = System.Drawing.Color.White;
            this.newPet1.Location = new System.Drawing.Point(187, 3);
            this.newPet1.Name = "newPet1";
            this.newPet1.Size = new System.Drawing.Size(609, 311);
            this.newPet1.TabIndex = 87;
            this.newPet1.Visible = false;
            // 
            // buscarPet1
            // 
            this.buscarPet1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarPet1.BackColor = System.Drawing.Color.White;
            this.buscarPet1.Location = new System.Drawing.Point(187, 3);
            this.buscarPet1.Name = "buscarPet1";
            this.buscarPet1.Size = new System.Drawing.Size(609, 311);
            this.buscarPet1.TabIndex = 86;
            this.buscarPet1.Visible = false;
            // 
            // btnAddServico
            // 
            this.btnAddServico.ActiveControl = null;
            this.btnAddServico.Location = new System.Drawing.Point(114, 13);
            this.btnAddServico.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(31, 23);
            this.btnAddServico.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnAddServico.TabIndex = 89;
            this.btnAddServico.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddServico.TileImage")));
            this.btnAddServico.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddServico.UseSelectable = true;
            this.btnAddServico.UseTileImage = true;
            this.btnAddServico.Click += new System.EventHandler(this.BtnAddServico_Click);
            // 
            // newServico1
            // 
            this.newServico1.BackColor = System.Drawing.Color.White;
            this.newServico1.Location = new System.Drawing.Point(187, 4);
            this.newServico1.Name = "newServico1";
            this.newServico1.Size = new System.Drawing.Size(245, 151);
            this.newServico1.TabIndex = 90;
            this.newServico1.Visible = false;
            // 
            // NewConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newServico1);
            this.Controls.Add(this.btnAddServico);
            this.Controls.Add(this.buscarFuncionario1);
            this.Controls.Add(this.newPet1);
            this.Controls.Add(this.buscarPet1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnBuscarPet);
            this.Controls.Add(this.btnBuscarFunc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtServico);
            this.Name = "NewConsulta";
            this.Size = new System.Drawing.Size(799, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtServico;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPet;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtFuncionario;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSituacao;
        private MetroFramework.Controls.MetroTile btnBuscarFunc;
        private MetroFramework.Controls.MetroTile btnBuscarPet;
        private MetroFramework.Controls.MetroTile metroTile1;
        private PETS.BuscarPet buscarPet1;
        private PETS.NewPet newPet1;
        private BuscarFuncionario buscarFuncionario1;
        private MetroFramework.Controls.MetroTile btnAddServico;
        private NewServico newServico1;
    }
}
