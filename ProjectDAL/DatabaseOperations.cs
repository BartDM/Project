using Project.DAL.Model;
using ProjectDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Project.DAL
{
    public static class DatabaseOperations
    {
        public static List<Location> GetLocations()
        {
            using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
            {  
                return projectDBEntity
                    .Locations
                    .ToList();
            }
        }

        public static List<Location> GetLocationsWithComputers()
        {
            using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
            {  
                return projectDBEntity
                    .Locations
                    .Include(i=>i.Computers)
                    .ToList();
            }
        }
        public static int AddLocation(Location location)
        {
            try
            {
                using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
                {

                    projectDBEntity.Locations.Add(location);
                    return projectDBEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //FileOperations.FoutLoggen(ex);
                return 0;
            }
        }
        public static int ModifyLocation(Location location)
        {
            try
            {
                using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
                {

                    projectDBEntity.Entry(location).State = EntityState.Modified;
                    return projectDBEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //FileOperations.FoutLoggen(ex);
                return 0;
            }
        }
        public static int DeleteLocation(Location location)
        {
            try
            {
                using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
                {

                    projectDBEntity.Entry(location).State = EntityState.Deleted;
                    return projectDBEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //FileOperations.FoutLoggen(ex);
                return 0;
            }
        }

        public static List<NetworkInterface> GetNetworkInterface()
        {
            using (ProjectDBContextCF projectDBEntity = new ProjectDBContextCF())
            {
                return projectDBEntity.NetworkInterfaces.ToList();
            }
        }
    }
}
