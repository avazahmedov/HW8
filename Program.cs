// Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.

// int [,] Create2DArray(int rows, int cols, int min, int max)
// {
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] RegularizeArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             for (int k = 0; k<array.GetLength(0)-1; k++){
//             if (array[i,j]>array[i, k])
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[i, k];
//                 array[i, k] = temp;

//             }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Enter rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = Create2DArray(rows, cols, min, max);
// Show2DArray(myarray);
// Console.WriteLine();
// int [,] newarray = RegularizeArray(myarray);
// Show2DArray(newarray);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// int [,] Create2DArray(int rows, int cols, int min, int max)
// {
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// void Summ(int [,] array)
// {
//     int minsum = 0;
//     int minsumstring = 0;
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             sum += array [i,j];
//         }
//         if (sum<=minsum || minsum == 0)
//         {
//             minsum = sum;
//             minsumstring = i+1;
//         }
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов - {minsumstring}");
// }


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (rows != cols){
// Console.WriteLine("Введите минимальное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = Create2DArray(rows, cols, min, max);
// Show2DArray(myarray);
// Console.WriteLine();
// Summ(myarray);
// }
// else 
// Console.WriteLine("Введите неравное количество строк и столбцов"); 


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:


// int [,] Create2DArray(int rows, int cols, int min, int max)
// {
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     } 
// }



// int [,] Multiplier(int [,] array1, int[,] array2)
// {
//         int [,] arraym = new int [array1.GetLength(0), array1.GetLength(1)];
//         for (int a = 0; a<array1.GetLength(0); a++)
//         {
//             for (int b = 0; b<array1.GetLength(1); b++)
//             {
//                 int sum = 0;
//                 for(int c=0; c<array1.GetLength(0); c++){
//                 sum = sum + array1[a,c]*array2[c,b];
//                 }
//                 arraym[a,b] = sum;             
//             }
//         }
//         return arraym;

// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива 1");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива 1");
// int max1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива 2");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива 2");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int [,] array1 = Create2DArray(rows, cols, min1, max1);
// int [,] array2 = Create2DArray(rows, cols, min2, max2);
// if (rows == cols)
// {
// Console.WriteLine("Первая матрица");
// Show2DArray(array1);
// Console.WriteLine("Вторая матрица");
// Show2DArray(array2);
// int [,] arraym = Multiplier(array1, array2);
// Console.WriteLine("Произведение двух матриц");
// Show2DArray(arraym);
// }
// else 
// Console.WriteLine("Введите равное количество строк и столбцов"); 


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

// int [,,] Create3DArray(int pages, int rows, int cols)
// {
//     int [,,] array = new int[pages, rows, cols];
//     int n = 0;
//     int temp = 0;
//     int [] tarray = new int[array.Length];
//     for (int i = 0; i<pages; i++)
//     {
//         for (int j = 0; j<rows; j++)
//         {
//             for(int k = 0; k<cols; k++, n++)
//             {
//                temp = new Random().Next(10, 100);
//                for (int a = 0; a<n+1; a++)
//                {
//                     if (tarray[a] == temp)
//                     {
//                         while(tarray[a] == temp)
//                         {
//                             temp = new Random().Next(10, 100);
//                         }
//                     }
//                 }
//                 tarray[n] = temp;
//                 array [i,j,k] = temp;
//             }
//         }
//     }
//     return array;
// }

// void Show3DArray(int [,,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             for(int k = 0; k<array.GetLength(2); k++)
//             {
//             Console.Write(array[i,j,k] + $"({i};{j};{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     } 
//     Console.WriteLine();
// }



// Console.WriteLine("Введите количество страниц");
// int pages = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,,] myarray = Create3DArray(pages, rows, cols);
// Show3DArray(myarray);



// Напишите программу, которая заполнит спирально массив 4 на 4.

// int [,] Create2DArray(int rows, int cols)
// {
//     int [,] array = new int[rows, cols];
//     for (int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j<cols; j++)
//         {
//             array[i,j] = 0;
//         }
//     }
//     return array;
// }


// void Show2DArray(int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] FillArray(int [,] myarray, int rows, int cols)
// {
//     int t = 1;
//     int s = 0;
//     while (t <= rows*cols)
//     {
//      for (int j = 0+s; j < cols-s; j++)
//      {
//         myarray[0+s,j] = t;
//         t++;
//      }   
//      for (int i = 1+s; i < rows-s; i++)
//      {
//         myarray[i,cols-1-s] = t;
//         t++;
//      }
//      for (int k = cols-2-s; k >=0+s; k--)
//      {
//         myarray[rows-1-s,k] = t;
//         t++;
//      }
//      for (int l = rows-2-s; l >=1+s; l--)
//      {
//         myarray[l,0+s] = t;
//         t++;
//      }
// s++;
// }
// return  myarray;
// } 

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = Create2DArray(rows, cols);
// Show2DArray(myarray);
// Console.WriteLine();
// int [,] newarray = FillArray(myarray, rows, cols);
// Show2DArray(newarray);