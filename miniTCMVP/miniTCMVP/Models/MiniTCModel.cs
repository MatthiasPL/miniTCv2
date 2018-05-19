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
            try
            {
                if (name != "")
                {
                    Directory.CreateDirectory(path + "\\" + name);
                }
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        public void RemoveFolder(string path)
        {
            try
            {
                if (path != "")
                    Directory.Delete(path, true);
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        public void RemoveFile(string path)
        {
            try
            {
                if (path != "")
                    File.Delete(path);
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        //Method used to copy files
        public void Copy(string source, string output, string nameOutput)
        {
            try
            {
                if (source != "" && output != "" && nameOutput != "")
                {
                    File.Copy(source, output + "\\" + nameOutput, true);
                }
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        //Method used to copy directories
        public void Copy(string source, string output)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(source);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + source);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();
                if (!Directory.Exists(output))
                {
                    Directory.CreateDirectory(output);
                }

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(output, file.Name);
                    file.CopyTo(temppath, true);
                }

                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(output, subdir.Name);
                    Copy(subdir.FullName, temppath);
                }
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        public void Move(string source, string output)
        {
            try
            {
                if (source != "" && output != "")
                {
                    if (Directory.Exists(source))
                    {
                        Copy(source, output);
                        RemoveFolder(source);
                    }
                    else
                    {
                        Copy(source, output, FolderCutter(source));
                        RemoveFile(source);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd.");
            }
        }
        public string FolderCutter(string path)
        {
            string exitFolder = path;
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
            {
                int index = exitFolder.LastIndexOf("\\");
                if (index > 0)
                    exitFolder = exitFolder.Substring(index + 1, exitFolder.Length - index - 1);
                //exitFolder = "(D) " + exitFolder;
            }
            else
            {
                int index = exitFolder.LastIndexOf("\\");
                if (index > 0)
                    exitFolder = exitFolder.Substring(index + 1, exitFolder.Length - index - 1);
            }

            return exitFolder;
        }
    }
}
