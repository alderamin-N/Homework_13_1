namespace Homework_13_1
{
        internal class Program
        {
            static void Main(string[] args)
            {

                List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                List<int> listNew = new List<int>(number.Top(30));

                foreach (int n in listNew)
                {
                    Console.WriteLine(n);
                }

            }
        }
        public static class EnumerableExtentions
        {
            public static IEnumerable<T> Top<T>(this IEnumerable<T> list, int number)
            {
                if (number < 1 || number > 100)
                {
                    throw new ArgumentException("Процент был указан меньше 1 или больше 100");
                }
                int count = (int)Math.Ceiling(((list.Count() * (double)number) / 100));
                return list.OrderByDescending(x => x).Take(count);

            }

            public static IEnumerable<T> Top<T, P>(this IEnumerable<T> list, int number, Func<T, P> condition)
            {
                if (number < 1 || number > 100)
                {
                    throw new ArgumentException("Процент был указан меньше 1 или больше 100");
                }
                int count = (int)Math.Ceiling(((list.Count() * (double)number) / 100));
                return list.OrderByDescending(condition).Take(count);

            }
        }   
}

