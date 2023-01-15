namespace MyFlix
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
            this.lbldirections = new System.Windows.Forms.Label();
            this.MoviesShowsListBox = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldirections
            // 
            this.lbldirections.AutoSize = true;
            this.lbldirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirections.Location = new System.Drawing.Point(94, 83);
            this.lbldirections.Name = "lbldirections";
            this.lbldirections.Size = new System.Drawing.Size(783, 29);
            this.lbldirections.TabIndex = 0;
            this.lbldirections.Text = "Choose as many downloads as you want by holding down the CTRL Key";
            // 
            // MoviesShowsListBox
            // 
            this.MoviesShowsListBox.FormattingEnabled = true;
            this.MoviesShowsListBox.ItemHeight = 20;
            this.MoviesShowsListBox.Items.AddRange(new object[] {
            "Big Bang Theory",
            "Nova",
            "The Fifth Element",
            "Stranger Things",
            "Star Wars",
            "Lord of the Rings"});
            this.MoviesShowsListBox.Location = new System.Drawing.Point(356, 133);
            this.MoviesShowsListBox.Name = "MoviesShowsListBox";
            this.MoviesShowsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MoviesShowsListBox.Size = new System.Drawing.Size(186, 124);
            this.MoviesShowsListBox.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(380, 263);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 30);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(341, 327);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(51, 20);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "label1";
            this.lblDisplay.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 613);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.MoviesShowsListBox);
            this.Controls.Add(this.lbldirections);
            this.Name = "Form1";
            this.Text = "Movies/Tv Shows Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldirections;
        private System.Windows.Forms.ListBox MoviesShowsListBox;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblDisplay;
    }
}

