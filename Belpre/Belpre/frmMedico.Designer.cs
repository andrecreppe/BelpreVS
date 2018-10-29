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
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.tabCadPac = new System.Windows.Forms.TabPage();
            this.tabPac = new System.Windows.Forms.TabPage();
            this.tabCadCons = new System.Windows.Forms.TabPage();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMedico.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.tabHome);
            this.tabMedico.Controls.Add(this.tabAgenda);
            this.tabMedico.Controls.Add(this.tabCadCons);
            this.tabMedico.Controls.Add(this.tabCadPac);
            this.tabMedico.Controls.Add(this.tabPac);
            this.tabMedico.Location = new System.Drawing.Point(13, 12);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.SelectedIndex = 0;
            this.tabMedico.Size = new System.Drawing.Size(620, 507);
            this.tabMedico.TabIndex = 0;
            // 
            // tabAgenda
            // 
            this.tabAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(612, 481);
            this.tabAgenda.TabIndex = 0;
            this.tabAgenda.Text = "Agenda";
            this.tabAgenda.UseVisualStyleBackColor = true;
            // 
            // tabCadPac
            // 
            this.tabCadPac.Location = new System.Drawing.Point(4, 22);
            this.tabCadPac.Name = "tabCadPac";
            this.tabCadPac.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadPac.Size = new System.Drawing.Size(612, 481);
            this.tabCadPac.TabIndex = 1;
            this.tabCadPac.Text = "Cadastro Paciente";
            this.tabCadPac.UseVisualStyleBackColor = true;
            // 
            // tabPac
            // 
            this.tabPac.Location = new System.Drawing.Point(4, 22);
            this.tabPac.Name = "tabPac";
            this.tabPac.Size = new System.Drawing.Size(612, 481);
            this.tabPac.TabIndex = 2;
            this.tabPac.Text = "Pacientes";
            this.tabPac.UseVisualStyleBackColor = true;
            // 
            // tabCadCons
            // 
            this.tabCadCons.Location = new System.Drawing.Point(4, 22);
            this.tabCadCons.Name = "tabCadCons";
            this.tabCadCons.Size = new System.Drawing.Size(612, 481);
            this.tabCadCons.TabIndex = 3;
            this.tabCadCons.Text = "Cadastro Consultas";
            this.tabCadCons.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(612, 481);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 531);
            this.Controls.Add(this.tabMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tabMedico.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMedico;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabPage tabCadPac;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCadCons;
        private System.Windows.Forms.TabPage tabPac;
        private System.Windows.Forms.Label label1;
    }
}