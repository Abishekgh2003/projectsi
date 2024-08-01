using form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace form.Controllers
{
    public class RegisterController : Controller
    {
        [BindProperty]
        public List<string> Hobbies { get; set; }
        string hobbies;
        public IActionResult page6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult page6(Class6 fm)
        {
            if (Hobbies != null && Hobbies.Count > 0)
            {
                foreach (var item in Hobbies)
                {
                    hobbies += item + ";";
                }
            }

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Arun;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Table2(Name,Age,Country,State,City,PhoneNumber,Email,Gender,Hobbies) values(@name,@age,@country,@state,@city,@phonenumber,@email,@gender,@hobbies)", con);
            cmd.Parameters.AddWithValue("@name", fm.Name);
            cmd.Parameters.AddWithValue("@age", fm.Age);
            cmd.Parameters.AddWithValue("@country", fm.Country);
            cmd.Parameters.AddWithValue("@state", fm.State);
            cmd.Parameters.AddWithValue("@city", fm.City);
            cmd.Parameters.AddWithValue("@phonenumber", fm.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", fm.Email);
            cmd.Parameters.AddWithValue("@gender", fm.Gender);
            cmd.Parameters.AddWithValue("@hobbies", hobbies);
            cmd.ExecuteNonQuery();
            con.Close();

            return View("regsus");
        }
        public IActionResult regsus()
        {
            return View();
        }
    }
}