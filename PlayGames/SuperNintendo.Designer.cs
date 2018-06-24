namespace PlayGames
{
    partial class Frm_SuperNintendo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SuperNintendo));
            this.ListaRoms = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.Btn_load = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaRoms
            // 
            this.ListaRoms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaRoms.FormattingEnabled = true;
            this.ListaRoms.Location = new System.Drawing.Point(12, 131);
            this.ListaRoms.Name = "ListaRoms";
            this.ListaRoms.Size = new System.Drawing.Size(480, 485);
            this.ListaRoms.TabIndex = 0;
            this.ListaRoms.SelectedIndexChanged += new System.EventHandler(this.ListaRoms_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowser1.Location = new System.Drawing.Point(567, 131);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(374, 220);
            this.webBrowser1.TabIndex = 1;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBrowser2.Location = new System.Drawing.Point(567, 393);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(374, 197);
            this.webBrowser2.TabIndex = 2;
            // 
            // Btn_load
            // 
            this.Btn_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_load.Location = new System.Drawing.Point(567, 102);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(114, 23);
            this.Btn_load.TabIndex = 3;
            this.Btn_load.Text = "Load Roms";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_play.Location = new System.Drawing.Point(827, 102);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(114, 23);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.Location = new System.Drawing.Point(392, 102);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(100, 23);
            this.lbl_qtd.TabIndex = 5;
            this.lbl_qtd.Text = "Roms =";
            this.lbl_qtd.Click += new System.EventHandler(this.lbl_qtd_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(311, 102);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Frm_SuperNintendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ListaRoms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SuperNintendo";
            this.Text = "SuperNintendo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaRoms;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Button btn_voltar;
    }
}