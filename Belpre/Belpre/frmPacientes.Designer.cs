namespace Belpre
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.tabPaciente = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.picPaciente = new System.Windows.Forms.PictureBox();
            this.tabMeusDados = new System.Windows.Forms.TabPage();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeTitle = new System.Windows.Forms.Label();
            this.tabMinhasConsultas = new System.Windows.Forms.TabPage();
            this.btnErro = new System.Windows.Forms.Button();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblSobreTitle = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCPFTitle = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblSexoTitle = new System.Windows.Forms.Label();
            this.lblNascm = new System.Windows.Forms.Label();
            this.lblNascmTitle = new System.Windows.Forms.Label();
            this.lblTell = new System.Windows.Forms.Label();
            this.lblTelTitle = new System.Windows.Forms.Label();
            this.grpConsultaOK = new System.Windows.Forms.GroupBox();
            this.lblHoje = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.lblVocePossui = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblQtdCons = new System.Windows.Forms.Label();
            this.lblConsTitle = new System.Windows.Forms.Label();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.lblQtdRet = new System.Windows.Forms.Label();
            this.grpRetornoOK = new System.Windows.Forms.GroupBox();
            this.lblDataCons = new System.Windows.Forms.Label();
            this.lblDataTitulo = new System.Windows.Forms.Label();
            this.lblMed1 = new System.Windows.Forms.Label();
            this.lblMed1Title = new System.Windows.Forms.Label();
            this.lblMed2 = new System.Windows.Forms.Label();
            this.lblMed2Title = new System.Windows.Forms.Label();
            this.lblDataRet = new System.Windows.Forms.Label();
            this.lblRetornoTitle = new System.Windows.Forms.Label();
            this.grpRetornoNO = new System.Windows.Forms.GroupBox();
            this.lblNope = new System.Windows.Forms.Label();
            this.grpConsultaNO = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPaciente.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).BeginInit();
            this.tabMeusDados.SuspendLayout();
            this.tabMinhasConsultas.SuspendLayout();
            this.grpConsultaOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpRetornoOK.SuspendLayout();
            this.grpRetornoNO.SuspendLayout();
            this.grpConsultaNO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.tabHome);
            this.tabPaciente.Controls.Add(this.tabMeusDados);
            this.tabPaciente.Controls.Add(this.tabMinhasConsultas);
            this.tabPaciente.Location = new System.Drawing.Point(13, 12);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.SelectedIndex = 0;
            this.tabPaciente.Size = new System.Drawing.Size(715, 452);
            this.tabPaciente.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblHoje);
            this.tabHome.Controls.Add(this.lblConsultas);
            this.tabHome.Controls.Add(this.lblVocePossui);
            this.tabHome.Controls.Add(this.lblData);
            this.tabHome.Controls.Add(this.btnLogout);
            this.tabHome.Controls.Add(this.lblBemVindo);
            this.tabHome.Controls.Add(this.picPaciente);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(707, 426);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(310, 364);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(391, 55);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(377, 30);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(249, 33);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem vindo ciclanooo";
            // 
            // picPaciente
            // 
            this.picPaciente.Image = ((System.Drawing.Image)(resources.GetObject("picPaciente.Image")));
            this.picPaciente.Location = new System.Drawing.Point(6, 6);
            this.picPaciente.Name = "picPaciente";
            this.picPaciente.Size = new System.Drawing.Size(297, 416);
            this.picPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaciente.TabIndex = 0;
            this.picPaciente.TabStop = false;
            // 
            // tabMeusDados
            // 
            this.tabMeusDados.Controls.Add(this.pictureBox2);
            this.tabMeusDados.Controls.Add(this.pictureBox1);
            this.tabMeusDados.Controls.Add(this.lblTell);
            this.tabMeusDados.Controls.Add(this.lblTelTitle);
            this.tabMeusDados.Controls.Add(this.lblNascm);
            this.tabMeusDados.Controls.Add(this.lblNascmTitle);
            this.tabMeusDados.Controls.Add(this.lblSexo);
            this.tabMeusDados.Controls.Add(this.lblSexoTitle);
            this.tabMeusDados.Controls.Add(this.lblCPF);
            this.tabMeusDados.Controls.Add(this.lblCPFTitle);
            this.tabMeusDados.Controls.Add(this.lblSobre);
            this.tabMeusDados.Controls.Add(this.lblSobreTitle);
            this.tabMeusDados.Controls.Add(this.btnErro);
            this.tabMeusDados.Controls.Add(this.lblNome);
            this.tabMeusDados.Controls.Add(this.lblNomeTitle);
            this.tabMeusDados.Location = new System.Drawing.Point(4, 22);
            this.tabMeusDados.Name = "tabMeusDados";
            this.tabMeusDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeusDados.Size = new System.Drawing.Size(707, 426);
            this.tabMeusDados.TabIndex = 1;
            this.tabMeusDados.Text = "Meus dados";
            this.tabMeusDados.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(192, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(77, 29);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "fulano";
            // 
            // lblNomeTitle
            // 
            this.lblNomeTitle.AutoSize = true;
            this.lblNomeTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitle.Location = new System.Drawing.Point(95, 30);
            this.lblNomeTitle.Name = "lblNomeTitle";
            this.lblNomeTitle.Size = new System.Drawing.Size(91, 33);
            this.lblNomeTitle.TabIndex = 2;
            this.lblNomeTitle.Text = "Nome:";
            // 
            // tabMinhasConsultas
            // 
            this.tabMinhasConsultas.Controls.Add(this.grpConsultaNO);
            this.tabMinhasConsultas.Controls.Add(this.grpRetornoNO);
            this.tabMinhasConsultas.Controls.Add(this.grpRetornoOK);
            this.tabMinhasConsultas.Controls.Add(this.lblQtdCons);
            this.tabMinhasConsultas.Controls.Add(this.lblConsTitle);
            this.tabMinhasConsultas.Controls.Add(this.lblRetorno);
            this.tabMinhasConsultas.Controls.Add(this.lblQtdRet);
            this.tabMinhasConsultas.Controls.Add(this.grpConsultaOK);
            this.tabMinhasConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabMinhasConsultas.Name = "tabMinhasConsultas";
            this.tabMinhasConsultas.Size = new System.Drawing.Size(707, 426);
            this.tabMinhasConsultas.TabIndex = 2;
            this.tabMinhasConsultas.Text = "Minhas Consultas";
            this.tabMinhasConsultas.UseVisualStyleBackColor = true;
            // 
            // btnErro
            // 
            this.btnErro.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.Location = new System.Drawing.Point(6, 379);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(695, 41);
            this.btnErro.TabIndex = 5;
            this.btnErro.Text = "&Há algum erro?";
            this.btnErro.UseVisualStyleBackColor = true;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(192, 83);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(87, 29);
            this.lblSobre.TabIndex = 7;
            this.lblSobre.Text = "da silva";
            // 
            // lblSobreTitle
            // 
            this.lblSobreTitle.AutoSize = true;
            this.lblSobreTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreTitle.Location = new System.Drawing.Point(33, 80);
            this.lblSobreTitle.Name = "lblSobreTitle";
            this.lblSobreTitle.Size = new System.Drawing.Size(153, 33);
            this.lblSobreTitle.TabIndex = 6;
            this.lblSobreTitle.Text = "Sobrenome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(192, 135);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(164, 29);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "111.111.111-11";
            // 
            // lblCPFTitle
            // 
            this.lblCPFTitle.AutoSize = true;
            this.lblCPFTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFTitle.Location = new System.Drawing.Point(124, 132);
            this.lblCPFTitle.Name = "lblCPFTitle";
            this.lblCPFTitle.Size = new System.Drawing.Size(62, 33);
            this.lblCPFTitle.TabIndex = 8;
            this.lblCPFTitle.Text = "CPF:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(192, 189);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(63, 29);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "masc";
            // 
            // lblSexoTitle
            // 
            this.lblSexoTitle.AutoSize = true;
            this.lblSexoTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoTitle.Location = new System.Drawing.Point(111, 186);
            this.lblSexoTitle.Name = "lblSexoTitle";
            this.lblSexoTitle.Size = new System.Drawing.Size(75, 33);
            this.lblSexoTitle.TabIndex = 10;
            this.lblSexoTitle.Text = "Sexo:";
            // 
            // lblNascm
            // 
            this.lblNascm.AutoSize = true;
            this.lblNascm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascm.Location = new System.Drawing.Point(192, 240);
            this.lblNascm.Name = "lblNascm";
            this.lblNascm.Size = new System.Drawing.Size(127, 29);
            this.lblNascm.TabIndex = 13;
            this.lblNascm.Text = "12/12/2012";
            // 
            // lblNascmTitle
            // 
            this.lblNascmTitle.AutoSize = true;
            this.lblNascmTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascmTitle.Location = new System.Drawing.Point(30, 237);
            this.lblNascmTitle.Name = "lblNascmTitle";
            this.lblNascmTitle.Size = new System.Drawing.Size(156, 33);
            this.lblNascmTitle.TabIndex = 12;
            this.lblNascmTitle.Text = "Nascimento:";
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTell.Location = new System.Drawing.Point(192, 293);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(171, 29);
            this.lblTell.TabIndex = 15;
            this.lblTell.Text = "(14) 99999-9999";
            // 
            // lblTelTitle
            // 
            this.lblTelTitle.AutoSize = true;
            this.lblTelTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelTitle.Location = new System.Drawing.Point(85, 289);
            this.lblTelTitle.Name = "lblTelTitle";
            this.lblTelTitle.Size = new System.Drawing.Size(101, 33);
            this.lblTelTitle.TabIndex = 14;
            this.lblTelTitle.Text = "Celular:";
            // 
            // grpConsultaOK
            // 
            this.grpConsultaOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpConsultaOK.Controls.Add(this.lblMed1);
            this.grpConsultaOK.Controls.Add(this.lblMed1Title);
            this.grpConsultaOK.Controls.Add(this.lblDataCons);
            this.grpConsultaOK.Controls.Add(this.lblDataTitulo);
            this.grpConsultaOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultaOK.Location = new System.Drawing.Point(421, 20);
            this.grpConsultaOK.Name = "grpConsultaOK";
            this.grpConsultaOK.Size = new System.Drawing.Size(253, 178);
            this.grpConsultaOK.TabIndex = 21;
            this.grpConsultaOK.TabStop = false;
            this.grpConsultaOK.Text = "Próxima Consulta";
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoje.Location = new System.Drawing.Point(519, 140);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(121, 29);
            this.lblHoje.TabIndex = 10;
            this.lblHoje.Text = "xx/xx/xxxx";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(519, 219);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(134, 29);
            this.lblConsultas.TabIndex = 9;
            this.lblConsultas.Text = "X consultas!";
            // 
            // lblVocePossui
            // 
            this.lblVocePossui.AutoSize = true;
            this.lblVocePossui.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocePossui.Location = new System.Drawing.Point(335, 219);
            this.lblVocePossui.Name = "lblVocePossui";
            this.lblVocePossui.Size = new System.Drawing.Size(178, 29);
            this.lblVocePossui.TabIndex = 8;
            this.lblVocePossui.Text = "Hoje você possui";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(375, 140);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(138, 29);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Dia de Hoje: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(314, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblQtdCons
            // 
            this.lblQtdCons.AutoSize = true;
            this.lblQtdCons.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdCons.Location = new System.Drawing.Point(110, 113);
            this.lblQtdCons.Name = "lblQtdCons";
            this.lblQtdCons.Size = new System.Drawing.Size(77, 29);
            this.lblQtdCons.TabIndex = 25;
            this.lblQtdCons.Text = "fulano";
            // 
            // lblConsTitle
            // 
            this.lblConsTitle.AutoSize = true;
            this.lblConsTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsTitle.Location = new System.Drawing.Point(51, 69);
            this.lblConsTitle.Name = "lblConsTitle";
            this.lblConsTitle.Size = new System.Drawing.Size(238, 33);
            this.lblConsTitle.TabIndex = 22;
            this.lblConsTitle.Text = "Consultas Marcadas";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.Location = new System.Drawing.Point(51, 209);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(235, 33);
            this.lblRetorno.TabIndex = 24;
            this.lblRetorno.Text = "Retornos Marcados";
            // 
            // lblQtdRet
            // 
            this.lblQtdRet.AutoSize = true;
            this.lblQtdRet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRet.Location = new System.Drawing.Point(110, 252);
            this.lblQtdRet.Name = "lblQtdRet";
            this.lblQtdRet.Size = new System.Drawing.Size(77, 29);
            this.lblQtdRet.TabIndex = 23;
            this.lblQtdRet.Text = "fulano";
            // 
            // grpRetornoOK
            // 
            this.grpRetornoOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpRetornoOK.Controls.Add(this.lblMed2);
            this.grpRetornoOK.Controls.Add(this.lblMed2Title);
            this.grpRetornoOK.Controls.Add(this.lblDataRet);
            this.grpRetornoOK.Controls.Add(this.lblRetornoTitle);
            this.grpRetornoOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRetornoOK.Location = new System.Drawing.Point(421, 223);
            this.grpRetornoOK.Name = "grpRetornoOK";
            this.grpRetornoOK.Size = new System.Drawing.Size(253, 178);
            this.grpRetornoOK.TabIndex = 22;
            this.grpRetornoOK.TabStop = false;
            this.grpRetornoOK.Text = "Próximo Retorno";
            // 
            // lblDataCons
            // 
            this.lblDataCons.AutoSize = true;
            this.lblDataCons.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblDataCons.Location = new System.Drawing.Point(30, 53);
            this.lblDataCons.Name = "lblDataCons";
            this.lblDataCons.Size = new System.Drawing.Size(175, 29);
            this.lblDataCons.TabIndex = 37;
            this.lblDataCons.Text = "xx/xx/xx - aa:aah";
            // 
            // lblDataTitulo
            // 
            this.lblDataTitulo.AutoSize = true;
            this.lblDataTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTitulo.Location = new System.Drawing.Point(37, 19);
            this.lblDataTitulo.Name = "lblDataTitulo";
            this.lblDataTitulo.Size = new System.Drawing.Size(190, 29);
            this.lblDataTitulo.TabIndex = 36;
            this.lblDataTitulo.Text = "Data da Consulta:";
            // 
            // lblMed1
            // 
            this.lblMed1.AutoSize = true;
            this.lblMed1.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblMed1.Location = new System.Drawing.Point(81, 143);
            this.lblMed1.Name = "lblMed1";
            this.lblMed1.Size = new System.Drawing.Size(95, 29);
            this.lblMed1.TabIndex = 39;
            this.lblMed1.Text = "Marcelo";
            // 
            // lblMed1Title
            // 
            this.lblMed1Title.AutoSize = true;
            this.lblMed1Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed1Title.Location = new System.Drawing.Point(81, 114);
            this.lblMed1Title.Name = "lblMed1Title";
            this.lblMed1Title.Size = new System.Drawing.Size(95, 29);
            this.lblMed1Title.TabIndex = 38;
            this.lblMed1Title.Text = "Médico:";
            // 
            // lblMed2
            // 
            this.lblMed2.AutoSize = true;
            this.lblMed2.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblMed2.Location = new System.Drawing.Point(81, 143);
            this.lblMed2.Name = "lblMed2";
            this.lblMed2.Size = new System.Drawing.Size(95, 29);
            this.lblMed2.TabIndex = 43;
            this.lblMed2.Text = "Marcelo";
            // 
            // lblMed2Title
            // 
            this.lblMed2Title.AutoSize = true;
            this.lblMed2Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed2Title.Location = new System.Drawing.Point(81, 114);
            this.lblMed2Title.Name = "lblMed2Title";
            this.lblMed2Title.Size = new System.Drawing.Size(95, 29);
            this.lblMed2Title.TabIndex = 42;
            this.lblMed2Title.Text = "Médico:";
            // 
            // lblDataRet
            // 
            this.lblDataRet.AutoSize = true;
            this.lblDataRet.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblDataRet.Location = new System.Drawing.Point(24, 58);
            this.lblDataRet.Name = "lblDataRet";
            this.lblDataRet.Size = new System.Drawing.Size(175, 29);
            this.lblDataRet.TabIndex = 41;
            this.lblDataRet.Text = "xx/xx/xx - aa:aah";
            // 
            // lblRetornoTitle
            // 
            this.lblRetornoTitle.AutoSize = true;
            this.lblRetornoTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornoTitle.Location = new System.Drawing.Point(37, 19);
            this.lblRetornoTitle.Name = "lblRetornoTitle";
            this.lblRetornoTitle.Size = new System.Drawing.Size(185, 29);
            this.lblRetornoTitle.TabIndex = 40;
            this.lblRetornoTitle.Text = "Data do Retorno:";
            // 
            // grpRetornoNO
            // 
            this.grpRetornoNO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpRetornoNO.Controls.Add(this.lblNope);
            this.grpRetornoNO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRetornoNO.Location = new System.Drawing.Point(421, 223);
            this.grpRetornoNO.Name = "grpRetornoNO";
            this.grpRetornoNO.Size = new System.Drawing.Size(253, 178);
            this.grpRetornoNO.TabIndex = 44;
            this.grpRetornoNO.TabStop = false;
            this.grpRetornoNO.Text = "Próximo Retorno";
            // 
            // lblNope
            // 
            this.lblNope.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblNope.ForeColor = System.Drawing.Color.Red;
            this.lblNope.Location = new System.Drawing.Point(24, 45);
            this.lblNope.Name = "lblNope";
            this.lblNope.Size = new System.Drawing.Size(205, 99);
            this.lblNope.TabIndex = 41;
            this.lblNope.Text = "Você não possui nenum retorno marcado";
            this.lblNope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpConsultaNO
            // 
            this.grpConsultaNO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpConsultaNO.Controls.Add(this.label1);
            this.grpConsultaNO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultaNO.Location = new System.Drawing.Point(421, 20);
            this.grpConsultaNO.Name = "grpConsultaNO";
            this.grpConsultaNO.Size = new System.Drawing.Size(253, 178);
            this.grpConsultaNO.TabIndex = 45;
            this.grpConsultaNO.TabStop = false;
            this.grpConsultaNO.Text = "Próxima Consulta";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 99);
            this.label1.TabIndex = 41;
            this.label1.Text = "Você não possui nenuma consulta marcada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 476);
            this.Controls.Add(this.tabPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Paciente";
            this.tabPaciente.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaciente)).EndInit();
            this.tabMeusDados.ResumeLayout(false);
            this.tabMeusDados.PerformLayout();
            this.tabMinhasConsultas.ResumeLayout(false);
            this.tabMinhasConsultas.PerformLayout();
            this.grpConsultaOK.ResumeLayout(false);
            this.grpConsultaOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpRetornoOK.ResumeLayout(false);
            this.grpRetornoOK.PerformLayout();
            this.grpRetornoNO.ResumeLayout(false);
            this.grpConsultaNO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPaciente;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabMeusDados;
        private System.Windows.Forms.TabPage tabMinhasConsultas;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox picPaciente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeTitle;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.Label lblTelTitle;
        private System.Windows.Forms.Label lblNascm;
        private System.Windows.Forms.Label lblNascmTitle;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblSexoTitle;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCPFTitle;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblSobreTitle;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.GroupBox grpConsultaOK;
        private System.Windows.Forms.Label lblHoje;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Label lblVocePossui;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpRetornoOK;
        private System.Windows.Forms.Label lblQtdCons;
        private System.Windows.Forms.Label lblConsTitle;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label lblQtdRet;
        private System.Windows.Forms.Label lblMed2;
        private System.Windows.Forms.Label lblMed2Title;
        private System.Windows.Forms.Label lblDataRet;
        private System.Windows.Forms.Label lblRetornoTitle;
        private System.Windows.Forms.Label lblMed1;
        private System.Windows.Forms.Label lblMed1Title;
        private System.Windows.Forms.Label lblDataCons;
        private System.Windows.Forms.Label lblDataTitulo;
        private System.Windows.Forms.GroupBox grpRetornoNO;
        private System.Windows.Forms.Label lblNope;
        private System.Windows.Forms.GroupBox grpConsultaNO;
        private System.Windows.Forms.Label label1;
    }
}