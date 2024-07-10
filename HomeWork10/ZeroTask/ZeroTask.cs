
using System.Collections;

namespace HomeWork10.ZeroTask
{
    public static class ZeroTask
    {
        public static void PointOne()
        {
            ArrayList list = new ArrayList();
            object s = list[18];
        }

        public static void PointTwo()
        {
            Dictionary<int, string> alphabet = new Dictionary<int, string>()
            {

                { 1, "a" },
                { 2, "b" },
                { 3, "c" },
                { 4, "d" },
                { 5, "e" },
                { 6, "f" },
                { 7, "g" },
                { 8, "h" },
                { 9, "i" },
                { 10, "g" },

            };

            Console.WriteLine(string.Join(" , \n", alphabet));
        }

        public static void PointThree()
        {
            string numbers = "1, 1, 2, 3, 4, 4, 5";   
            List<char> chars = new List<char>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if (Char.IsDigit(numbers[i]))
                {
                    chars.Add(numbers[i]);
                }
            }

            for(int i = 0; i < chars.Count; i++)
            {
                for(int j = i+1; j < chars.Count; j++)
                {
                    if (chars[i].Equals(chars[j]) && i != j)
                    {
                        chars.RemoveAt(j);
                    }  
                }
            }
            Console.WriteLine(string.Join(" , ", chars));
        }
    }
}

