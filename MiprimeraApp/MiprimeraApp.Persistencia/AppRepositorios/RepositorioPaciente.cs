using System.Collections.Generic;
using System.Linq;
using MiprimeraApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MiprimeraApp.Persistencia
{
    public class RepositorioPaciente :IRepositorioPaciente
    {
        private readonly AppContext _appContext= new AppContext();

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPaciente()
        {
            return _appContext.Pacientes;
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.Find(idPaciente);
        }
    }
}