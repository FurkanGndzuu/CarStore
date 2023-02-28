using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Application.ViewModels
{
    public class CreateCarViewModel 
    {
        public string Name { get; set; }
        public float price  { get; set; }
       
    }
}
