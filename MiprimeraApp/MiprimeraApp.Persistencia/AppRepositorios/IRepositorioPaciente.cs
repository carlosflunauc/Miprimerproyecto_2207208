using System.Collections.Generic;
using MiprimeraApp.Dominio;

namespace MiprimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
         IEnumerable<Paciente> GetAllPaciente();
         Paciente AddPaciente(Paciente paciente);
         Paciente GetPaciente(int idPaciente);
         SignoVital AsignarSignoVital(int idPaciente, SignoVital signoVital);
    }
}