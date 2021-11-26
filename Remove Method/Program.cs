/********************************************************************************************************/
/* file Name: Remove Method.sln                                                                         */
/* file info: This file for remove an element from doubly linkend list.                                 */
/* version  : V1.0                                                                                      */
/* Date     : 20 Nov021                                                                                 */
/* Author   : Ahmed Zoher                                                                               */
/********************************************************************************************************/
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Remove_Method
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ZOHERLinkedList = new LinkedList<string>();

            LinkedListNode<string> ZOHERNode1 = ZOHERLinkedList.AddFirst("Mohammed");

            ZOHERLinkedList.AddLast("Abd Elmaged");
            ZOHERLinkedList.AddAfter(ZOHERNode1, "Zohir");
            ZOHERLinkedList.AddBefore(ZOHERNode1, "Ahmed");
            ZOHERLinkedList.AddLast("EL-KONE");

            Console.WriteLine("\t\t---> The linked List Before Deletion <---\n");
            Console.Write("[HEAD] --> ");

            foreach (var item in ZOHERLinkedList)
            {
                Console.Write(item + " --> ");
            }

            Console.WriteLine("[NULL]\n");

            ZOHERLinkedList.RemoveFirst();
            ZOHERLinkedList.Remove("Abd Elmaged");
            ZOHERLinkedList.RemoveLast();

            Console.WriteLine("\t\t---> The linked List After Deletion  <---\n");
            Console.Write("[HEAD] --> ");

            foreach (var item in ZOHERLinkedList)
            {
                Console.Write(item + " --> ");
            }

            Console.WriteLine("[NULL]\n");

            Console.WriteLine("\t\t---> ******************************* <---\n");
        }

    }
}
