using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace InheritanceUgulama
{
    public class Worker
    {
        private int id;
        private string name;
        private string surname;

        public Worker(int _id,string _name,string _surname)
        {
            this.id = _id;
            this.name = _name;
            this.surname = _surname;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setNanme(string name)
        {
            this.name = name;
        }
        public string getSurname()
        {
            return surname;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("id: "+this.id);
            Console.WriteLine("Name: "+this.name);
            Console.WriteLine("Surname: "+this.surname);
        }

    }
}
