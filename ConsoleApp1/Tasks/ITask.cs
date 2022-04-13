using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tasks
{
   public interface ITask
    {
        //attempted an interface however not sure if this was the right was so decided to stop work on this method 
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
