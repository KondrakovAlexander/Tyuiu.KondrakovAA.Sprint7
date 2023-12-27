using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    public partial class FormAbout_KAA : Form
    {
        public FormAbout_KAA()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(40, 0, 79);
            this.label1.ForeColor = Color.FromArgb(215, 255, 254);
            this.label2.ForeColor = Color.FromArgb(215, 255, 254);
            this.label3.ForeColor = Color.FromArgb(215, 255, 254);
            this.label4.ForeColor = Color.FromArgb(215, 255, 254);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(dir + "\\Debug\\Tyuiu.SolievAH.Sprint7.Projcet.V10.exe");
        }
    }
}
