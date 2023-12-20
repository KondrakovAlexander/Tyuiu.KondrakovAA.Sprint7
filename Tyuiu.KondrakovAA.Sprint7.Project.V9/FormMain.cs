using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint7.Project.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    public partial class FormMain_KAA : Form
    {
        DataService ds = new DataService();
        public FormMain_KAA()
        {
            InitializeComponent();
        }

        private void buttonLoadListener(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Video files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv";
            openFileDialog.Title = "Выберите видео файл для сохранения";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] fileData = File.ReadAllBytes(filePath);
                ds.SaveFile(Path.GetFileName(filePath), fileData);
            }
        }
        private void buttonAboutListener(object sender, EventArgs e)
        {
            FormAbout_KAA form = new FormAbout_KAA();
            form.ShowDialog();
        }
    }
}
