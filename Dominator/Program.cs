using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {3,4,3,2,3,-1,3,3};

            List<int> dominatorIndexes = DominatorIndexes(arr);
            dominatorIndexes.ForEach(x=> Console.WriteLine("Dominator Indexes are: {0}", x));
            Console.Read();
        }

        private static List<int> DominatorIndexes(int[] arr)
        {
            Dictionary<int,List<int>> _dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(_dic.ContainsKey(arr[i]))
                    _dic[arr[i]].Add(i);
                else
                    _dic.Add(arr[i],new List<int>() {i});
            }

            return _dic.First(x => x.Value.Count > arr.Length / 2).Value;
        }
    }
}
