using CinemaApplication.Base;
using CinemaApplication.Data;
using CinemaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(ApplicationDbContext context) : base(context) { }
    }
}
