using Microsoft.AspNetCore.Mvc;

namespace P05Zawodnicy.API.Controllers
{

    public class Zawodnik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class ZawodnicyController : Controller
    {
        [HttpGet]
        public List<Zawodnik> PodajZawodnikow()
        {
            return
                new List<Zawodnik>() 
                {
                    new Zawodnik(){ Imie="jan",Nazwisko="kowalski"},
                    new Zawodnik(){ Imie="adam",Nazwisko="nowak"}
                };

        }
    }
}
