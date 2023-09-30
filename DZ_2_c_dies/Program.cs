using System.Security.Cryptography.X509Certificates;

namespace DZ_2_c_dies
{
    internal class Program

    {
        class Matrix
        {
            public int _x;
            public int _y;
            public int[,] mass;

            public Matrix(int x, int y)
            {
                _x = x;
                _y = y;
                mass = new int[_x, _y];
                Random rnd = new Random();
                int Randomize = rnd.Next(1, 10);
                for (int i = 0; i < _x; ++i)
                {
                    for (int j = 0; j < _y; ++j)
                        mass[i, j] = rnd.Next(1, 10);
                }
            }
            public Matrix(int[,] m, int x, int y)
            {
                mass = m; _x = x; _y = y;
            }
            public void Mostra()
            {
                for (int i = 0; i < _x; ++i)
                {
                    for (int j = 0; j < _y; ++j)
                    { Console.Write(mass[i, j] + " "); }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
            public static Matrix operator +(Matrix m1, Matrix m2)
            {
                if (m1._x != m2._x && m1._y != m2._y)
                {
                    Console.WriteLine("Ошибка");
                    return m1;
                }
                int[,] m3 = new int[m1._x, m1._y];
                for (int i = 0; i < m1._x; ++i)
                {
                    for (int j = 0; j < m1._y; ++j)
                    { m3[i, j] = m1.mass[i, j] + m2.mass[i, j]; }
                }
                return new Matrix(m3, m1._x, m1._y);
            }
            public static Matrix operator -(Matrix m1, Matrix m2)
            {
                if (m1._x != m2._x && m1._y != m2._y)
                {
                    Console.WriteLine("Ошибка");
                    return m1;
                }
                int[,] m3 = new int[m1._x, m1._y];
                for (int i = 0; i < m1._x; ++i)
                {
                    for (int j = 0; j < m1._y; ++j)
                    { m3[i, j] = m1.mass[i, j] - m2.mass[i, j]; }
                }
                return new Matrix(m3, m1._x, m1._y);
            }
            public static Matrix operator *(Matrix m1, Matrix m2)
            {
                if (m1._x != m2._x && m1._y != m2._y)
                {
                    Console.WriteLine("Ошибка");
                    return m1;
                }
                int[,] m3 = new int[m1._y, m2._x];

                for (int i = 0; i < m1._x; ++i)
                {
                    for (int j = 0; j < m2._y; ++j)
                    {
                        m3[i, j] = 0;

                        for (int k = 0; k < m1._y; ++k)
                        {
                            m3[i, j] += m1.mass[i, k] * m2.mass[k, j];
                        }
                    }
                }
                return new Matrix(m3, m1._y, m2._x);
            }
            public static Matrix operator *(Matrix m1, int a)
            {
                int[,] m3 = new int[m1._x, m1._y];
                for (int i = 0; i < m1._x; ++i)
                {
                    for (int j = 0; j < m1._y; ++j)
                    { m3[i, j] = m1.mass[i, j] * a; }
                }
                return new Matrix(m3, m1._x, m1._y);
            }
        }

        static void Main(string[] args)
        {
            // задание 1
            /*Console.WriteLine("Введите ширину квадрата : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ : ");
            char ch=Convert.ToChar(Console.ReadLine());
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }*/

            // 1
            int[]A=new int[5];
            int[,] B = new int[3, 4];
            for(int i = 0; i < 5; ++i)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random rnd = new Random();
            int Randomize = rnd.Next(1, 10);
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                    B[i, j] = rnd.Next(1, 10);
            }
            for (int i = 0; i < 5; ++i)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                { Console.Write(B[i, j] + " "); }
                Console.WriteLine();     
            }
            int min1 = A[0], min2 = B[0, 0], max1 = A[0], max2 = B[0, 0], sum1 = 0, sum2 = 0, pr1 = 1, pr2 = 1, chet = 0, nech = 0;
            for (int i = 1; i < 5; ++i)
            {
                if (A[i] < min1) min1 = A[i];
                if (A[i] > max1) max1 = A[i];
            }
            for (int i = 0; i < 5; ++i)
            {
                sum1 += A[i]; pr1 *= A[i];
                if (A[i] % 2 == 0) chet += A[i];
            }
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    if (B[i,j] <= min2) min2 = B[i,j];
                    if (B[i,j] >= max2) max2 = B[i,j];
                    sum2 += B[i, j]; pr2 *= B[i, j];
                    if (j % 2 != 0) nech += B[i, j];
                }
            }
            Console.WriteLine("Макс A " + max1 + "\nМин А " + min1 + "\nСумма " + sum1 + "\nСумма четных " + chet);
            Console.WriteLine("Макс B " + max2 + "\nМин B " + min2 + "\nСумма " + sum2 + "\nСумма нечетных столбцов " + nech);

            // 2
            int [,]mass = new int[5, 5];
            Random rnd1 = new Random();
            int Randomize1 = rnd1.Next (- 100, 100);
            int sum_elem = 0;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                    mass[i, j] = rnd1.Next(-100, 100);
            }
            int max_mas = mass[0, 0], min_mas = mass[0, 0];
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                { Console.Write(mass[i, j] + " ");
                    if (mass[i, j] <= min_mas) { min_mas = mass[i, j]; }
                    if (mass[i, j] >= max_mas) { max_mas = mass[i, j]; }
                }
                Console.WriteLine();
            }
            int[] mass2 = new int[25];
            int k=0;
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    mass2[k]=mass[i, j];
                    k++;
                }
            }
            int n1=0;
            int n2=0;
            for (int i = 0; i < 25; i++)
            {
                if (min_mas == mass2[i])
                {
                    n1 = i;
                    break;
                }
            }

            for (int i = 0; i <25; i++)
            {
                if (max_mas == mass2[i])
                {
                    n2 = i;
                    break;
                }
            }
            if (n1 < n2) 
            {

                for (int i = n1; i <= n2; i++)
                    sum_elem = sum_elem + mass2[i];
            }
            else
            {
                for (int i = n2; i <= n1; i++)
                    sum_elem = sum_elem + mass2[i];

            }

            Console.WriteLine("Мин "+ min_mas + "\nМакс " + max_mas + "\nСумма "+sum_elem);

            // 4

            Matrix mat1 = new Matrix(4, 4);
            Matrix mat2 = new Matrix(4, 4);
            mat1.Mostra();
            mat2.Mostra();
            Matrix mat3 = mat1 + mat2;
            mat3.Mostra();
            Matrix mat4 = mat1 - mat2;
            mat4.Mostra();

            Matrix mat5 = new Matrix(5, 5);
            Matrix mat6 = mat1 + mat5;


            Matrix mat7 = mat1 * 2;
            mat7.Mostra();
            Matrix mat8 = mat1 * mat2;
            mat8.Mostra();
            Matrix mat9 = new Matrix(4, 4);
            Matrix mat10 = mat1 * mat9;  // только квадратные
            mat10.Mostra();
        }
    }
}