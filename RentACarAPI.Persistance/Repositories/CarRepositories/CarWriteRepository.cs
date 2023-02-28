using RentACarAPI.Application.Repositories.CarRepositories;
using RentACarAPI.Domain.Entities;
using RentACarAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance.Repositories.CarRepositories
{
    public class CarWriteRepository : WriteRepository<Car>, ICarWriteRepository
    {
        public CarWriteRepository(RenACarDbContext _context) : base(_context)
        {
        }
    }
}
