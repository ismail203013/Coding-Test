using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class Folder

    {
        public string FolderName { get; set; }

        public Folder folder { get; set; }

        public Items item { get; set; }

        public int FolderSize { get; set; }

        public DateTime FolderDateModified { get { return DateTime.Now; } }

    }
}

