using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Processes_1
{
    class Persone
    {
        private String first_name;
        public String last_name { get; set; }
        public Persone()
        {
            first_name = "Vasia";
            last_name = "Pupkin";
        }
        public Persone(String _first_name, String _last_name)
        {
            first_name = _first_name;
            last_name = _last_name;
        }
        public void sayHello() { Console.WriteLine($"fname: {first_name}; lname: {last_name}"); }
    }
}
