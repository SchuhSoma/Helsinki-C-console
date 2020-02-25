using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki2
{
    class Helsinki
    {
        public int Helyezes;
        public int SportolokSzama;
        public string SportagNeve;
        public string VersenyszamNeve;

        public Helsinki( string sor)
        {
            var dbok = sor.Split(' ');
            this.Helyezes = int.Parse(dbok[0]);
            this.SportolokSzama = int.Parse(dbok[1]);
            this.SportagNeve = dbok[2];
            this.VersenyszamNeve = dbok[3];
        }



    }
}
