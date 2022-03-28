using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraAssignment3
{
    public class Teacher: Person
    {
        private string _grade;
        private int _salary;

        public override void Name(string name)
        {
            _name = name;
        }

        public override int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value + 10;
            }
        }

        public int grade{ get; set; }

        public int salary { get; set; }

        public void giveTest()
        {
            string[] difficulties = new string[3] { "easy", "medium", "hard" };
            Random rnd = new Random();
            int num = rnd.Next(0, 3);
            Console.WriteLine(difficulties[num]);
        }

    }
}
