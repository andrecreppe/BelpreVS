namespace Belpre
{
    partial class frmMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedico));
            this.tabMedico = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblHoje = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.lblVocePossui = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.picMedicoa = new System.Windows.Forms.PictureBox();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.grpSeg = new System.Windows.Forms.GroupBox();
            this.lblTerca = new System.Windows.Forms.Label();
            this.btnHoje = new System.Windows.Forms.Button();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.picAvancar = new System.Windows.Forms.PictureBox();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblSexta = new System.Windows.Forms.Label();
            this.lblQuinta = new System.Windows.Forms.Label();
            this.lblQuarta = new System.Windows.Forms.Label();
            this.lblSegunda = new System.Windows.Forms.Label();
            this.grpDomingo = new System.Windows.Forms.GroupBox();
            this.dgvDom = new System.Windows.Forms.DataGridView();
            this.grpSabado = new System.Windows.Forms.GroupBox();
            this.grpSexta = new System.Windows.Forms.GroupBox();
            this.grpQuinta = new System.Windows.Forms.GroupBox();
            this.grpQuarta = new System.Windows.Forms.GroupBox();
            this.grpTerca = new System.Windows.Forms.GroupBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.cmbIDOculto = new System.Windows.Forms.ComboBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.btnLimpaConsulta = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.chkParticular = new System.Windows.Forms.CheckBox();
            this.cmbConvenio = new System.Windows.Forms.ComboBox();
            this.lblM = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.mskDiaConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.picConsulta = new System.Windows.Forms.PictureBox();
            this.tabPac = new System.Windows.Forms.TabPage();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.lblAtivos = new System.Windows.Forms.Label();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.mskNascmCad = new System.Windows.Forms.MaskedTextBox();
            this.mskCellCad = new System.Windows.Forms.MaskedTextBox();
            this.mskCPFCad = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpaCad = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.radMascCad = new System.Windows.Forms.RadioButton();
            this.radFemCad = new System.Windows.Forms.RadioButton();
            this.txtSobreCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblCellCad = new System.Windows.Forms.Label();
            this.lblNascmCad = new System.Windows.Forms.Label();
            this.lblSexoCad = new System.Windows.Forms.Label();
            this.lblCPFCad = new System.Windows.Forms.Label();
            this.lblSobrCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.tabMedico.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicoa)).BeginInit();
            this.tabAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvancar)).BeginInit();
            this.grpDomingo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDom)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConsulta)).BeginInit();
            this.tabPac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.tabHome);
            this.tabMedico.Controls.Add(this.tabAgenda);
            this.tabMedico.Controls.Add(this.tabConsulta);
            this.tabMedico.Controls.Add(this.tabPac);
            this.tabMedico.Controls.Add(this.tabCadastro);
            this.tabMedico.Controls.Add(this.tabDados);
            this.tabMedico.Location = new System.Drawing.Point(13, 12);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.SelectedIndex = 0;
            this.tabMedico.Size = new System.Drawing.Size(903, 507);
            this.tabMedico.TabIndex = 0;
            this.tabMedico.SelectedIndexChanged += new System.EventHandler(this.tabMedico_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.lblHoje);
            this.tabHome.Controls.Add(this.lblConsultas);
            this.tabHome.Controls.Add(this.lblVocePossui);
            this.tabHome.Controls.Add(this.lblData);
            this.tabHome.Controls.Add(this.btnLogout);
            this.tabHome.Controls.Add(this.lblBemVindo);
            this.tabHome.Controls.Add(this.picMedicoa);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(895, 481);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            // 
            // lblHoje
            // 
            this.lblHoje.AutoSize = true;
            this.lblHoje.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoje.Location = new System.Drawing.Point(643, 143);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(121, 29);
            this.lblHoje.TabIndex = 6;
            this.lblHoje.Text = "xx/xx/xxxx";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(643, 222);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(137, 29);
            this.lblConsultas.TabIndex = 5;
            this.lblConsultas.Text = "X Consultas!";
            // 
            // lblVocePossui
            // 
            this.lblVocePossui.AutoSize = true;
            this.lblVocePossui.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocePossui.Location = new System.Drawing.Point(453, 222);
            this.lblVocePossui.Name = "lblVocePossui";
            this.lblVocePossui.Size = new System.Drawing.Size(184, 29);
            this.lblVocePossui.TabIndex = 4;
            this.lblVocePossui.Text = "Hoje você possui:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(499, 143);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(138, 29);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Dia de Hoje: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(371, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(521, 57);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "&Sair";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(507, 16);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(263, 36);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem vindo fulanooo";
            // 
            // picMedicoa
            // 
            this.picMedicoa.Image = ((System.Drawing.Image)(resources.GetObject("picMedicoa.Image")));
            this.picMedicoa.Location = new System.Drawing.Point(13, 65);
            this.picMedicoa.Name = "picMedicoa";
            this.picMedicoa.Size = new System.Drawing.Size(352, 404);
            this.picMedicoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedicoa.TabIndex = 0;
            this.picMedicoa.TabStop = false;
            // 
            // tabAgenda
            // 
            this.tabAgenda.BackColor = System.Drawing.Color.White;
            this.tabAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAgenda.Controls.Add(this.grpSeg);
            this.tabAgenda.Controls.Add(this.lblTerca);
            this.tabAgenda.Controls.Add(this.btnHoje);
            this.tabAgenda.Controls.Add(this.picVoltar);
            this.tabAgenda.Controls.Add(this.picAvancar);
            this.tabAgenda.Controls.Add(this.lblDomingo);
            this.tabAgenda.Controls.Add(this.lblSabado);
            this.tabAgenda.Controls.Add(this.lblSexta);
            this.tabAgenda.Controls.Add(this.lblQuinta);
            this.tabAgenda.Controls.Add(this.lblQuarta);
            this.tabAgenda.Controls.Add(this.lblSegunda);
            this.tabAgenda.Controls.Add(this.grpDomingo);
            this.tabAgenda.Controls.Add(this.grpSabado);
            this.tabAgenda.Controls.Add(this.grpSexta);
            this.tabAgenda.Controls.Add(this.grpQuinta);
            this.tabAgenda.Controls.Add(this.grpQuarta);
            this.tabAgenda.Controls.Add(this.grpTerca);
            this.tabAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(895, 481);
            this.tabAgenda.TabIndex = 0;
            this.tabAgenda.Text = "Agenda";
            // 
            // grpSeg
            // 
            this.grpSeg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeg.Location = new System.Drawing.Point(169, 43);
            this.grpSeg.Name = "grpSeg";
            this.grpSeg.Size = new System.Drawing.Size(115, 432);
            this.grpSeg.TabIndex = 0;
            this.grpSeg.TabStop = false;
            this.grpSeg.Text = "Segunda-Feira";
            // 
            // lblTerca
            // 
            this.lblTerca.AutoSize = true;
            this.lblTerca.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerca.Location = new System.Drawing.Point(305, 13);
            this.lblTerca.Name = "lblTerca";
            this.lblTerca.Size = new System.Drawing.Size(59, 23);
            this.lblTerca.TabIndex = 8;
            this.lblTerca.Text = "label3";
            // 
            // btnHoje
            // 
            this.btnHoje.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoje.Location = new System.Drawing.Point(3, 416);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(39, 59);
            this.btnHoje.TabIndex = 16;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(6, 258);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(35, 31);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVoltar.TabIndex = 15;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // picAvancar
            // 
            this.picAvancar.Image = ((System.Drawing.Image)(resources.GetObject("picAvancar.Image")));
            this.picAvancar.Location = new System.Drawing.Point(7, 184);
            this.picAvancar.Name = "picAvancar";
            this.picAvancar.Size = new System.Drawing.Size(35, 31);
            this.picAvancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvancar.TabIndex = 14;
            this.picAvancar.TabStop = false;
            this.picAvancar.Click += new System.EventHandler(this.picAvancar_Click);
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.BackColor = System.Drawing.Color.Transparent;
            this.lblDomingo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingo.ForeColor = System.Drawing.Color.Black;
            this.lblDomingo.Location = new System.Drawing.Point(58, 13);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(77, 23);
            this.lblDomingo.TabIndex = 13;
            this.lblDomingo.Text = "*label8*";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.Location = new System.Drawing.Point(785, 13);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(59, 23);
            this.lblSabado.TabIndex = 12;
            this.lblSabado.Text = "label7";
            // 
            // lblSexta
            // 
            this.lblSexta.AutoSize = true;
            this.lblSexta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexta.Location = new System.Drawing.Point(665, 13);
            this.lblSexta.Name = "lblSexta";
            this.lblSexta.Size = new System.Drawing.Size(59, 23);
            this.lblSexta.TabIndex = 11;
            this.lblSexta.Text = "label6";
            // 
            // lblQuinta
            // 
            this.lblQuinta.AutoSize = true;
            this.lblQuinta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuinta.Location = new System.Drawing.Point(546, 13);
            this.lblQuinta.Name = "lblQuinta";
            this.lblQuinta.Size = new System.Drawing.Size(59, 23);
            this.lblQuinta.TabIndex = 10;
            this.lblQuinta.Text = "label5";
            // 
            // lblQuarta
            // 
            this.lblQuarta.AutoSize = true;
            this.lblQuarta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarta.Location = new System.Drawing.Point(425, 13);
            this.lblQuarta.Name = "lblQuarta";
            this.lblQuarta.Size = new System.Drawing.Size(59, 23);
            this.lblQuarta.TabIndex = 9;
            this.lblQuarta.Text = "label4";
            // 
            // lblSegunda
            // 
            this.lblSegunda.AutoSize = true;
            this.lblSegunda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegunda.Location = new System.Drawing.Point(179, 13);
            this.lblSegunda.Name = "lblSegunda";
            this.lblSegunda.Size = new System.Drawing.Size(59, 23);
            this.lblSegunda.TabIndex = 7;
            this.lblSegunda.Text = "label1";
            // 
            // grpDomingo
            // 
            this.grpDomingo.Controls.Add(this.dgvDom);
            this.grpDomingo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDomingo.Location = new System.Drawing.Point(47, 43);
            this.grpDomingo.Name = "grpDomingo";
            this.grpDomingo.Size = new System.Drawing.Size(115, 432);
            this.grpDomingo.TabIndex = 6;
            this.grpDomingo.TabStop = false;
            this.grpDomingo.Text = "Domingo";
            // 
            // dgvDom
            // 
            this.dgvDom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDom.Location = new System.Drawing.Point(7, 22);
            this.dgvDom.Name = "dgvDom";
            this.dgvDom.Size = new System.Drawing.Size(102, 404);
            this.dgvDom.TabIndex = 0;
            // 
            // grpSabado
            // 
            this.grpSabado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSabado.Location = new System.Drawing.Point(774, 43);
            this.grpSabado.Name = "grpSabado";
            this.grpSabado.Size = new System.Drawing.Size(115, 432);
            this.grpSabado.TabIndex = 5;
            this.grpSabado.TabStop = false;
            this.grpSabado.Text = "Sábado";
            // 
            // grpSexta
            // 
            this.grpSexta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexta.Location = new System.Drawing.Point(653, 43);
            this.grpSexta.Name = "grpSexta";
            this.grpSexta.Size = new System.Drawing.Size(115, 432);
            this.grpSexta.TabIndex = 4;
            this.grpSexta.TabStop = false;
            this.grpSexta.Text = "Sexta-Feira";
            // 
            // grpQuinta
            // 
            this.grpQuinta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuinta.Location = new System.Drawing.Point(532, 43);
            this.grpQuinta.Name = "grpQuinta";
            this.grpQuinta.Size = new System.Drawing.Size(115, 432);
            this.grpQuinta.TabIndex = 3;
            this.grpQuinta.TabStop = false;
            this.grpQuinta.Text = "Quinta-Feira";
            // 
            // grpQuarta
            // 
            this.grpQuarta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuarta.Location = new System.Drawing.Point(411, 43);
            this.grpQuarta.Name = "grpQuarta";
            this.grpQuarta.Size = new System.Drawing.Size(115, 432);
            this.grpQuarta.TabIndex = 2;
            this.grpQuarta.TabStop = false;
            this.grpQuarta.Text = "Quarta-Feira";
            // 
            // grpTerca
            // 
            this.grpTerca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTerca.Location = new System.Drawing.Point(290, 43);
            this.grpTerca.Name = "grpTerca";
            this.grpTerca.Size = new System.Drawing.Size(115, 432);
            this.grpTerca.TabIndex = 1;
            this.grpTerca.TabStop = false;
            this.grpTerca.Text = "Terça-Feira";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.cmbIDOculto);
            this.tabConsulta.Controls.Add(this.cmbPacientes);
            this.tabConsulta.Controls.Add(this.btnLimpaConsulta);
            this.tabConsulta.Controls.Add(this.btnAgendar);
            this.tabConsulta.Controls.Add(this.chkParticular);
            this.tabConsulta.Controls.Add(this.cmbConvenio);
            this.tabConsulta.Controls.Add(this.lblM);
            this.tabConsulta.Controls.Add(this.lblH);
            this.tabConsulta.Controls.Add(this.cmbMinutos);
            this.tabConsulta.Controls.Add(this.cmbHora);
            this.tabConsulta.Controls.Add(this.mskDiaConsulta);
            this.tabConsulta.Controls.Add(this.lblConvenio);
            this.tabConsulta.Controls.Add(this.lblHorario);
            this.tabConsulta.Controls.Add(this.lblDia);
            this.tabConsulta.Controls.Add(this.lblPaciente);
            this.tabConsulta.Controls.Add(this.picConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Size = new System.Drawing.Size(895, 481);
            this.tabConsulta.TabIndex = 3;
            this.tabConsulta.Text = "Agendar Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // cmbIDOculto
            // 
            this.cmbIDOculto.FormattingEnabled = true;
            this.cmbIDOculto.Location = new System.Drawing.Point(185, 95);
            this.cmbIDOculto.Name = "cmbIDOculto";
            this.cmbIDOculto.Size = new System.Drawing.Size(121, 21);
            this.cmbIDOculto.TabIndex = 23;
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.DropDownHeight = 200;
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.IntegralHeight = false;
            this.cmbPacientes.Location = new System.Drawing.Point(185, 45);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(164, 34);
            this.cmbPacientes.TabIndex = 22;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // btnLimpaConsulta
            // 
            this.btnLimpaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaConsulta.Location = new System.Drawing.Point(280, 375);
            this.btnLimpaConsulta.Name = "btnLimpaConsulta";
            this.btnLimpaConsulta.Size = new System.Drawing.Size(163, 42);
            this.btnLimpaConsulta.TabIndex = 21;
            this.btnLimpaConsulta.Text = "&Limpar";
            this.btnLimpaConsulta.UseVisualStyleBackColor = true;
            this.btnLimpaConsulta.Click += new System.EventHandler(this.btnLimpaConsulta_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(54, 375);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(163, 42);
            this.btnAgendar.TabIndex = 20;
            this.btnAgendar.Text = "&Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // chkParticular
            // 
            this.chkParticular.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParticular.Location = new System.Drawing.Point(365, 254);
            this.chkParticular.Name = "chkParticular";
            this.chkParticular.Size = new System.Drawing.Size(123, 53);
            this.chkParticular.TabIndex = 19;
            this.chkParticular.Text = "&Consulta particular?";
            this.chkParticular.UseVisualStyleBackColor = true;
            this.chkParticular.CheckedChanged += new System.EventHandler(this.chkParticular_CheckedChanged);
            // 
            // cmbConvenio
            // 
            this.cmbConvenio.DropDownHeight = 200;
            this.cmbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvenio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConvenio.FormattingEnabled = true;
            this.cmbConvenio.IntegralHeight = false;
            this.cmbConvenio.Items.AddRange(new object[] {
            "Amil",
            "APAS",
            "Bradesco Saúde",
            "São Lucas",
            "SulAmérica",
            "Unimed"});
            this.cmbConvenio.Location = new System.Drawing.Point(185, 263);
            this.cmbConvenio.Name = "cmbConvenio";
            this.cmbConvenio.Size = new System.Drawing.Size(164, 34);
            this.cmbConvenio.Sorted = true;
            this.cmbConvenio.TabIndex = 18;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(344, 213);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(49, 25);
            this.lblM.TabIndex = 17;
            this.lblM.Text = "min";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(249, 212);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(25, 25);
            this.lblH.TabIndex = 16;
            this.lblH.Text = "h";
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.DropDownHeight = 200;
            this.cmbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.IntegralHeight = false;
            this.cmbMinutos.Location = new System.Drawing.Point(280, 204);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(61, 34);
            this.cmbMinutos.TabIndex = 15;
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownHeight = 200;
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.IntegralHeight = false;
            this.cmbHora.Location = new System.Drawing.Point(185, 204);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(61, 34);
            this.cmbHora.TabIndex = 14;
            // 
            // mskDiaConsulta
            // 
            this.mskDiaConsulta.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDiaConsulta.Location = new System.Drawing.Point(185, 144);
            this.mskDiaConsulta.Mask = "00/00/0000";
            this.mskDiaConsulta.Name = "mskDiaConsulta";
            this.mskDiaConsulta.Size = new System.Drawing.Size(131, 37);
            this.mskDiaConsulta.TabIndex = 13;
            this.mskDiaConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(40, 266);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(118, 25);
            this.lblConvenio.TabIndex = 5;
            this.lblConvenio.Text = "Convênio:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(62, 207);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(96, 25);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horario:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(104, 150);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(54, 25);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Dia:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(47, 48);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(111, 25);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente:";
            // 
            // picConsulta
            // 
            this.picConsulta.Image = ((System.Drawing.Image)(resources.GetObject("picConsulta.Image")));
            this.picConsulta.Location = new System.Drawing.Point(545, 45);
            this.picConsulta.Name = "picConsulta";
            this.picConsulta.Size = new System.Drawing.Size(330, 372);
            this.picConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConsulta.TabIndex = 0;
            this.picConsulta.TabStop = false;
            // 
            // tabPac
            // 
            this.tabPac.Controls.Add(this.lblRetorno);
            this.tabPac.Controls.Add(this.lblAtivos);
            this.tabPac.Controls.Add(this.picReload);
            this.tabPac.Controls.Add(this.label2);
            this.tabPac.Controls.Add(this.dgvConsulta);
            this.tabPac.Location = new System.Drawing.Point(4, 22);
            this.tabPac.Name = "tabPac";
            this.tabPac.Size = new System.Drawing.Size(895, 481);
            this.tabPac.TabIndex = 2;
            this.tabPac.Text = "Meus Pacientes";
            this.tabPac.UseVisualStyleBackColor = true;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.Location = new System.Drawing.Point(679, 215);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(136, 15);
            this.lblRetorno.TabIndex = 12;
            this.lblRetorno.Text = "Pacitentes com Retorno";
            // 
            // lblAtivos
            // 
            this.lblAtivos.AutoSize = true;
            this.lblAtivos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivos.Location = new System.Drawing.Point(697, 34);
            this.lblAtivos.Name = "lblAtivos";
            this.lblAtivos.Size = new System.Drawing.Size(100, 15);
            this.lblAtivos.TabIndex = 11;
            this.lblAtivos.Text = "Pacitentes Ativos";
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(486, 449);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(60, 29);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 10;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Para mais informações, duplo clique no ID desejado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgvConsulta.Size = new System.Drawing.Size(543, 443);
            this.dgvConsulta.TabIndex = 8;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.mskNascmCad);
            this.tabCadastro.Controls.Add(this.mskCellCad);
            this.tabCadastro.Controls.Add(this.mskCPFCad);
            this.tabCadastro.Controls.Add(this.btnLimpaCad);
            this.tabCadastro.Controls.Add(this.btnCadastrar);
            this.tabCadastro.Controls.Add(this.lblSenhaCad);
            this.tabCadastro.Controls.Add(this.txtSenhaCad);
            this.tabCadastro.Controls.Add(this.radMascCad);
            this.tabCadastro.Controls.Add(this.radFemCad);
            this.tabCadastro.Controls.Add(this.txtSobreCad);
            this.tabCadastro.Controls.Add(this.txtNomeCad);
            this.tabCadastro.Controls.Add(this.lblCellCad);
            this.tabCadastro.Controls.Add(this.lblNascmCad);
            this.tabCadastro.Controls.Add(this.lblSexoCad);
            this.tabCadastro.Controls.Add(this.lblCPFCad);
            this.tabCadastro.Controls.Add(this.lblSobrCad);
            this.tabCadastro.Controls.Add(this.lblNomeCad);
            this.tabCadastro.Controls.Add(this.picCadastro);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(895, 481);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro Paciente";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // mskNascmCad
            // 
            this.mskNascmCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascmCad.Location = new System.Drawing.Point(175, 221);
            this.mskNascmCad.Mask = "00/00/0000";
            this.mskNascmCad.Name = "mskNascmCad";
            this.mskNascmCad.Size = new System.Drawing.Size(131, 37);
            this.mskNascmCad.TabIndex = 12;
            this.mskNascmCad.ValidatingType = typeof(System.DateTime);
            // 
            // mskCellCad
            // 
            this.mskCellCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCellCad.Location = new System.Drawing.Point(175, 277);
            this.mskCellCad.Mask = "(99) 00000-0000";
            this.mskCellCad.Name = "mskCellCad";
            this.mskCellCad.Size = new System.Drawing.Size(169, 37);
            this.mskCellCad.TabIndex = 13;
            // 
            // mskCPFCad
            // 
            this.mskCPFCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPFCad.Location = new System.Drawing.Point(175, 122);
            this.mskCPFCad.Mask = "000,000,000-00";
            this.mskCPFCad.Name = "mskCPFCad";
            this.mskCPFCad.Size = new System.Drawing.Size(169, 37);
            this.mskCPFCad.TabIndex = 9;
            this.mskCPFCad.ValidatingType = typeof(int);
            // 
            // btnLimpaCad
            // 
            this.btnLimpaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaCad.Location = new System.Drawing.Point(260, 414);
            this.btnLimpaCad.Name = "btnLimpaCad";
            this.btnLimpaCad.Size = new System.Drawing.Size(163, 42);
            this.btnLimpaCad.TabIndex = 16;
            this.btnLimpaCad.Text = "&Limpar";
            this.btnLimpaCad.UseVisualStyleBackColor = true;
            this.btnLimpaCad.Click += new System.EventHandler(this.btnLimpaCad_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(24, 414);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(163, 42);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCad.Location = new System.Drawing.Point(74, 335);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(81, 29);
            this.lblSenhaCad.TabIndex = 15;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCad.Location = new System.Drawing.Point(175, 332);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.PasswordChar = '*';
            this.txtSenhaCad.Size = new System.Drawing.Size(169, 37);
            this.txtSenhaCad.TabIndex = 14;
            // 
            // radMascCad
            // 
            this.radMascCad.AutoSize = true;
            this.radMascCad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMascCad.Location = new System.Drawing.Point(305, 179);
            this.radMascCad.Name = "radMascCad";
            this.radMascCad.Size = new System.Drawing.Size(118, 30);
            this.radMascCad.TabIndex = 11;
            this.radMascCad.TabStop = true;
            this.radMascCad.Text = "&Masculino";
            this.radMascCad.UseVisualStyleBackColor = true;
            // 
            // radFemCad
            // 
            this.radFemCad.AutoSize = true;
            this.radFemCad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemCad.Location = new System.Drawing.Point(175, 179);
            this.radFemCad.Name = "radFemCad";
            this.radFemCad.Size = new System.Drawing.Size(110, 30);
            this.radFemCad.TabIndex = 10;
            this.radFemCad.TabStop = true;
            this.radFemCad.Text = "&Feminino";
            this.radFemCad.UseVisualStyleBackColor = true;
            // 
            // txtSobreCad
            // 
            this.txtSobreCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobreCad.Location = new System.Drawing.Point(175, 70);
            this.txtSobreCad.Name = "txtSobreCad";
            this.txtSobreCad.Size = new System.Drawing.Size(222, 37);
            this.txtSobreCad.TabIndex = 8;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCad.Location = new System.Drawing.Point(175, 16);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(222, 37);
            this.txtNomeCad.TabIndex = 7;
            // 
            // lblCellCad
            // 
            this.lblCellCad.AutoSize = true;
            this.lblCellCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellCad.Location = new System.Drawing.Point(64, 280);
            this.lblCellCad.Name = "lblCellCad";
            this.lblCellCad.Size = new System.Drawing.Size(91, 29);
            this.lblCellCad.TabIndex = 6;
            this.lblCellCad.Text = "Celular:";
            // 
            // lblNascmCad
            // 
            this.lblNascmCad.AutoSize = true;
            this.lblNascmCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascmCad.Location = new System.Drawing.Point(15, 224);
            this.lblNascmCad.Name = "lblNascmCad";
            this.lblNascmCad.Size = new System.Drawing.Size(140, 29);
            this.lblNascmCad.TabIndex = 5;
            this.lblNascmCad.Text = "Nascimento:";
            // 
            // lblSexoCad
            // 
            this.lblSexoCad.AutoSize = true;
            this.lblSexoCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoCad.Location = new System.Drawing.Point(89, 181);
            this.lblSexoCad.Name = "lblSexoCad";
            this.lblSexoCad.Size = new System.Drawing.Size(66, 29);
            this.lblSexoCad.TabIndex = 4;
            this.lblSexoCad.Text = "Sexo:";
            // 
            // lblCPFCad
            // 
            this.lblCPFCad.AutoSize = true;
            this.lblCPFCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCad.Location = new System.Drawing.Point(98, 125);
            this.lblCPFCad.Name = "lblCPFCad";
            this.lblCPFCad.Size = new System.Drawing.Size(57, 29);
            this.lblCPFCad.TabIndex = 3;
            this.lblCPFCad.Text = "CPF:";
            // 
            // lblSobrCad
            // 
            this.lblSobrCad.AutoSize = true;
            this.lblSobrCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrCad.Location = new System.Drawing.Point(19, 73);
            this.lblSobrCad.Name = "lblSobrCad";
            this.lblSobrCad.Size = new System.Drawing.Size(136, 29);
            this.lblSobrCad.TabIndex = 2;
            this.lblSobrCad.Text = "Sobrenome:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(69, 19);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(86, 29);
            this.lblNomeCad.TabIndex = 1;
            this.lblNomeCad.Text = "Nome: ";
            // 
            // picCadastro
            // 
            this.picCadastro.Image = ((System.Drawing.Image)(resources.GetObject("picCadastro.Image")));
            this.picCadastro.Location = new System.Drawing.Point(524, 58);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(330, 334);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCadastro.TabIndex = 0;
            this.picCadastro.TabStop = false;
            // 
            // tabDados
            // 
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(895, 481);
            this.tabDados.TabIndex = 5;
            this.tabDados.Text = "Dados Paciente";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 531);
            this.Controls.Add(this.tabMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tabMedico.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedicoa)).EndInit();
            this.tabAgenda.ResumeLayout(false);
            this.tabAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvancar)).EndInit();
            this.grpDomingo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDom)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConsulta)).EndInit();
            this.tabPac.ResumeLayout(false);
            this.tabPac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMedico;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabPac;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox picMedicoa;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpDomingo;
        private System.Windows.Forms.GroupBox grpSabado;
        private System.Windows.Forms.GroupBox grpSexta;
        private System.Windows.Forms.GroupBox grpQuinta;
        private System.Windows.Forms.GroupBox grpQuarta;
        private System.Windows.Forms.GroupBox grpTerca;
        private System.Windows.Forms.GroupBox grpSeg;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Label lblAtivos;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblSexta;
        private System.Windows.Forms.Label lblQuinta;
        private System.Windows.Forms.Label lblQuarta;
        private System.Windows.Forms.Label lblTerca;
        private System.Windows.Forms.Label lblSegunda;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.PictureBox picAvancar;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvDom;
        private System.Windows.Forms.PictureBox picConsulta;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.RadioButton radMascCad;
        private System.Windows.Forms.RadioButton radFemCad;
        private System.Windows.Forms.TextBox txtSobreCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblCellCad;
        private System.Windows.Forms.Label lblNascmCad;
        private System.Windows.Forms.Label lblSexoCad;
        private System.Windows.Forms.Label lblCPFCad;
        private System.Windows.Forms.Label lblSobrCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.Button btnLimpaCad;
        private System.Windows.Forms.MaskedTextBox mskNascmCad;
        private System.Windows.Forms.MaskedTextBox mskCellCad;
        private System.Windows.Forms.MaskedTextBox mskCPFCad;
        private System.Windows.Forms.Label lblHoje;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Label lblVocePossui;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.MaskedTextBox mskDiaConsulta;
        private System.Windows.Forms.ComboBox cmbMinutos;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.CheckBox chkParticular;
        private System.Windows.Forms.ComboBox cmbConvenio;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.Button btnLimpaConsulta;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox cmbIDOculto;
    }
}