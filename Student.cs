using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraAssignment3
{
    public class Student : Person
    {
        private int _age;
        private int _gender;

        public int age{ get; set; }

        public int gender{ get; set; }

        public override void Name(string name)
        {
            _name = name;
        }

        public void takeTest()
        {
            Random random = new Random();
            int num = random.Next(0,101);
            Console.WriteLine(num);
        }
    }
}
