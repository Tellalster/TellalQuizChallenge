namespace CodeChallengeJeroen
{
    partial class MainForm
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
            this.LblIntro1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblIntro2 = new System.Windows.Forms.Label();
            this.lblIntro3 = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.lblIntro4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblIntro1
            // 
            this.LblIntro1.AutoSize = true;
            this.LblIntro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblIntro1.Location = new System.Drawing.Point(224, 76);
            this.LblIntro1.Name = "LblIntro1";
            this.LblIntro1.Size = new System.Drawing.Size(320, 20);
            this.LblIntro1.TabIndex = 0;
            this.LblIntro1.Text = "Hallo en welkom in deze multiple choice quiz";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnStart.Location = new System.Drawing.Point(667, 342);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(121, 64);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Laten we beginnen";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblIntro2
            // 
            this.LblIntro2.AutoSize = true;
            this.LblIntro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblIntro2.Location = new System.Drawing.Point(234, 139);
            this.LblIntro2.Name = "LblIntro2";
            this.LblIntro2.Size = new System.Drawing.Size(300, 20);
            this.LblIntro2.TabIndex = 2;
            this.LblIntro2.Text = "Er zullen 10 vragen aan u gesteld worden";
            // 
            // lblIntro3
            // 
            this.lblIntro3.AutoSize = true;
            this.lblIntro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIntro3.Location = new System.Drawing.Point(251, 203);
            this.lblIntro3.Name = "lblIntro3";
            this.lblIntro3.Size = new System.Drawing.Size(272, 20);
            this.lblIntro3.TabIndex = 3;
            this.lblIntro3.Text = "Aan het einde word uw score getoont";
            // 
            // BtnQuit
            // 
            this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnQuit.Location = new System.Drawing.Point(12, 342);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(121, 64);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quiz verlaten";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblIntro4
            // 
            this.lblIntro4.AutoSize = true;
            this.lblIntro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIntro4.Location = new System.Drawing.Point(327, 276);
            this.lblIntro4.Name = "lblIntro4";
            this.lblIntro4.Size = new System.Drawing.Size(108, 20);
            this.lblIntro4.TabIndex = 5;
            this.lblIntro4.Text = "Veel succes :)\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntro4);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.lblIntro3);
            this.Controls.Add(this.LblIntro2);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblIntro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Code Challenge Questions";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblIntro1;
        private System.Windows.Forms.Label LblIntro2;
        private System.Windows.Forms.Label lblIntro3;
        private System.Windows.Forms.Label lblIntro4;

        #endregion
    }
}

