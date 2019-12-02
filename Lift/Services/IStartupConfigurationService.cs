using Models.Models;

namespace Lift.Services
{
    public interface IStartupConfigurationService
    {
        StartupConfigurations GetStartupConfigurations();

        void SetModelWorkSystem(bool worked);

        void AddFloors();

        void RemoveFloors();

        void AddLifts();

        void RemoveLifts();

        void AddPeopleInLifts();

        void RemovePeopleInLifts();
        
        void AddSpeedOfLifts();

        void RemoveSpeedOfLifts();

        void AddAccelerationOfLifts();

        void RemoveAccelerationOfLifts();

    }
}
