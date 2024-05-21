using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer
{
    public partial class ucTypeTrack : UserControl
    {
        public ucTypeTrack()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private Image typeImage;
        private string txtType;

        public Image TypeImage 
        { 
            get { return typeImage; } 
            set { typeImage = value; pcTypeImage.Image = value; }
        }

        public string TxtType
        {
            get { return txtType; }
            set { txtType = value; lbText.Text = value; }
        }

    }
}
