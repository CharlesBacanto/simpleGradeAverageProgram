class Program
{
    static void Main(string[] args)
    {
        //Fetching Grades to compute
        Console.WriteLine("Please enter 4 grades");
        float grade1 = Convert.ToSingle(Console.ReadLine());
        float grade2 = Convert.ToSingle(Console.ReadLine());
        float grade3 = Convert.ToSingle(Console.ReadLine());
        float grade4 = Convert.ToSingle(Console.ReadLine());

        //Printing out Grades
        Console.WriteLine("Input 1: " + grade1 + " Input 2: " + grade2 + " Input 3: " + grade3 + " Input 4: " + grade4);

        //Arithmetic Computation
        float average = (grade1 + grade2 + grade3 + grade4) / 4;

        //float average = Convert.ToSingle(Console.ReadLine());// For validation of conditional statement

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
            Console.WriteLine(average + " is considered as With Honors");
        } else if (average >= 75 || average == 89.99)
        {
            Console.WriteLine(average + " is considered as Passed");
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