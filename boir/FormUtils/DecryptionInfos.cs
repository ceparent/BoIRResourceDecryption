using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BoIRResourceEditor.FormUtils
{
    public class DecryptionInfos
    {
        public DirectoryInfo SteamLocation { get; set; }
        public DirectoryInfo OutputLocation { get; set; }
        public string Debug { get; set; }

        public void WriteLine(string message)
        {
            Debug = message + Environment.NewLine + Debug;
        }
    }
}
