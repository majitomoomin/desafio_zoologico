using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_zoologico
{
    public class Animales
    {
        public Animales()
        {
        especie = "";
        nombre= "";
        sexo= "";
        alimentacion= "";
        suena= "";
        accioon= "";
    }
        public string especie;
        public string nombre;
        public string sexo;
        public string alimentacion;
        public string suena;
        public string accioon;

        public void comer()
        {
            Console.WriteLine(especie + " come " + alimentacion);
        }
        public void sonar()
        {
            Console.WriteLine("Él "+ especie+ " Le hace "+ suena);
        }
        public void accion()
        {
            Console.WriteLine("El " + especie +" "+ accioon);
        }
    }
}
