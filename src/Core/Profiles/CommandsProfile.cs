using AutoMapper;
using Core.DTOs;
using Core.Model;

namespace Core.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //? Source -> Target
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
            CreateMap<CommandUpdateDTO, Command>();
            CreateMap<Command, CommandUpdateDTO>();
        }
    }
}