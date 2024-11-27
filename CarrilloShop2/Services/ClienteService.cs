using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrilloShop2.Services
{
    public class ClienteService
    {
        private AppDBcontext _context;

        public ClienteService(AppDBcontext context)
        {
            _context = context;
        }


    }
}
