using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class StudentUniversity : StudentCollege
    {
        private float score4;
        public StudentUniversity(float score1, float score2, float score3, float score4, string name, int year) : base(score1, score2, score3, name, year)
        {
            this.score4 = score4;
        }

        public override float Average()
        {
            return (Score1+ Score2+ Score3 + Score4)/4;
        }

        public new void Display()
        {
            Console.WriteLine(year+": "+name);
            Console.WriteLine("Average: "+Average());
        }


    }
}
