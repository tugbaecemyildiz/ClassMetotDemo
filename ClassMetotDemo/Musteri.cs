using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tc { get; set; }

        public Musteri(int ıd, string name, string surname, string tc)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Tc = tc;
        }
    }
}
