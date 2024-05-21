namespace musicPlayer.UserControls
{
    partial class ucPanelComments
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
            this.flPnComments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddComment = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comments";
            // 
            // flPnComments
            // 
            this.flPnComments.AutoScroll = true;
            this.flPnComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPnComments.Location = new System.Drawing.Point(-10, 32);
            this.flPnComments.Name = "flPnComments";
            this.flPnComments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 50);
            this.flPnComments.Size = new System.Drawing.Size(440, 143);
            this.flPnComments.TabIndex = 1;
            // 
            // btnAddComment
            // 
            this.btnAddComment.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddComment.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddComment.Image = global::musicPlayer.Properties.Resources.add_to_chat_50px;
            this.btnAddComment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddComment.ImageRotate = 0F;
            this.btnAddComment.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddComment.Location = new System.Drawing.Point(391, 1);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddComment.Size = new System.Drawing.Size(30, 30);
            this.btnAddComment.TabIndex = 2;
            // 
            // ucPanelComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.flPnComments);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPanelComments";
            this.Size = new System.Drawing.Size(430, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flPnComments;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddComment;
    }
}
