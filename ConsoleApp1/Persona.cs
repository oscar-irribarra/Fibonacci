using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        private string name;
        public string Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = name;
            }
        }

        public Persona(){
        }

        public void setname(string name)
        {
            this.name = name;
        }

        public string getNombre(){

            return this.Nombre;
        }
    }
}
