namespace Ejercicio_POO
{
    using System;

    class Program
    {
        static void Main()
        {
            Persona juan = new Persona();
            juan.MostrarDatos();

            Casa nuevaCasa = new Casa(50);
            nuevaCasa.Puerta.SetColor("Verde");

            Persona ana = new Persona("Carlos", nuevaCasa);
            ana.MostrarDatos();
        }
    }


}