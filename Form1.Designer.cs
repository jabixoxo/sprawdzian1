
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSzyfr = new System.Windows.Forms.TextBox();
            this.nUpDn = new System.Windows.Forms.NumericUpDown();
            this.chckMale = new System.Windows.Forms.CheckBox();
            this.chckDuze = new System.Windows.Forms.CheckBox();
            this.chckLiczby = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSzyfr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "wpisz tekst do zaszyfrowania";
            // 
            // txtSzyfr
            // 
            this.txtSzyfr.Location = new System.Drawing.Point(275, 69);
            this.txtSzyfr.Name = "txtSzyfr";
            this.txtSzyfr.Size = new System.Drawing.Size(212, 20);
            this.txtSzyfr.TabIndex = 1;
            this.txtSzyfr.TextChanged += new System.EventHandler(this.txtSzyfr_TextChanged);
            // 
            // nUpDn
            // 
            this.nUpDn.Location = new System.Drawing.Point(33, 129);
            this.nUpDn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUpDn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDn.Name = "nUpDn";
            this.nUpDn.Size = new System.Drawing.Size(33, 20);
            this.nUpDn.TabIndex = 2;
            this.nUpDn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDn.ValueChanged += new System.EventHandler(this.nUpDn_ValueChanged);
            // 
            // chckMale
            // 
            this.chckMale.AutoSize = true;
            this.chckMale.Location = new System.Drawing.Point(103, 131);
            this.chckMale.Name = "chckMale";
            this.chckMale.Size = new System.Drawing.Size(46, 17);
            this.chckMale.TabIndex = 3;
            this.chckMale.Text = "a - z";
            this.chckMale.UseVisualStyleBackColor = true;
            this.chckMale.CheckedChanged += new System.EventHandler(this.chckMale_CheckedChanged);
            // 
            // chckDuze
            // 
            this.chckDuze.AutoSize = true;
            this.chckDuze.Location = new System.Drawing.Point(189, 131);
            this.chckDuze.Name = "chckDuze";
            this.chckDuze.Size = new System.Drawing.Size(49, 17);
            this.chckDuze.TabIndex = 4;
            this.chckDuze.Text = "A - Z";
            this.chckDuze.UseVisualStyleBackColor = true;
            this.chckDuze.CheckedChanged += new System.EventHandler(this.chckDuze_CheckedChanged);
            // 
            // chckLiczby
            // 
            this.chckLiczby.AutoSize = true;
            this.chckLiczby.Location = new System.Drawing.Point(275, 130);
            this.chckLiczby.Name = "chckLiczby";
            this.chckLiczby.Size = new System.Drawing.Size(47, 17);
            this.chckLiczby.TabIndex = 5;
            this.chckLiczby.Text = "0 - 9";
            this.chckLiczby.UseVisualStyleBackColor = true;
            this.chckLiczby.CheckedChanged += new System.EventHandler(this.chckLiczby_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // btnSzyfr
            // 
            this.btnSzyfr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSzyfr.Location = new System.Drawing.Point(375, 130);
            this.btnSzyfr.Name = "btnSzyfr";
            this.btnSzyfr.Size = new System.Drawing.Size(75, 23);
            this.btnSzyfr.TabIndex = 7;
            this.btnSzyfr.Text = "Szyfruj";
            this.btnSzyfr.UseVisualStyleBackColor = false;
            this.btnSzyfr.Click += new System.EventHandler(this.btnSzyfr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(371, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SZYFR CEZARA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSzyfr);
            this.Controls.Add(this.chckLiczby);
            this.Controls.Add(this.chckDuze);
            this.Controls.Add(this.chckMale);
            this.Controls.Add(this.nUpDn);
            this.Controls.Add(this.txtSzyfr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplikacja Okienkowa";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSzyfr;
        private System.Windows.Forms.NumericUpDown nUpDn;
        private System.Windows.Forms.CheckBox chckMale;
        private System.Windows.Forms.CheckBox chckDuze;
        private System.Windows.Forms.CheckBox chckLiczby;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Button btnSzyfr;
        private System.Windows.Forms.Label label2;
    }
}

