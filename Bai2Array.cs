using System.Collections.Generic;
using System.Linq;

namespace KT1_2033216515_NguyenHoangPhuc
{
    internal class Bai2Array
    {
        private List<int> arr = new List<int>();

        public Bai2Array(string text)
        {
            string[] strSplit = text.Split(' ');

            foreach (string item in strSplit)
            {
                arr.Add(int.Parse(item));
            }
        }

        public List<int> sortArray()
        {
            List<int> arr2 = arr;
            arr2.Sort();
            return arr2;
        }

        public int Sumary()
        {
            return arr.Sum();
        }

        public int SumWithCondition()
        {
            int sum = 0;

            foreach (int i in arr)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
