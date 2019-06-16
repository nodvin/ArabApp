using ArabApp.Core.Model;
using ArabApp.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabApp.Core.Service
{
    public class HotdogDataService
    {
        private static HotdogRepository hotdogRepository = new HotdogRepository();

        public List<Hotdog> GetAllHotDogs()
        {
            return hotdogRepository.GetAllHotdogs();
        }

        public List<HotdogGroup> GetGroupedHotdogs()
        {
            return hotdogRepository.GetGroupedHotdogs();
        }

        public List<Hotdog> GetHotdogsForGroup(int hotdogGroupId)
        {
            return hotdogRepository.GetHotdogsForGroup(hotdogGroupId);
        }

        public Hotdog GetHotdogById(int hotdogId)
        {
            return hotdogRepository.GetHotdogById(hotdogId);
        }
    }
}
