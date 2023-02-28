using Microsoft.AspNetCore.Mvc;
using RentACarAPI.Application.Paginations;
using RentACarAPI.Application.Repositories.CarRepositories;
using RentACarAPI.Application.ViewModels;

namespace RentACarAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Car : Controller
    {
        readonly ICarReadRepository _carReadRepository;
        readonly ICarWriteRepository _carWriteRepository;
        public Car(ICarWriteRepository carWriteRepository , ICarReadRepository carReadRepository)
        {
            _carWriteRepository = carWriteRepository;
            _carReadRepository = carReadRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Pagination pagination)
        {
            int total = _carReadRepository.GetAll().Count();
            var cars = _carReadRepository.GetAll().Skip(pagination.Page * pagination.Size)
                .Take(pagination.Size).Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Price,
                    x.CreatedDate,
                    x.UpdatedDate
                }).ToList();

            return Ok(new
            {
                total,
                cars
            });
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCarViewModel car)
        {
            if (ModelState.IsValid)
            {

            }
            await _carWriteRepository.AddAsync(new Domain.Entities.Car()
            {
                Name = car.Name,
                Price =(long) car.price,
                
            });

            await _carWriteRepository.SaveAsync();

            return Ok();

        }

        [HttpPut("{Id}")]

        public async Task<IActionResult> Put(UpdateCarViewModel car)
        {
            var UpdattingCar = await _carReadRepository.GetByIdAsync(car.Id);

            UpdattingCar.Name = car.Name;
            UpdattingCar.Price =(long) car.price;
           

            await _carWriteRepository.SaveAsync();

            return Ok();


        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> Delete(string Id)
        {
            var car =await _carReadRepository.GetByIdAsync(Id);

            _carWriteRepository.Remove(car);

           await _carWriteRepository.SaveAsync();

            return Ok();
        }
    }
}
