
namespace TugasTiga1
{
    partial class Form1
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
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblIsiNim = new System.Windows.Forms.Label();
            this.lblIsiNama = new System.Windows.Forms.Label();
            this.lblIsiKelas = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(12, 24);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(27, 13);
            this.lblNim.TabIndex = 0;
            this.lblNim.Text = "NIM";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 44);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(12, 64);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(33, 13);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas";
            // 
            // lblIsiNim
            // 
            this.lblIsiNim.AutoSize = true;
            this.lblIsiNim.Location = new System.Drawing.Point(75, 24);
            this.lblIsiNim.Name = "lblIsiNim";
            this.lblIsiNim.Size = new System.Drawing.Size(67, 13);
            this.lblIsiNim.TabIndex = 3;
            this.lblIsiNim.Text = ": 20.11.3637";
            // 
            // lblIsiNama
            // 
            this.lblIsiNama.AutoSize = true;
            this.lblIsiNama.Location = new System.Drawing.Point(75, 44);
            this.lblIsiNama.Name = "lblIsiNama";
            this.lblIsiNama.Size = new System.Drawing.Size(135, 13);
            this.lblIsiNama.TabIndex = 4;
            this.lblIsiNama.Text = ": Darussalaam Nur Rasyidu";
            // 
            // lblIsiKelas
            // 
            this.lblIsiKelas.AutoSize = true;
            this.lblIsiKelas.Location = new System.Drawing.Point(75, 64);
            this.lblIsiKelas.Name = "lblIsiKelas";
            this.lblIsiKelas.Size = new System.Drawing.Size(65, 13);
            this.lblIsiKelas.TabIndex = 5;
            this.lblIsiKelas.Text = ": 20-S1IF-06";
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(54, 99);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 6;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(135, 99);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(75, 23);
            this.btnKosongkan.TabIndex = 7;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 153);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.lblIsiKelas);
            this.Controls.Add(this.lblIsiNama);
            this.Controls.Add(this.lblIsiNim);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblIsiNim;
        private System.Windows.Forms.Label lblIsiNama;
        private System.Windows.Forms.Label lblIsiKelas;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKosongkan;
    }
}

