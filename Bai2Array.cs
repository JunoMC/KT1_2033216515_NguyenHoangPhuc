using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
