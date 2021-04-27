
namespace Métodos
{
    partial class frmExercício3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.tbPalavra1 = new System.Windows.Forms.TextBox();
            this.tbPalavra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btInvert = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.tbPalavra1);
            this.groupBox1.Controls.Add(this.tbPalavra2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btInvert);
            this.groupBox1.Controls.Add(this.btReplace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(6, 288);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(227, 95);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover ocorrências";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            // 
            // btInvert
            // 
            this.btInvert.Location = new System.Drawing.Point(532, 288);
            this.btInvert.Name = "btInvert";
            this.btInvert.Size = new System.Drawing.Size(227, 95);
            this.btInvert.TabIndex = 6;
            this.btInvert.Text = "Inverte";
            this.btInvert.UseVisualStyleBackColor = true;
            this.btInvert.Click += new System.EventHandler(this.btInvert_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(261, 288);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(227, 95);
            this.btReplace.TabIndex = 5;
            this.btReplace.Text = "Remover ocorrências (Replace)";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra 2";
            // 
            // frmExercício3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExercício3";
            this.Text = "frmExercício3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbPalavra1;
        private System.Windows.Forms.TextBox tbPalavra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInvert;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Label label2;
    }
}