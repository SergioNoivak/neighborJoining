using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class ParJoin
    {
       public  int inicio          ;
       public  int fim             ;
       public  double pesoMinimo   ;

        public ParJoin()
        {
            this.inicio = this.fim = -1;
            this.pesoMinimo = Double.MaxValue;
        }

        public ParJoin(int inicio,int fim,double pesoMinimo)
        {
            this.inicio = inicio;
            this.fim       =fim       ;
            this.pesoMinimo=pesoMinimo;


        }


        public void exibir()
        {

            Console.WriteLine("{inicio: " + inicio + " ,fim: " + fim + " ,pesoMinimo: " + this.pesoMinimo+"}");


        }
    }
}
