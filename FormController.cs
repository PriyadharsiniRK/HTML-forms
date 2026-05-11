using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
        [HttpPost("submit")]
        public IActionResult Submit()
        {
            var form = Request.Form;

            string itemName = form["itemName"];
            string timeSlot = form["timeslot"];
            string receipt = form["receipt"];
            string quantity = form["quantity"];

            Console.WriteLine("---- FORM DATA RECEIVED ----");
            Console.WriteLine($"Item Name: {itemName}");
            Console.WriteLine($"Time Slot: {timeSlot}");
            Console.WriteLine($"Receipt: {receipt}");
            Console.WriteLine($"Quantity: {quantity}");

            return Ok("Form received successfully!");
        }
    }
}