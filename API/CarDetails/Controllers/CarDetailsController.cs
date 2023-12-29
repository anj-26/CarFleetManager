using Microsoft.AspNetCore.Mvc;
using CarDetails.Data;
using CarDetails.DTOs;
using Microsoft.EntityFrameworkCore;
using CarDetails.Models;
//using System.Net;

namespace CarDetails.Controllers;

[ApiController]
[Route("[controller]")]
public class CarDetailsController : ControllerBase
{
    private readonly DataContext _context;
    
    public CarDetailsController(DataContext context)
    {
            _context = context;
        
    }

  [HttpGet("{registrationNum}")]
    public async Task<ActionResult<CarDTO>> GetCarDetails(int registrationNum)
    {
       var car = await _context.Cars.FindAsync(registrationNum);

        return new CarDTO
        {
            RegistrationId=car.RegistrationId,
           Brand=car.Brand,
          FirstInspection=car.FirstInspection,
          IsInspectionExpired=car.IsInspectionExpired,
          IsRoadWorthy=car.IsRoadWorthy,
          LastInspection=car.LastInspection,
          NextInspection= car.NextInspection,
       };
    }

    [HttpPost("update")]
    public async Task<ActionResult> Register([FromBody]CarDTO carDTO)
    {
        var carId = carDTO.RegistrationId;
        
        if(!await CarExists(carDTO.RegistrationId)) return BadRequest("Registration No. does not exist");
       
        var UpdatedCar = await _context.Cars.FindAsync(carId);
        
        UpdatedCar.RegistrationId=carDTO.RegistrationId;
        UpdatedCar.Brand=carDTO.Brand;
        UpdatedCar.FirstInspection=carDTO.FirstInspection;
        UpdatedCar.IsInspectionExpired=carDTO.IsInspectionExpired;
        UpdatedCar.IsRoadWorthy=carDTO.IsRoadWorthy;
        UpdatedCar.LastInspection=carDTO.LastInspection;
        UpdatedCar.NextInspection= carDTO.NextInspection;
        
        try
        {
            _context.Cars.Update(UpdatedCar);
            await _context.SaveChangesAsync(); 
        }
        catch
        {
            StatusCode(304);
        }
        
        return Ok("Record updated successfully") ;
  }
    public async Task<bool> CarExists(int RegistrationId)
    {
        return await _context.Cars.AnyAsync(x => x.RegistrationId == RegistrationId);
    }
    
    
}
