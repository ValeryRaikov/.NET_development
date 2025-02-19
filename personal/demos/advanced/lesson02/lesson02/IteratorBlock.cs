using System.Collections.Generic;

namespace lesson02
{
    static class IteratorBlock
    {
        public static IEnumerable<int> MyIteratorBlock(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> MyIteratorBlock2(IEnumerable<int> source)
        {
            foreach (int item in source)
            {
                yield return item * item;
            }
        }

        public static IEnumerable<int> FilterMin(IEnumerable<int> source, int min)
        {
            foreach (int item in source)
            {
                if (item > min)
                    yield return item;
            }
        }
    }
}
