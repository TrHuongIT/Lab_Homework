using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class StudentCollege:Student
    {
        private float score1, score2, score3;

        public float Score1 { get { return score1; } set { score1 = value; } }
        public float Score2 { get { return score1; } set { score1 = value; } }
        public float Score3 { get { return score1; } set { score1 = value; } }
        public float Score4 { get { return score1; } set { score1 = value; } }

        public StudentCollege()
        {

        }

        public StudentCollege(float score1, float score2, float score3, string name, int year):base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public override float Average()
        {
            return (score1+score2+score3)/3;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Average: "+Average());
        }

        
    }
}
