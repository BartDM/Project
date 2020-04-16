using Project.BLL.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Project.BLL
{
    public class LocationManager
    {
        private IMapper mapper; 
        public LocationManager()
        { 
            mapper = AutoMapperInit.Init();
        }

        public List<BDO.Location> GetLocations()
        {
            List<BDO.Location> bdoLocations = new List<BDO.Location>();
            var dalLocations = DAL.DatabaseOperations.GetLocations();
            foreach (var item in dalLocations)
            {
                var bdoLocation = new BDO.Location();
                bdoLocation.Description = item.Description;
                bdoLocation.LocationId = item.LocId;
                bdoLocation.Name = item.Name;
                bdoLocations.Add(bdoLocation);
            }
            return bdoLocations;

            //return mapper.Map<List<DAL.Model.Location>, List<BDO.Location>> (DAL.DatabaseOperations.GetLocations());
        }

        public bool AddLocation()
        {
            //return mapper.Map<List<DAL.Model.Location>, List<BDO.Location>> (DAL.DatabaseOperations.GetLocations());
            
            return true;
        }
    }
}
