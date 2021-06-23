
namespace Clinica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Médico = new System.Windows.Forms.ToolStripMenuItem();
            this.drCláudioPereiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CRM = new System.Windows.Forms.ToolStripMenuItem();
            this.cRM68392SPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Especialidade = new System.Windows.Forms.ToolStripMenuItem();
            this.cardiologistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Médico,
            this.CRM,
            this.Especialidade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Médico
            // 
            this.Médico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drCláudioPereiraToolStripMenuItem});
            this.Médico.Name = "Médico";
            this.Médico.Size = new System.Drawing.Size(59, 20);
            this.Médico.Text = "Médico";
            // 
            // drCláudioPereiraToolStripMenuItem
            // 
            this.drCláudioPereiraToolStripMenuItem.Name = "drCláudioPereiraToolStripMenuItem";
            this.drCláudioPereiraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drCláudioPereiraToolStripMenuItem.Text = "Dr.Cláudio Pereira";
            // 
            // CRM
            // 
            this.CRM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRM68392SPToolStripMenuItem});
            this.CRM.Name = "CRM";
            this.CRM.Size = new System.Drawing.Size(45, 20);
            this.CRM.Text = "CRM";
            // 
            // cRM68392SPToolStripMenuItem
            // 
            this.cRM68392SPToolStripMenuItem.Name = "cRM68392SPToolStripMenuItem";
            this.cRM68392SPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRM68392SPToolStripMenuItem.Text = "CRM 68392 SP";
            // 
            // Especialidade
            // 
            this.Especialidade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardiologistaToolStripMenuItem});
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.Size = new System.Drawing.Size(90, 20);
            this.Especialidade.Text = "Especialidade";
            // 
            // cardiologistaToolStripMenuItem
            // 
            this.cardiologistaToolStripMenuItem.Name = "cardiologistaToolStripMenuItem";
            this.cardiologistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cardiologistaToolStripMenuItem.Text = "Cardiologista";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(9, 52);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(52, 15);
            this.lab.TabIndex = 1;
            this.lab.Text = "Paciente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(578, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data do Lançamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(613, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profissão";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 23);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(613, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 23);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data/Hora da Consulta";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 23);
            this.textBox5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tempo Médio da Consulta";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(257, 204);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 23);
            this.textBox6.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clínica Médica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Médico;
        private System.Windows.Forms.ToolStripMenuItem drCláudioPereiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CRM;
        private System.Windows.Forms.ToolStripMenuItem cRM68392SPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Especialidade;
        private System.Windows.Forms.ToolStripMenuItem cardiologistaToolStripMenuItem;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}

