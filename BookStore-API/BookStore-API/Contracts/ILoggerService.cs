using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Contracts
{
    public interface ILoggerService
    {
        void LogInfo(string message);

        void LogWarning(string message);

        void LogError(string message);

        void LogDebug(string message);
    }
}
