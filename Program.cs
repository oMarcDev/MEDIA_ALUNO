using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {90, 95, 97, 98, 100};
int[] lucasScores = new int[] {87, 85, 70, 90, 95};

string[] studentNames = new string[] {"Sophia", "Andrew", "Lucas"};

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{

    string currentStudent = name;
    if (currentStudent == "Sophia")
    studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
    studentScores = andrewScores;

    else if (currentStudent == "Lucas")
    studentScores = lucasScores;

    int sumAssignmentsScores = 0;

    decimal currentStudentGrade;

    foreach(int score in studentScores)
    {
    sumAssignmentsScores += score;
    }

currentStudentGrade = (decimal)sumAssignmentsScores / currentAssignments; 
Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
