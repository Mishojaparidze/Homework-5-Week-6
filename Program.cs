using System;


namespace HomeWork5_Week_6
{
    internal class Program
    {
        static void Main()
        {
            #region SolutionN1
            Console.WriteLine("SolutionN1");
            Console.WriteLine("Enter the size of array: ");
            Console.WriteLine("----------------");
            var n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];
            int k = 0, j = 0, i;
            Console.WriteLine("Enter the numbers: ");
            Console.WriteLine("----------------");
            for (i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your numbers are: ");
            Console.WriteLine("----------------");
            foreach (int item in firstArray)
            {
                Console.WriteLine(item);
            }
            for (i = 0; i < n; i++)
            {
                if (firstArray[i] % 2 == 0)
                {
                    evenArray[j] = firstArray[i];
                    j++;
                }
                else
                {
                    oddArray[k] = firstArray[i];
                    k++;
                }
            }
            Console.WriteLine("even numbers are: ");
            Console.WriteLine("- - - -");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(evenArray[i]);
            }
            Console.WriteLine("odd numbers are: ");
            Console.WriteLine("- - -");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(oddArray[i]);
            }
            #endregion

            #region SolutionN2

            Console.WriteLine("SolutionN2");
            int[] fullArray = new int[1000];
            int[] frequenceArray = new int[1000];
            int ctr;


            Console.WriteLine("Count the frequency of each element of an array:");
            Console.WriteLine("------------------------");

            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", i + 1);
                fullArray[i] = Convert.ToInt32(Console.ReadLine());
                frequenceArray[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (fullArray[i] == fullArray[j])
                    {
                        ctr++;
                        frequenceArray[j] = 0;
                    }
                }

                if (frequenceArray[i] != 0)
                {
                    frequenceArray[i] = ctr;
                }
            }
            Console.WriteLine("The frequency of all elements of the array : ");
            for (i = 0; i < n; i++)
            {
                if (frequenceArray[i] != 0)
                {
                    Console.WriteLine("{0} appears {1} times total sum: {2}", fullArray[i], frequenceArray[i], fullArray[i] * frequenceArray[i]);
                }
            }







            #endregion

            #region SolutionN3


            Console.WriteLine("SolutionN3");
            Console.WriteLine("Enter quantity of students: ");
            Console.WriteLine("----------------");
            var x = int.Parse(Console.ReadLine());
            int[] quantityArray = new int[x];
            Console.WriteLine("Enter grades of students: ");
            Console.WriteLine("----------------");

            int[] gradesArray = new int[x];
            for (i = 0; i < x; i++)
            {
                gradesArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(gradesArray);
            Array.Reverse(gradesArray);


            Console.WriteLine("Enter how many top students grades you want to see: ");
            Console.WriteLine("----------------");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h < x)
            {
               for (i = 0; i < h; i++)
                {
                    Console.WriteLine(gradesArray[i]);
                }
            }
            else
            {
                Console.WriteLine("we don't have that much students here");
            }


            #endregion

        }
    }
}
