using System.IO;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MolokanovNK.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
           using(StreamReader reader = new StreamReader(path))
           {
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                    len++; 
               }
           }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(num => num > 2 && num < 7).ToArray();

            return numsArray;

        }
    }
}
