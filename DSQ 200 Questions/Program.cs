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
            obj.ElementAppears([1, 2, 3, 4, 1, 2, 3, 4, 1, 3], 2);
            obj.ReverseInArray([1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 9]);
            obj.CheckIsAscendingArray([1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 9]);
            obj.RotateArrayByK([1, 2, 3, 4, 1, 2, 3, 4, 1, 3, 9], 3);
            obj.ArraySort([1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0]);



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

        // Q.24 Reverse an array in-place without built-in Reverse()
        public Array ReverseInArray(int[] n)
        {
            int[] reverse = new int[n.Length];
            int rev = 0;

            for (int i = n.Length - 1; i >= 0; i--)
            {

                reverse[rev] = n[i];
                rev++;
            }

            return reverse;
        }


        // Q.25 Check if an array is sorted in ascending order.
        public bool CheckIsAscendingArray(int[] n)
        {
            for (int i = 0; i < n.Length - 1; i++)
            {
                if (n[i] > n[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        // 26 Rotate an array to the right by K positions in O(n) time, O(1) space.
        public void RotateArrayByK(int[] n, int k)
        {
            if (k > 0)
            {
                k = k % n.Length;
                Reverse(n, 0, n.Length - 1);
                Reverse(n, 0, k - 1);
                Reverse(n, k, n.Length - 1);

                Console.WriteLine(string.Join(",", n));
            }
        }

        void Reverse(int[] n, int l, int r)
        {
            while (l < r)
            {
                int temp = n[l];
                n[l] = n[r];
                n[r] = temp;
                l++;
                r--;
            }
        }

        //Q. 27 Given array of 0s and 1s, move all 0s to left and 1s to right in one pass.

        public void ArraySort(int[] n)
        {
            if (n.Length < 0)
            {
                return;
            }

            int left = 0;
            int right = n.Length - 1;


            while (left < right)
            {

                if (n[left] == 0)
                {
                    left++;
                }
                else if (n[right] == 1)
                {
                    right--;
                }
                else
                {
                    int temp = n[left];
                    n[left] = n[right];
                    n[right] = temp;
                }
            }
        }
    }
}