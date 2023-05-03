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

            //------------------Number Pyramid-----------//
            //int row = 6;
            //for(int i=1;i<=row;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //------------Inverted Number Pyramid--------------//
            //int row = 6;
            //for (int i = row; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //---------Number Pyramid increment----------------//
            //int row = 5;
            //int num = 1;
            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num + " ");
            //        num++;
            //    }
            //    Console.WriteLine();
            //}

            //----------- 0-1 Pyramid----------//
            //1
            //0 1
            //1 0 1
            //int row = 5;
            //for(int i=1;i<=row;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        int sum = i + j;
            //        if(sum % 2 == 0)
            //        {
            //            Console.Write(1 + " ");
            //        }
            //        else
            //        {
            //            Console.Write(0 + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //-------------------Butterfly Pattern---------------//
            int row = 5;
            //Upper half
            for(int i=1;i<=row; i++)
            {
                //1st part
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                //2nd part
                int spaces = 2 * (row - i);
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }
                //3rd part
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Lower half
            for (int i = row; i >= 1; i--)
            {
                //1st part
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                //2nd part
                int spaces = 2 * (row - i);
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }
                //3rd part
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //------------Solid Rhombus----------//
            int num = 5;
            for(int i = 1; i <= num; i++)
            {
                //print spaces
                for(int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                //print pattern
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }

}
