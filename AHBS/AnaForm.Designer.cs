namespace AHBS
{
    partial class AnaForm
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
            this.btnCikis1 = new System.Windows.Forms.Button();
            this.btnHastaKabul = new System.Windows.Forms.Button();
            this.btnHastaislem = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnDoktorİs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis1
            // 
            this.btnCikis1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis1.Image = global::AHBS.Properties.Resources.cikis;
            this.btnCikis1.Location = new System.Drawing.Point(740, 10);
            this.btnCikis1.Name = "btnCikis1";
            this.btnCikis1.Size = new System.Drawing.Size(170, 150);
            this.btnCikis1.TabIndex = 9;
            this.btnCikis1.Text = "Çıkış";
            this.btnCikis1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis1.UseVisualStyleBackColor = false;
            this.btnCikis1.Click += new System.EventHandler(this.btnCikis1_Click);
            // 
            // btnHastaKabul
            // 
            this.btnHastaKabul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaKabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKabul.Image = global::AHBS.Properties.Resources.hastakabul;
            this.btnHastaKabul.Location = new System.Drawing.Point(570, 10);
            this.btnHastaKabul.Name = "btnHastaKabul";
            this.btnHastaKabul.Size = new System.Drawing.Size(170, 150);
            this.btnHastaKabul.TabIndex = 8;
            this.btnHastaKabul.Text = "Hasta Kabul";
            this.btnHastaKabul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHastaKabul.UseVisualStyleBackColor = false;
            this.btnHastaKabul.Click += new System.EventHandler(this.btnHastaKabul_Click);
            // 
            // btnHastaislem
            // 
            this.btnHastaislem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHastaislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaislem.Image = global::AHBS.Properties.Resources.hastaislem;
            this.btnHastaislem.Location = new System.Drawing.Point(400, 10);
            this.btnHastaislem.Name = "btnHastaislem";
            this.btnHastaislem.Size = new System.Drawing.Size(170, 150);
            this.btnHastaislem.TabIndex = 7;
            this.btnHastaislem.Text = "Hasta İşlemleri";
            this.btnHastaislem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHastaislem.UseVisualStyleBackColor = false;
            this.btnHastaislem.Click += new System.EventHandler(this.btnHastaislem_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuayene.BackgroundImage = global::AHBS.Properties.Resources.muayene;
            this.btnMuayene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayene.Location = new System.Drawing.Point(230, 10);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(170, 150);
            this.btnMuayene.TabIndex = 6;
            this.btnMuayene.Text = "Muayene";
            this.btnMuayene.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuayene.UseVisualStyleBackColor = false;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnDoktorİs
            // 
            this.btnDoktorİs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoktorİs.BackgroundImage = global::AHBS.Properties.Resources.indir;
            this.btnDoktorİs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoktorİs.CausesValidation = false;
            this.btnDoktorİs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorİs.Location = new System.Drawing.Point(60, 10);
            this.btnDoktorİs.Name = "btnDoktorİs";
            this.btnDoktorİs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDoktorİs.Size = new System.Drawing.Size(170, 150);
            this.btnDoktorİs.TabIndex = 5;
            this.btnDoktorİs.Text = "Doktor İşlemleri";
            this.btnDoktorİs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoktorİs.UseVisualStyleBackColor = false;
            this.btnDoktorİs.Click += new System.EventHandler(this.btnDoktorİs_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnCikis1);
            this.Controls.Add(this.btnHastaKabul);
            this.Controls.Add(this.btnHastaislem);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.btnDoktorİs);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aile Hekimliği Bilgi Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorİs;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.Button btnHastaislem;
        private System.Windows.Forms.Button btnHastaKabul;
        private System.Windows.Forms.Button btnCikis1;
    }
}