namespace PB_503___Abstraction__Polymorphism_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User();
            //user1.Email = "user1@mail.com";
            //user1.Fullname = "User1";
            //user1.Password = "USER1sALAM";

            //Console.WriteLine(user1.PasswordChecker(user1.Password));
            //user1.ShowInfo();

            //User user2 = new User();
            //user2.Email = "user2@mail.com";
            //user2.Fullname = "User2";
            //user2.Password = "user2Salam";

            //Console.WriteLine(user2.PasswordChecker(user2.Password));
            //user2.ShowInfo();

            Student student1 = new Student();
            student1.Fullname = "Studen1";
            student1.Point = 4.5;

            Student student2 = new Student();
            student2.Fullname = "Studen2";
            student2.Point = 5.5;

            Student student3 = new Student();
            student3.Fullname = "Studen3";
            student3.Point = 5.5;

            Student student4 = new Student();
            student4.Fullname = "Studen4";
            student4.Point = 5.5;

            Student student5 = new Student();
            student5.Fullname = "Studen5";
            student5.Point = 5.5;

            Student student6 = new Student();
            student6.Fullname = "Studen6";
            student6.Point = 5.5;


            //student1.StudentInfo();
            //student2.StudentInfo();
            //student3.StudentInfo();
            //student4.StudentInfo();
            //student5.StudentInfo();
            //student6.StudentInfo();



            Group group1 = new Group();
            group1.GroupNo = "PB503";
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            //group1.AddStudent(student4);
            //group1.AddStudent(student5);
            //group1.AddStudent(student6);

            foreach (var grp in group1._students)
            {
                Console.WriteLine(grp.Fullname);
            }


            // group1.GetAllStudents();

            //Console.WriteLine(group1.CheckGroupNo(group1.GroupNo)); 

        }
    }
}
