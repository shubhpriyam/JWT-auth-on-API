using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.Models;

namespace JWTAuthentication.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        public Task<UserAuthModel> LoginValidate(string user);
        IEnumerable<Command> GetAllCommands();
        Command GetCommandByID(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
