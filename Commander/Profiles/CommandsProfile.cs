using AutoMapper;
using Commander.Dtos;
using Commander.Models;



namespace Commander.Profiles
{
    // profilec omes from automapper
    public class CommandsProfile : Profile
    {

        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }

    }
}