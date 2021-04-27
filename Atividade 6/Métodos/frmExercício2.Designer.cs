
namespace Métodos
{
    partial class frmExercício2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPalavra1 = new System.Windows.Forms.TextBox();
            this.tbPalavra2 = new System.Windows.Forms.TextBox();
            this.btVerifica = new System.Windows.Forms.Button();
            this.btMeio = new System.Windows.Forms.Button();
            this.btAsterisco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPalavra1
            // 
            this.tbPalavra1.Location = new System.Drawing.Point(261, 62);
            this.tbPalavra1.Name = "tbPalavra1";
            this.tbPalavra1.Size = new System.Drawing.Size(149, 26);
            this.tbPalavra1.TabIndex = 2;
            // 
            // tbPalavra2
            // 
            this.tbPalavra2.Location = new System.Drawing.Point(261, 152);
            this.tbPalavra2.Name = "tbPalavra2";
            this.tbPalavra2.Size = new System.Drawing.Size(150, 26);
            this.tbPalavra2.TabIndex = 3;
            // 
            // btVerifica
            // 
            this.btVerifica.Location = new System.Drawing.Point(6, 288);
            this.btVerifica.Name = "btVerifica";
            this.btVerifica.Size = new System.Drawing.Size(227, 95);
            this.btVerifica.TabIndex = 4;
            this.btVerifica.Text = "Verificar se são iguais";
            this.btVerifica.UseVisualStyleBackColor = true;
            this.btVerifica.Click += new System.EventHandler(this.btVerifica_Click);
            // 
            // btMeio
            // 
            this.btMeio.Location = new System.Drawing.Point(261, 288);
            this.btMeio.Name = "btMeio";
            this.btMeio.Size = new System.Drawing.Size(227, 95);
            this.btMeio.TabIndex = 5;
            this.btMeio.Text = "Inserir a palavra 1 no meio da palavra 2";
            this.btMeio.UseVisualStyleBackColor = true;
            this.btMeio.Click += new System.EventHandler(this.btMeio_Click);
            // 
            // btAsterisco
            // 
            this.btAsterisco.Location = new System.Drawing.Point(532, 288);
            this.btAsterisco.Name = "btAsterisco";
            this.btAsterisco.Size = new System.Drawing.Size(227, 95);
            this.btAsterisco.TabIndex = 6;
            this.btAsterisco.Text = "Inserir Asteríscos no meio da palavra 1";
            this.btAsterisco.UseVisualStyleBackColor = true;
            this.btAsterisco.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerifica);
            this.groupBox1.Controls.Add(this.tbPalavra1);
            this.groupBox1.Controls.Add(this.tbPalavra2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAsterisco);
            this.groupBox1.Controls.Add(this.btMeio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frmExercício2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExercício2";
            this.Text = "frmExercício2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPalavra1;
        private System.Windows.Forms.TextBox tbPalavra2;
        private System.Windows.Forms.Button btVerifica;
        private System.Windows.Forms.Button btMeio;
        private System.Windows.Forms.Button btAsterisco;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}