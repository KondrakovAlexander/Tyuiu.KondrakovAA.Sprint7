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
        DirectoryInfo dr;
        public FormMain_KAA()
        {
            InitializeComponent();
        }

        private void buttonLoadListener(object sender, EventArgs e)
        {
            FormSaveFile_KAA form = new FormSaveFile_KAA();
            form.ShowDialog();
        }
        private void buttonAboutListener(object sender, EventArgs e)
        {
            FormAbout_KAA form = new FormAbout_KAA();
            form.ShowDialog();
        }

        private void setTheme(object sender, EventArgs e)
        {
            listBoxVideos_KAA.Items.Clear();

            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Природа":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Nature");
                    break;
                case "Наука":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Science");
                    break;
                case "Спорт":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Sports");
                    break;
                case "Видеоигры":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Videogames");
                    break;
                case "Музыка":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Music");
                    break;
                case "Технологии":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Tech");
                    break;
                case "Кулинария":
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Cuisine");
                    break;
            }

            string[] filePaths = Directory.GetFiles(Convert.ToString(dr));
            foreach (string filePath in filePaths)
            {
                if (IsVideoFile(filePath))
                {
                    string dir = Path.GetDirectoryName(filePath);
                    string fileName = Path.GetFileName(filePath);
                    FileInfo fileInfo = new FileInfo(filePath);
                    string duration = ds.GetVideoDuration(fileName, dir);
                    listBoxVideos_KAA.Items.Add($"{fileInfo.Name} ({duration} сек., {fileInfo.CreationTime})");
                }
            }

        }

        private void listBoxVideosListener(object sender, EventArgs e)
        {
            string[] selectedFile = Convert.ToString(listBoxVideos_KAA.SelectedItem).Split(' ');
            string fileName = dr + "\\" + selectedFile[0];
            System.Diagnostics.Process.Start(fileName);
        }

        private bool IsVideoFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension == ".mp4" || extension == ".avi" || extension == ".mkv";
        }
    }
}
