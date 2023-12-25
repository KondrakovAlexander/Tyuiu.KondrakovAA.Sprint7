using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Tyuiu.KondrakovAA.Sprint7.Project.V9.Lib;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    public partial class FormSaveFile_KAA : Form
    {
        DateTime localDate;
        DataService ds = new DataService();
        string filePath;
        byte[] fileData;
        string fileName;
        string savePath;

        public FormSaveFile_KAA()
        {
            InitializeComponent();
        }

        private void buttonLoadListener(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Video files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv";
            openFileDialog.Title = "Выберите видеофайл для сохранения";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                FileInfo fileInfo = new FileInfo(filePath);
                fileData = File.ReadAllBytes(filePath);

                localDate = DateTime.Today;
                textBoxDateTime_KAA.Text = localDate.ToString("d");

                string dir = Path.GetDirectoryName(filePath);
                string file = Path.GetFileName(filePath);

                string value = ds.GetVideoDuration(file, dir);
                textBoxDuration_KAA.Text = value;
            }
        }

        bool allTextBoxesIsNotEmpty()
        {
            bool AllIsOk = false;
            if (textBoxName_KAA.TextLength > 0 && textBoxDateTime_KAA.TextLength > 0 && textBoxDuration_KAA.TextLength > 0 && comboBoxTheme_KAA.SelectedIndex != -1)
            {
                AllIsOk = true;
            }
            return AllIsOk;
        }

        void TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxTheme_KAA.SelectedItem)
            {
                case "Природа":
                    savePath = $@"{Directory.GetCurrentDirectory()}\videos\Nature";
                    break;
                case "Спорт":
                    savePath = $@"{Directory.GetCurrentDirectory()}\videos\Sports";
                    break;
                case "Наука":
                    savePath = $@"{Directory.GetCurrentDirectory()}\videos\Science";
                    break;
                case "Видеоигры":
                    savePath = $@"{Directory.GetCurrentDirectory()}\videos\Videogames";
                    break;
            }
            fileName = textBoxName_KAA.Text;
            buttonEnter_KAA.Enabled = allTextBoxesIsNotEmpty();
        }

        private void buttonEnterListener(object sender, EventArgs e)
        {
            string filePath = openFileDialog_KAA.FileName;

            ds.SaveFile(fileName.Replace(' ', '_') + ".mp4", fileData, savePath);
            this.Close();
        }
    }
}
