using System;
using System.Collections.Generic;
using MiprimeraApp.Dominio;
using MiprimeraApp.Persistencia;

namespace MiprimeraApp.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al 4 noviembre");
            //AddPaciente();
            //BuscarPaciente(1);
            MostrarPacientes();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Tatiana",
                Apellidos="Perez",
                NumeroTelefono="6068855555",
                Genero=Genero.Femenino,
                Direccion="Calle 20 no 10-20",
                Ciudad="Villamaria",
                FechaNacimiento= new DateTime(1985,04,12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPaciente();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
        }
    }
}
