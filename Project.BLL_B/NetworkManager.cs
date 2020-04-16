using AutoMapper;
using Project.BLL.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL
{
    public class NetworkManager 
    {
        private IMapper mapper;
        public NetworkManager()
        {
            mapper = AutoMapperInit.Init();
        }

        public List<BDO.NetworkInterface> GetNetworkInterface()
        {
            return mapper.Map<List<DAL.Model.NetworkInterface>, List<BDO.NetworkInterface>>(DAL.DatabaseOperations.GetNetworkInterface());
        }
    }
}
