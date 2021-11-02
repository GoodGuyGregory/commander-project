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
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            // creates another entry for a new DTO to map 
            CreateMap<CommandCreateDto, Command>();
        }

    }
}