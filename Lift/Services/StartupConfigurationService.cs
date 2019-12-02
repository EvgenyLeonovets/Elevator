using Lift.Models;
using Repository.Startup;
using System;

namespace Lift.Services
{
    public class StartupConfigurationService : IStartupConfigurationService
    {
        private readonly IStartupRepository _startupRepository;
        public StartupConfigurationService(IStartupRepository startupRepository)
        {
            _startupRepository = startupRepository;
        }
        public void AddAccelerationOfLifts()
        {
            throw new NotImplementedException();
        }

        public void AddFloors()
        {
            throw new NotImplementedException();
        }

        public void AddLifts()
        {
            _startupRepository.ChangeAmountOfLiftsUp(1);
        }

        public void AddPeopleInLifts()
        {
            throw new NotImplementedException();
        }

        public void AddSpeedOfLifts()
        {
            throw new NotImplementedException();
        }

        public StartupConfigurations GetStartupConfigurations()
        {
            return _startupRepository.GetStartupConfig();
        }

        public void RemoveAccelerationOfLifts()
        {
            throw new NotImplementedException();
        }

        public void RemoveFloors()
        {
            throw new NotImplementedException();
        }

        public void RemoveLifts()
        {
            _startupRepository.ChangeAmountOfLiftsDown(1);
        }

        public void RemovePeopleInLifts()
        {
            throw new NotImplementedException();
        }

        public void RemoveSpeedOfLifts()
        {
            throw new NotImplementedException();
        }

        public void SetModelWorkSystem(bool worked)
        {
            throw new NotImplementedException();
        }
    }
}
