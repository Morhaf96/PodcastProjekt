﻿namespace PodcastProjekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.dgvPod = new System.Windows.Forms.DataGridView();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.lvKat = new System.Windows.Forms.ListView();
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
            this.lblBeskrivning = new System.Windows.Forms.Label();
            this.lvlKateogir = new System.Windows.Forms.Label();
            this.lblUppdateringsintervall = new System.Windows.Forms.Label();
            this.cmbUppdatering = new System.Windows.Forms.ComboBox();
            this.wbBeskrivning = new System.Windows.Forms.WebBrowser();
            this.lblAvsnittTitel = new System.Windows.Forms.Label();
            this.clmAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUppdateringsfrekvens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvPod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAvsnitt,
            this.clmNamn,
            this.clmUppdateringsfrekvens,
            this.clmKategori});
            this.dgvPod.Location = new System.Drawing.Point(12, 28);
            this.dgvPod.Name = "dgvPod";
            this.dgvPod.Size = new System.Drawing.Size(466, 151);
            this.dgvPod.TabIndex = 3;
            this.dgvPod.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPod_CellValueChanged);
            this.dgvPod.SelectionChanged += new System.EventHandler(this.dgvPod_SelectionChanged);
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 294);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(466, 199);
            this.lbAvsnitt.TabIndex = 4;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged);
            // 
            // lvKat
            // 
            this.lvKat.HideSelection = false;
            this.lvKat.LabelEdit = true;
            this.lvKat.Location = new System.Drawing.Point(552, 31);
            this.lvKat.Name = "lvKat";
            this.lvKat.Size = new System.Drawing.Size(325, 148);
            this.lvKat.TabIndex = 5;
            this.lvKat.UseCompatibleStateImageBehavior = false;
            this.lvKat.SelectedIndexChanged += new System.EventHandler(this.lvKat_SelectedIndexChanged);
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
            this.btnLaggTillPod.Click += new System.EventHandler(this.btnLaggTillPod_Click);
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
            // lblBeskrivning
            // 
            this.lblBeskrivning.AutoSize = true;
            this.lblBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeskrivning.Location = new System.Drawing.Point(523, 273);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(93, 16);
            this.lblBeskrivning.TabIndex = 19;
            this.lblBeskrivning.Text = "Beskrivning:";
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
            // cmbUppdatering
            // 
            this.cmbUppdatering.FormattingEnabled = true;
            this.cmbUppdatering.Items.AddRange(new object[] {
            "1 min",
            "3 min",
            "5 min",
            "10 min"});
            this.cmbUppdatering.Location = new System.Drawing.Point(160, 245);
            this.cmbUppdatering.Name = "cmbUppdatering";
            this.cmbUppdatering.Size = new System.Drawing.Size(172, 21);
            this.cmbUppdatering.TabIndex = 22;
            this.cmbUppdatering.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wbBeskrivning
            // 
            this.wbBeskrivning.Location = new System.Drawing.Point(532, 294);
            this.wbBeskrivning.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBeskrivning.Name = "wbBeskrivning";
            this.wbBeskrivning.Size = new System.Drawing.Size(345, 198);
            this.wbBeskrivning.TabIndex = 23;
            // 
            // lblAvsnittTitel
            // 
            this.lblAvsnittTitel.AutoSize = true;
            this.lblAvsnittTitel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittTitel.Location = new System.Drawing.Point(625, 268);
            this.lblAvsnittTitel.Name = "lblAvsnittTitel";
            this.lblAvsnittTitel.Size = new System.Drawing.Size(0, 19);
            this.lblAvsnittTitel.TabIndex = 24;
            // 
            // clmAvsnitt
            // 
            this.clmAvsnitt.HeaderText = "Avsnitt";
            this.clmAvsnitt.Name = "clmAvsnitt";
            // 
            // clmNamn
            // 
            this.clmNamn.HeaderText = "Namn";
            this.clmNamn.Name = "clmNamn";
            // 
            // clmUppdateringsfrekvens
            // 
            this.clmUppdateringsfrekvens.HeaderText = "Uppdateringsfrekvens";
            this.clmUppdateringsfrekvens.MinimumWidth = 11;
            this.clmUppdateringsfrekvens.Name = "clmUppdateringsfrekvens";
            // 
            // clmKategori
            // 
            this.clmKategori.HeaderText = "Kategori";
            this.clmKategori.Name = "clmKategori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 513);
            this.Controls.Add(this.lblAvsnittTitel);
            this.Controls.Add(this.wbBeskrivning);
            this.Controls.Add(this.cmbUppdatering);
            this.Controls.Add(this.lblUppdateringsintervall);
            this.Controls.Add(this.lvlKateogir);
            this.Controls.Add(this.lblBeskrivning);
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
        private System.Windows.Forms.Label lblBeskrivning;
        private System.Windows.Forms.Label lvlKateogir;
        private System.Windows.Forms.Label lblUppdateringsintervall;
        private System.Windows.Forms.ComboBox cmbUppdatering;
        private System.Windows.Forms.WebBrowser wbBeskrivning;
        private System.Windows.Forms.Label lblAvsnittTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUppdateringsfrekvens;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKategori;
    }
}

