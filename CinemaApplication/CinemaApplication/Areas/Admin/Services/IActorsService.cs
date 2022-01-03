using CinemaApplication.Base;
using CinemaApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Services
{

    public interface IActorsService : IEntityBaseRepository<Actor>
    {
    }
}
