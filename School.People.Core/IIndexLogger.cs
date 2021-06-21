using System;

namespace School.People.Core
{
    public interface IIndexLogger : IDisposable
    {
        int GetLog(string key);
        void Log(string key, int index);
        void RegisterKey(string key);
        void SaveLogs();
    }
}