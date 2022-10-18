using static OOP_3_AbstractClassAndMethods.Program;

namespace OOP_3_AbstractClassAndMethods
{
    internal partial class Program
    {
        public class MaxHeap : Heap
        {
            public override int Extract()
            {
                var item = _list.Max;
                _list.Remove(item);
                return item;

            }
        }

    }
}

