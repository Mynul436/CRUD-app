
using Assignment3;

DbContestClass db = new DbContestClass();
Student student = new Student();
Admin admin = new Admin();
Teacher teacher = new Teacher();
Course course = new Course();
int fInput=0;
int sInput=0;

Console.WriteLine($"What type of User You are?\n1.Admin\n2.Teacher\n3.Student\n4.Exit");
// fInput=Convert.ToInt32(Console.ReadLine());
do
{
    fInput = Convert.ToInt32(Console.ReadLine());

    switch (fInput)
    {
        
        case 1:
            Console.WriteLine("Please Lognin...");
            Console.WriteLine("Please Enter Your UserName:\n");
            string UserName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password:\n");
            string Password = Console.ReadLine();
            
            
                
                if (UserName == "Akash" && Password == "1234")
                {
                   
                    Console.WriteLine("Welcome!!Login Successful");
                    Console.WriteLine("What do You Want?\n1.Create Teacher Account\n2.Create New Course\n3.Create Student Account\n4.Exit\n");

                 

                    sInput = Convert.ToInt32(Console.ReadLine());
                    switch (sInput)
                    {
                        case 1:
                            Console.WriteLine("Enter Teacher Name\n");
                            teacher.Name = Console.ReadLine();
                            Console.WriteLine("Enter UserName\n");
                            teacher.UserName = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            teacher.Password = Console.ReadLine();
                           // Console.WriteLine("Assigned Course Id");
                            db.Teachers.Add(teacher);
                            db.SaveChanges();
                            break;
                        case 2:
                            Console.WriteLine("Enter Course Name:\n");
                            course.CourseName = Console.ReadLine();
                            Console.WriteLine("Enter Course Fees\n");
                            course.Fees = Console.ReadLine();
                        Console.WriteLine("Course will start :");
                            course.ClassStartDate = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Total Number Of Class");
                            course.TotalNumberOfClass = Convert.ToInt32(Console.ReadLine());
                            //Console.WriteLine("Coure Teacher Id");
                           // course.CourseTeacherId = Convert.ToInt32(Console.ReadLine());
                            db.Courses.Add(course);
                            db.SaveChanges();
                            break;

                        case 3:

                            Console.WriteLine("Enter Student Name:\n");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter UserName");
                            student.UserName = Console.ReadLine();
                            Console.WriteLine("Enter Password:\n");
                            student.Password = Console.ReadLine();
                            Console.WriteLine("Assign him in a Course.Give Course Id");
                            student.CourseId = Console.ReadLine();
                            Console.WriteLine("Give Initial Attendence will 0");
                                student.Attendance=Console.ReadLine();
                            db.Students.Add(student);
                            db.SaveChanges();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid UserName or Password");
                
                }
                
            break;
        case 2:
            Console.WriteLine("Please Enter UserName:");
            string un=Console.ReadLine();
            Console.WriteLine("Please Enter Password:");
            string pw=Console.ReadLine();

            teacher = db.Teachers.Where(x => x.UserName==un&&x.Password ==pw).FirstOrDefault();
            if(teacher != null)
            {
                Console.WriteLine("Login Successful");

            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
       
            

            break;

        case 3:
            Console.WriteLine("Please Enter UserName:");
            string un1 = Console.ReadLine();
            Console.WriteLine("Please Enter Password:");
            string pw1 = Console.ReadLine();

            student = db.Students.Where(x => x.UserName == un1 && x.Password == pw1).FirstOrDefault();
            if (teacher != null)
            {
                Console.WriteLine("Login Successful");
                Console.WriteLine("Give Your Attendance");
                student.Attendance=Console.ReadLine();
                db.Students.Add(student);
                db.SaveChanges();


            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
            break;
    }
}while(fInput!=4);
