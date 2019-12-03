namespace Models.Models
{
    public class StartupConfigurations
    {
        public bool ModelWorkSystem { get; set; } = false;
        public int Floors { get; set; } = 12;
        public int Lifts { get; set; } = 3;
        public int PeopleInLifts { get; set; } = 4;
        public int SpeedOfLifts { get; set; } = 2;
        public int AccelerationOfLifts { get; set; } = 1;
    }
}