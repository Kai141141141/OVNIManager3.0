namespace OVNIManager3._0
{
    partial class Painel
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
            this.grvDados = new System.Windows.Forms.GroupBox();
            this.btnPlaneta = new System.Windows.Forms.Label();
            this.lblTripulantess = new System.Windows.Forms.Label();
            this.lblAbduzidoss = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.bntLigar = new System.Windows.Forms.Button();
            this.bntDesligar = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.BntAbduzirr = new System.Windows.Forms.Button();
            this.bntDesabduzir = new System.Windows.Forms.Button();
            this.bntRetornar = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.cmdMudar = new System.Windows.Forms.Button();
            this.grvDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDados
            // 
            this.grvDados.Controls.Add(this.btnPlaneta);
            this.grvDados.Controls.Add(this.lblTripulantess);
            this.grvDados.Controls.Add(this.lblAbduzidoss);
            this.grvDados.Controls.Add(this.lblSituacao);
            this.grvDados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDados.Location = new System.Drawing.Point(12, 12);
            this.grvDados.Name = "grvDados";
            this.grvDados.Size = new System.Drawing.Size(203, 154);
            this.grvDados.TabIndex = 0;
            this.grvDados.TabStop = false;
            this.grvDados.Text = "Dados:";
            // 
            // btnPlaneta
            // 
            this.btnPlaneta.AutoSize = true;
            this.btnPlaneta.Location = new System.Drawing.Point(6, 126);
            this.btnPlaneta.Name = "btnPlaneta";
            this.btnPlaneta.Size = new System.Drawing.Size(77, 18);
            this.btnPlaneta.TabIndex = 3;
            this.btnPlaneta.Text = "Planeta:";
            // 
            // lblTripulantess
            // 
            this.lblTripulantess.AutoSize = true;
            this.lblTripulantess.Location = new System.Drawing.Point(6, 94);
            this.lblTripulantess.Name = "lblTripulantess";
            this.lblTripulantess.Size = new System.Drawing.Size(115, 18);
            this.lblTripulantess.TabIndex = 2;
            this.lblTripulantess.Text = "Triupulantes:";
            // 
            // lblAbduzidoss
            // 
            this.lblAbduzidoss.AutoSize = true;
            this.lblAbduzidoss.Location = new System.Drawing.Point(6, 66);
            this.lblAbduzidoss.Name = "lblAbduzidoss";
            this.lblAbduzidoss.Size = new System.Drawing.Size(99, 18);
            this.lblAbduzidoss.TabIndex = 1;
            this.lblAbduzidoss.Text = "Abduzidos:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 34);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(85, 18);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // bntLigar
            // 
            this.bntLigar.Location = new System.Drawing.Point(12, 172);
            this.bntLigar.Name = "bntLigar";
            this.bntLigar.Size = new System.Drawing.Size(203, 36);
            this.bntLigar.TabIndex = 1;
            this.bntLigar.Text = "LIGAR";
            this.bntLigar.UseVisualStyleBackColor = true;
            this.bntLigar.Click += new System.EventHandler(this.bntLigar_Click);
            // 
            // bntDesligar
            // 
            this.bntDesligar.Location = new System.Drawing.Point(12, 214);
            this.bntDesligar.Name = "bntDesligar";
            this.bntDesligar.Size = new System.Drawing.Size(203, 36);
            this.bntDesligar.TabIndex = 2;
            this.bntDesligar.Text = "DESLIGAR";
            this.bntDesligar.UseVisualStyleBackColor = true;
            this.bntDesligar.Click += new System.EventHandler(this.bntDesligar_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(239, 12);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(203, 36);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "ADICIONAR TRIPULANTE";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(239, 54);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(203, 36);
            this.bntRemover.TabIndex = 4;
            this.bntRemover.Text = "REMOVER TRIPULANTE";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // BntAbduzirr
            // 
            this.BntAbduzirr.Location = new System.Drawing.Point(239, 96);
            this.BntAbduzirr.Name = "BntAbduzirr";
            this.BntAbduzirr.Size = new System.Drawing.Size(203, 36);
            this.BntAbduzirr.TabIndex = 5;
            this.BntAbduzirr.Text = "ABDUZIR";
            this.BntAbduzirr.UseVisualStyleBackColor = true;
            this.BntAbduzirr.Click += new System.EventHandler(this.BntAbduzirr_Click);
            // 
            // bntDesabduzir
            // 
            this.bntDesabduzir.Location = new System.Drawing.Point(239, 138);
            this.bntDesabduzir.Name = "bntDesabduzir";
            this.bntDesabduzir.Size = new System.Drawing.Size(203, 36);
            this.bntDesabduzir.TabIndex = 6;
            this.bntDesabduzir.Text = "DESABDUZIR";
            this.bntDesabduzir.UseVisualStyleBackColor = true;
            this.bntDesabduzir.Click += new System.EventHandler(this.bntDesabduzir_Click);
            // 
            // bntRetornar
            // 
            this.bntRetornar.Location = new System.Drawing.Point(239, 180);
            this.bntRetornar.Name = "bntRetornar";
            this.bntRetornar.Size = new System.Drawing.Size(203, 36);
            this.bntRetornar.TabIndex = 7;
            this.bntRetornar.Text = "RETORNAR ORIGEM";
            this.bntRetornar.UseVisualStyleBackColor = true;
            this.bntRetornar.Click += new System.EventHandler(this.bntRetornar_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(239, 222);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 33);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // cmdMudar
            // 
            this.cmdMudar.Location = new System.Drawing.Point(366, 223);
            this.cmdMudar.Name = "cmdMudar";
            this.cmdMudar.Size = new System.Drawing.Size(76, 34);
            this.cmdMudar.TabIndex = 10;
            this.cmdMudar.Text = "MUDAR";
            this.cmdMudar.UseVisualStyleBackColor = true;
            this.cmdMudar.Click += new System.EventHandler(this.cmdMudar_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 287);
            this.Controls.Add(this.cmdMudar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.bntRetornar);
            this.Controls.Add(this.bntDesabduzir);
            this.Controls.Add(this.BntAbduzirr);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntDesligar);
            this.Controls.Add(this.bntLigar);
            this.Controls.Add(this.grvDados);
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grvDados.ResumeLayout(false);
            this.grvDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grvDados;
        private System.Windows.Forms.Label btnPlaneta;
        private System.Windows.Forms.Label lblTripulantess;
        private System.Windows.Forms.Label lblAbduzidoss;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button bntLigar;
        private System.Windows.Forms.Button bntDesligar;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.Button BntAbduzirr;
        private System.Windows.Forms.Button bntDesabduzir;
        private System.Windows.Forms.Button bntRetornar;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button cmdMudar;
    }
}