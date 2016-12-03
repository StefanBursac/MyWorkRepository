using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondBindingExersize
{
    public class Osoba
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static Osoba SetName()
        {
            var osoba = new Osoba()
            {
                firstName = "Stefan",
                lastName = "Bursac"
            };
            return osoba;
        }

    }
}
