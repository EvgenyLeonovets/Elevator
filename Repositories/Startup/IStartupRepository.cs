using Lift.Models;

namespace Repository.Startup
{
    public interface IStartupRepository
    {
        StartupConfigurations GetStartupConfig();
        void SetModelWorkSystem();

        void ChangeAmountOfLiftsUp(int amount);

        void ChangeAmountOfLiftsDown(int amount);

        void ChangeAmountOfFloors(int amount);

        void ChangeAmountOfPeopleInLifts(int amount);

        void ChangeAmountOfSpeedOfLifts(int amount);

        void ChangeAmountOfAccelerationOfLifts(int amount);
    }
}
