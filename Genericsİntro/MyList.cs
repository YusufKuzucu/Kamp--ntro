using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici array
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];// geçici array daki verileri geri aldık
            }
            items[items.Length - 1] = item;
            Console.WriteLine( item);
        }
    }
}
