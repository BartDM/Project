using System.Collections.Generic;
using System.Linq;
using Project.DAL.Model;

namespace Project.DAL.Repositories
{
    public interface ILocationRepository: IRepository
    {
        List<Location> Get();
    }

    public class LocationRepository : ILocationRepository
    {

        private ProjectContextCF contextCF;

        public LocationRepository()
        {
            contextCF = new ProjectContextCF();
        }

        public List<Location> Get()
        {
            return contextCF.Locations.ToList();
        }
    }
}
