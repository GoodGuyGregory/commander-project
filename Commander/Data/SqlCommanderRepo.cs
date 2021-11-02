using System;
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

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));

            }

            // calls the add method to include the new cmd coming in.
            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // uses Linq in order to return all the lists
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            // uses Linq to aquire the member with that
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            // saves the changes of the DB to ensure that the elements added or removed are saved
            //  if this isn't called there will be errors
            //  bool return type....
            return (_context.SaveChanges() >= 0);
        }
    }
}