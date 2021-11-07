using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using Commander.Dtos;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace Commander.Controllers
{
    // api commands:
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        //GET: api/commands/{id}
        [HttpGet("{id}", Name="GetCommandById")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            //  check to determine if it exisits
            if (commandItem != null)
            {
                // this will reroute the implementation to a DTO from the incoming commandItem
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        // POST: api/commands/
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto cmdCreate)
        {
            //in a real project type model parsing would be needed....
            var commandModel = _mapper.Map<Command>(cmdCreate);
            // pass the model in as an argument
            _repository.CreateCommand(commandModel);
            // save the changes which adds the record into the db
            _repository.SaveChanges();

            // return a commandDTO to abstract away the platform
            var commandDTO = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new { Id = commandDTO.Id }, commandDTO );
           // return Ok(commandDTO);
        }


    }
}