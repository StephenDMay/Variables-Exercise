namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int age = 40;
            char exclamation = '!';
            bool isProgrammer = true;
            double wage = 20.00;
            decimal salary = 50000.00m;

            Console.WriteLine($"{name} is {age} years old and it is {isProgrammer.ToString()} that he is a programmer{exclamation} He makes ${wage} an hour for a salary of {salary}");
        }
    }
}
