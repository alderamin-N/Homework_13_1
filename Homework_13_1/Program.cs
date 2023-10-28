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
       
}

