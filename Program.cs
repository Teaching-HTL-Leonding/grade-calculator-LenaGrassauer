const int max_points = 20;
var possible_points = 0;
int points = 0;
var points2 = 0;
var total_points = 0;
var percentage = 0;
int homework_points = 0;
int oralexam_points = 0;

Console.WriteLine("Do you have participated in the first_written_exam? (yes/no): ");
string first_written_exam = (Console.ReadLine()!);

if (first_written_exam == "yes")
{

    Console.WriteLine("How many points did you have? (0-20): ");
    points = int.Parse(Console.ReadLine()!);
    possible_points += max_points;

}


Console.WriteLine("Did you have participated in the twice_written_exam? (yes/no): ");
var twice_written_exam = (Console.ReadLine()!);

if (twice_written_exam == "yes")
{
    Console.WriteLine("How many points2 did you have? (0-20): ");
    points2 = int.Parse(Console.ReadLine()!);
    possible_points += max_points;
}

Console.WriteLine("How many points do you have on your homework? (0-20)");
homework_points = int.Parse(Console.ReadLine()!);
possible_points += max_points;

Console.WriteLine("Did you do an oral_exam? (Yes/no): ");
string oral_exam = Console.ReadLine()!;

if (oral_exam == "yes")

    Console.WriteLine("How many points did you made? (0-20)");
    oralexam_points = int.Parse(Console.ReadLine()!);
    possible_points += max_points;

total_points = points + points2 + homework_points + oralexam_points;



percentage = 100 * total_points / possible_points;


Console.WriteLine("You have " + percentage + " % reached");

switch (percentage)
{
    case >= 89:

        {
            Console.WriteLine("Your Grade is 1");
            break;
        }
    case >= 76:
        {
            Console.WriteLine("Your Grade is 2");
            break;
        }
    case >= 63:
        {
            Console.WriteLine("Your Grade is 3");
            break;
        }
    case >= 50:
        {
            Console.WriteLine("Your Grade is 4");
            break;
        }
    case < 50:
        {
            Console.WriteLine("Your Grade is 5");
            break;
        }
}


