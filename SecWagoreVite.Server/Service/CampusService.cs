using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SecWagoreVite.Server.Controllers.Service;
using SecWagoreVite.Server.Models;
using SecWagoreVite.Server.Service;

public class CampusService : BaseService<Campus>
{
    private readonly IConfiguration _configuration;

    /// <param name="dbModel"></param>
    /// <param name="configuration"></param>
    public CampusService(SecDbContext dbModel,
        IConfiguration configuration
        ) : base(dbModel)
    {
        _configuration = configuration;
    }

}
