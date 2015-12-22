using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbox
{
    public class Sauna
    {
        public bool Switched { get; set; }
        public void SaunaOn (){

            if (Switched == true)
            {
                Switched = false;
            }
            else
            {
                Switched = true;
            }
        }
    }
}
