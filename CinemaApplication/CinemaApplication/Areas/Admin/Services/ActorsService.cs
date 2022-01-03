using CinemaApplication.Base;
using CinemaApplication.Data;
using CinemaApplication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Services

{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}
