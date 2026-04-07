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



        }


        //Q1 Find the sum of all elements in an array.
        public int SumOfArray(int[] n)
        {
            int sum = 0;
            foreach(var i in n)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Array",sum);
            return sum;
        }








    }
}