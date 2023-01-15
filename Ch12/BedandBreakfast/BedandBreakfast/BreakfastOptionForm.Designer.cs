namespace BedandBreakfast
{
    partial class BreakfastOptionForm
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
            this.Textlbl = new System.Windows.Forms.Label();
            this.ContRadioButton = new System.Windows.Forms.RadioButton();
            this.FullRadioButton = new System.Windows.Forms.RadioButton();
            this.DeluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Textlbl
            // 
            this.Textlbl.AutoSize = true;
            this.Textlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textlbl.Location = new System.Drawing.Point(170, 75);
            this.Textlbl.Name = "Textlbl";
            this.Textlbl.Size = new System.Drawing.Size(441, 37);
            this.Textlbl.TabIndex = 0;
            this.Textlbl.Text = "Select your breakfast option";
            // 
            // ContRadioButton
            // 
            this.ContRadioButton.AutoSize = true;
            this.ContRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContRadioButton.Location = new System.Drawing.Point(309, 149);
            this.ContRadioButton.Name = "ContRadioButton";
            this.ContRadioButton.Size = new System.Drawing.Size(159, 33);
            this.ContRadioButton.TabIndex = 1;
            this.ContRadioButton.TabStop = true;
            this.ContRadioButton.Text = "Continental";
            this.ContRadioButton.UseVisualStyleBackColor = true;
            this.ContRadioButton.CheckedChanged += new System.EventHandler(this.ContRadioButton_CheckedChanged);
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullRadioButton.Location = new System.Drawing.Point(309, 195);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(78, 33);
            this.FullRadioButton.TabIndex = 2;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "Full";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            this.FullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // DeluxeRadioButton
            // 
            this.DeluxeRadioButton.AutoSize = true;
            this.DeluxeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeluxeRadioButton.Location = new System.Drawing.Point(309, 238);
            this.DeluxeRadioButton.Name = "DeluxeRadioButton";
            this.DeluxeRadioButton.Size = new System.Drawing.Size(113, 33);
            this.DeluxeRadioButton.TabIndex = 3;
            this.DeluxeRadioButton.TabStop = true;
            this.DeluxeRadioButton.Text = "Deluxe";
            this.DeluxeRadioButton.UseVisualStyleBackColor = true;
            this.DeluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButton_CheckedChanged);
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(305, 320);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(94, 32);
            this.Pricelbl.TabIndex = 4;
            this.Pricelbl.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.DeluxeRadioButton);
            this.Controls.Add(this.FullRadioButton);
            this.Controls.Add(this.ContRadioButton);
            this.Controls.Add(this.Textlbl);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textlbl;
        private System.Windows.Forms.RadioButton ContRadioButton;
        private System.Windows.Forms.RadioButton FullRadioButton;
        private System.Windows.Forms.RadioButton DeluxeRadioButton;
        private System.Windows.Forms.Label Pricelbl;
    }
}