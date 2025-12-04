using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.MolokanovNK.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            int columnToSort = 0;
            if (columnToSort < cols)
            {

                int[] columnValues = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    columnValues[i] = matrix[i, columnToSort];
                }


                Array.Sort(columnValues);


                for (int i = 0; i < rows; i++)
                {
                    result[i, columnToSort] = columnValues[i];
                }
            }
            return result;
        }
    }
}
