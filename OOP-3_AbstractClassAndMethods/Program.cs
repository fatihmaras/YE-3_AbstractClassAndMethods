using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_3_AbstractClassAndMethods.Program;

namespace OOP_3_AbstractClassAndMethods
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //  var heap = new Heap();   --- abstract ifadeler türetme yapılmaz.

            var arr = new int[] { 3, 2, 1, 4, 5 };
            var minheap = new MinHeap();
            var maxheap = new MaxHeap();

            foreach (var item in arr)
            {
                minheap.Insert(item);
                maxheap.Insert(item);
            }

            Console.WriteLine(minheap.Extract());   //1 
            Console.WriteLine(maxheap.Extract());   // 5 
            Console.ReadKey();


        }

    }
}
