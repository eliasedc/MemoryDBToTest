using DBRepository.Model;
using Microsoft.EntityFrameworkCore;
using Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Cars.Test
{
    public class UnitTest_IDisposable : IDisposable
    {
        private readonly DatabaseFixture _fixtureDB;

        private Domain.Domain _domain;

        public UnitTest_IDisposable()
        {
            _fixtureDB = new DatabaseFixture();
            _domain = new Domain.Domain(new DBRepository.DBRepository(_fixtureDB.Context));
        }

        [Theory]
        [InlineData("Accord", 1)]
        [InlineData("n", 2)]
        public async Task ToMustRetornCarByName(string name, int count)
        {
            // Arrange
            List<Car> cars = new List<Car>
            {
                new Car { Name = "Honda Accord", CreatedDate = DateTime.Now },
                new Car { Name = "Subaru Outback", CreatedDate = DateTime.Now.AddDays(-1) },
                new Car { Name = "Ford Mustang", CreatedDate = DateTime.Now.AddDays(-2) }
            };

            _fixtureDB.Context.Car.AddRange(cars);
            await _fixtureDB.Context.SaveChangesAsync();

            // Act
            List<CarDTO> result = await _domain.GetCarByName(name);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(count, result.Count);
        }

        public void Dispose()
        {
            _fixtureDB.Dispose();
        }
    }
}
