namespace ProjectSharp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Podcasts = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbUpdateInterval = new System.Windows.Forms.ComboBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LvEpisodes = new System.Windows.Forms.ListView();
            this.EpisodesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRemoveFeed = new System.Windows.Forms.Button();
            this.BtnAddFeed = new System.Windows.Forms.Button();
            this.TbUrl = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.LvFeed = new System.Windows.Forms.ListView();
            this.Episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorier = new System.Windows.Forms.TabPage();
            this.TbAddCategory = new System.Windows.Forms.TextBox();
            this.BtnRemoveCategory = new System.Windows.Forms.Button();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.LvCategory = new System.Windows.Forms.ListView();
            this.btnChange = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Podcasts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Kategorier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Podcasts);
            this.tabControl1.Controls.Add(this.Kategorier);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 475);
            this.tabControl1.TabIndex = 1;
            // 
            // Podcasts
            // 
            this.Podcasts.BackColor = System.Drawing.Color.Salmon;
            this.Podcasts.Controls.Add(this.btnChange);
            this.Podcasts.Controls.Add(this.pictureBox2);
            this.Podcasts.Controls.Add(this.pictureBox1);
            this.Podcasts.Controls.Add(this.CbUpdateInterval);
            this.Podcasts.Controls.Add(this.TbDescription);
            this.Podcasts.Controls.Add(this.LvEpisodes);
            this.Podcasts.Controls.Add(this.BtnRemoveFeed);
            this.Podcasts.Controls.Add(this.BtnAddFeed);
            this.Podcasts.Controls.Add(this.TbUrl);
            this.Podcasts.Controls.Add(this.CbCategory);
            this.Podcasts.Controls.Add(this.LvFeed);
            this.Podcasts.Location = new System.Drawing.Point(4, 25);
            this.Podcasts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Podcasts.Name = "Podcasts";
            this.Podcasts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Podcasts.Size = new System.Drawing.Size(509, 446);
            this.Podcasts.TabIndex = 0;
            this.Podcasts.Text = "Podcasts";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectSharp.Properties.Resources.icons8_menu_24;
            this.pictureBox2.Location = new System.Drawing.Point(316, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectSharp.Properties.Resources.icons8_time_24;
            this.pictureBox1.Location = new System.Drawing.Point(316, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CbUpdateInterval
            // 
            this.CbUpdateInterval.FormattingEnabled = true;
            this.CbUpdateInterval.Location = new System.Drawing.Point(346, 188);
            this.CbUpdateInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbUpdateInterval.Name = "CbUpdateInterval";
            this.CbUpdateInterval.Size = new System.Drawing.Size(151, 24);
            this.CbUpdateInterval.TabIndex = 8;
            this.CbUpdateInterval.Text = "Frekvens";
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(316, 218);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(181, 217);
            this.TbDescription.TabIndex = 7;
            // 
            // LvEpisodes
            // 
            this.LvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EpisodesColumn});
            this.LvEpisodes.Location = new System.Drawing.Point(5, 218);
            this.LvEpisodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvEpisodes.MultiSelect = false;
            this.LvEpisodes.Name = "LvEpisodes";
            this.LvEpisodes.Size = new System.Drawing.Size(304, 217);
            this.LvEpisodes.TabIndex = 5;
            this.LvEpisodes.UseCompatibleStateImageBehavior = false;
            this.LvEpisodes.View = System.Windows.Forms.View.Details;
            this.LvEpisodes.SelectedIndexChanged += new System.EventHandler(this.LvEpisodes_SelectedIndexChanged);
            // 
            // EpisodesColumn
            // 
            this.EpisodesColumn.Text = "";
            this.EpisodesColumn.Width = 297;
            // 
            // BtnRemoveFeed
            // 
            this.BtnRemoveFeed.Location = new System.Drawing.Point(121, 187);
            this.BtnRemoveFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveFeed.Name = "BtnRemoveFeed";
            this.BtnRemoveFeed.Size = new System.Drawing.Size(91, 27);
            this.BtnRemoveFeed.TabIndex = 4;
            this.BtnRemoveFeed.Text = "Ta bort";
            this.BtnRemoveFeed.UseVisualStyleBackColor = true;
            this.BtnRemoveFeed.Click += new System.EventHandler(this.BtnRemoveFeed_Click);
            // 
            // BtnAddFeed
            // 
            this.BtnAddFeed.Location = new System.Drawing.Point(24, 187);
            this.BtnAddFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddFeed.Name = "BtnAddFeed";
            this.BtnAddFeed.Size = new System.Drawing.Size(91, 27);
            this.BtnAddFeed.TabIndex = 3;
            this.BtnAddFeed.Text = "Lägg till";
            this.BtnAddFeed.UseVisualStyleBackColor = true;
            this.BtnAddFeed.Click += new System.EventHandler(this.BtnAddFeed_Click);
            // 
            // TbUrl
            // 
            this.TbUrl.Location = new System.Drawing.Point(5, 158);
            this.TbUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbUrl.Name = "TbUrl";
            this.TbUrl.Size = new System.Drawing.Size(304, 22);
            this.TbUrl.TabIndex = 2;
            this.TbUrl.Text = "http://...";
            this.TbUrl.Enter += new System.EventHandler(this.TbUrl_Enter);
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(346, 158);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(151, 24);
            this.CbCategory.TabIndex = 1;
            this.CbCategory.Text = "Kategori";
            // 
            // LvFeed
            // 
            this.LvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episodes,
            this.Title,
            this.Interval,
            this.Category});
            this.LvFeed.FullRowSelect = true;
            this.LvFeed.Location = new System.Drawing.Point(8, 6);
            this.LvFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvFeed.MultiSelect = false;
            this.LvFeed.Name = "LvFeed";
            this.LvFeed.Size = new System.Drawing.Size(491, 146);
            this.LvFeed.TabIndex = 0;
            this.LvFeed.UseCompatibleStateImageBehavior = false;
            this.LvFeed.View = System.Windows.Forms.View.Details;
            this.LvFeed.SelectedIndexChanged += new System.EventHandler(this.LvFeed_SelectedIndexChanged);
            // 
            // Episodes
            // 
            this.Episodes.Text = "Avsnitt";
            this.Episodes.Width = 40;
            // 
            // Title
            // 
            this.Title.Text = "Titel";
            this.Title.Width = 125;
            // 
            // Interval
            // 
            this.Interval.Text = "Frekvens";
            this.Interval.Width = 92;
            // 
            // Category
            // 
            this.Category.Text = "Kategori";
            this.Category.Width = 100;
            // 
            // Kategorier
            // 
            this.Kategorier.BackColor = System.Drawing.Color.PeachPuff;
            this.Kategorier.Controls.Add(this.TbAddCategory);
            this.Kategorier.Controls.Add(this.BtnRemoveCategory);
            this.Kategorier.Controls.Add(this.BtnAddCategory);
            this.Kategorier.Controls.Add(this.LvCategory);
            this.Kategorier.Location = new System.Drawing.Point(4, 25);
            this.Kategorier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kategorier.Name = "Kategorier";
            this.Kategorier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kategorier.Size = new System.Drawing.Size(509, 446);
            this.Kategorier.TabIndex = 1;
            this.Kategorier.Text = "Kategorier";
            // 
            // TbAddCategory
            // 
            this.TbAddCategory.Location = new System.Drawing.Point(8, 201);
            this.TbAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbAddCategory.Name = "TbAddCategory";
            this.TbAddCategory.Size = new System.Drawing.Size(136, 22);
            this.TbAddCategory.TabIndex = 12;
            // 
            // BtnRemoveCategory
            // 
            this.BtnRemoveCategory.Location = new System.Drawing.Point(405, 201);
            this.BtnRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveCategory.Name = "BtnRemoveCategory";
            this.BtnRemoveCategory.Size = new System.Drawing.Size(91, 23);
            this.BtnRemoveCategory.TabIndex = 11;
            this.BtnRemoveCategory.Text = "Ta bort";
            this.BtnRemoveCategory.UseVisualStyleBackColor = true;
            this.BtnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(307, 201);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(91, 23);
            this.BtnAddCategory.TabIndex = 10;
            this.BtnAddCategory.Text = "Lägg till";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // LvCategory
            // 
            this.LvCategory.Location = new System.Drawing.Point(5, 6);
            this.LvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LvCategory.Name = "LvCategory";
            this.LvCategory.Size = new System.Drawing.Size(489, 189);
            this.LvCategory.TabIndex = 7;
            this.LvCategory.UseCompatibleStateImageBehavior = false;
            this.LvCategory.View = System.Windows.Forms.View.List;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(218, 188);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 27);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Ändra";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 475);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Podcasts.ResumeLayout(false);
            this.Podcasts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Kategorier.ResumeLayout(false);
            this.Kategorier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Podcasts;
        private System.Windows.Forms.ComboBox CbUpdateInterval;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.ListView LvEpisodes;
        private System.Windows.Forms.Button BtnRemoveFeed;
        private System.Windows.Forms.Button BtnAddFeed;
        private System.Windows.Forms.TextBox TbUrl;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ListView LvFeed;
        private System.Windows.Forms.ColumnHeader Episodes;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Interval;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.TabPage Kategorier;
        private System.Windows.Forms.TextBox TbAddCategory;
        private System.Windows.Forms.Button BtnRemoveCategory;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.ListView LvCategory;
        private System.Windows.Forms.ColumnHeader EpisodesColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnChange;
    }
}

