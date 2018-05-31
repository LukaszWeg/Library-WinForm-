namespace Bibloteka
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.książkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytelnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypożyczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKlientówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCzytelnikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPracownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWypożyczeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszeregujWPionieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszeregujWPoziomieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uszegerujKaskadowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.daneToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.widokToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.książkeToolStripMenuItem,
            this.czytelnikaToolStripMenuItem,
            this.pracownikaToolStripMenuItem,
            this.wypożyczenieToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // książkeToolStripMenuItem
            // 
            this.książkeToolStripMenuItem.Name = "książkeToolStripMenuItem";
            this.książkeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.książkeToolStripMenuItem.Text = "Książke";
            this.książkeToolStripMenuItem.Click += new System.EventHandler(this.książkeToolStripMenuItem_Click);
            // 
            // czytelnikaToolStripMenuItem
            // 
            this.czytelnikaToolStripMenuItem.Name = "czytelnikaToolStripMenuItem";
            this.czytelnikaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.czytelnikaToolStripMenuItem.Text = "Czytelnika";
            this.czytelnikaToolStripMenuItem.Click += new System.EventHandler(this.czytelnikaToolStripMenuItem_Click);
            // 
            // pracownikaToolStripMenuItem
            // 
            this.pracownikaToolStripMenuItem.Name = "pracownikaToolStripMenuItem";
            this.pracownikaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pracownikaToolStripMenuItem.Text = "Pracownika";
            this.pracownikaToolStripMenuItem.Click += new System.EventHandler(this.pracownikaToolStripMenuItem_Click);
            // 
            // wypożyczenieToolStripMenuItem
            // 
            this.wypożyczenieToolStripMenuItem.Name = "wypożyczenieToolStripMenuItem";
            this.wypożyczenieToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wypożyczenieToolStripMenuItem.Text = "Wypożyczenie";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKlientówToolStripMenuItem,
            this.listaCzytelnikówToolStripMenuItem,
            this.listaPracownikówToolStripMenuItem,
            this.listaWypożyczeńToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // listaKlientówToolStripMenuItem
            // 
            this.listaKlientówToolStripMenuItem.Name = "listaKlientówToolStripMenuItem";
            this.listaKlientówToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaKlientówToolStripMenuItem.Text = "Lista książek";
            this.listaKlientówToolStripMenuItem.Click += new System.EventHandler(this.listaKlientówToolStripMenuItem_Click);
            // 
            // listaCzytelnikówToolStripMenuItem
            // 
            this.listaCzytelnikówToolStripMenuItem.Name = "listaCzytelnikówToolStripMenuItem";
            this.listaCzytelnikówToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaCzytelnikówToolStripMenuItem.Text = "Lista czytelników";
            this.listaCzytelnikówToolStripMenuItem.Click += new System.EventHandler(this.listaCzytelnikówToolStripMenuItem_Click);
            // 
            // listaPracownikówToolStripMenuItem
            // 
            this.listaPracownikówToolStripMenuItem.Name = "listaPracownikówToolStripMenuItem";
            this.listaPracownikówToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaPracownikówToolStripMenuItem.Text = "Lista pracowników";
            this.listaPracownikówToolStripMenuItem.Click += new System.EventHandler(this.listaPracownikówToolStripMenuItem_Click);
            // 
            // listaWypożyczeńToolStripMenuItem
            // 
            this.listaWypożyczeńToolStripMenuItem.Name = "listaWypożyczeńToolStripMenuItem";
            this.listaWypożyczeńToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaWypożyczeńToolStripMenuItem.Text = "Lista wypożyczeń";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uszeregujWPionieToolStripMenuItem,
            this.uszeregujWPoziomieToolStripMenuItem,
            this.uszegerujKaskadowoToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // uszeregujWPionieToolStripMenuItem
            // 
            this.uszeregujWPionieToolStripMenuItem.Name = "uszeregujWPionieToolStripMenuItem";
            this.uszeregujWPionieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszeregujWPionieToolStripMenuItem.Text = "Uszereguj w pionie";
            this.uszeregujWPionieToolStripMenuItem.Click += new System.EventHandler(this.uszeregujWPionieToolStripMenuItem_Click);
            // 
            // uszeregujWPoziomieToolStripMenuItem
            // 
            this.uszeregujWPoziomieToolStripMenuItem.Name = "uszeregujWPoziomieToolStripMenuItem";
            this.uszeregujWPoziomieToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszeregujWPoziomieToolStripMenuItem.Text = "Uszereguj w poziomie";
            this.uszeregujWPoziomieToolStripMenuItem.Click += new System.EventHandler(this.uszeregujWPoziomieToolStripMenuItem_Click);
            // 
            // uszegerujKaskadowoToolStripMenuItem
            // 
            this.uszegerujKaskadowoToolStripMenuItem.Name = "uszegerujKaskadowoToolStripMenuItem";
            this.uszegerujKaskadowoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.uszegerujKaskadowoToolStripMenuItem.Text = "Uszegeruj kaskadowo";
            this.uszegerujKaskadowoToolStripMenuItem.Click += new System.EventHandler(this.uszegerujKaskadowoToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.zakończToolStripMenuItem.Text = "Zamknij aplikacje";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "Bibloteka";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bibloteka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem książkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czytelnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypożyczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKlientówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCzytelnikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPracownikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWypożyczeńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszeregujWPionieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszeregujWPoziomieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uszegerujKaskadowoToolStripMenuItem;
    }
}