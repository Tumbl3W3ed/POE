using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace POE
{
    class FileRead
    {
        public Object ReadData<type>()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            string file = openFileDialog.FileName;
            Stream stream = File.Open(file, FileMode.Open);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            return (type)binaryFormatter.Deserialize(stream);
        }
    }
}
