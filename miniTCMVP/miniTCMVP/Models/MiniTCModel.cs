using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Models
{
    public class MiniTCModel
    {
        public void CreateFolder(string path, string name)
        {
            if (name != "")
            {
                Directory.CreateDirectory(path + "\\" + name);
            }
        }
        public void RemoveFolder(string path)
        {
            if (path != "")
                Directory.Delete(path, true);
        }
        public void Copy(string source, string output, string nameSource, string nameOutput)
        {
            if(source!="" && output != "" && nameSource!="" && nameOutput!="")
            {
                
            }
        }
    }
}
