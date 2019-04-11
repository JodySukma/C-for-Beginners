using System.IO;

namespace Selection_9
{
    public class FileAndFileInfo
    {
        public void exampleFileAndFileInfo()
        {
            var path = @"e:\somefile.jpg";

            File.Copy(@"e:\temp\myfile.jpg", @"e:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                // do something about file at disk E
            }

            var content = File.ReadAllText(path);
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // do someting about info file at disk E
            }

        }
    }
}
