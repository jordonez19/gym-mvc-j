using System;
using System.Collections.Generic;


namespace ConsoleAppDAOMVCSingletonSolid
{
    public class EmpleadoView
    {
        public void MostrarEmpleado(Empleado cliente)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Datos del Cliente:\n" + cliente.ToString());
            Console.WriteLine("------------------------------");

        }

        public void MostrarEmpleados(List<Empleado> empleados)
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("No hay clientes para mostrar.");
                Console.WriteLine("------------------------------");

                return;
            }

            Console.WriteLine("Lista de Empleados:");
            foreach (Empleado cliente in empleados)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(cliente.ToString());
                Console.WriteLine("------------------------------");
            }
        }
    }
}
