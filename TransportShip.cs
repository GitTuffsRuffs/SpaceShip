using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    public class TransportShip
    {
        public string name;
        public int size;
        public int available;
        Stack<Cargo> storage = new Stack<Cargo>();

        public TransportShip(string name, int size)
        {
            this.name = name;
            this.size = size;
            this.available = size;
        }

        public bool AddCargo(Cargo item)
        {
            //Add cargo to ship
            if(item.size >= available)
            {
                return false;
            }

            storage.Push(item);
            available -= item.size;
            return true;
        }

        public Cargo RemoveCargo()
        {
            if(storage.Count == 0)
            {
                return null;
            }

            //return and remove cargo.
            available += storage.Peek().size;
            return storage.Pop();
        }

        public void ListCargo()
        {
            if (storage.Count <= 0)
            {
                Console.WriteLine("<Empty>");
            } else {
                foreach(var box in storage)
                {
                    Console.WriteLine(box.description);
                }
            }
        }

    }
}
