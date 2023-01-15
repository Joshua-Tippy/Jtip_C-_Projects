namespace BedandBreakfast
{
    partial class BelleAireForm
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
            this.belleAireDescriptionLabel = new System.Windows.Forms.Label();
            this.belleAirePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // belleAireDescriptionLabel
            // 
            this.belleAireDescriptionLabel.AutoSize = true;
            this.belleAireDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAireDescriptionLabel.Location = new System.Drawing.Point(91, 62);
            this.belleAireDescriptionLabel.Name = "belleAireDescriptionLabel";
            this.belleAireDescriptionLabel.Size = new System.Drawing.Size(616, 74);
            this.belleAireDescriptionLabel.TabIndex = 0;
            this.belleAireDescriptionLabel.Text = "The BelleAire Suite has two bedrooms, \r\ntwo baths, and a private balcony";
            // 
            // belleAirePriceLabel
            // 
            this.belleAirePriceLabel.AutoSize = true;
            this.belleAirePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAirePriceLabel.Location = new System.Drawing.Point(252, 165);
            this.belleAirePriceLabel.Name = "belleAirePriceLabel";
            this.belleAirePriceLabel.Size = new System.Drawing.Size(197, 32);
            this.belleAirePriceLabel.TabIndex = 1;
            this.belleAirePriceLabel.Text = "$199 per night";
            this.belleAirePriceLabel.Click += new System.EventHandler(this.belleAirePriceLabel_Click);
            // 
            // BelleAireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.belleAirePriceLabel);
            this.Controls.Add(this.belleAireDescriptionLabel);
            this.Name = "BelleAireForm";
            this.Text = "Belle Aire Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label belleAireDescriptionLabel;
        private System.Windows.Forms.Label belleAirePriceLabel;
    }
}