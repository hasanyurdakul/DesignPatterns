using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class CustomDatabaseOperations
    {
        IDatabaseFactory _dbFactory;
        Connection _connection;
        Command _command;

        public CustomDatabaseOperations(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _connection = _dbFactory.CreateConnection();
            _command = _dbFactory.CreateCommand();
        }

        public void RemoveByID(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand($"DELETE FROM Table WHERE ID = {id}");
            _connection.CloseConnection();
        }

        public void GetByID(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand($"SELECT * FROM Table WHERE ID = {id}");
            _connection.CloseConnection();
        }

        public void GetAll()
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("SELECT * FROM Table");
            _connection.CloseConnection();
        }
    }
}
