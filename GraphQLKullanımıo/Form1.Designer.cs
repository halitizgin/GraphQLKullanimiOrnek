namespace GraphQLKullanımıo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yönetmeniGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filmleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetmenEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 301);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Çıkış Yılı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Imdb";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Konu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetmeniGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // yönetmeniGösterToolStripMenuItem
            // 
            this.yönetmeniGösterToolStripMenuItem.Name = "yönetmeniGösterToolStripMenuItem";
            this.yönetmeniGösterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.yönetmeniGösterToolStripMenuItem.Text = "Yönetmeni Göster";
            this.yönetmeniGösterToolStripMenuItem.Click += new System.EventHandler(this.YönetmeniGösterToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(319, 11);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(277, 301);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "#";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yönetmen Adı";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Doğum Yılı";
            this.columnHeader8.Width = 77;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.toolStripSeparator1,
            this.yönetmenEkleToolStripMenuItem,
            this.toolStripSeparator2,
            this.filmleriGösterToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 104);
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmEkleToolStripMenuItem.Text = "Yönetmen Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.FilmEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // filmleriGösterToolStripMenuItem
            // 
            this.filmleriGösterToolStripMenuItem.Name = "filmleriGösterToolStripMenuItem";
            this.filmleriGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmleriGösterToolStripMenuItem.Text = "Filmleri Göster";
            this.filmleriGösterToolStripMenuItem.Click += new System.EventHandler(this.FilmleriGösterToolStripMenuItem_Click);
            // 
            // yönetmenEkleToolStripMenuItem
            // 
            this.yönetmenEkleToolStripMenuItem.Name = "yönetmenEkleToolStripMenuItem";
            this.yönetmenEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yönetmenEkleToolStripMenuItem.Text = "Film Ekle";
            this.yönetmenEkleToolStripMenuItem.Click += new System.EventHandler(this.YönetmenEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 324);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yönetmeniGösterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filmleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yönetmenEkleToolStripMenuItem;
    }
}

