namespace OrdenacaoInsercao
{
    partial class Insercao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContadorOrd = new System.Windows.Forms.Label();
            this.lblContadorRand = new System.Windows.Forms.Label();
            this.txtInteiros = new System.Windows.Forms.TextBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOrdenados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Maroon;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(249, 53);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(299, 78);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Maroon;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(249, 238);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(299, 76);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Números a Ordenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(551, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Números Ordenados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tempo:";
            // 
            // lblContadorOrd
            // 
            this.lblContadorOrd.AutoSize = true;
            this.lblContadorOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorOrd.ForeColor = System.Drawing.Color.White;
            this.lblContadorOrd.Location = new System.Drawing.Point(649, 428);
            this.lblContadorOrd.Name = "lblContadorOrd";
            this.lblContadorOrd.Size = new System.Drawing.Size(58, 13);
            this.lblContadorOrd.TabIndex = 14;
            this.lblContadorOrd.Text = "Contador";
            // 
            // lblContadorRand
            // 
            this.lblContadorRand.AutoSize = true;
            this.lblContadorRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorRand.ForeColor = System.Drawing.Color.White;
            this.lblContadorRand.Location = new System.Drawing.Point(96, 428);
            this.lblContadorRand.Name = "lblContadorRand";
            this.lblContadorRand.Size = new System.Drawing.Size(58, 13);
            this.lblContadorRand.TabIndex = 15;
            this.lblContadorRand.Text = "Contador";
            // 
            // txtInteiros
            // 
            this.txtInteiros.Location = new System.Drawing.Point(15, 53);
            this.txtInteiros.Multiline = true;
            this.txtInteiros.Name = "txtInteiros";
            this.txtInteiros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInteiros.Size = new System.Drawing.Size(228, 355);
            this.txtInteiros.TabIndex = 16;
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Maroon;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(249, 154);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(299, 78);
            this.btnManual.TabIndex = 17;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(249, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 76);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zerar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOrdenados
            // 
            this.txtOrdenados.BackColor = System.Drawing.Color.Goldenrod;
            this.txtOrdenados.Location = new System.Drawing.Point(554, 53);
            this.txtOrdenados.Multiline = true;
            this.txtOrdenados.Name = "txtOrdenados";
            this.txtOrdenados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrdenados.Size = new System.Drawing.Size(228, 355);
            this.txtOrdenados.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "* Um número por linha";
            // 
            // Insercao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrdenados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.txtInteiros);
            this.Controls.Add(this.lblContadorRand);
            this.Controls.Add(this.lblContadorOrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "Insercao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insercao";
            this.Load += new System.EventHandler(this.Insercao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContadorOrd;
        private System.Windows.Forms.Label lblContadorRand;
        private System.Windows.Forms.TextBox txtInteiros;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOrdenados;
        private System.Windows.Forms.Label label4;
    }
}

