using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class StudentUniversity : StudentCollege
    {
        private float score4;
        public StudentUniversity(float score1, float score2, float score3, string name, int year, float score4) : base(score1, score2, score3, name, year)
        {
            this.score4 = score4;
        }

        public override float Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score4: "+score4);
        }
    }
}
