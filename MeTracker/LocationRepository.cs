using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MeTracker.Models;
using MeTracker.Repositories;
using SQLite;

namespace MeTracker
{
    public class LocationRepository : ILocationRepository
    {
        private SQLiteAsyncConnection connection;

        private async Task CreateConnection() {

            if (connection != null) {
                return;
            }

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Location.db");
            await connection.CreateTableAsync<Location>(); 
        
        }
        public async Task Save(Location location)
        {
            await CreateConnection();
            await connection.InsertAsync(location);
        }
    }
}
