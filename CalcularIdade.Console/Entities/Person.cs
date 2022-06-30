using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIdade.Console.Entities
{
    internal class Person
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        private int CalcularIdade()
        {
            DateTime d1 = DateTime.Now;
            double idade = (d1 - BirthDate).Days / 365;

            if (d1.Month >= BirthDate.Month && d1.Day > BirthDate.Day)
            {
                return (int)--idade;
            }
            else
            {
                return (int)idade;
            }
        }

        public override string ToString()
        {
            return $"Olá, {Name}. Sua idade é {CalcularIdade()}";
        }

    }
}
