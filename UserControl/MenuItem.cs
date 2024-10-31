using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_build
{
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        public string MenuName
        {
            get { return lblMenuName.Text; }
            set { lblMenuName.Text = value; }
        }

        public string MenuPrice
        {
            get { return lblMenuPrice.Text; }
            set { lblMenuPrice.Text = value; }
        }

        public Image MenuImage
        {

            get => Pic_drink.Image;
            set { Pic_drink.Image = value; }
            
        }

        public void setImageMode(PictureBoxSizeMode mode)
        {
            Pic_drink.SizeMode = mode;
        }

    }
}
