
using Models.Models;

namespace Repository.Startup
{
    public interface IStartupRepository
    {
        StartupConfigurations GetStartupConfig();

        void SetModelWorkSystemFirst(bool flag);

        void SetModelWorkSystemSecond(bool flag);

        void ChangeAmountOfLiftsUp(int amount);

        void ChangeAmountOfLiftsDown(int amount);

        void ChangeAmountOfFloorsUp(int amount);

        void ChangeAmountOfFloorsDowm(int amount);

        void ChangeAmountOfPeopleInLiftsUp(int amount);

        void ChangeAmountOfPeopleInLiftsDown(int amount);

        void ChangeAmountOfSpeedOfLiftsUp(int amount);

        void ChangeAmountOfSpeedOfLiftsDown(int amount);

        void ChangeAmountOfAccelerationOfLiftsUp(int amount);

        void ChangeAmountOfAccelerationOfLiftsDown(int amount);

        void DownloadConfig(int amount);
    }
}
