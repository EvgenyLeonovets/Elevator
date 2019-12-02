using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lift.Models
{
    public class StartupConfigurations
    {
        public bool ModelWorkSystem { get; set; } = false;
        public int Floors { get; set; } = 12;
        public int Lifts { get; set; } = 3;
        public int PeopleInLifts { get; set; } = 5;
        public double SpeedOfLifts { get; set; } = 2;
        public double AccelerationOfLifts { get; set; } = 1;
    }
}