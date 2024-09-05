using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer()
            {
                Id= 1,
                FirstName="Ahmet",
                LastName="Göz",
                Email = "agoz@gmail.com"
            };

            Order order = new Order()
            {
                Id = 1,
                ProductName ="Mobile Phone",
                Price = 24480,
                Quantity = 1,

            };
            Order order1 = new Order()
            {
                Id = 2,
                ProductName = "Laptop",
                Price = 35000,
                Quantity = 1,

            };
            List<Order> orders = new List<Order>();
            orders.Add(order);
            orders.Add(order1);

            var viewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = orders
                

            };


            return View(viewModel);
        }
    }
}
