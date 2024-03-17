using System;
using System.Threading;

namespace desafio_zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 16;
            switch (option)
            {
                case 1:
                    Leon leon = new Leon();
                    leon.IniciarLeon();
                    break;
                case 2:
                    Jirafa jirafa = new Jirafa();
                    jirafa.Iniciarjirafa();
                    break;
                case 3:
                    Tiger tiger = new Tiger();
                    tiger.IniciarTiger();
                    break;

            }
        }

        class Leon //1
        {
            Animales leon = new Animales();
            public void IniciarLeon()
            {
                leon.especie = "Leon";
                leon.nombre = "Simba";
                leon.sexo = "Masculino";
                leon.suena = "RAWR";
                leon.alimentacion = "carne";
                Console.WriteLine("Él " + leon.especie + " se llama " + leon.nombre + " y es de genero " + leon.sexo);
                leon.comer();
                leon.sonar();
            }

        }
        class Jirafa //2
        {
            Animales jirafa = new Animales();
            public void Iniciarjirafa()
            {
                jirafa.especie = "Jirafa";
                jirafa.nombre = "irbis";
                jirafa.sexo = "Femenino";
                jirafa.alimentacion = "hierbas";
                Console.WriteLine("La " + jirafa.especie + " se llama " + jirafa.nombre + " y es de genero " + jirafa.sexo);
                jirafa.comer();
                jirafa.sonar();
            }
            class Tiger //3
            {
                Animales tiger = new Animales();
                public void IniciarTiger()
                {
                    tiger.especie = "Tigre";
                    tiger.nombre = "rango";
                    tiger.sexo = "Masculino";
                    tiger.alimentacion = "carne";
                    tiger.accioon = "Caza a sus presas";
                    Console.WriteLine("Él " + tiger.especie + " se llama " + tiger.nombre + " y es de genero " + tiger.sexo);
                    tiger.comer();
                    tiger.sonar();
                    tiger.accion();

                }
            }
        }
    }
}
