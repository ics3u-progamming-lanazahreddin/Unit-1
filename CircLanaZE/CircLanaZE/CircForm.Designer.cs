namespace CircLanaZE
{
    partial class frmCirc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCirc));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCirc = new System.Windows.Forms.Label();
            this.lblCircAnswer = new System.Windows.Forms.Label();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(12, 72);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(371, 36);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Entre the radius of a circle:";
            this.lblInstructions.Click += new System.EventHandler(this.LblInstructions_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(527, 87);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(202, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(308, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(199, 75);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblCirc
            // 
            this.lblCirc.AutoSize = true;
            this.lblCirc.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirc.Location = new System.Drawing.Point(177, 296);
            this.lblCirc.Name = "lblCirc";
            this.lblCirc.Size = new System.Drawing.Size(470, 36);
            this.lblCirc.TabIndex = 4;
            this.lblCirc.Text = "The circumference of the circle is: ";
            // 
            // lblCircAnswer
            // 
            this.lblCircAnswer.AutoSize = true;
            this.lblCircAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircAnswer.Location = new System.Drawing.Point(240, 355);
            this.lblCircAnswer.Name = "lblCircAnswer";
            this.lblCircAnswer.Size = new System.Drawing.Size(0, 25);
            this.lblCircAnswer.TabIndex = 5;
            // 
            // picCircle
            // 
            this.picCircle.Image = ((System.Drawing.Image)(resources.GetObject("picCircle.Image")));
            this.picCircle.Location = new System.Drawing.Point(113, 0);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(552, 467);
            this.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCircle.TabIndex = 6;
            this.picCircle.TabStop = false;
            // 
            // frmCirc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCircAnswer);
            this.Controls.Add(this.lblCirc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCircle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCirc";
            this.Text = "Circumference by Lana ZE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCirc;
        private System.Windows.Forms.Label lblCircAnswer;
        private System.Windows.Forms.PictureBox picCircle;
    }
}

