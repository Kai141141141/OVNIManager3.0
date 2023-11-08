using System;

namespace OVNIManager3._0
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPorigem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudeTripulantes = new System.Windows.Forms.NumericUpDown();
            this.nudeAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeAbduzidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblTitulo.Image = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328__1_;
            this.lblTitulo.Location = new System.Drawing.Point(187, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OVNI Manager 3.0";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.BackColor = System.Drawing.SystemColors.Control;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblTripulantes.Image = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328__1_;
            this.lblTripulantes.Location = new System.Drawing.Point(285, 87);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(105, 16);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max.Tripulantes:";
            // 
            // lblPorigem
            // 
            this.lblPorigem.AutoSize = true;
            this.lblPorigem.BackColor = System.Drawing.SystemColors.Control;
            this.lblPorigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorigem.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblPorigem.Image = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328__1_;
            this.lblPorigem.Location = new System.Drawing.Point(268, 113);
            this.lblPorigem.Name = "lblPorigem";
            this.lblPorigem.Size = new System.Drawing.Size(122, 16);
            this.lblPorigem.TabIndex = 3;
            this.lblPorigem.Text = "Planeta de Origem:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OVNIManager3._0.Properties.Resources.existem_muitos_alienigenas_que_estao_em_um_circulo_gerador_de_ia_958124_31331;
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nudeTripulantes
            // 
            this.nudeTripulantes.Location = new System.Drawing.Point(396, 87);
            this.nudeTripulantes.Name = "nudeTripulantes";
            this.nudeTripulantes.Size = new System.Drawing.Size(103, 20);
            this.nudeTripulantes.TabIndex = 5;
            // 
            // nudeAbduzidos
            // 
            this.nudeAbduzidos.Location = new System.Drawing.Point(396, 61);
            this.nudeAbduzidos.Name = "nudeAbduzidos";
            this.nudeAbduzidos.Size = new System.Drawing.Size(103, 20);
            this.nudeAbduzidos.TabIndex = 6;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(396, 113);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(103, 21);
            this.cmbPlaneta.TabIndex = 7;
            //this.cmbPlaneta.SelectedIndexChanged += new System.EventHandler(this.cmbPlaneta_SelectedIndexChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnIniciar.Image = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328__1_;
            this.btnIniciar.Location = new System.Drawing.Point(288, 150);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(214, 43);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblAbduzidos.Image = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328__1_;
            this.lblAbduzidos.Location = new System.Drawing.Point(285, 63);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(95, 16);
            this.lblAbduzidos.TabIndex = 9;
            this.lblAbduzidos.Text = "Max.Abdzidos:";
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OVNIManager3._0.Properties.Resources.Captura_de_tela_2023_11_07_200328;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 216);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.nudeAbduzidos);
            this.Controls.Add(this.nudeTripulantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPorigem);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudeAbduzidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPorigem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudeTripulantes;
        private System.Windows.Forms.NumericUpDown nudeAbduzidos;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblAbduzidos;
    }
}