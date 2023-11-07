using AutoMapper;
using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Mapper
{
    public class Mapping : Profile
    {
        public Mapping() {

            CreateMap<User, UserDTO>();
        }
    }
}
