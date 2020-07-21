namespace CodeChallengeJeroen.Forms
{
    partial class ResultForm
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
            this.lblScoreScreenIntro1 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScoreCongratulation = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScoreScreenIntro1
            // 
            this.lblScoreScreenIntro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScoreScreenIntro1.Location = new System.Drawing.Point(332, 67);
            this.lblScoreScreenIntro1.Name = "lblScoreScreenIntro1";
            this.lblScoreScreenIntro1.Size = new System.Drawing.Size(100, 23);
            this.lblScoreScreenIntro1.TabIndex = 1;
            this.lblScoreScreenIntro1.Text = "Uw score is";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 342);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(121, 64);
            this.btnBackToMenu.TabIndex = 16;
            this.btnBackToMenu.Text = "Terug naar begin";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.Location = new System.Drawing.Point(667, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 64);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Afsluiten";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblScoreCongratulation
            // 
            this.lblScoreCongratulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScoreCongratulation.Location = new System.Drawing.Point(213, 169);
            this.lblScoreCongratulation.Name = "lblScoreCongratulation";
            this.lblScoreCongratulation.Size = new System.Drawing.Size(336, 74);
            this.lblScoreCongratulation.TabIndex = 19;
            this.lblScoreCongratulation.Text = "Felicitatie tekst";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Lime;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.Location = new System.Drawing.Point(288, 108);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(189, 42);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "10 van de 10";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreCongratulation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblScoreScreenIntro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.Text = "ResultForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreCongratulation;
        private System.Windows.Forms.Label lblScoreScreenIntro1;

        #endregion
    }
}