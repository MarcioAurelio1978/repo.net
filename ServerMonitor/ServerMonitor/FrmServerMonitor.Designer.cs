namespace ServerMonitor
{
    partial class FrmServerMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerMonitor));
            this.btnScan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgMapeamentos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUso = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.PgEspaco = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.lblEspacoLivre = new System.Windows.Forms.Label();
            this.lblEspacoUsado = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDrive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAnalisar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMapeamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.Red;
            this.btnScan.Location = new System.Drawing.Point(18, 559);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(595, 43);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgMapeamentos);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(18, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 442);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapeamentos";
            // 
            // dgMapeamentos
            // 
            this.dgMapeamentos.AllowUserToAddRows = false;
            this.dgMapeamentos.AllowUserToDeleteRows = false;
            this.dgMapeamentos.AllowUserToResizeColumns = false;
            this.dgMapeamentos.AllowUserToResizeRows = false;
            this.dgMapeamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMapeamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMapeamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMapeamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMapeamentos.Location = new System.Drawing.Point(3, 16);
            this.dgMapeamentos.Name = "dgMapeamentos";
            this.dgMapeamentos.ReadOnly = true;
            this.dgMapeamentos.Size = new System.Drawing.Size(592, 423);
            this.dgMapeamentos.TabIndex = 16;
            this.dgMapeamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMapeamentos_CellContentClick);
            this.dgMapeamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgMapeamentos_CellFormatting);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(495, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 87);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 608);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 257);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propriedades";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUso);
            this.groupBox3.Controls.Add(this.lblPorcentagem);
            this.groupBox3.Controls.Add(this.PgEspaco);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lblCapacidade);
            this.groupBox3.Controls.Add(this.lblEspacoLivre);
            this.groupBox3.Controls.Add(this.lblEspacoUsado);
            this.groupBox3.Controls.Add(this.lblFormato);
            this.groupBox3.Controls.Add(this.lblVolume);
            this.groupBox3.Controls.Add(this.lblTipo);
            this.groupBox3.Controls.Add(this.lblDrive);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 232);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // lblUso
            // 
            this.lblUso.AutoSize = true;
            this.lblUso.Location = new System.Drawing.Point(300, 163);
            this.lblUso.Name = "lblUso";
            this.lblUso.Size = new System.Drawing.Size(74, 13);
            this.lblUso.TabIndex = 23;
            this.lblUso.Text = "Uso estimado:";
            this.lblUso.Visible = false;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.Color.Red;
            this.lblPorcentagem.Location = new System.Drawing.Point(401, 163);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(27, 13);
            this.lblPorcentagem.TabIndex = 22;
            this.lblPorcentagem.Text = "0 %";
            this.lblPorcentagem.Visible = false;
            // 
            // PgEspaco
            // 
            this.PgEspaco.Location = new System.Drawing.Point(262, 118);
            this.PgEspaco.Name = "PgEspaco";
            this.PgEspaco.Size = new System.Drawing.Size(269, 29);
            this.PgEspaco.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgEspaco.TabIndex = 21;
            this.PgEspaco.Value = 50;
            this.PgEspaco.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Location = new System.Drawing.Point(147, 192);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(10, 13);
            this.lblCapacidade.TabIndex = 19;
            this.lblCapacidade.Text = " ";
            // 
            // lblEspacoLivre
            // 
            this.lblEspacoLivre.AutoSize = true;
            this.lblEspacoLivre.Location = new System.Drawing.Point(147, 163);
            this.lblEspacoLivre.Name = "lblEspacoLivre";
            this.lblEspacoLivre.Size = new System.Drawing.Size(10, 13);
            this.lblEspacoLivre.TabIndex = 18;
            this.lblEspacoLivre.Text = " ";
            // 
            // lblEspacoUsado
            // 
            this.lblEspacoUsado.AutoSize = true;
            this.lblEspacoUsado.Location = new System.Drawing.Point(147, 134);
            this.lblEspacoUsado.Name = "lblEspacoUsado";
            this.lblEspacoUsado.Size = new System.Drawing.Size(10, 13);
            this.lblEspacoUsado.TabIndex = 17;
            this.lblEspacoUsado.Text = " ";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(147, 104);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(10, 13);
            this.lblFormato.TabIndex = 16;
            this.lblFormato.Text = " ";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(147, 74);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(10, 13);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = " ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(147, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(10, 13);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = " ";
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(147, 16);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(10, 13);
            this.lblDrive.TabIndex = 13;
            this.lblDrive.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Volume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Espaço usado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Espaço livre:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(533, 534);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(573, 534);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "    0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Análisar:";
            this.label8.Visible = false;
            // 
            // lblAnalisar
            // 
            this.lblAnalisar.AutoSize = true;
            this.lblAnalisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalisar.ForeColor = System.Drawing.Color.Red;
            this.lblAnalisar.Location = new System.Drawing.Point(72, 534);
            this.lblAnalisar.Name = "lblAnalisar";
            this.lblAnalisar.Size = new System.Drawing.Size(22, 13);
            this.lblAnalisar.TabIndex = 14;
            this.lblAnalisar.Text = "  0";
            this.lblAnalisar.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ServerMonitor.Properties.Resources.header2;
            this.pictureBox2.Location = new System.Drawing.Point(21, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(595, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // FrmServerMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 875);
            this.Controls.Add(this.lblAnalisar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmServerMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoria de Servidores - CIAF";
            this.Load += new System.EventHandler(this.FrmServerMonitor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMapeamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.Label lblEspacoLivre;
        private System.Windows.Forms.Label lblEspacoUsado;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar PgEspaco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAnalisar;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblUso;
        private System.Windows.Forms.DataGridView dgMapeamentos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

