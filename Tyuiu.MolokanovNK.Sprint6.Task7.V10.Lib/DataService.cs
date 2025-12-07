using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolokanovNK.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            // 1. Читаем все строки из файла и фильтруем пустые
            var lines = File.ReadAllLines(path)
                           .Where(l => !string.IsNullOrWhiteSpace(l))
                           .ToArray();

            // Если файл пустой - возвращаем пустую матрицу
            if (lines.Length == 0) return new int[0, 0];

            // 2. Определяем размеры матрицы:
            int rows = lines.Length; // Количество строк = количеству непустых строк
                                     // Находим максимальное количество столбцов во всех строках
            int cols = lines.Max(l => l.Split(';').Length);

            // 3. Создаем матрицу нужного размера
            int[,] matrix = new int[rows, cols];

            // 4. Заполняем матрицу данными
            for (int i = 0; i < rows; i++)
            {
                var vals = lines[i].Split(';'); // Разделяем строку по запятым

                // Итерируем по элементам строки, но не выходим за границы cols
                for (int j = 0; j < vals.Length && j < cols; j++)
                {
                    // Пытаемся преобразовать в число, если не получается - будет 0
                    int.TryParse(vals[j].Trim(), out matrix[i, j]);
                }
                // Остальные ячейки в строке (если vals.Length < cols) останутся 0
            }

            // 5. Обрабатываем пятую строку (индекс 4)
            if (rows >= 5) // Проверяем, что есть хотя бы 5 строк
            {
                for (int j = 0; j < cols; j++)
                {
                    // Если значение от 5 до 10 включительно
                    if (matrix[4, j] >= 5 && matrix[4, j] <= 10)
                        matrix[4, j] = 0; // Заменяем на 0
                }
            }

            // 6. Возвращаем готовую матрицу
            return matrix;
        }
    }
}
