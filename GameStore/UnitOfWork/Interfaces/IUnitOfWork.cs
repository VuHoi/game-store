using GameStore.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> CompleteAsync();
    }
}
