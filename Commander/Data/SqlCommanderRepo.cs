using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{

    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            // uses Linq in order to return all the lists
            return _context.Commands.ToList();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            // uses Linq to aquire the memeber with that
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}