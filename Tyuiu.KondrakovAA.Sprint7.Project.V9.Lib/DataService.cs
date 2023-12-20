using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public void SaveFile(string path, byte[] data)
        {
            string SavePath = $@"{Directory.GetCurrentDirectory()}\videos";

            using (FileStream fileStream = new FileStream(Path.Combine(SavePath, path), FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(data, 0, data.Length);
            }
        }
    }
}
