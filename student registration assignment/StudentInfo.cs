// See https://aka.ms/new-console-template for more informat
class StudentInfo
{
    public string _studentname;
    public int _age;
    public long _phone;
    public string _city;



    public StudentInfo(string studentname, int age, long phone, string city)
    {
        _studentname = studentname;
        _age = age;
        _phone = phone;
        _city = city;

    }

    public void Display()
    {
        Console.Write("\n----------------------------------------------------\n");

        Console.Write(_studentname   +  "\t");
        Console.Write(_age + "\t");
        Console.Write(_phone + "\t");
        Console.Write(_city);
        Console.Write("\n----------------------------------------------------\n");


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
