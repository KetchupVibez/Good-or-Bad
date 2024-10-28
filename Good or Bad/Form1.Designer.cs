namespace Good_or_Bad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgGood = new System.Windows.Forms.PictureBox();
            this.imgBad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGood.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.ForeColor = System.Drawing.Color.Gold;
            this.btnGood.Location = new System.Drawing.Point(113, 179);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(270, 66);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Black;
            this.btnBad.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBad.Location = new System.Drawing.Point(407, 179);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(270, 66);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(255, 37);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(291, 58);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Good or Bad?";
            // 
            // imgGood
            // 
            this.imgGood.Image = ((System.Drawing.Image)(resources.GetObject("imgGood.Image")));
            this.imgGood.Location = new System.Drawing.Point(3, 10);
            this.imgGood.Name = "imgGood";
            this.imgGood.Size = new System.Drawing.Size(798, 428);
            this.imgGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood.TabIndex = 4;
            this.imgGood.TabStop = false;
            this.imgGood.Visible = false;
            // 
            // imgBad
            // 
            this.imgBad.Image = ((System.Drawing.Image)(resources.GetObject("imgBad.Image")));
            this.imgBad.Location = new System.Drawing.Point(3, 0);
            this.imgBad.Name = "imgBad";
            this.imgBad.Size = new System.Drawing.Size(798, 444);
            this.imgBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad.TabIndex = 5;
            this.imgBad.TabStop = false;
            this.imgBad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBad);
            this.Controls.Add(this.imgGood);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgGood;
        private System.Windows.Forms.PictureBox imgBad;
    }
}

