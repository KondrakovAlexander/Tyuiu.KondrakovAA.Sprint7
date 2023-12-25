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
        public void SaveFile(string path, byte[] data, string savePath)
        {
            using (FileStream fileStream = new FileStream(Path.Combine(savePath, path), FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(data, 0, data.Length);
            }
        }

        public string GetVideoDuration(string file, string dir)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            dynamic shell = Activator.CreateInstance(shellAppType);

            dynamic folder = shell.NameSpace(dir);
            dynamic folderItem = folder.ParseName(file);
            string value = folder.GetDetailsOf(folderItem, 27).ToString();
            
            return value;
        }
    }
}
