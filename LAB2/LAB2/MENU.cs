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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai05 bai5 = new Bai05();
            this.Hide();
            bai5.Show();
        }
    }
}
