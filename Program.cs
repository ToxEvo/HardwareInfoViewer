using HardwareInfoViewer.Services;

var cpuService = new CpuInfoService();
var cpu = cpuService.GetCpuInfo();

Console.WriteLine("CPU Information:");
Console.WriteLine($"Name: {cpu.Name}");
Console.WriteLine($"Cores: {cpu.CoreCount}");
Console.WriteLine($"Threads: {cpu.ThreadCount}");
Console.WriteLine($"Base Clock: {cpu.BaseClockGHz} GHz");
Console.WriteLine($"Current Clock: {cpu.CurrentClockGHz} GHz");
Console.WriteLine($"Max Clock: {cpu.MaxClockGHz} GHz");
Console.WriteLine($"Manufacturer: {cpu.Manufacturer}");
Console.WriteLine($"Architecture: {cpu.Architecture}");
