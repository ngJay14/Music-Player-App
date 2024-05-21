using musicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer.UserControls
{
    public partial class ucComment : UserControl
    {
        public ucComment()
        {
            InitializeComponent();
        }

        private int track_id;
        private string nameAuthor;
        private string sex;
        private string body;
        private int rating;
        private string time;

        public int Track_id
        {
            get { return track_id; }
            set { track_id = value; }
        }

        public string NameAuthor
        {
            get { return nameAuthor; }
            set { nameAuthor = value; lbName.Text = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; setSex(value); }
        }

        public string Body
        {
            get { return body; }
            set { body = value; richTxtBody.Text = value; setSizeofRichTextbox(); }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; lbTime.Text = value; setLocaOfLbTime(); }
        }

        private void setSex(string sex)
        {
            if (sex == "male")
                pcImage.Image = Resources.male_50px;
            else
                pcImage.Image = Resources.female_50px;
        }

        private void setLocaOfLbTime()
        {
            int x = pnContent.Location.X;
            int y = pnContent.Location.Y + pnContent.Height + 5;

            Point point = new Point(x, y);

            lbTime.Location = point;
        }

        void setSizeofRichTextbox()
        {
            lbBody.Visible = false;
            lbBody.Text = body;

            int width = lbBody.Width;
            int height = lbBody.Height;
            int padding = 5;

            richTxtBody.Size = new Size(width + padding, height + padding);
            richTxtBody.Cursor = Cursors.Arrow;

            pnContent.Size = new Size(richTxtBody.Height + padding, lbName.Height + richTxtBody.Height + padding);

            this.Size = new Size(400, pnContent.Height + padding*10);

        }
    }
}
