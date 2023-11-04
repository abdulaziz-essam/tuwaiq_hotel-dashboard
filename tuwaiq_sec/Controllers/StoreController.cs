using Microsoft.AspNetCore.Mvc;

namespace tuwaiq_sec.Controllers
{
    public class StoreController : Controller
    {
        public String Index()
        {
            return "hi from Store";
        }
        public String details(int id)
        {
            String message = "id number " + id;
            return message;
        } 
    }
}
