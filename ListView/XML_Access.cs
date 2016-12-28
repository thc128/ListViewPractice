using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace ListView
{
    class XML_Access
    {
        public static XElement DataRoot;
        public static string DataPath = @"C:\Users\asaf\Desktop\תרגול בC++\ListView\ListView\data1.xml";
        public XML_Access()
        {
            if(File.Exists(DataPath))
            {
                LoadData();
            }
            else
            {
                CreateFile();
                throw new Exception("File not found");
            }
        }

        void CreateFile()
        {
        }

        void LoadData()
        {
            try
            {
                DataRoot = XElement.Load(DataPath);
            }
            catch
            {
                throw new Exception("Cannot open the file");
            }
        }
    }
}
 
