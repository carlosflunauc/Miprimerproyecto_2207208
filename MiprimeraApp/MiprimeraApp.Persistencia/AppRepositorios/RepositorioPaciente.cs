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
        SignoVital IRepositorioPaciente.AsignarSignoVital(int idPaciente, SignoVital signoVital)
        {
            var paciente = _appContext.Pacientes
                .Where(p =>p.Id == idPaciente)
                //.Include(p =>p.SignosVitales)
                .FirstOrDefault();

                if(paciente != null)
                {
                    paciente.SignosVitales.Add(signoVital);
                    _appContext.SaveChanges();
                    return signoVital;
                }
                return null;
        }
    }
}