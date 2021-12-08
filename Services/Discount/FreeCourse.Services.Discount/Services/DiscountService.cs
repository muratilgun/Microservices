using FreeCourse.Shared.Dtos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private IDbConnection _dbConnection;


        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnection = new Npgsql.NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }

   
    }
}
