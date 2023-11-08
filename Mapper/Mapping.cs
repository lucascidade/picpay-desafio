using AutoMapper;
using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Mapper
{
    public class Mapping : Profile
    {
        public Mapping() {

            CreateMap<User, UserDTO>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<UserUpdateDTO, User>();
            CreateMap<Transaction, TransactionDTO>()
                .ForMember(dest => dest.User, opt => opt.MapFrom((src, dest, destMember, context) =>
                {
                    return
                    src.PayerId == (Guid)context.Items["id"] ?
                    src.Payee?.GetFullName() :
                    src.Payer?.GetFullName();
                }))
                .ForMember(dest => dest.Value, opt => opt.MapFrom((src, dest, destMember, context) =>
                      {
                          return
                              src.PayerId == (Guid)context.Items["id"] ?
                              src.Value * -1 :
                              src.Value;
             }));
        }
    }
}
