using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceUgulama
{
    public class Admin:Worker
    {
        private int responsiblePeople;
        public Admin(int id,string name,string surname, int responsiblePeople):base(id,name,surname)
        {
            this.responsiblePeople = responsiblePeople;
        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine(getName()+" "+zamMiktarı+" tl çalışanlarına zam yapıyor...");
        }
    }
}
