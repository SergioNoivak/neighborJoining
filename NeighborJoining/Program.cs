﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborJoining
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            List<List<double>> matrizDistancia = new List<List<double>>
            {
               new List<double>() {0.0,5.0,9.0,9.0,8.0},
               new List<double>() {5.0,0.0,10.0,10.0,9.0},
               new List<double>() {9.0,10.0,0.0,8.0,7.0},
               new List<double>() {9.0,10.0,8.0,0.0,3.0},
               new List<double>() {8.0,9.0,7.0,3.0,0.0}
            };


            List<List<double>> matrizQ = Algoritmos.calculoMatrizQ(matrizDistancia);
            Algoritmos.imprimirMatriz(matrizQ);
           

            ParJoin parMinimo= Algoritmos.parMinimo(matrizQ);
            parMinimo.exibir();

            Algoritmos.calcularDistanciaPar(matrizDistancia, parMinimo);
            //Algoritmos.removerPar(matrizDistancia,parMinimo);
            Console.Read();
        }
    }
}
