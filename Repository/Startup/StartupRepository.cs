using Lift.Models;
using Repository.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StartupRepository : IStartupRepository
    {
        private static StartupConfigurations startupConfigurations = new StartupConfigurations();

        public void ChangeAmountOfAccelerationOfLifts(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfFloors(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfLifts(int amount)
        {
            if (startupConfigurations.Lifts + amount >= 0)
            {
                startupConfigurations.Lifts += amount;
            }
        }

        public void ChangeAmountOfPeopleInLifts(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfSpeedOfLifts(int amount)
        {
            throw new NotImplementedException();
        }

        public void SetModelWorkSystem()
        {
            throw new NotImplementedException();
        }
    }
}
