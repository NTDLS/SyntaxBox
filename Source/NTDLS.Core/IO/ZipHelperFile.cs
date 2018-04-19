using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NTDLS.IO
{
    public class ZipHelperFile : ZipHelperEntry
    {
        internal ZipHelperFile(ZipHelper owner, string path)
            : base(owner, path)
        {
        }

        public string Extension
        {
            get
            {
                return System.IO.Path.GetExtension(InternalZipEntry.Name);
            }
        }
    }
}
