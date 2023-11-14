using System;
namespace GradeBook;

public class GradeBook
{
    private int[] grades;

    public string CourseName { get; set; }

    //two-parameter contructor
    public GradeBook(string name, int[] gradesArray)
    {
        CourseName = name;
        grades = gradesArray;
    }

    //display a welcome message to the GradeBook user
    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to the gradebook for \n{0}!\n", CourseName);
    }

    public void ProcessGrades()
    {
        //output grades array
        OutputGrades();

        //call method GetAverage to calculate the average grade
        //Console.WriteLine("\nClass average is {0:F}", GetAverage() );

    }

    public void OutputGrades()
    {
        Console.WriteLine("The grades are:\n");

        for (int student = 0; student < grades.Length; student++)
            Console.WriteLine("Student {0,2}: {1,3}", student + 1, grades[student]);
        Console.WriteLine("");
    }

    public void OutputBarChart()
    {
        int total = 0;

        foreach (int number in grades)
            total += number;
        Console.WriteLine("Total of array elements: {0}", total);

        Console.WriteLine( "Grade distribution:" );

        //stores frequency of grades in each range of 10 grades
        int[] frequency = new int[11];

        //for each grade, increment the appropriate frequency
        foreach (int grade in grades)
            ++frequency[grade / 10];

        //for each grade frequency, display bar in chart
        for (int count = 0; count < frequency.Length; count++)
        {
            if (count == 10)
                Console.Write("100: ");
            else
                Console.Write("{0:D2}-{1:D2}: ", count * 10, count * 10 + 9);

            //display bar of astericks
            for (int stars = 0; stars < frequency[count]; stars++)
                Console.Write( "*" );

            Console.WriteLine();
        }
            //output bar label ("00-09: ", ... "90-99: "
    }
}
