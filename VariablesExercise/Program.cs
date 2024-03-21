namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Yaakov";
            int number = 2;
            char letter = 'a';
            bool correct = true;
            double aLot = 5.99;
            decimal aTon = 7m;

            Console.WriteLine($"{name} went to the store to get soda pop {letter}\n" +
                $"for {number} dollars, {correct} to not spend {aLot} on an Ice Cream \n" +
                $" or {aTon}thousand on a Bike");
                
        }
    }
}
