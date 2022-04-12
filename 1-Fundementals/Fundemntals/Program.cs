using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundemntals
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeDeclare();
        }

        #region 1-Equality Check
        static bool Check(int X,int Y)
        {
            return X == Y;
        }
        static void Check()
        {
            Console.WriteLine("Please enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int y = int.Parse(Console.ReadLine());
            if (x==y)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }

        }
        #endregion
        #region 2-Sum
        static void Sum(double X, double Y)
        {
            double sum = X + Y;
            Console.WriteLine("Sum = {0}", sum);
        }
        #endregion
        #region 3-Swap
        static void Swap(ref double num1,ref double num2)
        {
            double temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Num1 = {0}\nNum2 = {1}", num1, num2);
        }
        static void Swap()
        {
            Console.WriteLine("Please enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            double temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("First number = {0}\nSecond number = {1}", num1, num2);
        }
        #endregion
        #region 4-Checking Age
        static bool CheckAge1()
        {
            Console.WriteLine("Please enter your age");
            double age = double.Parse(Console.ReadLine());
            return age == 21;

        }
        static void CheckAge2()
        {
            Console.WriteLine("Please enter your age");
            double age = double.Parse(Console.ReadLine());
            if (age==21)
            {
                Console.WriteLine("Eligable");
            }
            else
            {
                Console.WriteLine("Not Eligable");
            }
        }
        #endregion
        #region 5-Multiply
        static void Multiply(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}",num,i,num*i);
            }
        }
        #endregion
        #region 6-Average
        static void Average(double a,double b,double c,double d)
        {
            double average = (a + b + c + d) / 4;
            Console.WriteLine("The Average = {0}", average);
        }
        static void Average(params double[]arr)
        {
            double average = arr.Sum() / arr.Length;
            Console.WriteLine("The Average = {0}", average);
        }
        #endregion
        #region 7-Operations
        static void Operations(double num1,double num2)
        {
            double sum = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num1 / num2;
            Console.WriteLine("Sum = {0}\nSub = {1}\nProduct = {2}\nDivide = {3}", sum,sub,mul,div);
        }
        #endregion
        #region 8-Sum&Average
        static void calc()
        {
            double[] arr = new double[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Please enter num{0}", i + 1);
                arr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}\nAverage = {1}", arr.Sum(),arr.Sum()/arr.Length);
           
        }
        static void calc(params double[] nums)
        {
            Console.WriteLine("Sum = {0}\nAverage = {1}", nums.Sum(),nums.Sum()/nums.Length);
            
           
        }
        static void calc2()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter number {0}", i + 1);
                sum += double.Parse(Console.ReadLine());

            }
            double average = sum / 10;
            Console.WriteLine("Sum = {0}\nAverage = {1}", sum, average);
        }
        #endregion
        #region 9-Angles Check
        static void AnglesCheck()
        {
            double[] angles = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter angle {0}", i + 1);
                angles[i] = double.Parse(Console.ReadLine());
            }
            if (angles.Sum()==180)
            {
                Console.WriteLine("Triangle can be formed");
            }
            else
            {
                Console.WriteLine("Triangle can not be formed");
            }
        }
        static bool AnglesCheck(double x,double y ,double z)
        {
            return x + y + z == 180;
        }
        #endregion
        #region 10-Grade
        static void GradeDeclare()
        {
            Console.WriteLine("Please enter grade in upperr case");
            char grade =Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Please enter valid grade");
                    break;
            }
        }
        static void GradeDeclare(Grade grade)
        {
            if (grade==Grade.E)
            {
                Console.WriteLine("Excellent");
            }
           else if (grade == Grade.V)
            {
                Console.WriteLine("Very Good");
            }
           else if (grade == Grade.G)
            {
                Console.WriteLine("Good");
            }
          else if (grade == Grade.A)
            {
                Console.WriteLine("Average");
            }
          else if (grade == Grade.F)
            {
                Console.WriteLine("Fail");
            }
        } 

        #endregion
        

    }
    public enum Grade
    {
        E,
        V,
        G,
        A,
        F,
    }
}
