using System.Collections.Generic;
using Commander.Models;


namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // This interface defines the contract for objects of this type.
        // the objects that USE this type will have to define and implement the methods of this interface
        // this interface will define all of the methods of our rest API
        

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        

    }
}