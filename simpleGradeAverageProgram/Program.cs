class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 4 grades");
        double grade1 = Convert.ToDouble(Console.ReadLine());
        double grade2 = Convert.ToDouble(Console.ReadLine());
        double grade3 = Convert.ToDouble(Console.ReadLine());
        double grade4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input 1: " + grade1 + " Input 2: " + grade2 + " Input 3: " + grade3 + " Input 4: " + grade4);
        double average = (grade1 + grade2 + grade3 + grade4) / 4;

        if (average > 100)
        {
            Console.WriteLine(average + " is an Invalid Grade");
        } else if (average >= 98 || average == 100)
        {
            Console.WriteLine(average + " is considered as With Highest Honors");
        } else if (average >= 95 || average == 97.99)
        {
            Console.WriteLine(average + " is considered as With High Honors");
        } else if (average >= 90 || average == 94.99)
        {
            Console.WriteLine(average + "is considered as With Honors");
        } else if (average >= 75 || average == 89.99)
        {
            Console.WriteLine(average + "is considered as Passed");
        } else if (average < 75)
        {
            Console.WriteLine(average + " is considered as Failed");
        }
        else
        {
            Console.WriteLine(average + " is not applicable");
        }
    }
}