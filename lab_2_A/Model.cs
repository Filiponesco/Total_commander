using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_2_A
{
    class Model
    {  
        public String[] ShowFiles(string currDisk)
        {
            if (Directory.Exists(currDisk))
            {
                string[] files = Directory.GetFiles(currDisk);
                string[] dirs = Directory.GetDirectories(currDisk);
                string[] result = files.Concat(dirs).ToArray();
                return result;
            }
            else return null;
        }
        public void Model_Copy(string from, string to)
        {
            string destFile = Path.Combine(to, Path.GetFileName(from));

            File.Copy(from, destFile);
        }
    }
}
