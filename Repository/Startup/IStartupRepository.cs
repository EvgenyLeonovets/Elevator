using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Startup
{
    public interface IStartupRepository
    {
        void SetModelWorkSystem();

        void ChangeAmountOfLifts(int amount);

        void ChangeAmountOfFloors(int amount);

        void ChangeAmountOfPeopleInLifts(int amount);

        void ChangeAmountOfSpeedOfLifts(int amount);

        void ChangeAmountOfAccelerationOfLifts(int amount);
    }
}
