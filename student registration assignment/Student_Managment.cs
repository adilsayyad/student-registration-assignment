// See https://aka.ms/new-console-template for more informat
using static Student;

public class Student_Managment


{
    Student student = new Student();
    Subject subject = new Subject();
    public void AddStudentRecord()
    {
        Console.WriteLine("enter studnt name");
        var studentname = Console.ReadLine();
        Console.WriteLine("age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Phone");
     int phone =int.Parse ( Console.ReadLine());
        var city = Console.ReadLine();


        student.AddRecord(studentname , age,phone, city);

    }

    public void AddSubjectRecord()

    {  
        int subjectcode = int.Parse(Console.ReadLine());


        var subjectname = Console.ReadLine();
        subject.AddRecord(subjectname, subjectcode);
  

    }


    public void DisplayAllSubject()
    {
        subject.Display();
        
    }
    public void DisplaySubjectByName()
    {
        var subjectname = Console.ReadLine();
        subject.DisplayAny(subjectname);
    }

    public void DisplayAllStudent()
    {
        student.Display();
    }
    public void DisplayStudentByName()
    {
        var studentname = Console.ReadLine();
        student.DisplayAny(studentname);
    }
}





































//SubjectInfo subject = new SubjectInfo(111, "java");
//SubjectInfo subject1= new SubjectInfo(122 , "html");
//SubjectInfo subject2 = new SubjectInfo(133, "css");
//subject.Display();
//Console.WriteLine("-------------------------------------------------------");

//subject1.Display();
//Console.WriteLine("-------------------------------------------------------");

//subject._subjectname = "csharp";
//subject.Display();
//Console.WriteLine("-------------------------------------------------------");


//StudentInfo studentInfo = new StudentInfo("adil", 21, 8180002023 , "nagar");

//StudentInfo studentInfo1 = new StudentInfo("salim", 22, 8180002023, "pune");
//StudentInfo studentInfo2 = new StudentInfo("vishal", 23, 8180002023, "nashik");

//Console.ForegroundColor = ConsoleColor.DarkBlue;

//studentInfo.Display();
//Console.WriteLine("-------------------------------------------------------");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Yellow;
//studentInfo1.Display();
//Console.WriteLine("-------------------------------------------------------");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Green;
//studentInfo2.Display();
//Console.WriteLine("-------------------------------------------------------");
//Console.ResetColor();


//Console.WriteLine(" Your Data Is Updated..!!!");
//studentInfo._studentname = "sayyad";
//studentInfo.Display();

//Console.WriteLine("-------------------------------------------------------");
