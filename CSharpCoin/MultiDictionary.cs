using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoin
{
    class MultiDictionary<TKey, TValue>
    {
        private Dictionary<TKey, List<TValue>> data = new Dictionary<TKey, List<TValue>>();

        public void Add(TKey k, TValue v)
        {
            // can be a optimized a little with TryGetValue, this is for clarity
            if (data.ContainsKey(k))
                data[k].Add(v);
            else
                data.Add(k, new List<TValue>() { v });
        }

        public void Remove(TKey k, TValue v)
        {
            if (data.ContainsKey(k))
                data[k].Remove(v);
            else
                Console.WriteLine("The KEY specified doesn´t exists!");
        }

        public void GetValueList(TKey k)
        {
            if (data.ContainsKey(k))
            {
                foreach(KeyValuePair<TKey, List<TValue>> kvp in data)
                    foreach (TValue value in kvp.Value)
                        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, value);
            }
            else
            {
                Console.WriteLine("The KEY specified doesn´t exists!");
            }
        }

        // more members
    }
}
