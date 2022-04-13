using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class Folder

    {
        // Name of Folder
        public string FolderName { get; set; }

        // can store a list of items inside a folder using the model Items 
        List<Items> items = new List<Items>();

        // you should also be able to store a list of folders with a folder
        List<Folder> folders = new List<Folder>();


        public int FolderSize { get; set; }

        public DateTime FolderDateModified { get { return DateTime.Now; } }


    }
}

