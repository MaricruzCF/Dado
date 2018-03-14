using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        Random rdn = new Random();
        
        public int lanzar()
        {
            int lanzar= rdn.Next(6);
            return lanzar +1;
        }
    }
}
