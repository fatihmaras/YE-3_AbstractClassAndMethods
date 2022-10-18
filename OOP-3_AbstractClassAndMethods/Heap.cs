using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_AbstractClassAndMethods
{
    
        internal partial class Program
        {
            public abstract class Heap
            {
                //field
                protected SortedSet<int> _list;  // kalıtım devralınan sınıflarda protected ile ilgili yere erişirim sağlarz.
                public Heap()
                {
                    _list = new SortedSet<int>();
                }
                public void Insert(int item)
                {
                    _list.Add(item);
                }

                // abstract method __ abstract method tanımı yaparken sadece methodun imzasına yer verilir, gövdesi olmaz.

                public abstract int Extract();  // abstract ifadeler devralanınan sınıfta override edilmek zorunda.


            }

        }
    }

