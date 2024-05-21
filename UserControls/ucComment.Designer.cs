namespace musicPlayer.UserControls
{
    partial class ucComment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.pnContent = new Guna.UI2.WinForms.Guna2Panel();
            this.richTxtBody = new System.Windows.Forms.RichTextBox();
            this.lbBody = new System.Windows.Forms.Label();
            this.lbTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pcImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(2, 2);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // pnContent
            // 
            this.pnContent.AutoSize = true;
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.BorderColor = System.Drawing.Color.Black;
            this.pnContent.BorderRadius = 5;
            this.pnContent.BorderThickness = 1;
            this.pnContent.Controls.Add(this.richTxtBody);
            this.pnContent.Controls.Add(this.lbName);
            this.pnContent.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnContent.Location = new System.Drawing.Point(40, 14);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(257, 81);
            this.pnContent.TabIndex = 1;
            // 
            // richTxtBody
            // 
            this.richTxtBody.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTxtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBody.ForeColor = System.Drawing.Color.White;
            this.richTxtBody.Location = new System.Drawing.Point(6, 26);
            this.richTxtBody.Name = "richTxtBody";
            this.richTxtBody.ReadOnly = true;
            this.richTxtBody.Size = new System.Drawing.Size(248, 52);
            this.richTxtBody.TabIndex = 1;
            this.richTxtBody.Text = "";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBody.Location = new System.Drawing.Point(3, 0);
            this.lbBody.MaximumSize = new System.Drawing.Size(248, 0);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(52, 16);
            this.lbBody.TabIndex = 2;
            this.lbBody.Text = "Content";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.ForeColor = System.Drawing.Color.Gray;
            this.lbTime.Location = new System.Drawing.Point(40, 99);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 15);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "11:04:23 27/03/2024";
            // 
            // pcImage
            // 
            this.pcImage.Image = global::musicPlayer.Properties.Resources.male_50px;
            this.pcImage.ImageRotate = 0F;
            this.pcImage.Location = new System.Drawing.Point(0, 0);
            this.pcImage.Margin = new System.Windows.Forms.Padding(2);
            this.pcImage.Name = "pcImage";
            this.pcImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcImage.Size = new System.Drawing.Size(38, 41);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // ucComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pcImage);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucComment";
            this.Size = new System.Drawing.Size(300, 122);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pcImage;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTime;
        private System.Windows.Forms.RichTextBox richTxtBody;
        private System.Windows.Forms.Label lbBody;
    }
}
