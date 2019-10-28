namespace PodcastProjekt
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
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.dgvPod = new System.Windows.Forms.DataGridView();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.lvKat = new System.Windows.Forms.ListView();
            this.tlpDetalj = new System.Windows.Forms.TableLayoutPanel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnLaggTillPod = new System.Windows.Forms.Button();
            this.btnTaBortPod = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.lblKatnamn = new System.Windows.Forms.Label();
            this.btnLaggTillKat = new System.Windows.Forms.Button();
            this.btnTaBortKat = new System.Windows.Forms.Button();
            this.btnSparaKat = new System.Windows.Forms.Button();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblDetaljer = new System.Windows.Forms.Label();
            this.lvlKateogir = new System.Windows.Forms.Label();
            this.lblUppdateringsintervall = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKat
            // 
            this.cmbKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(86, 219);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(246, 21);
            this.cmbKat.TabIndex = 0;
            // 
            // dgvPod
            // 
            this.dgvPod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPod.Location = new System.Drawing.Point(12, 28);
            this.dgvPod.Name = "dgvPod";
            this.dgvPod.Size = new System.Drawing.Size(466, 151);
            this.dgvPod.TabIndex = 3;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 294);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(466, 186);
            this.lbAvsnitt.TabIndex = 4;
            // 
            // lvKat
            // 
            this.lvKat.HideSelection = false;
            this.lvKat.Location = new System.Drawing.Point(552, 31);
            this.lvKat.Name = "lvKat";
            this.lvKat.Size = new System.Drawing.Size(325, 148);
            this.lvKat.TabIndex = 5;
            this.lvKat.UseCompatibleStateImageBehavior = false;
            this.lvKat.SelectedIndexChanged += new System.EventHandler(this.lvKat_SelectedIndexChanged);
            // 
            // tlpDetalj
            // 
            this.tlpDetalj.ColumnCount = 2;
            this.tlpDetalj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalj.Location = new System.Drawing.Point(552, 294);
            this.tlpDetalj.Name = "tlpDetalj";
            this.tlpDetalj.RowCount = 2;
            this.tlpDetalj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlpDetalj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tlpDetalj.Size = new System.Drawing.Size(325, 186);
            this.tlpDetalj.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(15, 220);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 16);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Katergori:";
            this.lblKategori.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(56, 185);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(276, 20);
            this.tbUrl.TabIndex = 8;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(15, 186);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 16);
            this.lblUrl.TabIndex = 9;
            this.lblUrl.Text = "URL:";
            // 
            // btnLaggTillPod
            // 
            this.btnLaggTillPod.Location = new System.Drawing.Point(338, 189);
            this.btnLaggTillPod.Name = "btnLaggTillPod";
            this.btnLaggTillPod.Size = new System.Drawing.Size(140, 30);
            this.btnLaggTillPod.TabIndex = 10;
            this.btnLaggTillPod.Text = "Lägg till podcast";
            this.btnLaggTillPod.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPod
            // 
            this.btnTaBortPod.Location = new System.Drawing.Point(338, 235);
            this.btnTaBortPod.Name = "btnTaBortPod";
            this.btnTaBortPod.Size = new System.Drawing.Size(140, 31);
            this.btnTaBortPod.TabIndex = 11;
            this.btnTaBortPod.Text = "Ta bort markerad podcast";
            this.btnTaBortPod.UseVisualStyleBackColor = true;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(696, 188);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(181, 20);
            this.tbKategori.TabIndex = 12;
            this.tbKategori.Tag = "";
            // 
            // lblKatnamn
            // 
            this.lblKatnamn.AutoSize = true;
            this.lblKatnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatnamn.Location = new System.Drawing.Point(572, 189);
            this.lblKatnamn.Name = "lblKatnamn";
            this.lblKatnamn.Size = new System.Drawing.Size(118, 16);
            this.lblKatnamn.TabIndex = 13;
            this.lblKatnamn.Text = "Namn på kategori:";
            // 
            // btnLaggTillKat
            // 
            this.btnLaggTillKat.Location = new System.Drawing.Point(552, 216);
            this.btnLaggTillKat.Name = "btnLaggTillKat";
            this.btnLaggTillKat.Size = new System.Drawing.Size(108, 33);
            this.btnLaggTillKat.TabIndex = 14;
            this.btnLaggTillKat.Text = "Lägg till kategori";
            this.btnLaggTillKat.UseVisualStyleBackColor = true;
            this.btnLaggTillKat.Click += new System.EventHandler(this.btnLaggTillKat_Click);
            // 
            // btnTaBortKat
            // 
            this.btnTaBortKat.Location = new System.Drawing.Point(771, 217);
            this.btnTaBortKat.Name = "btnTaBortKat";
            this.btnTaBortKat.Size = new System.Drawing.Size(106, 32);
            this.btnTaBortKat.TabIndex = 15;
            this.btnTaBortKat.Text = "Ta bort kategori";
            this.btnTaBortKat.UseVisualStyleBackColor = true;
            this.btnTaBortKat.Click += new System.EventHandler(this.btnTaBortKat_Click);
            // 
            // btnSparaKat
            // 
            this.btnSparaKat.Location = new System.Drawing.Point(666, 217);
            this.btnSparaKat.Name = "btnSparaKat";
            this.btnSparaKat.Size = new System.Drawing.Size(98, 32);
            this.btnSparaKat.TabIndex = 16;
            this.btnSparaKat.Text = "Spara kategori";
            this.btnSparaKat.UseVisualStyleBackColor = true;
            this.btnSparaKat.Click += new System.EventHandler(this.btnSparaKat_Click);
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(12, 9);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(69, 16);
            this.lblPodcast.TabIndex = 17;
            this.lblPodcast.Text = "Podcast:";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(15, 275);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(58, 16);
            this.lblAvsnitt.TabIndex = 18;
            this.lblAvsnitt.Text = "Avsnitt:";
            // 
            // lblDetaljer
            // 
            this.lblDetaljer.AutoSize = true;
            this.lblDetaljer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljer.Location = new System.Drawing.Point(549, 275);
            this.lblDetaljer.Name = "lblDetaljer";
            this.lblDetaljer.Size = new System.Drawing.Size(67, 16);
            this.lblDetaljer.TabIndex = 19;
            this.lblDetaljer.Text = "Detlajer:";
            // 
            // lvlKateogir
            // 
            this.lvlKateogir.AutoSize = true;
            this.lvlKateogir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlKateogir.Location = new System.Drawing.Point(546, 9);
            this.lvlKateogir.Name = "lvlKateogir";
            this.lvlKateogir.Size = new System.Drawing.Size(70, 16);
            this.lvlKateogir.TabIndex = 20;
            this.lvlKateogir.Text = "Kategori:";
            // 
            // lblUppdateringsintervall
            // 
            this.lblUppdateringsintervall.AutoSize = true;
            this.lblUppdateringsintervall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsintervall.Location = new System.Drawing.Point(15, 250);
            this.lblUppdateringsintervall.Name = "lblUppdateringsintervall";
            this.lblUppdateringsintervall.Size = new System.Drawing.Size(139, 16);
            this.lblUppdateringsintervall.TabIndex = 21;
            this.lblUppdateringsintervall.Text = "Uppdateringsintervall:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PodcastProjekt.Properties.Resources._9;
            this.ClientSize = new System.Drawing.Size(889, 493);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUppdateringsintervall);
            this.Controls.Add(this.lvlKateogir);
            this.Controls.Add(this.lblDetaljer);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.btnSparaKat);
            this.Controls.Add(this.btnTaBortKat);
            this.Controls.Add(this.btnLaggTillKat);
            this.Controls.Add(this.lblKatnamn);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.btnTaBortPod);
            this.Controls.Add(this.btnLaggTillPod);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.tlpDetalj);
            this.Controls.Add(this.lvKat);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.dgvPod);
            this.Controls.Add(this.cmbKat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcast RSS Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.DataGridView dgvPod;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.ListView lvKat;
        private System.Windows.Forms.TableLayoutPanel tlpDetalj;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnLaggTillPod;
        private System.Windows.Forms.Button btnTaBortPod;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Label lblKatnamn;
        private System.Windows.Forms.Button btnLaggTillKat;
        private System.Windows.Forms.Button btnTaBortKat;
        private System.Windows.Forms.Button btnSparaKat;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblDetaljer;
        private System.Windows.Forms.Label lvlKateogir;
        private System.Windows.Forms.Label lblUppdateringsintervall;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

