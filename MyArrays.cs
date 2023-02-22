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

        public static string MatrixToString<T>(T[,] matrix)
        {
            string result = string.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result += $"{matrix[i, j]} ";

                result += Environment.NewLine;
            }

            return result;
        }
    }
    #endregion
}