using Microsoft.AspNetCore.Mvc;
using scopewebsite.Models;
using Microsoft.Data.SqlClient;

namespace scopewebsite.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult page6(Class6 reg)
        {
            SqlConnection newconobj = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            newconobj.Open();
            return View();
        }
    }
}
