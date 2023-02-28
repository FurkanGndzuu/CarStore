﻿using RentACarAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Application.Repositories.CarRepositories
{
    public interface ICarReadRepository : IReadRepository<Car>
    {
    }
}
