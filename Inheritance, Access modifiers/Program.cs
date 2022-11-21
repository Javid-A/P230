using Inheritance__Access_modifiers;
using System.Text;

#region Homeworks
//static string ToCapitalized(string sentence)
//{
//    //string result = string.Empty;
//    StringBuilder result = new();
//    string newSentence = sentence.ToLower();
//    string[] words = newSentence.Split();

//    foreach (string word in words)
//    {
//        result.Append(char.ToUpper(word[0]));

//        char[] letters = word.ToCharArray();

//        for (int i = 1; i < letters.Length; i++)
//        {
//            result.Append(letters[i]);
//        }
//        result.Append(" ");
//    }

//    return result.ToString().TrimEnd();
//}

//Console.WriteLine(ToCapitalized("MehRaC yenE bos BOS DaNisHir"));

//Student student = new("Mehrac","Mammadov","P230",87,true);




//Console.WriteLine(student.Fullname());
//student.Info();

//Console.WriteLine(student.TryAnother());

#endregion

#region Inheritance
//Student stu = new("Rashid","Bagirov","P230",20,true);
//Student stu2 = new("Rashid","Bagirov","P230",30,true);


//stu.ShowData();
//stu2.ShowData();


//Student stu = new("Ulviyya","Rustamova","P230",43);

//stu.Fullname();

//Teacher teacher = new Teacher("Javid","Asadullayev","Male",25,"Programming",912323);
//Doctor doctor = new Doctor("Kamran","Zeynalov","Male",19,"Brain",1);
//Student student = new Student("Parviz","Alizade","Male",19,"Programming",30);
//Console.WriteLine(teacher.Fullname());
//Console.WriteLine(doctor.Fullname());
//Console.WriteLine(student.Fullname());

#endregion


Computer comp = new Computer("Lenovo","Thinkpad",10000,16, "512 SSD","1234567890-123456789");


//Console.WriteLine(comp.ShowCode());

//comp.ChangeCode();

Console.WriteLine(comp.Code);
Console.WriteLine(comp.Code);
//Console.WriteLine(comp.ShowCode());