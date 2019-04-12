using System;
using System.IO;
namespace Selection_9
{
    public class Paths
    {
        public void ExamplePath()
        {
            var path = @"E:\Pelatihan\HariKe-18\CSharpBeginners\CsharpBeginners\CsharpBeginners.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension : {0}", Path.GetExtension(path));
            Console.WriteLine("File name : {0}", Path.GetFileName(path));
            Console.WriteLine("File name without extension : {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name : {0}", Path.GetDirectoryName(path));
        }
    }
}
