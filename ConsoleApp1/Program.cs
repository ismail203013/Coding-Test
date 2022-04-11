using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
             void addItem(Items item)
             {
                if (item.ItemName == null)
                {
                    Console.WriteLine("Error please enter a file name");
                }
                else { 
                    // ADD item to list
                }
             }
            void RemoveItem(Items item) 
            {
                //Remove item form list
            }

            void TransferItem (Items item ,Folder folder)
            { 

            }


        }
    }
}
