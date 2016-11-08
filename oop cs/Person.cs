using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cs
{
    public class Person
    {
        public Person(string x, string y)
        {
            Vorname = x;
            Nachname = y;
            Energie = 100;
        }
        
        public string Nachname;
        public string Vorname;
        public int Alter;
        public int Energie;
        public bool HatHunger;

        public void Laufe(int strecke)
        {
            Energie = Energie - strecke;
        }
    }
}
