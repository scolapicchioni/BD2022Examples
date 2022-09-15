using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceA
{
    struct Person 
    {
        public int id;
        public string name;
        public int age;
        public ItalianDayOfTheWeek FavoriteDay;
    }

    enum ItalianDayOfTheWeek { 
        Lunedi = 1,
        Martedi = 10,
        Mercoledi = 100,
        Giovedi = 1000,
        Venerdi,
        Sabato,
        Domenica
    }
}

namespace ServiceB {
    struct Person {
        public string name;
        public int age;
        public int surname;
    }
}
