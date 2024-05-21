using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer.UserControls
{
    public partial class ucPanelComments : UserControl
    {
        public ucPanelComments()
        {
            InitializeComponent();
        }

        public void setCommentItems(DataTable cmts)
        {
            flPnComments.Controls.Clear();

            if(cmts.Rows.Count > 0)
            {
                foreach(DataRow row in cmts.Rows)
                {
                    ucComment cmt = new ucComment();

                    cmt.Track_id = Int32.Parse(row[0].ToString());
                    cmt.NameAuthor = row[1].ToString();
                    cmt.Sex = row[2].ToString();
                    cmt.Body = row[3].ToString();
                    cmt.Rating = Int32.Parse(row[4].ToString());
                    cmt.Time = row[5].ToString();

                    flPnComments.Controls.Add(cmt);
                }
            }
        }

        public event EventHandler AddBtnAddCommentClick
        {
            add { btnAddComment.Click += value; }
            remove { btnAddComment.Click -= value; }
        }
    }
}
