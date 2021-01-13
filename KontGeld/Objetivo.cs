using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontGeld
{
    class Objetivo
    {

        public double vt,tt;
		public int mobj;

        //métodos
        public void calcular()
        {
            this.tt = this.vt / this.mobj;
        }
    }
}
