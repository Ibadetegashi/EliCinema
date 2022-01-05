using CinemaApplication.Base;
using CinemaApplication.Data;
using CinemaApplication.Models;
using CinemaApplication.Areas.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context)
        {
        }
    }
}