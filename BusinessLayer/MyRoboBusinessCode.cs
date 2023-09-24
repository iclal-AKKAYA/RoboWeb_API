using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MyRoboBusinessCode
    {
        private readonly ApplicationContext _context;

        public MyRoboBusinessCode(ApplicationContext context)
        {
            _context = context;
        }

        public bool AddRobo(RoboWorld roboWorld)
        {
            _context.Worlds.Add(roboWorld);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteRobo(int roboId)
        {
            var robo = _context.Worlds.Find(roboId);

            if (robo != null)
            {
                _context.Worlds.Remove(robo);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateRobo(RoboWorld roboWorld, int roboId)
        {
            var robo = _context.Worlds.Find(roboId);

            if (robo != null)
            {
                robo.Name = roboWorld.Name;
                robo.SpecialPower = roboWorld.SpecialPower;
                robo.Charge = roboWorld.Charge;
                robo.Id = roboId;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public RoboWorld GetRobo(int roboId)
        {
            return _context.Worlds.Find(roboId);
        }
    }
}
