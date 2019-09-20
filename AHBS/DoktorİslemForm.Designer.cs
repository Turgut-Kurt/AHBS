namespace AHBS
{
    partial class DoktorİslemForm
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
            this.txtDoktorAra = new System.Windows.Forms.TextBox();
            this.cmbbxDokAraSecim = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis2 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnMEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoktorAra
            // 
            this.txtDoktorAra.Location = new System.Drawing.Point(220, 60);
            this.txtDoktorAra.Multiline = true;
            this.txtDoktorAra.Name = "txtDoktorAra";
            this.txtDoktorAra.Size = new System.Drawing.Size(120, 24);
            this.txtDoktorAra.TabIndex = 0;
            // 
            // cmbbxDokAraSecim
            // 
            this.cmbbxDokAraSecim.FormattingEnabled = true;
            this.cmbbxDokAraSecim.Items.AddRange(new object[] {
            "Tümü",
            "Tc Kimlik",
            "Adı Soyadı",
            "Sicil No",
            "Cep Tel",
            "Ev Tel",
            "Adres",
            "E Mail"});
            this.cmbbxDokAraSecim.Location = new System.Drawing.Point(360, 60);
            this.cmbbxDokAraSecim.Name = "cmbbxDokAraSecim";
            this.cmbbxDokAraSecim.Size = new System.Drawing.Size(120, 24);
            this.cmbbxDokAraSecim.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 400);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::AHBS.Properties.Resources.doctor;
            this.pictureBox1.Image = global::AHBS.Properties.Resources.doctor1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis2
            // 
            this.btnCikis2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis2.BackgroundImage = global::AHBS.Properties.Resources.Go_back;
            this.btnCikis2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis2.Location = new System.Drawing.Point(810, 550);
            this.btnCikis2.Name = "btnCikis2";
            this.btnCikis2.Size = new System.Drawing.Size(120, 100);
            this.btnCikis2.TabIndex = 6;
            this.btnCikis2.Text = "Geri Dön";
            this.btnCikis2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis2.UseVisualStyleBackColor = false;
            this.btnCikis2.Click += new System.EventHandler(this.btnCikis2_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.BackgroundImage = global::AHBS.Properties.Resources.delete;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(690, 550);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 100);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMEkle
            // 
            this.btnMEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMEkle.BackgroundImage = global::AHBS.Properties.Resources.doktorekleee;
            this.btnMEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMEkle.Location = new System.Drawing.Point(570, 550);
            this.btnMEkle.Name = "btnMEkle";
            this.btnMEkle.Size = new System.Drawing.Size(120, 100);
            this.btnMEkle.TabIndex = 4;
            this.btnMEkle.Text = "Ekle";
            this.btnMEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMEkle.UseVisualStyleBackColor = false;
            this.btnMEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = global::AHBS.Properties.Resources.ara;
            this.btnAra.Location = new System.Drawing.Point(550, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(120, 110);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // DoktorİslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnMEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbbxDokAraSecim);
            this.Controls.Add(this.txtDoktorAra);
            this.Name = "DoktorİslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgileri";
            this.Load += new System.EventHandler(this.DoktorİslemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoktorAra;
        private System.Windows.Forms.ComboBox cmbbxDokAraSecim;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnMEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}