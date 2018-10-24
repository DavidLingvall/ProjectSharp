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
            this.CbUpdateInterval = new System.Windows.Forms.ComboBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LblEpisodes = new System.Windows.Forms.Label();
            this.LvEpisodes = new System.Windows.Forms.ListView();
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
            this.tabControl1.SuspendLayout();
            this.Podcasts.SuspendLayout();
            this.Kategorier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Podcasts);
            this.tabControl1.Controls.Add(this.Kategorier);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // Podcasts
            // 
            this.Podcasts.BackColor = System.Drawing.Color.Salmon;
            this.Podcasts.Controls.Add(this.CbUpdateInterval);
            this.Podcasts.Controls.Add(this.TbDescription);
            this.Podcasts.Controls.Add(this.LblEpisodes);
            this.Podcasts.Controls.Add(this.LvEpisodes);
            this.Podcasts.Controls.Add(this.BtnRemoveFeed);
            this.Podcasts.Controls.Add(this.BtnAddFeed);
            this.Podcasts.Controls.Add(this.TbUrl);
            this.Podcasts.Controls.Add(this.CbCategory);
            this.Podcasts.Controls.Add(this.LvFeed);
            this.Podcasts.Location = new System.Drawing.Point(4, 22);
            this.Podcasts.Margin = new System.Windows.Forms.Padding(2);
            this.Podcasts.Name = "Podcasts";
            this.Podcasts.Padding = new System.Windows.Forms.Padding(2);
            this.Podcasts.Size = new System.Drawing.Size(380, 360);
            this.Podcasts.TabIndex = 0;
            this.Podcasts.Text = "Podcasts";
            // 
            // CbUpdateInterval
            // 
            this.CbUpdateInterval.FormattingEnabled = true;
            this.CbUpdateInterval.Location = new System.Drawing.Point(237, 153);
            this.CbUpdateInterval.Margin = new System.Windows.Forms.Padding(2);
            this.CbUpdateInterval.Name = "CbUpdateInterval";
            this.CbUpdateInterval.Size = new System.Drawing.Size(137, 21);
            this.CbUpdateInterval.TabIndex = 8;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(237, 177);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(137, 177);
            this.TbDescription.TabIndex = 7;
            // 
            // LblEpisodes
            // 
            this.LblEpisodes.AutoSize = true;
            this.LblEpisodes.Location = new System.Drawing.Point(3, 158);
            this.LblEpisodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEpisodes.Name = "LblEpisodes";
            this.LblEpisodes.Size = new System.Drawing.Size(35, 13);
            this.LblEpisodes.TabIndex = 6;
            this.LblEpisodes.Text = "label1";
            // 
            // LvEpisodes
            // 
            this.LvEpisodes.Location = new System.Drawing.Point(4, 177);
            this.LvEpisodes.Margin = new System.Windows.Forms.Padding(2);
            this.LvEpisodes.Name = "LvEpisodes";
            this.LvEpisodes.Size = new System.Drawing.Size(229, 177);
            this.LvEpisodes.TabIndex = 5;
            this.LvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // BtnRemoveFeed
            // 
            this.BtnRemoveFeed.Location = new System.Drawing.Point(165, 151);
            this.BtnRemoveFeed.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRemoveFeed.Name = "BtnRemoveFeed";
            this.BtnRemoveFeed.Size = new System.Drawing.Size(68, 19);
            this.BtnRemoveFeed.TabIndex = 4;
            this.BtnRemoveFeed.Text = "Ta bort";
            this.BtnRemoveFeed.UseVisualStyleBackColor = true;
            // 
            // BtnAddFeed
            // 
            this.BtnAddFeed.Location = new System.Drawing.Point(93, 151);
            this.BtnAddFeed.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddFeed.Name = "BtnAddFeed";
            this.BtnAddFeed.Size = new System.Drawing.Size(68, 19);
            this.BtnAddFeed.TabIndex = 3;
            this.BtnAddFeed.Text = "Lägg till";
            this.BtnAddFeed.UseVisualStyleBackColor = true;
            // 
            // TbUrl
            // 
            this.TbUrl.Location = new System.Drawing.Point(4, 128);
            this.TbUrl.Margin = new System.Windows.Forms.Padding(2);
            this.TbUrl.Name = "TbUrl";
            this.TbUrl.Size = new System.Drawing.Size(231, 20);
            this.TbUrl.TabIndex = 2;
            this.TbUrl.Text = "http://";
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(237, 128);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(137, 21);
            this.CbCategory.TabIndex = 1;
            // 
            // LvFeed
            // 
            this.LvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episodes,
            this.Title,
            this.Interval,
            this.Category});
            this.LvFeed.Location = new System.Drawing.Point(5, 5);
            this.LvFeed.Margin = new System.Windows.Forms.Padding(2);
            this.LvFeed.Name = "LvFeed";
            this.LvFeed.Size = new System.Drawing.Size(369, 119);
            this.LvFeed.TabIndex = 0;
            this.LvFeed.UseCompatibleStateImageBehavior = false;
            this.LvFeed.View = System.Windows.Forms.View.Details;
            // 
            // Episodes
            // 
            this.Episodes.Text = "Avsnitt";
            this.Episodes.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Titel";
            this.Title.Width = 175;
            // 
            // Interval
            // 
            this.Interval.Text = "Frekvens";
            this.Interval.Width = 149;
            // 
            // Category
            // 
            this.Category.Text = "Kategori";
            this.Category.Width = 103;
            // 
            // Kategorier
            // 
            this.Kategorier.BackColor = System.Drawing.Color.PeachPuff;
            this.Kategorier.Controls.Add(this.TbAddCategory);
            this.Kategorier.Controls.Add(this.BtnRemoveCategory);
            this.Kategorier.Controls.Add(this.BtnAddCategory);
            this.Kategorier.Controls.Add(this.LvCategory);
            this.Kategorier.Location = new System.Drawing.Point(4, 22);
            this.Kategorier.Margin = new System.Windows.Forms.Padding(2);
            this.Kategorier.Name = "Kategorier";
            this.Kategorier.Padding = new System.Windows.Forms.Padding(2);
            this.Kategorier.Size = new System.Drawing.Size(380, 360);
            this.Kategorier.TabIndex = 1;
            this.Kategorier.Text = "Kategorier";
            // 
            // TbAddCategory
            // 
            this.TbAddCategory.Location = new System.Drawing.Point(6, 163);
            this.TbAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.TbAddCategory.Name = "TbAddCategory";
            this.TbAddCategory.Size = new System.Drawing.Size(103, 20);
            this.TbAddCategory.TabIndex = 12;
            // 
            // BtnRemoveCategory
            // 
            this.BtnRemoveCategory.Location = new System.Drawing.Point(304, 163);
            this.BtnRemoveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRemoveCategory.Name = "BtnRemoveCategory";
            this.BtnRemoveCategory.Size = new System.Drawing.Size(68, 19);
            this.BtnRemoveCategory.TabIndex = 11;
            this.BtnRemoveCategory.Text = "Ta bort";
            this.BtnRemoveCategory.UseVisualStyleBackColor = true;
            this.BtnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Location = new System.Drawing.Point(230, 163);
            this.BtnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(68, 19);
            this.BtnAddCategory.TabIndex = 10;
            this.BtnAddCategory.Text = "Lägg till";
            this.BtnAddCategory.UseVisualStyleBackColor = true;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // LvCategory
            // 
            this.LvCategory.Location = new System.Drawing.Point(4, 5);
            this.LvCategory.Margin = new System.Windows.Forms.Padding(2);
            this.LvCategory.Name = "LvCategory";
            this.LvCategory.Size = new System.Drawing.Size(368, 154);
            this.LvCategory.TabIndex = 7;
            this.LvCategory.UseCompatibleStateImageBehavior = false;
            this.LvCategory.SelectedIndexChanged += new System.EventHandler(this.LvCategory_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 386);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Podcasts.ResumeLayout(false);
            this.Podcasts.PerformLayout();
            this.Kategorier.ResumeLayout(false);
            this.Kategorier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Podcasts;
        private System.Windows.Forms.ComboBox CbUpdateInterval;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LblEpisodes;
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
    }
}

