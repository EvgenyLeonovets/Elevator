using Lift.Models;
using Repository.Startup;
using System;

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

        public void ChangeAmountOfLiftsUp(int amount)
        {
            if (startupConfigurations.Lifts + amount <= 5)
            {
                startupConfigurations.Lifts += amount;
            }
        }

        public void ChangeAmountOfLiftsDown(int amount)
        {
            if (startupConfigurations.Lifts - amount >= 1)
            {
                startupConfigurations.Lifts -= amount;
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

        public StartupConfigurations GetStartupConfig()
        {
            return startupConfigurations;
        }

        public void SetModelWorkSystem()
        {
            throw new NotImplementedException();
        }
    }
}
