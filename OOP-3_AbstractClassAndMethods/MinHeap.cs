using static OOP_3_AbstractClassAndMethods.Program;

namespace OOP_3_AbstractClassAndMethods
{
    internal partial class Program
    {
        public class MinHeap : Heap
        {
            public override int Extract()
            {
                var item = _list.Min;
                _list.Remove(item);
                return item;

            }
        }

    }
}

