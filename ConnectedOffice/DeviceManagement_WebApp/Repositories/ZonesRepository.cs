using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZonesRepository : GenericRepository<Zone>, IZonesRepository
    {
        public ZonesRepository(ConnectedOfficeContext context) : base(context)
        {
        }


    }

}