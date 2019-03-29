using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas linhas : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas Colunas ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int number = 0;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    number = mat[i, j];
                    for (int i1 = 0; i1 < l; i1++){
                        for (int j1 = 0; j1 < c; j1++){
                            if (mat[i1, j1] == number && i != i1 && j != j1) {
                                Console.WriteLine("Numero: " + number + " , Localização " + i1 + " , " + j1 + ";") ;
                            }
                        }
                    }
                }
            }
        }
    }
}