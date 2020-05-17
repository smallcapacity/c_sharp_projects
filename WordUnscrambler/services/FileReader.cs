using System;
using System.IO;

namespace WordUnscrambler.services
{
    public class FileReader
    {
        public string[] Read(string fileName)
        {
            string[] fileContent = null;
            try
            {
                fileContent = File.ReadAllLines(fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}