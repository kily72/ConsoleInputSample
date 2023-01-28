namespace ProgramTests

{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(long.Parse);
            Console.WriteLine("The sum is: ");
            Console.WriteLine(nums.Sum());
        }
    }
}