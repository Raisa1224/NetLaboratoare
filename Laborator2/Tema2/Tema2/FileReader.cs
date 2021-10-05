using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class FileReader
    {
        List<string> DataLines;
        string header;
        public FileReader(string FilePath)
        {
            DataLines = new List<string>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            this.header = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                // Check if it's a line that contains data
                if (-1 != line.IndexOfAny("12345678abcdefghijklmnopqrstuvxyz".ToCharArray()))
                {
                    this.DataLines.Add(line);
                }
            }

            file.Close();

        }

        public void OverwriteData(string FilePath)
        {
            DataLines = new List<string>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            this.header = file.ReadLine();

            while ((line = file.ReadLine()) != null)
            {
                // Check if it's a line that contains data
                if (-1 != line.IndexOfAny("12345678abcdefghijklmnopqrstuvxyz".ToCharArray()))
                {
                    this.DataLines.Add(line);
                }
            }

            file.Close();

        }
        public List<string> GetDataLines()
        {
            return this.DataLines;
        }
    }
}
