using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mf
{
    public partial class Form1 : Form
    {
        public string PathViewLeft;
        public string PathViewRight;

        public Form1()
        {
            InitializeComponent();

            PathViewLeft = @"C:\";

            IEnumerable<string> dirs
              = Directory.EnumerateDirectories(PathViewLeft, "*", SearchOption.TopDirectoryOnly);

            label1.Text = PathViewLeft;

            foreach (string file in dirs)
            {
                string[] itm = { "", Path.GetFileName(file), "[DIR]", "" };
                var lst = new ListViewItem(itm);
                listView1.Items.Add(lst);
            }

            IEnumerable<string> files
              = Directory.EnumerateFiles(PathViewLeft, "*", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                string[] itm = { "", file, "", "" };
                var lst = new ListViewItem(itm);
                listView1.Items.Add(lst);
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch ( e.KeyCode)
            {
                case Keys.Enter:
                    var ext = listView1.SelectedItems[0].SubItems[2].Text;
                    if( ext == "[DIR]")
                    {
                        PathViewLeft += listView1.SelectedItems[0].SubItems[1].Text + "\\";
                        
                    }
                    break;
            }
        }
    }
}
