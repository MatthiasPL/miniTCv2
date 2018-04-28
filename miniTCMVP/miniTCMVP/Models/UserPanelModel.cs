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
            //string[] directories=new string[] { };
            try
            {
                if (Directory.GetDirectories(path) != null)
                {
                    dirs = Directory.GetDirectories(path).ToList();
                    for (int i = 0; i < dirs.Count; i++)
                    {
                        int index = dirs[i].LastIndexOf("\\");
                        if (index > 0)
                            dirs[i] = dirs[i].Substring(index + 1, dirs[i].Length - index - 1);
                        dirs[i] = "(D) " + dirs[i];
                        if (dirs[i][4] == '$')
                        {
                            dirs.RemoveAt(i);
                        }
                    }
                    files = Directory.GetFiles(path).ToList();
                    //string[] files = Directory.GetFiles(path).ToArray();
                    for (int i = 0; i < files.Count; i++)
                    {
                        int index = files[i].LastIndexOf("\\");
                        if (index > 0)
                            files[i] = files[i].Substring(index + 1, files[i].Length - index - 1);
                        if (files[i][0] == '$')
                        {
                            files.RemoveAt(i);
                        }
                    }
                }
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
    }
}
