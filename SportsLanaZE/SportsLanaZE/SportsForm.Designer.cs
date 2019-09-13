namespace SportsLanaZE
{
    partial class frmSpots
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
            this.components = new System.ComponentModel.Container();
            this.mnuSports = new System.Windows.Forms.MenuStrip();
            this.mniSports = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoccer = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTennis = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBasketball = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFootball = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSportType = new System.Windows.Forms.Label();
            this.lblFavPlayer = new System.Windows.Forms.Label();
            this.mnuSports.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSports
            // 
            this.mnuSports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSports});
            this.mnuSports.Location = new System.Drawing.Point(0, 0);
            this.mnuSports.Name = "mnuSports";
            this.mnuSports.Size = new System.Drawing.Size(800, 24);
            this.mnuSports.TabIndex = 0;
            this.mnuSports.Text = "menuStrip1";
            // 
            // mniSports
            // 
            this.mniSports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSoccer,
            this.mniTennis,
            this.mniBasketball,
            this.mniFootball});
            this.mniSports.Name = "mniSports";
            this.mniSports.Size = new System.Drawing.Size(52, 20);
            this.mniSports.Text = "Sports";
            this.mniSports.Click += new System.EventHandler(this.MniSports_Click);
            // 
            // mniSoccer
            // 
            this.mniSoccer.Name = "mniSoccer";
            this.mniSoccer.Size = new System.Drawing.Size(180, 22);
            this.mniSoccer.Text = "Soccer";
            this.mniSoccer.Click += new System.EventHandler(this.SoccerToolStripMenuItem_Click);
            // 
            // mniTennis
            // 
            this.mniTennis.Name = "mniTennis";
            this.mniTennis.Size = new System.Drawing.Size(180, 22);
            this.mniTennis.Text = "Tennis";
            this.mniTennis.Click += new System.EventHandler(this.MniTennis_Click);
            // 
            // mniBasketball
            // 
            this.mniBasketball.Name = "mniBasketball";
            this.mniBasketball.Size = new System.Drawing.Size(180, 22);
            this.mniBasketball.Text = "Basketball";
            // 
            // mniFootball
            // 
            this.mniFootball.Name = "mniFootball";
            this.mniFootball.Size = new System.Drawing.Size(180, 22);
            this.mniFootball.Text = "football";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Font = new System.Drawing.Font("Proxy 3", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportType.ForeColor = System.Drawing.Color.Red;
            this.lblSportType.Location = new System.Drawing.Point(115, 49);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(0, 117);
            this.lblSportType.TabIndex = 2;
            // 
            // lblFavPlayer
            // 
            this.lblFavPlayer.AutoSize = true;
            this.lblFavPlayer.Font = new System.Drawing.Font("OpenSymbol", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavPlayer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFavPlayer.Location = new System.Drawing.Point(124, 265);
            this.lblFavPlayer.Name = "lblFavPlayer";
            this.lblFavPlayer.Size = new System.Drawing.Size(0, 64);
            this.lblFavPlayer.TabIndex = 3;
            // 
            // frmSpots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFavPlayer);
            this.Controls.Add(this.lblSportType);
            this.Controls.Add(this.mnuSports);
            this.MainMenuStrip = this.mnuSports;
            this.Name = "frmSpots";
            this.Text = "Sports";
            this.Load += new System.EventHandler(this.FrmSpots_Load);
            this.mnuSports.ResumeLayout(false);
            this.mnuSports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSports;
        private System.Windows.Forms.ToolStripMenuItem mniSports;
        private System.Windows.Forms.ToolStripMenuItem mniSoccer;
        private System.Windows.Forms.ToolStripMenuItem mniTennis;
        private System.Windows.Forms.ToolStripMenuItem mniBasketball;
        private System.Windows.Forms.ToolStripMenuItem mniFootball;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSportType;
        private System.Windows.Forms.Label lblFavPlayer;
    }
}

