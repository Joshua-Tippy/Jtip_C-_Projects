namespace BedandBreakfast
{
    partial class BaileysForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.belleAireCheckbox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckbox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(80, 53);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(371, 40);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome To Bailey\'s";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(132, 108);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(254, 37);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Check our Rates";
            // 
            // belleAireCheckbox
            // 
            this.belleAireCheckbox.AutoSize = true;
            this.belleAireCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAireCheckbox.Location = new System.Drawing.Point(139, 158);
            this.belleAireCheckbox.Name = "belleAireCheckbox";
            this.belleAireCheckbox.Size = new System.Drawing.Size(253, 36);
            this.belleAireCheckbox.TabIndex = 2;
            this.belleAireCheckbox.Text = "Belle Aire Suite";
            this.belleAireCheckbox.UseVisualStyleBackColor = true;
            this.belleAireCheckbox.CheckedChanged += new System.EventHandler(this.belleAireCheckbox_CheckedChanged);
            // 
            // lincolnCheckbox
            // 
            this.lincolnCheckbox.AutoSize = true;
            this.lincolnCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnCheckbox.Location = new System.Drawing.Point(139, 200);
            this.lincolnCheckbox.Name = "lincolnCheckbox";
            this.lincolnCheckbox.Size = new System.Drawing.Size(227, 36);
            this.lincolnCheckbox.TabIndex = 3;
            this.lincolnCheckbox.Text = "Lincoln Room";
            this.lincolnCheckbox.UseVisualStyleBackColor = true;
            this.lincolnCheckbox.CheckedChanged += new System.EventHandler(this.lincolnCheckbox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(139, 442);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(181, 37);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.mealButton_Click);
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 612);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.lincolnCheckbox);
            this.Controls.Add(this.belleAireCheckbox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey\'s Bed & Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.CheckBox belleAireCheckbox;
        private System.Windows.Forms.CheckBox lincolnCheckbox;
        private System.Windows.Forms.Button mealButton;
    }
}

