using System;

namespace MatrixFromArray
{
    class MyMatrix
    {
        int rows;
        int colomns;

        int[,] matrix;

        public MyMatrix(int rows, int colomns)
        {
            this.rows = rows;
            this.colomns = colomns;
            matrix = new int[rows, colomns];
            FillMatrix(matrix);
        }

        public void FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int index1 = 0; index1 < matrix.GetLength(0); index1++)
            {
                for (int index2 = 0; index2 < matrix.GetLength(1); index2++)
                {
                    matrix[index1, index2] = random.Next(0, 9);
                }
            }
        }

        public void ShowMatrix()
        {
            ShowMatrix(0, rows, 0, colomns);
        }

        public void ChangeMatrixSize(int rowsNew, int colomnsNew)
        {
            int[,] matrixResized = new int[rowsNew, colomnsNew];
            for (int rowIndex = 0; rowIndex < rowsNew; rowIndex++)
            {
                if (rowIndex < rows)
                {
                    for (int colomnsIndex = 0; colomnsIndex < colomnsNew; colomnsIndex++)
                    {
                        if (colomnsIndex < colomns)
                        {
                            matrixResized[rowIndex, colomnsIndex] = matrix[rowIndex, colomnsIndex];
                        }
                        else
                        {
                            matrixResized[rowIndex, colomnsIndex] = 1;
                        }
                    }
                }
                else
                {
                    for (int colomnsIndex = 0; colomnsIndex < colomnsNew; colomnsIndex++)
                    {
                        matrixResized[rowIndex, colomnsIndex] = 1;
                    }
                }
            }
            rows = rowsNew;
            colomns = colomnsNew;
            matrix = matrixResized;
        }

        public void ShowMatrix(int rowsStart, int rowsEnd, int colomnsStart, int colomnsEnd)
        {
            if (colomnsStart >= 0 && colomnsStart < colomnsEnd && colomnsEnd <= colomns
                && rowsStart >= 0 && rowsStart < rowsEnd && rowsEnd <= rows)
            {
                for (int rowIndex = rowsStart; rowIndex < rowsEnd; rowIndex++)
                {
                    for (int colomnIndex = colomnsStart; colomnIndex < colomnsEnd; colomnIndex++)
                    {
                        Console.Write(matrix[rowIndex, colomnIndex] + "\t");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Requested scope is out of array range");
            }
        }
    }
}
