using System.Collections.Generic;
using Commander.Models;


namespace Commander.Data
{
    // this is the implementation of the ICommanderRepo class.
    public class MockCommanderRepo : ICommanderRepo
    {
       
       public IEnumerable<Command> GetAllCommands()
       {
           var commands = new List<Command>
           {
             new Command{Id=0, HowTo="boil an egg", Line="Boil water", Platform="Kettle & Pan"},
             new Command{Id=1, HowTo="cut bread", Line="Get a knife", Platform="Knife and Chopping board"},
             new Command{Id=2, HowTo="make tea", Line="Boil water add tea", Platform="Kettle & Pan"}
           };

           return commands;
          
       }

       public Command GetCommandById(int id) 
       {
           return new Command{Id=0, HowTo="boil an egg", Line="Boil water", Platform="Kettle & Pan"};
       }
    }
}