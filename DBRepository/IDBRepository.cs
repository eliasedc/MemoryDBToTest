using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public interface IDBRepository
    {
        Task<List<CarDTO>> GetCarByName(string carName);
    }
}
