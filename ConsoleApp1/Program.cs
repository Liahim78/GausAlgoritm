using System;

namespace GausAlgoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArr = Console.ReadLine()?.Split(' ');
            if (stringArr == null) return;
            var x = int.Parse(stringArr[0]);
            var y = int.Parse(stringArr[1]) + 1;
            var matrix = new int[x, y];
            for (var i = 0; i < x; i++)
            {
                var currentStringArr = Console.ReadLine()?.Split(' ');
                if (currentStringArr == null) return;
                for (var j = 0; j < y; j++)
                    matrix[i, j] = int.Parse(currentStringArr[j]);
            }
            var myMatrix = new Matrix(matrix);
        }
    }

    enum GousResult
    {
        Yes,
        No,
        Inf
    }

    class Matrix
    {
        private int[,] _matrix;

        public Matrix(int x, int y)
        {
            _matrix = new int[x, y];
        }

        public Matrix(int [,] matrix)
        {
            _matrix = matrix;
        }

        public int[] GetGousResult(out GousResult strResult)
        {
            var result = new int[_matrix.GetLength(1)];
            strResult = GousResult.No;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                //Todo:
            }
            return result;
        }
    }
}
