using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tasks
{
    public class Task : ITask
    {
        //methods of the tasks that would be called, depending on the type of application 
        public List<Folder> folders { get; set; }
        public List<Items> items { get; set ; }

        public Task AddFolder()
        {
            throw new NotImplementedException();
        }

        public Task AddItem()
        {
            throw new NotImplementedException();
        }

        public Task DeleteFolder()
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem()
        {
            throw new NotImplementedException();
        }

        public Task MoveFolder()
        {
            throw new NotImplementedException();
        }

        public Task MoveItem()
        {
            throw new NotImplementedException();
        }
    }
}
