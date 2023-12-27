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
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KondrakovAA.Sprint7.Project.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    public partial class FormStats_KAA : Form
    {
        DataService ds = new DataService();
        DirectoryInfo dr;
        public FormStats_KAA()
        {
            InitializeComponent();
        }

        public void setStats(object sender, EventArgs e)
        {
            chartDuration_KAA.Titles.Add("Средняя длительность видеофайлов по папкам");
            chartDuration_KAA.ChartAreas[0].AxisX.Title = "Имя папки";
            chartDuration_KAA.ChartAreas[0].AxisY.Title = "Средняя длительность";

            string[] folders = Directory.GetDirectories($@"{Directory.GetCurrentDirectory()}\videos");

            foreach(string folder in folders)
            {
                string[] files = Directory.GetFiles(folder);
                double avDir = 0;
                int count = 0;

                foreach (string file in files)
                {
                    string dir = Path.GetDirectoryName(file);
                    string fileName = Path.GetFileName(file);
                    string duration = ds.GetVideoDuration(fileName, dir).Replace(":", "");
                    count++;
                    avDir += Convert.ToInt32(duration);
                }

                avDir = avDir / count;
                chartDuration_KAA.Series[0].Points.AddXY(Path.GetFileName(folder), avDir);
                chartDuration_KAA.Invalidate();
            }
        }
    }
}
