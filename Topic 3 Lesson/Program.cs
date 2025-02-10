namespace Topic_3_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int age, height, weight;

            name = "Linkin Krysa";
            age = 16;
            height = 181;    //inches
            weight = 205;    //last time I checked
            eyes = "Green";
            hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("His eyes are " + eyes + " and hair is " + hair);
            Console.WriteLine();

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I get " + (age + height + weight) + ".");
        }
    }
}
