using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace POE
{
    class FileWrite
    {
        private object BinarySerialization;

        public void WriteData<T>(T objectToWrite, bool append = false)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string file = openFileDialog.FileName;
            Stream stream = File.Open(file, append ? FileMode.Append : FileMode.Create);
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(stream, objectToWrite);
        }
    }
}
