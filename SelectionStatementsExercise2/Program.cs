namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats is your favorite school subject");
           
            string subject = Console.ReadLine()!;
           
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("numbers a stuff thats cool, i guess.");
                    break;
                case "science":
                    Console.WriteLine("that's the bees knees!");
                    break;
                case "art":
                    Console.WriteLine("I like it, Picasso!");
                    break;
                case "gym":
                    Console.WriteLine("Bet You're not faster than me.");
                    break;
                case "history":
                    Console.WriteLine("paul revere and what not.");
                    break;
                case "english":
                    Console.WriteLine("To code or not to code, that is the quetion.");
                    break;
                default:
                    Console.WriteLine("don't know that one guess it's back to class for me.");
                    break;

            }
        }
    }
}