namespace AHBS
{
    partial class Hastaislemform
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
            this.txtHastara = new System.Windows.Forms.TextBox();
            this.cmbbxHara = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHcikis = new System.Windows.Forms.Button();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnHastaara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHastara
            // 
            this.txtHastara.Location = new System.Drawing.Point(220, 60);
            this.txtHastara.Multiline = true;
            this.txtHastara.Name = "txtHastara";
            this.txtHastara.Size = new System.Drawing.Size(120, 24);
            this.txtHastara.TabIndex = 0;
            // 
            // cmbbxHara
            // 
            this.cmbbxHara.FormattingEnabled = true;
            this.cmbbxHara.Items.AddRange(new object[] {
            "Tümü",
            "TcKimlik",
            "Ad"});
            this.cmbbxHara.Location = new System.Drawing.Point(357, 60);
            this.cmbbxHara.Name = "cmbbxHara";
            this.cmbbxHara.Size = new System.Drawing.Size(120, 24);
            this.cmbbxHara.TabIndex = 1;
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
            this.dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AHBS.Properties.Resources.indir2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnHcikis
            // 
            this.btnHcikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHcikis.BackgroundImage = global::AHBS.Properties.Resources.Go_back;
            this.btnHcikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHcikis.Location = new System.Drawing.Point(810, 550);
            this.btnHcikis.Name = "btnHcikis";
            this.btnHcikis.Size = new System.Drawing.Size(120, 100);
            this.btnHcikis.TabIndex = 11;
            this.btnHcikis.Text = "Geri Dön";
            this.btnHcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHcikis.UseVisualStyleBackColor = false;
            this.btnHcikis.Click += new System.EventHandler(this.btnHcikis_Click);
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaSil.BackgroundImage = global::AHBS.Properties.Resources.delete;
            this.btnHastaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaSil.Location = new System.Drawing.Point(690, 550);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(120, 100);
            this.btnHastaSil.TabIndex = 10;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaSil.UseVisualStyleBackColor = false;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaEkle.BackgroundImage = global::AHBS.Properties.Resources.doktorekle;
            this.btnHastaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaEkle.Location = new System.Drawing.Point(570, 550);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(120, 100);
            this.btnHastaEkle.TabIndex = 9;
            this.btnHastaEkle.Text = "Ekle";
            this.btnHastaEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnHastaara
            // 
            this.btnHastaara.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaara.Image = global::AHBS.Properties.Resources.ara;
            this.btnHastaara.Location = new System.Drawing.Point(550, 15);
            this.btnHastaara.Name = "btnHastaara";
            this.btnHastaara.Size = new System.Drawing.Size(120, 110);
            this.btnHastaara.TabIndex = 4;
            this.btnHastaara.Text = "Ara";
            this.btnHastaara.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHastaara.UseVisualStyleBackColor = false;
            this.btnHastaara.Click += new System.EventHandler(this.btnHastaara_Click);
            // 
            // Hastaislemform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHcikis);
            this.Controls.Add(this.btnHastaSil);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHastaara);
            this.Controls.Add(this.cmbbxHara);
            this.Controls.Add(this.txtHastara);
            this.Name = "Hastaislemform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.Hastaislemform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastara;
        private System.Windows.Forms.ComboBox cmbbxHara;
        private System.Windows.Forms.Button btnHastaara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnHastaSil;
        private System.Windows.Forms.Button btnHcikis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}