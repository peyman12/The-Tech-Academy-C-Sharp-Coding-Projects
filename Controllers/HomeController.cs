using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPracticalExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth,
            string CarYear, string CarMake, string CarModel, string DUI, int Tickets, string Coverage )
        {

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress) || string.IsNullOrEmpty(Convert.ToString(DateOfBirth)) || string.IsNullOrEmpty(CarYear) || string.IsNullOrEmpty(CarMake) ||
      string.IsNullOrEmpty(CarModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                double Quote = 50;
                int Age = DateTime.Now.Year - DateOfBirth.Year;

                if ( Age < 25)
                {
                    Quote += 10;
                }

                if (Age < 18)
                {
                    Quote += 100;
                }

                if (Age > 100)
                {
                    Quote += 25;
                }

                if (Convert.ToInt32(CarYear) < 2000)
                {
                    Quote += 20;
                }

                if (Convert.ToInt32(CarYear) > 2015)
                {
                    Quote += 25;
                }

                if (CarMake == "Porsche")
                {
                    Quote += 25;
                }


                if (CarModel == "911 Carrera")
                {
                    Quote += 25;
                }

                if (Tickets > 0)
                {
                    Quote += (Tickets * 10);
                }

                if (DUI == "Yes")
                {
                    Quote *= 1.25;
                }

                if (Coverage == "Full")
                {
                    Quote *= 1.5;
                }
                string connectionString = @"Data Source = .; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True;                      ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                string queryString = @"INSERT INTO CarInsurance (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, Tickets) VALUES
                                               (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @Tickets, @Quote)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@Quote", SqlDbType.Money);


                    command.Parameters["@FirstName"].Value = FirstName;
                    command.Parameters["@LastName"].Value = LastName;
                    command.Parameters["@EmailAdress"].Value = EmailAddress;
                    command.Parameters["@DateOfBirth"].Value = DateOfBirth;
                    command.Parameters["@CarYear"].Value = CarYear;
                    command.Parameters["@CarMake"].Value = CarMake;
                    command.Parameters["@CarModel"].Value = CarModel;
                    command.Parameters["@DUI"].Value = DUI;
                    command.Parameters["@Tickets"].Value = Tickets;
                    command.Parameters["@Quote"].Value = Quote;


                    connection.Open();
                    command.ExecuteNonQuery();
                    //CarInsurance.SaveChanges();
                    connection.Close();

                }
                return View("Success");
            }
        }
        
    }
}