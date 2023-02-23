namespace MyArrays
{
    #region Array Methods
    class ArrayHandler
    {
        public static int[] GetRandomArray(int length, int minVal, int maxVal)
        {
            int[] arr = new int[length];

            Random rnd = new Random();

            for (int i = 0; i < length; i++)
                arr[i] = rnd.Next(minVal, maxVal + 1);

            return arr;           
        }

        public static double[] GetRandomArray(int length, double minVal, double maxVal)
        {
            double[] arr = new double[length];

            Random rnd = new Random();

            for (int i = 0; i < length; i++)
                arr[i] = minVal + rnd.NextDouble() * (maxVal - minVal);

            return arr;         
        }

        public static string ArrayToString<T>(T[] array, string separator = " ")
        {
            string result = string.Empty;

            for (int i = 0; i < array.Length; i++)
                result += array[i] + separator;
            
            result += Environment.NewLine;

            return result;
        }

        public static int[] GetMinAndMaxElements(int[] array)
        {
            int[] arrMinMax = new int[2];

            arrMinMax[0] = array[0];
            arrMinMax[1] = array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] < arrMinMax[0]) arrMinMax[0] = array[i];
                else if (array[i] > arrMinMax[1]) arrMinMax[1] = array[i];

            return arrMinMax;
        } 

        public static double[] GetMinAndMaxElements(double[] array)
        {
            double[] arrMinMax = new double[2];

            arrMinMax[0] = array[0];
            arrMinMax[1] = array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] < arrMinMax[0]) arrMinMax[0] = array[i];
                else if (array[i] > arrMinMax[1]) arrMinMax[1] = array[i];

            return arrMinMax;
        }

        public static int[] GetMinAndMaxElementsPositions(int[] array)
        {
            int[] arrMinMaxPos = new int[2];

            arrMinMaxPos[0] = 0;
            arrMinMaxPos[1] = 0;

            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[arrMinMaxPos[0]]) arrMinMaxPos[0] = i;
                else if (array[i] > array[arrMinMaxPos[1]]) arrMinMaxPos[1] = i;

            return arrMinMaxPos;
        } 

        public static int[,] GetRandomMatrix(int rowsNumber, int columnsNumber, int minVal = -10, int maxVal = 10)
        {
            int[,] result = new int[rowsNumber, columnsNumber];
            Random rand = new Random();

            for (int i = 0; i < rowsNumber; i++)
                for (int j = 0; j < columnsNumber; j++)
                result[i, j] = rand.Next(minVal, maxVal + 1);
        
            return result;
        }

        public static double[,] GetRandomMatrix(int rowsNumber, int columnsNumber, double minVal = -10, double maxVal = 10, int roundDigits = 2)
        {
            double[,] result = new double[rowsNumber, columnsNumber];
            Random rand = new Random();

            for (int i = 0; i < rowsNumber; i++)
                for (int j = 0; j < columnsNumber; j++)
                    result[i, j] = Math.Round(minVal + rand.NextDouble() * (maxVal - minVal), roundDigits);

            return result;
        }

        public static string MatrixToString<T>(T[,] matrix, int row = -1, int col = -1)
        {
            string result = string.Empty;

            for (int i = (row == -1 ? 0 : row); i < (row == -1 ? matrix.GetLength(0) : row + 1); i++)
            {
                for (int j = (col == -1 ? 0 : col); j < (col == -1 ? matrix.GetLength(1) : col + 1); j++)
                    result += $"{matrix[i, j]} ";

                result += Environment.NewLine;
            }

            return result;
        }

        public static void SortMatrixRows(int[,] matrix, bool ascending = true)
        {
            int rowLenght = matrix.GetLength(1);
            int temp = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int numOfSorted = 0;

                while (numOfSorted < rowLenght - 1)
                {
                    int currPos = 0;

                    for (int j = 1; j < rowLenght - numOfSorted; j++)
                        if (ascending && matrix[i, j] > matrix[i, currPos])
                            currPos = j;
                        else if (!ascending && matrix[i, j] < matrix[i, currPos])
                            currPos = j;
                    
                    temp = matrix[i, currPos];
                    matrix[i, currPos] = matrix[i, rowLenght - numOfSorted - 1];
                    matrix[i, rowLenght - numOfSorted - 1] = temp;

                    numOfSorted++;
                }
            }
                 
        }

        public static int[] SumMatrixRows (int[,] matrix)
        {
            int[] result = new int[matrix.GetLength(0)];

            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result[i] += matrix[i, j];

            return result;
        }

        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int matrix1RowNum = matrix1.GetLength(0);
            int matrix1ColNum = matrix1.GetLength(1);
            int matrix2RowNum = matrix2.GetLength(0);
            int matrix2ColNum = matrix2.GetLength(1);

            if (matrix1ColNum != matrix2RowNum)
                return new int [1,1];

            int[,] multMatrix = new int[matrix1RowNum, matrix2ColNum];

            for (int i = 0; i < matrix1RowNum; i++)
                for (int j = 0; j < matrix2ColNum; j++)
                    for (int k = 0; k < matrix1ColNum; k++)
                        multMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        
        return multMatrix;
        }
    }
    #endregion
}