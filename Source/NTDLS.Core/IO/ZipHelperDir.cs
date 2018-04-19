using System;
using System.Collections.Generic;
using System.Text;
using NTDLS.IO.Compression.Zip;

namespace NTDLS.IO
{
    public class ZipHelperDir : ZipHelperEntry
    {

        internal ZipHelperDir(ZipHelper owner,string path)
            :base(owner,path)
        {
        }

        public string[] GetDirs()
        {
            return OwnerZip.GetDirs(this.Path);
        }
        public string[] GetFiles()
        {
            return OwnerZip.GetFiles(this.Path);
        }
    }
}
