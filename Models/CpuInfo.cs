namespace HardwareInfoViewer.Models
{
    public class CpuInfo
    {
        public string Name { get; set; }
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        public double BaseClockGHz { get; set; }
        public double CurrentClockGHz { get; set; }
        public double MaxClockGHz { get; set; }
        public string Architecture { get; set; }
        public string Manufacturer { get; set; }

    }
}