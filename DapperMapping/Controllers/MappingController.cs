using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data.SqlClient;

namespace DapperMapping.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MappingController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> TestMapping()
        {
            using var connection = new SqlConnection("Data Source=DESKTOP-DIFT32I\\SQLEXPRESS;Initial Catalog=DapperMapping;Integrated Security=True; TrustServerCertificate=True");

            string query = "SELECT * From Product";

            var products = connection.Query<Product>(query);

            return Ok(products);
        }
    }
}
