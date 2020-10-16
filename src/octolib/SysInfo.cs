using System;

namespace octolib
{
    public static class SysInfo
    {
        public static string GetMachineInfoString()
        {
            return $"{Environment.MachineName} is running {Environment.OSVersion}";
        }
    }
}
