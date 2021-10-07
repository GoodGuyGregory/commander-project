using System.Collections.Generic;
using Commander.Models;


namespace Commander.Data
{
    // this is the implementation of the ICommanderRepo class.
    public class MockCommanderRepo : ICommanderRepo
    {
       
       public IEnumerable<Command> GetAppCommands()
       {
           throw new System.NotImplementedExeception();
       }

       public Command GetCommandById() 
       {
           throw new System.NotImplementedExeception();
       }
    }
}