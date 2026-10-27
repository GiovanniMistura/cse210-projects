using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment = new Assigment("Peter Parker","Physics");
        assigment.GetSummary();

        MathAssignmnet mathAssignmnet = new MathAssignmnet("Page 200","problem n. 9","Peter Parker","Physics");
        mathAssignmnet.GetSummary();
        mathAssignmnet.GetHomeworkList();

        WritingAssignment writingAssignment = new WritingAssignment("The law of swinging","Peter Parker","Physics");
        writingAssignment.GetWritingInformation();
    }
}