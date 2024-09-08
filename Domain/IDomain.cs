using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomain
    {
        Task<List<CarDTO>> GetCarByName(string name);
    }
}
