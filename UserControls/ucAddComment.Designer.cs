namespace musicPlayer.UserControls
{
    partial class ucAddComment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.txtAuthorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBodyCmt = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStar5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStar4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStar3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStar2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStar1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add new comment";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(190, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 5;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.Indigo;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(25, 236);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BorderRadius = 5;
            this.txtAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorName.DefaultText = "";
            this.txtAuthorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthorName.ForeColor = System.Drawing.Color.Black;
            this.txtAuthorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthorName.Location = new System.Drawing.Point(25, 109);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.PasswordChar = '\0';
            this.txtAuthorName.PlaceholderText = "Your name (required)";
            this.txtAuthorName.SelectedText = "";
            this.txtAuthorName.Size = new System.Drawing.Size(245, 36);
            this.txtAuthorName.TabIndex = 4;
            // 
            // txtBodyCmt
            // 
            this.txtBodyCmt.BorderRadius = 5;
            this.txtBodyCmt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBodyCmt.DefaultText = "";
            this.txtBodyCmt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBodyCmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBodyCmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBodyCmt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBodyCmt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBodyCmt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBodyCmt.ForeColor = System.Drawing.Color.Black;
            this.txtBodyCmt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBodyCmt.Location = new System.Drawing.Point(25, 151);
            this.txtBodyCmt.Multiline = true;
            this.txtBodyCmt.Name = "txtBodyCmt";
            this.txtBodyCmt.PasswordChar = '\0';
            this.txtBodyCmt.PlaceholderText = "Your comment";
            this.txtBodyCmt.SelectedText = "";
            this.txtBodyCmt.Size = new System.Drawing.Size(245, 67);
            this.txtBodyCmt.TabIndex = 8;
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMale.ForeColor = System.Drawing.Color.White;
            this.rdBtnMale.Location = new System.Drawing.Point(25, 80);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(53, 19);
            this.rdBtnMale.TabIndex = 9;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "Male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFemale.ForeColor = System.Drawing.Color.White;
            this.rdBtnFemale.Location = new System.Drawing.Point(119, 81);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(67, 19);
            this.rdBtnFemale.TabIndex = 10;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rating:";
            // 
            // btnStar5
            // 
            this.btnStar5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStar5.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar5.Image = global::musicPlayer.Properties.Resources.star_50px;
            this.btnStar5.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStar5.ImageRotate = 0F;
            this.btnStar5.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStar5.Location = new System.Drawing.Point(199, 45);
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar5.Size = new System.Drawing.Size(25, 25);
            this.btnStar5.TabIndex = 16;
            this.btnStar5.Tag = "5";
            this.btnStar5.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStar4
            // 
            this.btnStar4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStar4.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar4.Image = global::musicPlayer.Properties.Resources.star_50px;
            this.btnStar4.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStar4.ImageRotate = 0F;
            this.btnStar4.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStar4.Location = new System.Drawing.Point(169, 45);
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar4.Size = new System.Drawing.Size(25, 25);
            this.btnStar4.TabIndex = 15;
            this.btnStar4.Tag = "4";
            this.btnStar4.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStar3
            // 
            this.btnStar3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStar3.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar3.Image = global::musicPlayer.Properties.Resources.star_50px;
            this.btnStar3.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStar3.ImageRotate = 0F;
            this.btnStar3.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStar3.Location = new System.Drawing.Point(140, 45);
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar3.Size = new System.Drawing.Size(25, 25);
            this.btnStar3.TabIndex = 14;
            this.btnStar3.Tag = "3";
            this.btnStar3.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStar2
            // 
            this.btnStar2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStar2.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar2.Image = global::musicPlayer.Properties.Resources.star_50px;
            this.btnStar2.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStar2.ImageRotate = 0F;
            this.btnStar2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStar2.Location = new System.Drawing.Point(111, 45);
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar2.Size = new System.Drawing.Size(25, 25);
            this.btnStar2.TabIndex = 13;
            this.btnStar2.Tag = "2";
            this.btnStar2.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnStar1
            // 
            this.btnStar1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStar1.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar1.Image = global::musicPlayer.Properties.Resources.star_50px1;
            this.btnStar1.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStar1.ImageRotate = 0F;
            this.btnStar1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStar1.Location = new System.Drawing.Point(80, 45);
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnStar1.Size = new System.Drawing.Size(25, 25);
            this.btnStar1.TabIndex = 12;
            this.btnStar1.Tag = "1";
            this.btnStar1.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // ucAddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.btnStar5);
            this.Controls.Add(this.btnStar4);
            this.Controls.Add(this.btnStar3);
            this.Controls.Add(this.btnStar2);
            this.Controls.Add(this.btnStar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdBtnFemale);
            this.Controls.Add(this.rdBtnMale);
            this.Controls.Add(this.txtBodyCmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtAuthorName);
            this.Name = "ucAddComment";
            this.Size = new System.Drawing.Size(300, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthorName;
        private Guna.UI2.WinForms.Guna2TextBox txtBodyCmt;
        private System.Windows.Forms.RadioButton rdBtnMale;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnStar1;
        private Guna.UI2.WinForms.Guna2ImageButton btnStar2;
        private Guna.UI2.WinForms.Guna2ImageButton btnStar4;
        private Guna.UI2.WinForms.Guna2ImageButton btnStar3;
        private Guna.UI2.WinForms.Guna2ImageButton btnStar5;
    }
}
