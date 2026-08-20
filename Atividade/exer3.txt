using System.ComponentModel;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
        namespace Lista
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> Lista1 = new List<int> { 2, 4, 6, 8, 3, 1, 9, 7, 5 };

                List<int> Lista2 = new List<int> { 10, 14, 16, 12, 13, 17, 18, 19, 11 };

                List<List<int>> Tudo = new List<List<int>> { Lista1, Lista2 };


                foreach (var t in Tudo)
                {
                    t.Sort();


                    foreach (var item in t)
                    {
                        Console.WriteLine(item);

                    }
                }
            }
        }
    }
}
    }
}
