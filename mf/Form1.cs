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
        public Form1()
        {
            InitializeComponent();

            IEnumerable<string> dirs
              = Directory.EnumerateDirectories(@"C:\", "*", SearchOption.TopDirectoryOnly);

            foreach (string file in dirs)
            {
                string[] itm = { "", file, "", "" };
                var lst = new ListViewItem(itm);
                listView1.Items.Add(lst);
            }

            IEnumerable<string> files
              = Directory.EnumerateFiles( @"C:\", "*", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                string[] itm = { "", file, "", "" };
                var lst = new ListViewItem(itm);
                listView1.Items.Add(lst);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
