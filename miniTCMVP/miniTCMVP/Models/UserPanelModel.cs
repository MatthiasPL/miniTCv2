using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCMVP.Models
{
    public class UserPanelModel
    {
        public string[] LoadDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            List<string> drives = new List<string> { };
            foreach (DriveInfo d in allDrives)
            {
                /*if (!d.IsReady)
                {
                    Console.Write("Dysk {0} nie jest gotowy.", d.Name);
                }
                else
                {*/
                drives.Add(d.Name);
                //}
            }
            return drives.ToArray();
        }
        public string[] LoadFolders(string path)
        {
            List<string> dirs = new List<string> { };
            List<string> files = new List<string> { };
            List<string> dirsfiles = new List<string> { };

            try
            {
                if (Directory.GetDirectories(path) != null)
                {
                    dirs = Directory.GetDirectories(path).ToList();
                    files = Directory.GetFiles(path).ToList();
                }
                dirsfiles.Add("..");
                dirsfiles.AddRange(dirs);
                dirsfiles.AddRange(files);
                return dirsfiles.ToArray();
            }
            catch (Exception ex)
            {
                if (ex is DirectoryNotFoundException)
                    Console.WriteLine("Directory not found: " + ex.Message);
                else if (ex is UnauthorizedAccessException)
                    MessageBox.Show(ex.Message);
            }
            return dirsfiles.ToArray();
        }

        private string FolderCutter(string path)
        {
            string exitFolder=path;
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
            {
                int index = exitFolder.LastIndexOf("\\");
                if (index > 0)
                    exitFolder = exitFolder.Substring(index + 1, exitFolder.Length - index - 1);
                exitFolder = "(D) " + exitFolder;
            }
            else
            {
                int index = exitFolder.LastIndexOf("\\");
                if (index > 0)
                    exitFolder = exitFolder.Substring(index + 1, exitFolder.Length - index - 1);
            }

            return exitFolder;
        }

        public string FolderUp(string path)
        {
            string exitPath = path;
            int index = path.LastIndexOf("\\");
            try
            {
                exitPath = exitPath.Remove(index, exitPath.Length - index);
            }
            catch(Exception ex)
            {
                
            }
            return exitPath;
        }
        public void CreateFolder(string path, string name)
        {
            if (name != "")
            {
                Directory.CreateDirectory(path + "\\" + name);
            }
        }
        public void RemoveFolder(string path)
        {
            Directory.Delete(path, true);
        }
    }
}
