using Lift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lift.Services
{
    public interface IStartupConfigurationService
    {
        public StartupConfigurations GetStartupConfigurations();
        public void SetModelWorkSystem(bool worked);

        public void AddFloors();

        public void RemoveFloors();

        public void AddLifts();

        public void RemoveLifts();

        public void AddPeopleInLifts();

        public void RemovePeopleInLifts();
        public void AddSpeedOfLifts();

        public void RemoveSpeedOfLifts();
        public void AddAccelerationOfLifts();

        public void RemoveAccelerationOfLifts();

    }
}
