using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the student's score:");
        int score = Convert.ToInt32(Console.ReadLine());

        char grade = GradeStudent(score);

        Console.WriteLine("Student's grade: " + grade);

        Console.ReadLine();
    }

    static char GradeStudent(int score)
    {
        if (score >= 90 && score <= 100)
        {
            return 'A';
        }
        else if (score >= 80)
        {
            return 'B';
        }
        else if (score >= 70)
        {
            return 'C';
        }
        else if (score >= 60)
        {
            return 'D';
        }
        else if (score < 60)
        {
            return 'F';
        }
        else
        {
            Console.WriteLine("wrong command")
        }
    }
}
