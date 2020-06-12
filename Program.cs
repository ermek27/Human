using System;
using HumanProj.Models_;
namespace HumanProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ermek  = new Human("Ermek", 45, 50, 50, 100);
            Human Ruslan = new Human("Rus", 20, 15, 90, 100);
            Ermek.Attack(Ruslan);
            Ruslan.Attack(Ermek);
        }
    }
}
