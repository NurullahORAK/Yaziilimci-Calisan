using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceUgulama
{
    public class Programmer:Worker
    {
        private string languages;
        public Programmer(int id,string name,string surname,string languages):base(id ,name,surname)
        {
            this.languages = languages;
        }

        public void Formatting(string isletimSistemi)
        {
            Console.WriteLine(getName()+" "+isletimSistemi+ " formatting the operating system.");
        }

    }
}
