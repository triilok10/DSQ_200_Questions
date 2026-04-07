using System.Text;


//Name Space
namespace TwoHundredQuestions
{
    // Class 
    public class Program
    {

        // Main Function
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.SumOfArray([1, 2, 3, 4, 1, 2, 3, 4, 1, 3]);
            obj.MinimunElement([1, 2, 3, 4, 1, 2, 3, 4, 1, 3]);
            obj.ElementAppears([1, 2, 3, 4, 1, 2, 3, 4, 1, 3],2);



        }


        //Q21 Find the sum of all elements in an array.
        public int SumOfArray(int[] n)
        {
            int sum = 0;
            foreach (var i in n)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Array", sum);
            return sum;
        }


        //Q22 Find the minimum element in an array without using built-in Min().
        public int MinimunElement(int[] n)
        {
            int min = 0;
            for (int i = 0; i < n.Length - 1; i++)
            {
                if (n[i] < min)
                {
                    min = n[i];
                }
                ;
            }
            return min;
        }

        //Q. 23 Count how many times a specific element appears in an array.
        public int ElementAppears(int[] n, int target)
        {
            int Element = 0;
            foreach (var i in n)
            {
                if (i == target)
                {
                    Element++;
                }
            }
            return Element;
        }





    }
}