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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.dgvPod = new System.Windows.Forms.DataGridView();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.lvKat = new System.Windows.Forms.ListView();
            this.tlpDetalj = new System.Windows.Forms.TableLayoutPanel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnLaggTillPod = new System.Windows.Forms.Button();
            this.btnTaBortPod = new System.Windows.Forms.Button();
            this.txbKategori = new System.Windows.Forms.TextBox();
            this.lblKatnamn = new System.Windows.Forms.Label();
            this.btnLaggTillKat = new System.Windows.Forms.Button();
            this.btnTaBortKat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 267);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(179, 21);
            this.cmbKategori.TabIndex = 0;
            // 
            // dgvPod
            // 
            this.dgvPod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPod.Location = new System.Drawing.Point(12, 12);
            this.dgvPod.Name = "dgvPod";
            this.dgvPod.Size = new System.Drawing.Size(316, 190);
            this.dgvPod.TabIndex = 3;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 294);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(316, 186);
            this.lbAvsnitt.TabIndex = 4;
            // 
            // lvKat
            // 
            this.lvKat.HideSelection = false;
            this.lvKat.Location = new System.Drawing.Point(351, 12);
            this.lvKat.Name = "lvKat";
            this.lvKat.Size = new System.Drawing.Size(390, 199);
            this.lvKat.TabIndex = 5;
            this.lvKat.UseCompatibleStateImageBehavior = false;
            // 
            // tlpDetalj
            // 
            this.tlpDetalj.ColumnCount = 2;
            this.tlpDetalj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalj.Location = new System.Drawing.Point(351, 294);
            this.tlpDetalj.Name = "tlpDetalj";
            this.tlpDetalj.RowCount = 2;
            this.tlpDetalj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tlpDetalj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tlpDetalj.Size = new System.Drawing.Size(390, 186);
            this.tlpDetalj.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(12, 247);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 16);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Katergori:";
            this.lblKategori.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(12, 224);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(179, 20);
            this.txbUrl.TabIndex = 8;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(12, 205);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 16);
            this.lblUrl.TabIndex = 9;
            this.lblUrl.Text = "URL:";
            // 
            // btnLaggTillPod
            // 
            this.btnLaggTillPod.Location = new System.Drawing.Point(206, 221);
            this.btnLaggTillPod.Name = "btnLaggTillPod";
            this.btnLaggTillPod.Size = new System.Drawing.Size(115, 23);
            this.btnLaggTillPod.TabIndex = 10;
            this.btnLaggTillPod.Text = "Lägg till podcast";
            this.btnLaggTillPod.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPod
            // 
            this.btnTaBortPod.Location = new System.Drawing.Point(206, 265);
            this.btnTaBortPod.Name = "btnTaBortPod";
            this.btnTaBortPod.Size = new System.Drawing.Size(115, 23);
            this.btnTaBortPod.TabIndex = 11;
            this.btnTaBortPod.Text = "Ta bort podcast";
            this.btnTaBortPod.UseVisualStyleBackColor = true;
            // 
            // txbKategori
            // 
            this.txbKategori.Location = new System.Drawing.Point(351, 247);
            this.txbKategori.Name = "txbKategori";
            this.txbKategori.Size = new System.Drawing.Size(125, 20);
            this.txbKategori.TabIndex = 12;
            // 
            // lblKatnamn
            // 
            this.lblKatnamn.AutoSize = true;
            this.lblKatnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatnamn.Location = new System.Drawing.Point(348, 221);
            this.lblKatnamn.Name = "lblKatnamn";
            this.lblKatnamn.Size = new System.Drawing.Size(118, 16);
            this.lblKatnamn.TabIndex = 13;
            this.lblKatnamn.Text = "Namn på kategori:";
            // 
            // btnLaggTillKat
            // 
            this.btnLaggTillKat.Location = new System.Drawing.Point(552, 220);
            this.btnLaggTillKat.Name = "btnLaggTillKat";
            this.btnLaggTillKat.Size = new System.Drawing.Size(129, 24);
            this.btnLaggTillKat.TabIndex = 14;
            this.btnLaggTillKat.Text = "Lägg till kategori";
            this.btnLaggTillKat.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKat
            // 
            this.btnTaBortKat.Location = new System.Drawing.Point(552, 265);
            this.btnTaBortKat.Name = "btnTaBortKat";
            this.btnTaBortKat.Size = new System.Drawing.Size(129, 23);
            this.btnTaBortKat.TabIndex = 15;
            this.btnTaBortKat.Text = "Ta bort kategori";
            this.btnTaBortKat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(753, 487);
            this.Controls.Add(this.btnTaBortKat);
            this.Controls.Add(this.btnLaggTillKat);
            this.Controls.Add(this.lblKatnamn);
            this.Controls.Add(this.txbKategori);
            this.Controls.Add(this.btnTaBortPod);
            this.Controls.Add(this.btnLaggTillPod);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.tlpDetalj);
            this.Controls.Add(this.lvKat);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.dgvPod);
            this.Controls.Add(this.cmbKategori);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcast RSS Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.DataGridView dgvPod;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.ListView lvKat;
        private System.Windows.Forms.TableLayoutPanel tlpDetalj;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnLaggTillPod;
        private System.Windows.Forms.Button btnTaBortPod;
        private System.Windows.Forms.TextBox txbKategori;
        private System.Windows.Forms.Label lblKatnamn;
        private System.Windows.Forms.Button btnLaggTillKat;
        private System.Windows.Forms.Button btnTaBortKat;
    }
}

