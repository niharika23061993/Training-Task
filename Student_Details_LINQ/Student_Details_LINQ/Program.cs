using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details_LINQ
{
    class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Marks;
            public ContactInfo GetContactInfo(Program pg, int id)
            {
                ContactInfo allinfo =
                    (from ci in pg.contactList
                     where ci.ID == id
                     select ci)
                    .FirstOrDefault();

                return allinfo;
            }

            public override string ToString()
            {
                return First + "" + Last + " :  " + ID;
            }
        }

        public class ContactInfo
        {
            public int ID { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public override string ToString() { return Email + "," + Phone; }
        }

        public class ScoreInfo
        {
            public double Average { get; set; }
            public int ID { get; set; }
        }
        List<Student> students = new List<Student>()
        {
             new Student {First="Tom", Last=".K", ID=1,
                          Marks= new List<int>() {97, 92, 81, 60}},
             new Student {First="Megan", Last=".L", ID=2,
                          Marks= new List<int>() {75, 84, 91, 39}},
             new Student {First="Jerry", Last=".S", ID=3,
                          Marks= new List<int>() {88, 94, 65, 91}},
             new Student {First="Andrea", Last=".O", ID=4,
                          Marks= new List<int>() {97, 89, 85, 82}},
        };
        List<ContactInfo> contactList = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="Tom@xyz.com", Phone="9328298765"},
            new ContactInfo {ID=112, Email="Meghan@aaa.com", Phone="9876543201"},
            new ContactInfo {ID=113, Email="Jerry@aaa.com", Phone="9087467653"},
            new ContactInfo {ID=114, Email="Andrea@qqq.com", Phone="9870098761"}
        };
        static void Main(string[] args)
        {
            Program pg = new Program();

            IEnumerable<Student> studentQuery1 =
                from student in pg.students
                where student.ID >= 1
                select student;

            Console.WriteLine("Query : Select range_variable");
            Console.WriteLine();
            
            Console.WriteLine("Name    : ID");
            
            foreach (Student s in studentQuery1)
            {
                Console.WriteLine(s.ToString());
            }
           
            Console.ReadLine();
        }
    }
}
