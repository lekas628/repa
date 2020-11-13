using System;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;

namespace Practicum_2_1
{
    public class task_1
    {
        public static void run(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            ShowDirectory(dir, 0);
        }

        static void ShowDirectory(DirectoryInfo dir, int lvl)
        {
            try
            {
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    for (int i = 0; i < lvl; i++)
                        Console.Write("\t");
                    Console.WriteLine($"dir: {subDir.Name}");
                    ShowDirectory(subDir, lvl + 1);
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                return;
            }
        }
    }
    public class task_2
    {
        public static void run()
        {
            Console.WriteLine("The watcher");
            string path = @"C:\users\admin\Documents\";
            using (FileSystemWatcher watcher =
                new FileSystemWatcher())
            {
                watcher.Path = path;
                watcher.Filter = "*.docx";
                watcher.IncludeSubdirectories = true;
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName
                                     | NotifyFilters.Attributes
                                     | NotifyFilters.Size;

                watcher.Changed += watcher_Changed;

                watcher.EnableRaisingEvents = true;
                
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
    }
}
namespace Practicum_2_2
{
    public class task_1
    {
        public static void run(string file)
        {
            using (StreamWriter writer = File.CreateText(file))
            {
                writer.WriteLine("This is new file");
                writer.WriteLine("Test asdadasd");
            }

        }
    }
    public class task_2
    {
        public static void run(string file)
        {
            using (StreamReader reader = File.OpenText(file))
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            Console.WriteLine("type anything to close");
            Console.ReadKey();
            File.Delete(file);
        }
    }
}
namespace Practicum_2_3
{
    public class task_1
    {
        public static void run(string inFile, string outFile)
        {
            CompressFile(inFile, outFile);
        }
        static void CompressFile(string inFilename, string outFilename)
        {
            using (FileStream sourceFile = new FileStream(inFilename, 
                FileMode.Open))
            {
                using(FileStream destFile = new FileStream(outFilename,
                    FileMode.Create))
                {
                    using(GZipStream compStream = new GZipStream(destFile,
                        CompressionMode.Compress))
                    {
                        int theByte = sourceFile.ReadByte();
                        while (theByte !=  -1)
                        {
                            compStream.WriteByte((byte)theByte);
                            theByte = sourceFile.ReadByte();
                        }
                    }
                }
            }
        }
    }
    
    public class task_2
    {
        public static void run(string inFileGz, string outFile)
        {
            UncompressFile(inFileGz, outFile);    
        }

        static void UncompressFile(string inFilename, string outFilename)
        {
            using (FileStream sourseFile = 
                new FileStream(inFilename, FileMode.Open))
            {
                using (FileStream destFile = 
                    new FileStream(outFilename, FileMode.Create))
                {
                    using (GZipStream compStream =
                        new GZipStream(sourseFile, 
                        CompressionMode.Decompress))
                    {
                        int theByte = compStream.ReadByte();
                        while(theByte != -1)
                        {
                            destFile.WriteByte((byte)theByte);
                            theByte = compStream.ReadByte();
                        }
                    }
                }
            }
        }
    }
}
namespace Practicum_2_4
{
    class task_1
    {
        public static void run()
        {
            IsolatedStorageFile userStore = 
                IsolatedStorageFile.GetUserStoreForAssembly();

            using (IsolatedStorageFileStream userStream =
                new IsolatedStorageFileStream(
                    "UserSettings.set",
                    FileMode.Create,
                    userStore))
            {
                using (StreamWriter userWriter = 
                    new StreamWriter(userStream))
                {
                    userWriter.WriteLine("User Prefs");
                }
            }
        }
    }
    class task_2
    {
        public static void run()
        {
            IsolatedStorageFile userStore =
                IsolatedStorageFile.GetUserStoreForAssembly();
            string[] files = userStore.GetFileNames(
                "UserSettings.set");

            if (files.Length == 0)
                return;
            
            foreach (string file in files)
                Console.WriteLine(file);
            
            using (IsolatedStorageFileStream userStream = 
                new IsolatedStorageFileStream(
                    "UserSettings.set",
                    FileMode.Open,
                    userStore))
            {
                using (StreamReader userReader = 
                    new StreamReader(userStream))
                {
                    string contents = userReader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
        }
    }
}