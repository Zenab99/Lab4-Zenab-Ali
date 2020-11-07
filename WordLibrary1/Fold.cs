using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLibrary1
{
    
        public static class Fold
        {
            private static string PathFiles => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            public static string Specfile => Path.Combine(PathFiles, "WordLibrary1");

            public static void CreateFolder()
            {
                Directory.CreateDirectory(Specfile);
            }

            public static string GetFilePath(string name)
            {
                return $"{Specfile}\\{name}.dat";
            }
        }
    
}
