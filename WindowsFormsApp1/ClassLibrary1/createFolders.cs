using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    static class  CreateFolders
    {
        public static string CreateXmlFolder()
        {
            string folder = @"..\XmlFeeds";
            var dir = new DirectoryInfo(folder);

            if (dir.Exists == false)
            {
                dir.Create();
            }
                
            return folder;

        }

        public static string CreateMp3Folder()
        {

            string folder = @"..\Mp3";
            var dir = new DirectoryInfo(folder);

            if (dir.Exists == false)
            {
                dir.Create();
            }
            return folder;

        }

	}

    
}
