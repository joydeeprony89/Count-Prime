namespace Count_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/count-primes/solutions/57588/my-simple-java-solution/
            var n = 70;
            var sol = new Solution();
            var ans = sol.CountPrimes(n);
            Console.WriteLine(ans);
        }
    }

    public class Solution
    {
        public int CountPrimes(int n)
        {
            var isPrime = new bool[n];
            var count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!isPrime[i])
                {
                    count++;
                    // set all multiples of i True
                    for (int j = 2; i * j < n; j++)
                        isPrime[i * j] = true;
                }
            }

            return count;
        }
    }
}
