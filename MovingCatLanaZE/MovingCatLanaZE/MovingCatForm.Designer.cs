namespace MovingCatLanaZE
{
    partial class frmMovingCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovingCat));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cat1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cat2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat1 = new System.Windows.Forms.PictureBox();
            this.picCat2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.catToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cat1ToolStripMenuItem,
            this.cat2ToolStripMenuItem});
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // cat1ToolStripMenuItem
            // 
            this.cat1ToolStripMenuItem.Name = "cat1ToolStripMenuItem";
            this.cat1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cat1ToolStripMenuItem.Text = "Cat 1 ";
            this.cat1ToolStripMenuItem.Click += new System.EventHandler(this.Cat1ToolStripMenuItem_Click);
            // 
            // cat2ToolStripMenuItem
            // 
            this.cat2ToolStripMenuItem.Name = "cat2ToolStripMenuItem";
            this.cat2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cat2ToolStripMenuItem.Text = "Cat 2";
            this.cat2ToolStripMenuItem.Click += new System.EventHandler(this.Cat2ToolStripMenuItem_Click);
            // 
            // picCat1
            // 
            this.picCat1.Image = ((System.Drawing.Image)(resources.GetObject("picCat1.Image")));
            this.picCat1.Location = new System.Drawing.Point(182, 48);
            this.picCat1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCat1.Name = "picCat1";
            this.picCat1.Size = new System.Drawing.Size(177, 206);
            this.picCat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat1.TabIndex = 1;
            this.picCat1.TabStop = false;
            // 
            // picCat2
            // 
            this.picCat2.Image = ((System.Drawing.Image)(resources.GetObject("picCat2.Image")));
            this.picCat2.Location = new System.Drawing.Point(160, 48);
            this.picCat2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCat2.Name = "picCat2";
            this.picCat2.Size = new System.Drawing.Size(184, 206);
            this.picCat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat2.TabIndex = 2;
            this.picCat2.TabStop = false;
            this.picCat2.Click += new System.EventHandler(this.PicCat2_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.picCat2);
            this.Controls.Add(this.picCat1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Lana ZE";
            this.Load += new System.EventHandler(this.FrmMovingCat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cat1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cat2ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCat1;
        private System.Windows.Forms.PictureBox picCat2;
    }
}

