using System.Management;
using HardwareInfoViewer.Models;

namespace HardwareInfoViewer.Services;

public class CpuInfoService
{
    public CpuInfo GetCpuInfo()
    {
        CpuInfo cpuInfo = new CpuInfo();

        using (var searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
        {
            foreach (var obj in searcher.Get())
            {
                cpuInfo.Name = obj["Name"]?.ToString()?.Trim();
                cpuInfo.CoreCount = Convert.ToInt32(obj["NumberOfCores"]);
                cpuInfo.ThreadCount = Convert.ToInt32(obj["NumberOfLogicalProcessors"]);
                cpuInfo.BaseClockGHz = Convert.ToDouble(obj["CurrentClockSpeed"]) / 1000.0;
                cpuInfo.CurrentClockGHz = Convert.ToDouble(obj["CurrentClockSpeed"]) / 1000.0;
                cpuInfo.MaxClockGHz = Convert.ToDouble(obj["MaxClockSpeed"]) / 1000.0;
                cpuInfo.Manufacturer = obj["Manufacturer"]?.ToString();
                cpuInfo.Architecture = MapArchitecture(Convert.ToUInt16(obj["Architecture"]));

                break; // Only handle the first processor found
            }
        }

        return cpuInfo;
    }

    private string MapArchitecture(ushort architectureCode)
    {
        return architectureCode switch
        {
            0 => "x86",
            1 => "MIPS",
            2 => "Alpha",
            3 => "PowerPC",
            5 => "ARM",
            6 => "Itanium",
            9 => "x64",
            _ => "Unknown"
        };
    }
}
