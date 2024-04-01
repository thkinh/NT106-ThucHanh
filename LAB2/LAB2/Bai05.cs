using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                DialogResult = fd.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    DirectoryInfo di = new DirectoryInfo(fd.SelectedPath);
                    FileInfo[] files = di.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        //string data = "";
                        //data += file.Name + "\t\t" + file.Length + "bytes" + "\n";
                        ListViewItem item = Files_list.Items.Add(file.Name);
                        item.SubItems.Add(file.Length.ToString() + " bytes");
                        item.SubItems.Add(file.Extension);
                        item.SubItems.Add(file.CreationTime.ToString());
                    }
                }
            }
        }


    }
}
