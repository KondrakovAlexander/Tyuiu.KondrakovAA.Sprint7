using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KondrakovAA.Sprint7.Project.V9.Lib
{
    class Video
    {
        int id;
        string path;
        int data;
        int duration;
        // Theme theme;
        int cost;   

        public string GetInfo()
        {
            string resp = "Код: " + id + " Дата: " + data + " Длительность: " + duration + " Стоимость: " + cost;



            return resp;
        }
    }
}
