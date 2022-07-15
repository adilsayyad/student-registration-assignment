// See https://aka.ms/new-console-template for more informat
using System;
using static Student;

//Student studentInfo = new Student();
//studentInfo.AddRecord();
//studentInfo.Display();
//studentInfo.DisplayAny("adil");


//Subject subject = new Subject();
//    subject.AddRecord();
//subject.Display();
//subject.DisplayAny("java");

int choice = 0;
//Student student = new Student();
Student_Managment student_Managment = new Student_Managment();

do
{
    Console.WriteLine("----------------------");
    Console.WriteLine("1.Add Student :  ");
    Console.WriteLine("----------------------");
    Console.WriteLine("2.Update Student : ");
    Console.WriteLine("----------------------");
    Console.WriteLine("3. Display any stuydent: ");
    Console.WriteLine("----------------------");
    Console.WriteLine("4.Display All student: ");
    Console.WriteLine("----------------------");
    Console.WriteLine("5.Add Module: ");
    Console.WriteLine("----------------------");
    Console.WriteLine("6.Update Module : ");
    Console.WriteLine("----------------------");
    Console.WriteLine("7.Display any Module : ");
    Console.WriteLine("----------------------");
    Console.WriteLine("8.Display all Module : ");

    Console.WriteLine(" Enter Your Choice: ");


    choice=int.Parse(Console.ReadLine());
   
    switch (choice)
    {
        case 1:
            student_Managment.AddStudentRecord();
            break;
        case 2:
            break;
        case 3:
            student_Managment.DisplayStudentByName();
            break;
        case 4:
            student_Managment.DisplayAllStudent();
            break;
        case 5:
            student_Managment.AddSubjectRecord();
            break;
        case 6:
            break;
        case 7:
            student_Managment.DisplaySubjectByName();
            break;
        case 8:
            student_Managment.DisplayAllSubject();

            break;
        default:
            break;


    }
}while (choice != 0);


























public class Student
{
    List<StudentInfo> _students;

    public Student()
    {
        _students = new List<StudentInfo>();
    }

    public void AddRecord(string studentname , int age , int phone , string city)
    {
        StudentInfo studentInfo = new StudentInfo(studentname, age, phone, city);
        _students.Add(studentInfo);
      

    }

    public void Display()
    {
        foreach (StudentInfo studentInfo in _students)

        {
            studentInfo.Display();
        }
    }

    public void DisplayAny(string studentname)

    {
        

        Console.WriteLine(studentname);

        Console.WriteLine("----------------------------------------------------");


        foreach (StudentInfo studentInfo in _students)
        {
            if (studentname == studentInfo._studentname);
            {


                Console.WriteLine("student info OutPut is ");
                studentInfo.Display();
                break;
            }

        }

    }


    public class Subject
    {
        List<SubjectInfo> _subjects;

        public Subject()
        {
            _subjects = new List<SubjectInfo>();
        }

        public void AddRecord(string subjectname, int subjectcode)
        {

            SubjectInfo subject = new SubjectInfo(subjectcode, subjectname);
            _subjects.Add(subject);

        }

        public void Display()
        {
            foreach (SubjectInfo subject in _subjects)

            {
                subject.Display();
                Console.WriteLine("----------------------------------------------------");
            }
        }

        public void DisplayAny(string subjectname)
        {
            Console.WriteLine(subjectname);

            Console.WriteLine("----------------------------------------------------");

            foreach (SubjectInfo subject in _subjects)
            {


                if (subjectname == subject._subjectname)
                {
                    Console.WriteLine(" Your Output is ");
                    subject.Display();


                }

            }

        }
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
