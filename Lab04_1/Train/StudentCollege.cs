using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class StudentCollege : Student
    {
        protected float score1, score2, score3;
        public StudentCollege(float score1, float score2, float score3, string name, int year) : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public override float Average()
        {
            return (score1 + score2 + score3) / 3;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score1: {0} - Score2: {1} - Score3: {2}",score1,score2,score3);
        }
    }
}
