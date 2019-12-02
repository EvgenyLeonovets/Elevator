using Models.Models;
using Repository.Startup;
using System;

namespace Repository
{
    public class StartupRepository : IStartupRepository
    {
        private static StartupConfigurations startupConfigurations = new StartupConfigurations();

        public StartupConfigurations GetStartupConfig()
        {
            return startupConfigurations;
        }

        public void SetModelWorkSystemFirst(bool flag)
        {
            if (startupConfigurations.ModelWorkSystem != flag)
            {
                startupConfigurations.ModelWorkSystem = flag;
            }
        }

        public void SetModelWorkSystemSecond(bool flag)
        {
            if (startupConfigurations.ModelWorkSystem != flag)
            {
                startupConfigurations.ModelWorkSystem = flag;
            }
        }

        public void ChangeAmountOfAccelerationOfLiftsUp(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfAccelerationOfLiftsDown(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfFloorsUp(int amount)
        {
            throw new NotImplementedException();
        }

        public void ChangeAmountOfFloorsDowm(int amount)
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

        public void ChangeAmountOfPeopleInLiftsUp(int amount)
        {
            if (startupConfigurations.PeopleInLifts + amount <= 5)
            {
                startupConfigurations.PeopleInLifts += amount;
            }
        }

        public void ChangeAmountOfPeopleInLiftsDown(int amount)
        {
            if (startupConfigurations.PeopleInLifts - amount >= 3)
            {
                startupConfigurations.PeopleInLifts -= amount;
            }
        }

        public void ChangeAmountOfSpeedOfLiftsUp(int amount)
        {
            if (startupConfigurations.SpeedOfLifts + amount <= 3)
            {
                startupConfigurations.SpeedOfLifts += amount;
            }
        }

        public void ChangeAmountOfSpeedOfLiftsDown(int amount)
        {
            if (startupConfigurations.SpeedOfLifts - amount >= 1)
            {
                startupConfigurations.SpeedOfLifts -= amount;
            }
        }

       
    }
}
