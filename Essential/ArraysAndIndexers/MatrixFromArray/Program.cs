using System;

namespace MatrixFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(2, 3);
            matrix.ShowMatrix();
            Console.WriteLine("");

            matrix.ChangeMatrixSize(5, 5);
            matrix.ShowMatrix();
            Console.WriteLine("");

            matrix.ShowMatrix(0,18,0,4);

            Console.ReadKey();
        }
    }
}
