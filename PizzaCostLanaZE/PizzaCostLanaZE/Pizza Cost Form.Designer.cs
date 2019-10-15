namespace PizzaCostLanaZE
{
    partial class frmPizzaCost
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(34, 57);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(670, 46);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(777, 77);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(140, 22);
            this.txtDiameter.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(298, 188);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(420, 128);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerText.Location = new System.Drawing.Point(34, 405);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(704, 46);
            this.lblAnswerText.TabIndex = 3;
            this.lblAnswerText.Text = "Here is the cost of your pizza (including tax):";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Brown;
            this.lblCost.Location = new System.Drawing.Point(796, 413);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(41, 38);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "??";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.Label lblCost;
    }
}

