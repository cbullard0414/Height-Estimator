namespace Height_Estimator
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            string loadingBar = "[----------]";
            WriteLine("Hello! Welcome to the Height Estimator! Please enter your name below.");
            string name = ReadLine();
            WriteLine("Alright, " + name + ", let's get started. Please enter your age!");
            int age = int.Parse(ReadLine());
            WriteLine("Perfect! Now, please enter your height in inches!");
            int height = int.Parse(ReadLine());
            foreach (char c in loadingBar)
            {
                Write(c);
                Thread.Sleep(200);
            }
            WriteLine();
            WriteLine("Your height is: " + height + " inches.");

        }
    }
}