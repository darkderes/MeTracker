using System;
using System.Collections.Generic;
using System.Text;
using MeTracker.Models;

using System.Threading.Tasks;

namespace MeTracker.Repositories
{
    public interface ILocationRepository
    {
        Task Save(Location location);
    }
}
