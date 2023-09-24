using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.CollectionInterface
{
     class IComparableDemo
    {
        static void Main(string[] args)
        {
            PlayerCls Rohit = new PlayerCls(14000, "Rohit");
            PlayerCls Virat = new PlayerCls(12000, "Virat");
            int result = Rohit.CompareTo(Virat); // -1 , 1 , 0
            if (result < 0)
            {
                Console.WriteLine("Rohit has less runs than Virat");
            }
            else if (result > 0)
            {
                Console.WriteLine("Rohit has more runs than Virat");
            }
            else
            {
                Console.WriteLine("Rohit & Virat has same runs");
            }
        }
    }
    public class PlayerCls : IComparable<PlayerCls>
    {
        private int runs;
        private string name;
        public PlayerCls(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public int CompareTo(PlayerCls other)// other --> hold data of Virat
        {
            // this keyword refers to Rohit's object
            // other will refers to Virat's object
            if (this.runs < other.runs)
            {
                return -1;
            }
            else if (this.runs > other.runs)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{runs} --> {name}";
        }
    }
}
