﻿using RentACarAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Application.Repositories.OrderRepositories
{
    public interface IOrderWriteRepository : IWriteRepository<Order>
    {
    }
}