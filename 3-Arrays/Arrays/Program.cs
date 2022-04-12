using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCopy();
        }

        #region 1D Array Input
        static double[] DoubleArray()
        {
            Console.WriteLine("Please enter number of elements");
            int num = int.Parse(Console.ReadLine());
            double[] arr = new double[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter value {0}", i);
                arr[i] = double.Parse(Console.ReadLine());
            }
            return arr;
        }
        #endregion
        #region 2D Array Input
        static double[,] Array2D()
        {
            Console.WriteLine("Please enter number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of columns");
            int col = int.Parse(Console.ReadLine());
            double[,] arr = new double[row, col];
            Console.WriteLine("Please enter values of array");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t");
                    arr[i, j] = double.Parse(Console.ReadLine());
                }
                Console.Write("\n\n");
            }
            return arr;
        }
        

        #endregion

        #region 1-Reverse
        //Using Reverse method
        static void Reverse()
        {
            double[] arr = DoubleArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("value {0} = {1}", i, arr[i]);
            }
            
        }

        //Without Using Reverse method
        static void Reverse2()
        {
            double[] arr1 = DoubleArray();
            double[] arr2 = new double[arr1.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[arr1.Length - 1 - i];
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region 2-Sum
        static void ArraySum(params double[]arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum = {0}", sum);
        }
        static void ArraySum()
        {
            double[] arr = DoubleArray();
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum = {0}", sum);
        }
        #endregion
        #region 3-Copy
        //Shallow Copy
        static void ArrayCopy()
        {
            double[] arr1 = DoubleArray();
            double[] arr2 = new double[arr1.Length];
            arr2 = arr1;
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        //Deep Copy
        static void ArrayCopy2()
        {
            double[] arr1 = DoubleArray();
            double[] arr2 = new double[arr1.Length];
            Array.Copy(arr1, arr2, arr1.Length);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
        #region 4-Count Duplicates
        static void DuplicatesCount()
        {
            double[] arr = DoubleArray();
           Console.WriteLine("Number of duplicates = {0}",arr.Length- arr.Distinct().Count());
        }
        static void DuplicatesCount2()
        {
            double[] arr = DoubleArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine("Number of duplicates = {0}", counter);
        }
        #endregion
        #region 5-Print Unique
        static void Unique()
        {
            double[] arr = DoubleArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        counter++;  
                    }
                    
                }
                if (counter == 0)
                {
                    Console.WriteLine(arr[i]);
                }

            }
            

        }
        #endregion
        #region 6-Odd&Even
        //input 2d array & output 1d arrays
        static void SeparateEvenOdd()
        {
            //Creating 2d array
            Console.WriteLine("Please enter number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of columns");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("please enter value of ({0},{1})", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Count Even
            int CountEven = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i,j]%2==0)
                    {
                        CountEven++;
                    }
                }
            }
            int[] even = new int[CountEven];
            int[] odd = new int[arr.Length - CountEven];
            int k = 0;
            int o = 0;

            //Adding elements to arrays
            while (k+o<arr.Length)
            {
                foreach (var item in arr)
                {
                    if (item % 2 == 0)
                    {
                        even[k] = item;
                        k++;
                    }
                    else
                    {
                        odd[o] = item;
                        o++;
                    }
                }
            }
            //Printing
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
        }


        //input 2d array & output 2d arrays
        static void SeparateEvenOdd2()
        { 
            //Creating 2d array
            Console.WriteLine("Please enter number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of columns");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("please enter value of ({0},{1})", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] even = new int[row, col];
            int[,] odd = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i,j]%2==0)
                    {
                        even[i, j] = arr[i, j];
                    }
                    else
                    {
                        odd[i, j] = arr[i, j];
                    }
                }
            }
            //testing-printing
            Console.WriteLine("Even values are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t{0}", even[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.WriteLine("odd values are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t{0}", odd[i, j]);
                }
                Console.Write("\n\n");
            }

        }
        #endregion
        #region 7-Even
        static void EvenCount()
        {
            double[] arr = DoubleArray();
            int counter = 0;
            foreach (var item in arr)
            {
                if (item%2==0)
                {
                    counter++;
                }
            }
            Console.WriteLine("Total number of even number = {0}", counter);
        }
        #endregion
        #region 8-Descending
        //Using Sort&Reverse
        static void ArrayDescending()
        {
            double[] arr = DoubleArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //Without using Sort&Reverse
        static void ArrayDescending2()
        {
            double[] arr1 = DoubleArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] >= arr1[j])
                    {
                        arr1[i] = arr1[i];
                    }
                    else
                    {
                        double temp = arr1[j];
                        arr1[j] = arr1[i];
                        arr1[i] = temp;
                       
                    }

                }
            }
            //testing
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region 9-Delete
        //Deleting element & Replace it with 0 with the same array length
        static void DeleteElement()
        {
            double[] arr = DoubleArray();
            Console.WriteLine("Please enter index of element to delete");
            int i = int.Parse(Console.ReadLine());
            Array.Clear(arr, i,1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }

        // Deleting element & Creating new array with a new length
        static void DeleteElement2()
        {
            double[] arr = DoubleArray();
            Console.WriteLine("Please enter index of element to delete");
            int index = int.Parse(Console.ReadLine());
            double[] arr2 = new double[arr.Length - 1];
            if (index==arr.Length)
            {
                Array.Copy(arr, arr2, arr.Length - 1);
            }
            else
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Copy(arr, arr2, arr.Length - 1);
            }
            
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region 10-Second Smallest
        //Using Sort
        static void SecondSmallest()
        {
            double[] arr = DoubleArray();
            Array.Sort(arr);
            if (arr.Length==1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                Console.WriteLine(arr[1]);
            }
        }

        //Without using Sort
        static void SecondSmallest2()
        {
            double[] arr = DoubleArray();
            if (arr.Length==1)
            {
                Console.WriteLine("second smallest number is {0}", arr[0]);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] <= arr[j])
                        {
                            arr[i] = arr[i];
                        }
                        else
                        {
                            double temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                Console.WriteLine("Second smallest number is {0}", arr[1]);
            }
            

        }
        #endregion
        #region 11-Matrices Addition
        static void MatricesAdd()
        {
            double[,] arr1 = Array2D();
            double[,] arr2 = Array2D();
            if (arr1.GetLength(0)==arr2.GetLength(0)&&arr1.GetLength(1)==arr2.GetLength(1))
            {
                double[,] arr3 = new double[arr1.GetLength(0), arr1.GetLength(1)];
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr3[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        Console.WriteLine("value of index ({0},{1}) = {2}", i, j, arr3[i, j]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrices are not of the same size");
            }
            


        }
        static void MatricesAdd2()
        {
            Console.WriteLine("Please enter number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of columns");
            int col = int.Parse(Console.ReadLine());
            double[,] arr1 = new double[row, col];
            double[,] arr2 = new double[row, col];
            double[,] arr3 = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("please enter value of first matrix ({0},{1})", i, j);
                    arr1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("please enter value of second matrix ({0},{1})", i, j);
                    arr2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("value of index ({0},{1}) = {2}", i, j, arr3[i, j]);
                }
            }

        }
        #endregion
        #region 12-Matrices Subtraction
        static void MatricesSub()
        {
            double[,] arr1 = Array2D();
            double[,] arr2 = Array2D();
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
            {
                double[,] arr3 = new double[arr1.GetLength(0), arr1.GetLength(1)];
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr3[i, j] = arr1[i, j] - arr2[i, j];
                    }
                }
                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        Console.WriteLine("value of index ({0},{1}) = {2}", i, j, arr3[i, j]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrices are not of the same size");
            }
        }
        #endregion
        #region 13-Multiplication of square matrices
        static void SquareMatricesMul()
        {
            //Creating Square Matrices

            Console.WriteLine("Please enter length of the square matrix");
            int L = int.Parse(Console.ReadLine());
            double[,] arr1 = new double[L, L];
            double[,] arr2 = new double[L, L];
            double[,] arr3 = new double[L, L];
            Console.WriteLine("Enter the values of first matrix");
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.Write("\t");
                    arr1[i, j] = double.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }
            Console.WriteLine("Enter the values of second matrix");
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.Write("\t");
                    arr2[i, j] = double.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }

            //Multiplication Process

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    for (int k = 0; k < L; k++)
                    {
                        arr3[i, j] += arr1[i,j] * arr2[i,k];
                    }

                }
            }

            //Printing

            Console.WriteLine("Values of multiplication of matrices");
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.Write("\t{0}", arr3[i, j]);
                }
                Console.Write("\n\n");
            }

        }
        #endregion
        #region 14-Sum of right diagonal of Matrix
        static void MatrixRightDiagonal()
        {
            Console.WriteLine("Please enter length of the square matrix");
            int L = int.Parse(Console.ReadLine());
            double[,] arr = new double[L, L];
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.WriteLine("Please enter the value of index ({0},{1})",i,j);
                    arr[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double sum = 0;
            int b = L-1;
            for (int i = 0; i < L; i++)
            {
                sum += arr[i, b];
                b--;
            }
            Console.WriteLine(sum);
        }
        #endregion
        #region 15-Identity Matrix
        static void IdentityCheck()
        {
            Console.WriteLine("Please enter the length of square matrix");
            int L = int.Parse(Console.ReadLine());
            int[,] arr = new int[L, L];
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.WriteLine("Please enter the value of ({0},{1})", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int counter = 0;
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    if ((arr[i,j]==1&&i==j)||(arr[i,j]==0&&i!=j))
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("It is not identity matrix");
                        i = L;
                        j = L;
                    }
                    
                }

            }
            if (counter==arr.Length)
            {
                Console.WriteLine("It is an identity matrix");
            }
            
        }
        #endregion
    }
}
