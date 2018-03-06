using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Processes_1
{
    class Surprise
    {
        public dynamic getSurprise(int _code) {

            dynamic result = null;
            switch (_code)
            {
                case 1: {
                        result = new Persone();
                        break;
                    }
                case 2:
                    {
                        result = new { id = 1, name = "myname" };
                        break;
                    }
                case 3:
                    {
                        result = new { id = 1, p = new Persone("myfname", "mylname") };
                        break;
                    }
                default:
                    break;
            }
            return result;
        }
    }
}
