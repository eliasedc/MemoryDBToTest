using DBRepository;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Domain : IDomain
    {
        IDBRepository _repository;

        public Domain(IDBRepository repository) { 
            _repository = repository;
        }

        public async Task<List<CarDTO>> GetCarByName(string name)
        {
            return await _repository.GetCarByName(name);
        }
    }
}
