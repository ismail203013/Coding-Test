using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class Folder

    {
        public string FolderName { get; set; }


        List<Items> items = new List<Items>();


        List<Folder> folders = new List<Folder>();


        public int FolderSize { get; set; }

        public DateTime FolderDateModified { get { return DateTime.Now; } }


    }
}

