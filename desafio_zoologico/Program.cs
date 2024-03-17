using System;
using System.Threading;
//n
namespace desafio_zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al zoologico!");
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1- Leon");
            Console.WriteLine("2- Jirafa");
            Console.WriteLine("3- Tigre");
            Console.WriteLine("4 - Mono");
            Console.WriteLine("5- Oso");
            Console.WriteLine("6 - Cocodrilo");
            Console.WriteLine("7 - Serpiente");
            Console.WriteLine("8 - Pingüino");
            Console.WriteLine("9 - Lobo");
            Console.WriteLine("10 - Cebra");
            Console.WriteLine("11 - Rinoceronte");
            Console.WriteLine("12- Panda");
            Console.WriteLine("13- Pavo Real");
            Console.WriteLine("14- Tortuga");
            Console.WriteLine("15- Pantera");

            string input = Console.ReadLine();
            int option;

            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Entrada no valida, ingrese un numero");
                return;
            }
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
                case 4:
                    Mono mono = new Mono();
                    mono.IniciarMono();
                    break;
                case 5:
                    Oso oso = new Oso();
                    oso.IniciarOso();
                    break;
                case 6:
                    Cocodrilo cocodrilo = new Cocodrilo();
                    cocodrilo.IniciarCocodrilo();
                    break;
                case 7:
                    Serpiente serpiente = new Serpiente();
                    serpiente.IniciarSerpiente();
                    break;
                case 8:
                    Pinguino pingui = new Pinguino();
                    pingui.IniciarPinguino();
                    break;
                case 9:
                    Lobo lobo = new Lobo();
                    lobo.IniciarLobo();
                    break;
                case 10:
                    Cebra cebra = new Cebra();
                    cebra.IniciarCebra();
                    break;
                case 11:
                    Rino rino = new Rino();
                    rino.IniciarRino();
                    break;
                case 12:
                    Panda panda = new Panda();
                    panda.IniciarPanda();
                    break;
                case 13:
                    Pavo pavo = new Pavo();
                    pavo.IniciarPavo();
                    break;
                case 14:
                    Tortu tortu = new Tortu();
                    tortu.IniciarTortu();
                    break;
                case 15:
                    Pantera pantera = new Pantera();
                    pantera.IniciarPantera();
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
            }
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
                    tiger.suena = "RAWR";
                    tiger.accioon = "Caza a sus presas";
                    Console.WriteLine("Él " + tiger.especie + " se llama " + tiger.nombre + " y es de genero " + tiger.sexo);
                    tiger.comer();
                    tiger.sonar();
                    tiger.accion();

                }
            }
        class Mono //4
        {
            Animales mono = new Animales();
            public void IniciarMono()
            {
                mono.especie = "Mono";
                mono.nombre = "doki";
                mono.sexo = "Masculino";
                mono.alimentacion = "animales y plantas";
                mono.suena = "uuaauuaa";
                mono.accioon = "Trepan los arboles";
                Console.WriteLine("Él " + mono.especie + " se llama " + mono.nombre + " y es de genero " + mono.sexo);
                mono.comer();
                mono.sonar();
                mono.accion();

            }
        }
        class Oso //5
        {
            Animales oso = new Animales();
            public void IniciarOso()
            {
                oso.especie = "Oso";
                oso.nombre = "wini";
                oso.sexo = "Masculino";
                oso.alimentacion = "animales y plantas";
                oso.suena = "RAWR";
                oso.accioon = "Hibernan";
                Console.WriteLine("Él " + oso.especie + " se llama " + oso.nombre + " y es de genero " + oso.sexo);
                oso.comer();
                oso.sonar();
                oso.accion();

            }
        }
        class Cocodrilo //6
        {
            Animales cocodrilo = new Animales();
            public void IniciarCocodrilo()
            {
                cocodrilo.especie = "Cocodrilo";
                cocodrilo.nombre = "dientes";
                cocodrilo.sexo = "Masculino";
                cocodrilo.alimentacion = "peces, aves y mamiferos de talla considerable";
                cocodrilo.accioon = "nadan";
                Console.WriteLine("Él " + cocodrilo.especie + " se llama " + cocodrilo.nombre + " y es de genero " + cocodrilo.sexo);
                cocodrilo.comer();
                cocodrilo.sonar();
                cocodrilo.accion();

            }
        }
        class Serpiente //7
        {
            Animales serpiente = new Animales();
            public void IniciarSerpiente()
            {
                serpiente.especie = "Serpiente";
                serpiente.nombre = "boa";
                serpiente.sexo = "Femenino";
                serpiente.alimentacion = "peces, aves y mamiferos de talla considerable";
                serpiente.suena = "PSSSSSSS";
                serpiente.accioon = "se arrastra";
                Console.WriteLine("Él " + serpiente.especie + " se llama " + serpiente.nombre + " y es de genero " + serpiente.sexo);
                serpiente.comer();
                serpiente.sonar();
                serpiente.accion();

            }
        }
        class Pinguino //8
        {
            Animales pingui = new Animales();
            public void IniciarPinguino()
            {
                pingui.especie = "Pingüino";
                pingui.nombre = "rey";
                pingui.sexo = "Masculino";
                pingui.alimentacion = "peces";
                pingui.accioon = "nadan y se deslizan por la nieve";
                Console.WriteLine("Él " + pingui.especie + " se llama " + pingui.nombre + " y es de genero " + pingui.sexo);
                pingui.comer();
                pingui.accion();

            }
        }
        class Lobo //9
        {
            Animales lobo = new Animales();
            public void IniciarLobo()
            {
                lobo.especie = "Lobo";
                lobo.nombre = "loui";
                lobo.sexo = "Masculino";
                lobo.alimentacion = "mamiferos pequeños y aves";
                lobo.suena = "AAAAUUUUUU";
                lobo.accioon = "corren";
                Console.WriteLine("Él " + lobo.especie + " se llama " + lobo.nombre + " y es de genero " + lobo.sexo);
                lobo.comer();
                lobo.accion();
                lobo.sonar();
            }
        }
        class Cebra //10
        {
            Animales cebra = new Animales();
            public void IniciarCebra()
            {
                cebra.especie = "Cebra";
                cebra.nombre = "rayitas";
                cebra.sexo = "Masculino";
                cebra.alimentacion = "plantas";
                cebra.accioon = "corren";
                Console.WriteLine("Él " + cebra.especie + " se llama " + cebra.nombre + " y es de genero " + cebra.sexo);
                cebra.comer();
                cebra.accion();
            }
        }
        class Rino //11
        {
            Animales rino = new Animales();
            public void IniciarRino()
            {
                rino.especie = "Rinoceronte";
                rino.nombre = "cornudo";
                rino.sexo = "Masculino";
                rino.alimentacion = "plantas";
                rino.accioon = "nadan";
                Console.WriteLine("Él " + rino.especie + " se llama " + rino.nombre + " y es de genero " + rino.sexo);
                rino.comer();
                rino.accion();
            }
        }
        class Panda //12
        {
            Animales panda = new Animales();
            public void IniciarPanda()
            {
                panda.especie = "Panda";
                panda.nombre = "Pelusa";
                panda.sexo = "Femenino";
                panda.alimentacion = "Bambú";
                panda.accioon = "escalan";
                Console.WriteLine("Él " + panda.especie + " se llama " + panda.nombre + " y es de genero " + panda.sexo);
                panda.comer();
                panda.accion();
            }
        }
        class Pavo //13
        {
            Animales pavo = new Animales();
            public void IniciarPavo()
            {
                pavo.especie = "Pavo Real";
                pavo.nombre = "trokis";
                pavo.sexo = "Masculino";
                pavo.alimentacion = "granos y plantas";
                pavo.accioon = "sacan sus colas";
                Console.WriteLine("Él " + pavo.especie + " se llama " + pavo.nombre + " y es de genero " + pavo.sexo);
                pavo.comer();
                pavo.accion();
            }
        }
        class Tortu//14
        {
            Animales tortu = new Animales();
            public void IniciarTortu()
            {
                tortu.especie = "Tortuga";
                tortu.nombre = "yoyo";
                tortu.sexo = "Masculino";
                tortu.alimentacion = "plantas";
                tortu.accioon = "camina";
                Console.WriteLine("Él " + tortu.especie + " se llama " + tortu.nombre + " y es de genero " + tortu.sexo);
                tortu.comer();
                tortu.accion();
            }
        }
        class Pantera //15
        {
            Animales pantera = new Animales();
            public void IniciarPantera()
            {
                pantera.especie = "Pantera";
                pantera.nombre = "Rosa";
                pantera.sexo = "Femenino";
                pantera.alimentacion = "carne";
                pantera.suena = "MEOW";
                pantera.accioon = "corre y caza";
                Console.WriteLine("Él " + pantera.especie + " se llama " + pantera.nombre + " y es de genero " + pantera.sexo);
                pantera.comer();
                pantera.sonar();
                pantera.accion();
            }
        }
    }
}
