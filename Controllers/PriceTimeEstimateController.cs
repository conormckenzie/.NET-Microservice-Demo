using Microsoft.AspNetCore.Mvc;

namespace MyMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class PriceTimeEstimateController : ControllerBase
{
    public PriceTimeEstimateController()
    {
        
    }

    [HttpGet(Name = "GetPriceTimeEstimate")]
    public PriceTimeEstimate Get()
    {
        double default_price = 5000;
        int default_time = 7;
        return new PriceTimeEstimate
        {
            price = default_price,
            time = default_time
        };
    }
}
