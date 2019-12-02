using System;
using Models.Models;
using Repository.Startup;

namespace Lift.Services
{
    public class StartupConfigurationService : IStartupConfigurationService
    {
        private readonly IStartupRepository _startupRepository;

        public StartupConfigurationService(IStartupRepository startupRepository)
        {
            _startupRepository = startupRepository;
        }

        public StartupConfigurations GetStartupConfigurations()
        {
            return _startupRepository.GetStartupConfig();
        }

        public void SetModelWorkSystemFirst()
        {
            _startupRepository.SetModelWorkSystemFirst(true);
        }

        public void SetModelWorkSystemSecond()
        {
            _startupRepository.SetModelWorkSystemFirst(false);
        }

        public void AddAccelerationOfLifts()
        {
            _startupRepository.ChangeAmountOfAccelerationOfLiftsUp(1);
        }

        public void AddFloors()
        {
           _startupRepository.ChangeAmountOfFloorsUp(1);
        }

        public void AddLifts()
        {
            _startupRepository.ChangeAmountOfLiftsUp(1);
        }

        public void AddPeopleInLifts()
        {
            _startupRepository.ChangeAmountOfPeopleInLiftsUp(1);
        }

        public void AddSpeedOfLifts()
        {
            _startupRepository.ChangeAmountOfSpeedOfLiftsUp(1);
        }

        public void RemoveAccelerationOfLifts()
        {
            _startupRepository.ChangeAmountOfAccelerationOfLiftsDown(1);
        }

        public void RemoveFloors()
        {
           _startupRepository.ChangeAmountOfFloorsDowm(1);
        }

        public void RemoveLifts()
        {
            _startupRepository.ChangeAmountOfLiftsDown(1);
        }

        public void RemovePeopleInLifts()
        {
            _startupRepository.ChangeAmountOfPeopleInLiftsDown(1);
        }

        public void RemoveSpeedOfLifts()
        {
            _startupRepository.ChangeAmountOfSpeedOfLiftsDown(1);
        }

    }
}
