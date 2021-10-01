using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
{
    public partial class PictureGUI : Form
    {
        private String path = "YuGiOh Card Lookup Pictures/";
        private String ext = ".png";
        public PictureGUI(String file, String title, String message)
        {
            InitializeComponent();
            try
            {
                String picture = path + file + ext;
                Picture_Box.Image = Image.FromFile(@picture);
            }
            catch(Exception){}
            Picture_Box.SizeMode = PictureBoxSizeMode.Zoom;
            Text = title;
            Text_Box.Text = message;
            Text_Box.Select(0, 0);
        }
    }
}
