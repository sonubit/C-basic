using System;
    class IndexOutOfRange
    {
        public IndexOutOfRange()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        Console.WriteLine("hello");
        }
    static void Main(string[] args)
    {
        IndexOutOfRange i = new IndexOutOfRange();
    }
    }

