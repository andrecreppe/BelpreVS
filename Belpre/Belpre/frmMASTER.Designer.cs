namespace Belpre
{
    partial class frmMASTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMASTER));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblIntro = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnLimparCad = new System.Windows.Forms.Button();
            this.btnCadastrarCad = new System.Windows.Forms.Button();
            this.mskNascmCad = new System.Windows.Forms.MaskedTextBox();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.mskCellCad = new System.Windows.Forms.MaskedTextBox();
            this.radMascCad = new System.Windows.Forms.RadioButton();
            this.radFemCad = new System.Windows.Forms.RadioButton();
            this.mskCPFCad = new System.Windows.Forms.MaskedTextBox();
            this.txtSobrenCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblNascm = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSobren = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picEsteto = new System.Windows.Forms.PictureBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabAltPesq = new System.Windows.Forms.TabPage();
            this.btnEstado = new System.Windows.Forms.Button();
            this.mskCPFAlt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpaAlt = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.mskNascmAlt = new System.Windows.Forms.MaskedTextBox();
            this.txtSenhaAlt = new System.Windows.Forms.TextBox();
            this.mskCelAlt = new System.Windows.Forms.MaskedTextBox();
            this.radMascAlt = new System.Windows.Forms.RadioButton();
            this.radFemAlt = new System.Windows.Forms.RadioButton();
            this.txtSobrAlt = new System.Windows.Forms.TextBox();
            this.txtNomeAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picAlt = new System.Windows.Forms.PictureBox();
            this.tabAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEsteto)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tabAltPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabHome);
            this.tabAdmin.Controls.Add(this.tabCadastro);
            this.tabAdmin.Controls.Add(this.tabConsulta);
            this.tabAdmin.Controls.Add(this.tabAltPesq);
            this.tabAdmin.Location = new System.Drawing.Point(13, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(458, 450);
            this.tabAdmin.TabIndex = 20;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblIntro);
            this.tabHome.Controls.Add(this.picAdmin);
            this.tabHome.Controls.Add(this.btnReturn);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(450, 424);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = " Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(3, 3);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(441, 50);
            this.lblIntro.TabIndex = 6;
            this.lblIntro.Text = "Bem-vindo(a) à pagina Administrativa!";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(71, 61);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(301, 241);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 7;
            this.picAdmin.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(117, 346);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(210, 56);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "&Voltar ao Login";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btnLimparCad);
            this.tabCadastro.Controls.Add(this.btnCadastrarCad);
            this.tabCadastro.Controls.Add(this.mskNascmCad);
            this.tabCadastro.Controls.Add(this.txtSenhaCad);
            this.tabCadastro.Controls.Add(this.mskCellCad);
            this.tabCadastro.Controls.Add(this.radMascCad);
            this.tabCadastro.Controls.Add(this.radFemCad);
            this.tabCadastro.Controls.Add(this.mskCPFCad);
            this.tabCadastro.Controls.Add(this.txtSobrenCad);
            this.tabCadastro.Controls.Add(this.txtNomeCad);
            this.tabCadastro.Controls.Add(this.lblSenha);
            this.tabCadastro.Controls.Add(this.lblCell);
            this.tabCadastro.Controls.Add(this.lblNascm);
            this.tabCadastro.Controls.Add(this.lblSexo);
            this.tabCadastro.Controls.Add(this.lblCPF);
            this.tabCadastro.Controls.Add(this.lblSobren);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Controls.Add(this.picEsteto);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(450, 424);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro médicos";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnLimparCad
            // 
            this.btnLimparCad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCad.Location = new System.Drawing.Point(234, 360);
            this.btnLimparCad.Name = "btnLimparCad";
            this.btnLimparCad.Size = new System.Drawing.Size(91, 33);
            this.btnLimparCad.TabIndex = 10;
            this.btnLimparCad.Text = "&Limpar";
            this.btnLimparCad.UseVisualStyleBackColor = true;
            this.btnLimparCad.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarCad
            // 
            this.btnCadastrarCad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCad.Location = new System.Drawing.Point(123, 361);
            this.btnCadastrarCad.Name = "btnCadastrarCad";
            this.btnCadastrarCad.Size = new System.Drawing.Size(91, 32);
            this.btnCadastrarCad.TabIndex = 9;
            this.btnCadastrarCad.Text = "&Cadastrar";
            this.btnCadastrarCad.UseVisualStyleBackColor = true;
            this.btnCadastrarCad.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mskNascmCad
            // 
            this.mskNascmCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascmCad.Location = new System.Drawing.Point(274, 217);
            this.mskNascmCad.Mask = "00/00/0000";
            this.mskNascmCad.Name = "mskNascmCad";
            this.mskNascmCad.Size = new System.Drawing.Size(100, 31);
            this.mskNascmCad.TabIndex = 6;
            this.mskNascmCad.ValidatingType = typeof(System.DateTime);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCad.Location = new System.Drawing.Point(274, 296);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.PasswordChar = '*';
            this.txtSenhaCad.Size = new System.Drawing.Size(141, 31);
            this.txtSenhaCad.TabIndex = 8;
            // 
            // mskCellCad
            // 
            this.mskCellCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCellCad.Location = new System.Drawing.Point(274, 255);
            this.mskCellCad.Mask = "(99) 00000-0000";
            this.mskCellCad.Name = "mskCellCad";
            this.mskCellCad.Size = new System.Drawing.Size(141, 31);
            this.mskCellCad.TabIndex = 7;
            // 
            // radMascCad
            // 
            this.radMascCad.AutoSize = true;
            this.radMascCad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMascCad.Location = new System.Drawing.Point(281, 184);
            this.radMascCad.Name = "radMascCad";
            this.radMascCad.Size = new System.Drawing.Size(89, 22);
            this.radMascCad.TabIndex = 5;
            this.radMascCad.Text = "&Masculino";
            this.radMascCad.UseVisualStyleBackColor = true;
            // 
            // radFemCad
            // 
            this.radFemCad.AutoSize = true;
            this.radFemCad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemCad.Location = new System.Drawing.Point(281, 156);
            this.radFemCad.Name = "radFemCad";
            this.radFemCad.Size = new System.Drawing.Size(85, 22);
            this.radFemCad.TabIndex = 4;
            this.radFemCad.Text = "&Feminino";
            this.radFemCad.UseVisualStyleBackColor = true;
            // 
            // mskCPFCad
            // 
            this.mskCPFCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPFCad.Location = new System.Drawing.Point(274, 117);
            this.mskCPFCad.Mask = "000,000,000-00";
            this.mskCPFCad.Name = "mskCPFCad";
            this.mskCPFCad.Size = new System.Drawing.Size(141, 31);
            this.mskCPFCad.TabIndex = 3;
            this.mskCPFCad.ValidatingType = typeof(int);
            // 
            // txtSobrenCad
            // 
            this.txtSobrenCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenCad.Location = new System.Drawing.Point(274, 72);
            this.txtSobrenCad.Name = "txtSobrenCad";
            this.txtSobrenCad.Size = new System.Drawing.Size(141, 31);
            this.txtSobrenCad.TabIndex = 2;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCad.Location = new System.Drawing.Point(274, 25);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(141, 31);
            this.txtNomeCad.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(199, 297);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 23);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell.Location = new System.Drawing.Point(191, 258);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(71, 23);
            this.lblCell.TabIndex = 43;
            this.lblCell.Text = "Celular:";
            // 
            // lblNascm
            // 
            this.lblNascm.AutoSize = true;
            this.lblNascm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascm.Location = new System.Drawing.Point(90, 220);
            this.lblNascm.Name = "lblNascm";
            this.lblNascm.Size = new System.Drawing.Size(172, 23);
            this.lblNascm.TabIndex = 42;
            this.lblNascm.Text = "Data de nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(209, 172);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(53, 23);
            this.lblSexo.TabIndex = 41;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(218, 121);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 23);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSobren
            // 
            this.lblSobren.AutoSize = true;
            this.lblSobren.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobren.Location = new System.Drawing.Point(156, 75);
            this.lblSobren.Name = "lblSobren";
            this.lblSobren.Size = new System.Drawing.Size(106, 23);
            this.lblSobren.TabIndex = 39;
            this.lblSobren.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(199, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 23);
            this.lblNome.TabIndex = 38;
            this.lblNome.Text = "Nome:";
            // 
            // picEsteto
            // 
            this.picEsteto.Image = ((System.Drawing.Image)(resources.GetObject("picEsteto.Image")));
            this.picEsteto.Location = new System.Drawing.Point(6, 25);
            this.picEsteto.Name = "picEsteto";
            this.picEsteto.Size = new System.Drawing.Size(148, 138);
            this.picEsteto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEsteto.TabIndex = 45;
            this.picEsteto.TabStop = false;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.picReload);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.dgvConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Size = new System.Drawing.Size(450, 424);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta Geral";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(392, 394);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(55, 27);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 7;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para mais informações, duplo clique no ID desejado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 3);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(444, 388);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // tabAltPesq
            // 
            this.tabAltPesq.Controls.Add(this.btnEstado);
            this.tabAltPesq.Controls.Add(this.mskCPFAlt);
            this.tabAltPesq.Controls.Add(this.label6);
            this.tabAltPesq.Controls.Add(this.label9);
            this.tabAltPesq.Controls.Add(this.btnLimpaAlt);
            this.tabAltPesq.Controls.Add(this.btnAlterar);
            this.tabAltPesq.Controls.Add(this.mskNascmAlt);
            this.tabAltPesq.Controls.Add(this.txtSenhaAlt);
            this.tabAltPesq.Controls.Add(this.mskCelAlt);
            this.tabAltPesq.Controls.Add(this.radMascAlt);
            this.tabAltPesq.Controls.Add(this.radFemAlt);
            this.tabAltPesq.Controls.Add(this.txtSobrAlt);
            this.tabAltPesq.Controls.Add(this.txtNomeAlt);
            this.tabAltPesq.Controls.Add(this.label2);
            this.tabAltPesq.Controls.Add(this.label3);
            this.tabAltPesq.Controls.Add(this.label4);
            this.tabAltPesq.Controls.Add(this.label5);
            this.tabAltPesq.Controls.Add(this.label7);
            this.tabAltPesq.Controls.Add(this.label8);
            this.tabAltPesq.Controls.Add(this.picAlt);
            this.tabAltPesq.Location = new System.Drawing.Point(4, 22);
            this.tabAltPesq.Name = "tabAltPesq";
            this.tabAltPesq.Size = new System.Drawing.Size(450, 424);
            this.tabAltPesq.TabIndex = 3;
            this.tabAltPesq.Text = "Alteração/Pesquisa - Médicos";
            this.tabAltPesq.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.Red;
            this.btnEstado.Location = new System.Drawing.Point(339, 362);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(91, 43);
            this.btnEstado.TabIndex = 69;
            this.btnEstado.Text = "&Excluir Médico";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // mskCPFAlt
            // 
            this.mskCPFAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPFAlt.Location = new System.Drawing.Point(289, 29);
            this.mskCPFAlt.Mask = "000,000,000-00";
            this.mskCPFAlt.Name = "mskCPFAlt";
            this.mskCPFAlt.Size = new System.Drawing.Size(141, 31);
            this.mskCPFAlt.TabIndex = 67;
            this.mskCPFAlt.ValidatingType = typeof(int);
            this.mskCPFAlt.Validating += new System.ComponentModel.CancelEventHandler(this.mskCPFAlt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 44);
            this.label9.TabIndex = 64;
            this.label9.Text = "Digite um CPF e aperte TAB para conferir os dados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLimpaAlt
            // 
            this.btnLimpaAlt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaAlt.Location = new System.Drawing.Point(15, 367);
            this.btnLimpaAlt.Name = "btnLimpaAlt";
            this.btnLimpaAlt.Size = new System.Drawing.Size(91, 33);
            this.btnLimpaAlt.TabIndex = 55;
            this.btnLimpaAlt.Text = "&Limpar";
            this.btnLimpaAlt.UseVisualStyleBackColor = true;
            this.btnLimpaAlt.Click += new System.EventHandler(this.btnLimpaAlt_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(129, 368);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 32);
            this.btnAlterar.TabIndex = 54;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // mskNascmAlt
            // 
            this.mskNascmAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascmAlt.Location = new System.Drawing.Point(289, 231);
            this.mskNascmAlt.Mask = "00/00/0000";
            this.mskNascmAlt.Name = "mskNascmAlt";
            this.mskNascmAlt.Size = new System.Drawing.Size(100, 31);
            this.mskNascmAlt.TabIndex = 51;
            this.mskNascmAlt.ValidatingType = typeof(System.DateTime);
            // 
            // txtSenhaAlt
            // 
            this.txtSenhaAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAlt.Location = new System.Drawing.Point(289, 310);
            this.txtSenhaAlt.Name = "txtSenhaAlt";
            this.txtSenhaAlt.PasswordChar = '*';
            this.txtSenhaAlt.Size = new System.Drawing.Size(141, 31);
            this.txtSenhaAlt.TabIndex = 53;
            // 
            // mskCelAlt
            // 
            this.mskCelAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelAlt.Location = new System.Drawing.Point(289, 269);
            this.mskCelAlt.Mask = "(99) 00000-0000";
            this.mskCelAlt.Name = "mskCelAlt";
            this.mskCelAlt.Size = new System.Drawing.Size(141, 31);
            this.mskCelAlt.TabIndex = 52;
            // 
            // radMascAlt
            // 
            this.radMascAlt.AutoSize = true;
            this.radMascAlt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMascAlt.Location = new System.Drawing.Point(296, 198);
            this.radMascAlt.Name = "radMascAlt";
            this.radMascAlt.Size = new System.Drawing.Size(89, 22);
            this.radMascAlt.TabIndex = 50;
            this.radMascAlt.Text = "&Masculino";
            this.radMascAlt.UseVisualStyleBackColor = true;
            // 
            // radFemAlt
            // 
            this.radFemAlt.AutoSize = true;
            this.radFemAlt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemAlt.Location = new System.Drawing.Point(296, 170);
            this.radFemAlt.Name = "radFemAlt";
            this.radFemAlt.Size = new System.Drawing.Size(85, 22);
            this.radFemAlt.TabIndex = 49;
            this.radFemAlt.Text = "&Feminino";
            this.radFemAlt.UseVisualStyleBackColor = true;
            // 
            // txtSobrAlt
            // 
            this.txtSobrAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrAlt.Location = new System.Drawing.Point(289, 128);
            this.txtSobrAlt.Name = "txtSobrAlt";
            this.txtSobrAlt.Size = new System.Drawing.Size(141, 31);
            this.txtSobrAlt.TabIndex = 47;
            // 
            // txtNomeAlt
            // 
            this.txtNomeAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAlt.Location = new System.Drawing.Point(289, 81);
            this.txtNomeAlt.Name = "txtNomeAlt";
            this.txtNomeAlt.Size = new System.Drawing.Size(141, 31);
            this.txtNomeAlt.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Sobrenome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Nome:";
            // 
            // picAlt
            // 
            this.picAlt.Image = ((System.Drawing.Image)(resources.GetObject("picAlt.Image")));
            this.picAlt.Location = new System.Drawing.Point(15, 24);
            this.picAlt.Name = "picAlt";
            this.picAlt.Size = new System.Drawing.Size(148, 138);
            this.picAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlt.TabIndex = 63;
            this.picAlt.TabStop = false;
            // 
            // frmMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 474);
            this.Controls.Add(this.tabAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMASTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabAdmin.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEsteto)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tabAltPesq.ResumeLayout(false);
            this.tabAltPesq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnLimparCad;
        private System.Windows.Forms.Button btnCadastrarCad;
        private System.Windows.Forms.MaskedTextBox mskNascmCad;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.MaskedTextBox mskCellCad;
        private System.Windows.Forms.RadioButton radMascCad;
        private System.Windows.Forms.RadioButton radFemCad;
        private System.Windows.Forms.MaskedTextBox mskCPFCad;
        private System.Windows.Forms.TextBox txtSobrenCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblNascm;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobren;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.PictureBox picEsteto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.TabPage tabAltPesq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpaAlt;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox mskNascmAlt;
        private System.Windows.Forms.TextBox txtSenhaAlt;
        private System.Windows.Forms.MaskedTextBox mskCelAlt;
        private System.Windows.Forms.RadioButton radMascAlt;
        private System.Windows.Forms.RadioButton radFemAlt;
        private System.Windows.Forms.TextBox txtSobrAlt;
        private System.Windows.Forms.TextBox txtNomeAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picAlt;
        private System.Windows.Forms.MaskedTextBox mskCPFAlt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEstado;
    }
}