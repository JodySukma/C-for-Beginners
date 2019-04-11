using System.IO;
using System;

namespace Selection_9
{
    public class DirectoryAndDirectories
    {
        public void CreateAndCekDirectory()
        {
            Directory.CreateDirectory(@"e:\temp\folder");

            //var files = Directory.GetFiles(@"e:\pelatihan\HariKe-18\CSharpBeginners", "*.sln", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"e:\pelatihan\HariKe - 18\CSharpBeginners", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
        
    }
}
