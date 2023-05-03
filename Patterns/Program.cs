namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //-------------solid Rectangle 4*5---------------//
            //int rows = 4, col = 5;
            //for(int i=1;i<= rows; i++)
            //{
            //    for(int j=1;j<= col; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //----Hollow Rectangle Pattern---------//
            //int rows = 7, col = 7;
            //for(int i=1;i<=rows;i++)
            //{
            //    for(int j = 1; j <= col; j++)
            //    {
            //        if(i == 1 || j==1 || i == rows || j == col)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //-----Half Pyramid----------//
            //int row = 5;
            //for(int i=1;i<=row;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //----------Inverted Half Pyramid---------//
            //int row = 7;
            //for (int i = row; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //----------180deg Inverted Half Pyramid---------//
            //int row = 7;
            //for (int i = 1; i <= row; i++)
            //{
            //    //for space print
            //    for(int k=1;k<= row-i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //for star print
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Number Pyramid
            int row = 6;
            for(int i=1;i<=row;i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }

}
