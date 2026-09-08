using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> LinkedList = new LinkedList<string>();

            LinkedList.AddLast("Node 1");
            LinkedList.AddLast("Node 2");
            LinkedList.AddFirst("Node 0");

            LinkedListNode<string> node1 = LinkedList.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            Debug.Log(node1.Previous.Value);

            var firstNode = LinkedList.First;
            var lastNode = LinkedList.Last;
            Debug.Log(firstNode.Previous);
            Debug.Log(lastNode.Next);

            LinkedList.AddAfter(node1, "Node 1.5");
            LinkedList.AddBefore(node1, "Node 0.5");

            LinkedList.RemoveFirst();
            LinkedList.RemoveLast();
            LinkedList.Remove("Node 1.5");

            LinkedList.Clear();

            Debug.Log("----");
            foreach(var item in LinkedList)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
           Hashtable table = new Hashtable();
            table.Add("Potion", 5);
            

                foreach (var item in table)
            {
                Debug.Log($"item");
            }
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string , int>  inv = new Dictionary<string , int>();
            //var inv = new Dictionary<string , int>();

            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            inv["Apple"] = 0;

            int potion = inv["Potion"];
            Debug.Log("potion: " + potion);

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log("hasPotion: " + hasPotion);

            inv.Remove("Banana");

            foreach (KeyValuePair<string , int> kvp in inv )
            {
                var key = kvp.Key;
                var value = kvp.Value;
                Debug.Log($"{key} ==> {value}");
            }

            inv.Clear();
        }

        #endregion
    }
}
