﻿// lesson_4
Console.Clear();


// string[,] table = new string[2,5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//  for (int columns = 0; columns < 5; columns++)
//  {
//  Console.WriteLine($"{table[rows, columns]}-");
//  }
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//  for (int j = 0; j < 4; j++)
//  {
//     Console.WriteLine($"{matrix[i, j]} ");
//  }
// Console.WriteLine();
// }


// void PrintArray(int[,] matr)
// {
//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//  Console.Write($"{matr[i, j]} ");
//  }
//  Console.WriteLine();
//  }
// }
// void FillArray(int[,] matr)
// {
//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//  matr[i,j] = new Random().Next(1,10);//[1; 10)
//  }
//  }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };



// void PrintImage(int[,] image)
// {
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//  for (int j = 0; j < image.GetLength(1); j++)
//  {
//  if(image[i,j] == 0) Console.Write($" ");
//  else Console.Write($"+");
//  }
//  Console.WriteLine();
//  }
// }

// void FillImage(int row, int col)
// {
//  if (pic[row, col] == 0)
//  {
//  pic[row, col] = 1;
//  FillImage(row - 1, col);
//  FillImage(row, col - 1);
//  FillImage(row + 1, col);
//  FillImage(row, col + 1);
//  }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);



// int Factorial(int n) {
//     if(n == 1) return 1;
//     else n * Factorial(n - 1);
// }

// System.Console.WriteLine(Factorial(5));


// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6


// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//  Console.WriteLine(Factorial(i));
// }



// double Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//  Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// int Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 10; i++)
// {
//  Console.WriteLine(Fibonacci(i));
// }



// double Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//  Console.WriteLine(Fibonacci(i));
// }



double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}