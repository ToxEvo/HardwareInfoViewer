using HardwareInfoViewer.Services;

var cpuService = new CpuInfoService();
var cpu = cpuService.GetCpuInfo();

Console.WriteLine(new string('-', 40));
Console.WriteLine("CPU INFORMATION");
Console.WriteLine(new string('-', 40));

Console.WriteLine($"Name           : {cpu.Name}");
Console.WriteLine($"Manufacturer   : {cpu.Manufacturer}");
Console.WriteLine($"Architecture   : {cpu.Architecture}");
Console.WriteLine($"Cores          : {cpu.CoreCount}");
Console.WriteLine($"Threads        : {cpu.ThreadCount}");
Console.WriteLine($"Base Clock     : {cpu.BaseClockGHz:F2} GHz");
Console.WriteLine($"Current Clock  : {cpu.CurrentClockGHz:F2} GHz");
Console.WriteLine($"Max Clock      : {cpu.MaxClockGHz:F2} GHz");

Console.WriteLine(new string('-', 40));

