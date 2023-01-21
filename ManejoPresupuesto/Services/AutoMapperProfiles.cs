using AutoMapper;
using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Services
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cuenta, CuentaCreacionViewModel>();
            CreateMap<TransaccionActualizacionViewModel, Transaccion>().ReverseMap();
            //ReverseMap permite configurar varios mapeos viceversas
        }
    }
}
