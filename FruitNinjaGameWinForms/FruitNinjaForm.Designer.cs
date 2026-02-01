namespace FruitNinjaGameWinForms
{
    partial class FruitNinjaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            scoreLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreLabel.ForeColor = Color.Gold;
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(57, 65);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            // 
            // FruitNinjaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(1934, 1018);
            Controls.Add(scoreLabel);
            Name = "FruitNinjaForm";
            Text = "FruitNinja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private System.Windows.Forms.Timer timer;
    }
}
