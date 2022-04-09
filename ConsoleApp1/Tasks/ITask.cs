using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tasks
{
   public interface ITask
    {
        List<Folder> folders { get; set; }

        List<Items> items { get; set; }
        Task AddFolder();

        Task DeleteFolder();

        Task MoveFolder();

        Task AddItem();

        Task DeleteItem();

        Task MoveItem();
    }
}
