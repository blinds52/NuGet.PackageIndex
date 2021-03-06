﻿namespace Nuget.PackageIndex.Logging
{
    public interface ILog
    {
        LogLevel Level { get; set; }
        void WriteVerbose(string format, params object[] args);
        void WriteInformation(string format, params object[] args);
        void WriteError(string format, params object[] args);
    }
}
