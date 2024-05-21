using Guna.UI2.WinForms;
using musicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using musicPlayer.Classes;

namespace musicPlayer.UserControls
{
    public partial class ucAddComment : UserControl
    {
        public ucAddComment()
        {
            InitializeComponent();
        }

        private int track_id;
        private string nameAuthor;
        private string sex;
        private string body;
        private int rating;
        private DateTime time;

        private int btnRateIndex = 0;

        public int Track_id
        {
            get { return track_id; }
            set { track_id = value; }
        }

        public string NameAuthor
        {
            get { nameAuthor = txtAuthorName.Text; return nameAuthor; }
            set { nameAuthor = value; }
        }

        public string Sex
        {
            get { getSex(); return sex; }
            set { sex = value; }
        }

        private void getSex()
        {
            if (rdBtnMale.Checked)
            {
                sex = "male";
                return;
            }

            if (rdBtnFemale.Checked)
            {
                sex = "female";
                return;
            }

            sex = "none";
        }   

        public string Body
        {
            get { body = txtBodyCmt.Text; return body; }
            set { body = value; }
        }

        public int Rating
        {
            get { rating = btnRateIndex * 2; return rating; }
            set { rating = value; }
        }

        public DateTime Time
        {
            get { time = DateTime.Now; return time; }
            set { time = value; }
        }

        private void fillStarBtn(int length)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Guna2ImageButton)
                {
                    var btn = (Guna2ImageButton)ctl;

                    int index = Int32.Parse(btn.Tag.ToString());

                    if (index <= length)
                        btn.Image = Resources.star_fill_50px;
                    else
                        btn.Image = Resources.star_50px;
                 }

            }  
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            var btn = (Guna2ImageButton) sender;

            int index = Int32.Parse(btn.Tag.ToString());

            btnRateIndex = index;

            switch (index)
            {
                case 1:
                    fillStarBtn(1);
                    break;
                case 2:
                    fillStarBtn(2);
                    break;
                case 3:
                    fillStarBtn(3);
                    break;
                case 4:
                    fillStarBtn(4);
                    break;
                case 5:
                    fillStarBtn(5);
                    break;
            }
        }

        public event EventHandler AddCancelBtnLikeClick
        {
            add { btnCancel.Click += value; }
            remove { btnCancel.Click -= value; }
        }

        public event EventHandler AddSendBtnLikeClick
        {
            add { btnSend.Click += value; }
            remove { btnSend.Click -= value; }
        }
    }
}
