using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // here i defined all the medthod that should be used for the application

           
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
                //transfer the item to another folder
            }

            void SearchResult (Items item, Folder folder)
            {
                // take in user input and use it to sreach for anything that matchs in the list
                // return the matchs 
                // could do this using a foreach loop 
            }


        }
    }
}
