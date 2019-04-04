using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class Algoritmos
    {



        public static void calcularDistanciaPar(List<List<double>> matrizDistancia,ParJoin par)
        {

            double distanciaInicio,distanciaFim;


            distanciaInicio = 0.5 * matrizDistancia[par.inicio][par.fim] + 1 / (2 * (matrizDistancia.Count - 2)*(calculoFatorDistanciaLinha(matrizDistancia,matrizDistancia.Count,par.inicio)-calculoFatorDistanciaLinha(matrizDistancia,matrizDistancia.Count,par.fim)));
            distanciaFim = matrizDistancia[par.inicio][par.fim] - distanciaInicio;

            Console.WriteLine(Math.Round(distanciaInicio));
            Console.WriteLine(Math.Round(distanciaFim));

        }


        public static void removerPar(List<List<double>> matrizDistancia, ParJoin par)
        {
            imprimirMatriz(matrizDistancia);
            Console.WriteLine();

            var ponteiroElementoInicioLinha = matrizDistancia.ElementAt(par.inicio);
            var ponteiroElementoFimLinha = matrizDistancia.ElementAt(par.fim);

            matrizDistancia.Remove(ponteiroElementoInicioLinha);
            matrizDistancia.Remove(ponteiroElementoFimLinha);

            foreach (var linha in matrizDistancia)
            {
                var ponteiroElementoInicioColuna = linha.ElementAt(par.inicio);
                var ponteiroElementoFimColuna = linha.ElementAt(par.fim);

                linha.Remove(ponteiroElementoInicioColuna);
                linha.Remove(ponteiroElementoFimColuna);
            }

            imprimirMatriz(matrizDistancia);


        }

        public static int ordemMatrizQuadrada(List<List<double>> matrizDistancia)
        {

            return Convert.ToInt32(Math.Sqrt(matrizDistancia.Count));
        }

        private static double calculoFatorDistanciaLinha(List<List<double>> matrizDistancia,int n, int linha)
        {
            double soma = 0;

            foreach(var elementoColuna in matrizDistancia[linha])
            {
                soma += elementoColuna;

            }

            
            return soma;

        }

        private static double calculoFatorDistanciaColuna(List<List<double>> matrizDistancia, int n, int coluna)
        {
            double soma = 0;
            for (int i = 0; i < n; i++)
                soma += matrizDistancia[i][coluna];
            return soma;

        }



        public static List<List<double>> calculoMatrizQ(List<List<double>> matrizDistancia)
        {
            int ordem =matrizDistancia.Count;

            Console.WriteLine(ordem);
            List<List<double>> matrizQ  = new List<List<double>>();

            for(int i = 0; i < ordem; i++)
            {
                List<double> linha = new List<double>();
                for (int j =0; j < ordem; j++)
                {

                linha.Add( (ordem - 2) * matrizDistancia[i][j] - calculoFatorDistanciaLinha(matrizDistancia, ordem, i) - calculoFatorDistanciaColuna(matrizDistancia, ordem, j));

                }
                matrizQ.Add(linha);
            }
            return matrizQ;
        }

        public static ParJoin parMinimo(List<List<double>> matrizQ)
        {
            int ordem = matrizQ.Count;
            ParJoin parjoin = new ParJoin();

            for (int i = 0; i < ordem; i++)
            {
                int j = i + 1;
                while (j < ordem)
                {
                    if (parjoin.pesoMinimo > matrizQ[i][ j])
                    {
                        parjoin.inicio = i;
                        parjoin.fim = j;
                        parjoin.pesoMinimo = matrizQ[i][ j];
                    }
                    j++;
                }
            }
            return parjoin;
        }


        public static void distanciaNovoParentesco(List<List<double>> matrizDistancia,int no,int antecessor)
        {
            
            //double distancia = 1/2*(matrizDistancia[])


        }



        public static void imprimirMatriz(List<List<double>> matriz)
        {


            foreach (var linha in matriz)
            {

                foreach (var x in linha)
                {

                    Console.Write(x + " ");

                }

                Console.WriteLine();

            }

        }



    }
}
