using Models.Models;
using Repository.Startup;
using System.IO;

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
            if (startupConfigurations.AccelerationOfLifts + amount <= 2)
            {
                startupConfigurations.AccelerationOfLifts += amount;
            }
        }

        public void ChangeAmountOfAccelerationOfLiftsDown(int amount)
        {
            if (startupConfigurations.AccelerationOfLifts - amount >= 1)
            {
                startupConfigurations.AccelerationOfLifts -= amount;
            }
        }

        public void ChangeAmountOfFloorsUp(int amount)
        {
            if (startupConfigurations.Floors + amount <= 20)
            {
                startupConfigurations.Floors += amount;
            }
        }

        public void ChangeAmountOfFloorsDowm(int amount)
        {
            if (startupConfigurations.Floors - amount >= 9)
            {
                startupConfigurations.Floors -= amount;
            }
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

        public void DownloadConfig(int amount)
        {
            StreamWriter f = new StreamWriter("test.txt", false);
            f.WriteLine("Mode of work: " + startupConfigurations.ModelWorkSystem);
            f.WriteLine("Number of lifts: " + startupConfigurations.Lifts);
            f.WriteLine("Number of floors: " + startupConfigurations.Floors);
            f.WriteLine("Number of people in lifts: " + startupConfigurations.PeopleInLifts);
            f.WriteLine("Value of speed of lifts: " + startupConfigurations.SpeedOfLifts);
            f.WriteLine("Value of acceleration of lifts: " + startupConfigurations.AccelerationOfLifts);
            f.Close();
        }
    }
}
