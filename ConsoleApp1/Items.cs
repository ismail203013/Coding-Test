using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Items
    {

        public string ItemName { get; set; }

        public string DocType { get; set; }

        public int ItemSize { get; set; }

        public DateTime ItemDateModified { get { return DateTime.Now; } }

    }
}
