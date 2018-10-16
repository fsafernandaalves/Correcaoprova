using System;
using System.Collections.Generic;
using System.Text;

namespace Fernanda_Alves_31828917
{
    class IMC
    {
        private double peso;
        private double altura;

        public IMC()

        {
            this.peso = 0.0;
            this.altura = 0.0;
        }

        public IMCC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
            Console.WriteLine(peso / (altura * altura));
        }
        public double Classificar(double imc)
        {
            return 0.0;
        }
    }