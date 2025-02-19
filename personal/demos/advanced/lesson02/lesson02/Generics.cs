using System;
using System.Collections.Generic;

namespace lesson02
{
    class Generics<TKey>
    {
        private readonly List<TKey> _keys;

        public Generics()
        {
            _keys = new List<TKey>();
        }

        public void Method(TKey key)
        {
            // var blegh = new Stuff<TKey>();
            _keys.Add(key);
        }
    }
}
