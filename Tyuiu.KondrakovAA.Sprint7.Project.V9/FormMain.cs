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
            this.BackColor = Color.FromArgb(143, 0, 57);
            this.textBoxSearch_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.textBoxSearch_KAA.BackColor = Color.FromArgb(40, 0, 79);
            this.labelSearch_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonAbout_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonNature_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonSaveFile_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonStats_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonCuisine_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonScience_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonIT_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonVideogames_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonSports_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonMusic_KAA.BackColor = Color.FromArgb(186, 2, 60);
            this.buttonAbout_KAA.BackColor = Color.FromArgb(186, 2, 60);

            this.buttonAbout_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonNature_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonSaveFile_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonStats_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonCuisine_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonScience_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonIT_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonVideogames_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonSports_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonMusic_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.buttonAbout_KAA.ForeColor = Color.FromArgb(215, 255, 254);

            this.listBoxVideos_KAA.ForeColor = Color.FromArgb(215, 255, 254);
            this.listBoxVideos_KAA.BackColor = Color.FromArgb(40, 0, 79);
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

        private void aboutListener(object sender, EventArgs e)
        {
            FormAbout_KAA form = new FormAbout_KAA();
            form.ShowDialog();
        }

        private void statsListener(object sender, EventArgs e)
        {
            FormStats_KAA form = new FormStats_KAA();
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
                    dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos\Cooking");
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
            var fileNames = Directory.EnumerateFiles(dr.ToString(), "*.mp4", SearchOption.AllDirectories);

            foreach (string f in fileNames)
            {
                string dir = Path.GetDirectoryName(f);
                string fileName = Path.GetFileName(f);
                string file = selectedFile[0];
                FileInfo fileInfo = new FileInfo(f);
                string duration = ds.GetVideoDuration(fileName, dir);

                if (fileName == file)
                {
                    System.Diagnostics.Process.Start(f);
                }
            }
        }

        private bool IsVideoFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension == ".mp4" || extension == ".avi" || extension == ".mkv";
        }

        private void searchListener(object sender, EventArgs e) 
        {
            listBoxVideos_KAA.Items.Clear();

            dr = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\videos");
            var fileNames = Directory.EnumerateFiles(dr.ToString(), "*.mp4", SearchOption.AllDirectories);

            foreach (string file in fileNames)
            {
                string dir = Path.GetDirectoryName(file);
                string fileName = Path.GetFileName(file);
                FileInfo fileInfo = new FileInfo(file);
                string duration = ds.GetVideoDuration(fileName, dir);

                if (fileName.Contains(textBoxSearch_KAA.Text) && !String.IsNullOrEmpty(textBoxSearch_KAA.Text)) 
                {
                    listBoxVideos_KAA.Items.Add($"{fileInfo.Name} ({duration} сек., {fileInfo.CreationTime})");
                }
            }
        }
    }
}
