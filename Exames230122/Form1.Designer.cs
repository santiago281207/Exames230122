namespace Exames230122
{
    partial class Form1
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnPresenca = new System.Windows.Forms.Button();
            this.ltbRegistos = new System.Windows.Forms.ListBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MMMM/yyyy";
            this.dtpData.Location = new System.Drawing.Point(12, 35);
            this.dtpData.MinDate = new System.DateTime(2026, 5, 16, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 0;
            this.dtpData.Value = new System.DateTime(2026, 5, 16, 0, 0, 0, 0);
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(246, 35);
            this.txtAluno.MaxLength = 6;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(100, 20);
            this.txtAluno.TabIndex = 1;
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluno_KeyPress);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(12, 75);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnPresenca
            // 
            this.btnPresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenca.Location = new System.Drawing.Point(246, 75);
            this.btnPresenca.Name = "btnPresenca";
            this.btnPresenca.Size = new System.Drawing.Size(100, 30);
            this.btnPresenca.TabIndex = 3;
            this.btnPresenca.Text = "Presença";
            this.btnPresenca.UseVisualStyleBackColor = true;
            this.btnPresenca.Click += new System.EventHandler(this.btnPresenca_Click);
            // 
            // ltbRegistos
            // 
            this.ltbRegistos.FormattingEnabled = true;
            this.ltbRegistos.Location = new System.Drawing.Point(12, 111);
            this.ltbRegistos.Name = "ltbRegistos";
            this.ltbRegistos.Size = new System.Drawing.Size(334, 251);
            this.ltbRegistos.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 19);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(243, 19);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(34, 13);
            this.lblAluno.TabIndex = 6;
            this.lblAluno.Text = "Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 375);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.ltbRegistos);
            this.Controls.Add(this.btnPresenca);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnPresenca;
        private System.Windows.Forms.ListBox ltbRegistos;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAluno;
    }
}

