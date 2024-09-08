using DBRepository.Model;
using Shared;

namespace DBRepository
{
    public class DBRepository : IDBRepository
    {
        EliasdcDevContext _context;
        public DBRepository(EliasdcDevContext context) { 
            _context = context;
        }

        public async Task<List<CarDTO>> GetCarByName(string carName)
        {
            return [.. _context.Car.Where(r => r.Name.Contains(carName)).Select(r => new CarDTO { Id = r.Id, Name = r.Name })];
        }
    }
}
