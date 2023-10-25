namespace Macierz
{
    class Program
    {
        static void Main()
        {
            bool isFinished = false;
            int columns = 0;
            int rows = 0;

            while (isFinished == false)
            {
                Console.WriteLine("Podaj ilość kolumn dla macierzy");
                columns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj ilość wierszy dla macierzy");
                rows = Convert.ToInt32(Console.ReadLine());

                Matrix matrix1 = new Matrix(rows, columns);
                Matrix matrix2 = new Matrix(rows, columns);

                for (int i = 0; i < matrix1.Rows; i++)
                {
                    for (int j = 0; j < matrix1.Columns; j++)
                    {
                        Console.WriteLine("Podaj wartość pola [" + i + "," + j + "] dla macierzy 1");
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Macierz 1");
                matrix1.Print();

                for (int i = 0; i < matrix2.Rows; i++)
                {
                    for (int j = 0; j < matrix2.Columns; j++)
                    {
                        Console.WriteLine("Podaj wartość pola [" + i + "," + j + "] dla macierzy 2");
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Macierz 2");
                matrix2.Print();

                Matrix sum = matrix1 + matrix2;
                Console.WriteLine("Suma macierzy");
                sum.Print();

                Matrix mult = matrix1 * matrix2;
                Console.WriteLine("Iloczyn macierzy");
                mult.Print();

                Matrix transpodsedMatirx1 = matrix1.Transpose();
                Console.WriteLine("Transpozycja macierzy1");
                transpodsedMatirx1.Print();
                Console.ReadLine();
                isFinished = true;

            }
        }
    }
}