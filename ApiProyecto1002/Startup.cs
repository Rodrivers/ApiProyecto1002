﻿using ApiProyecto1002.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiProyecto1002
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Conexion")));
        }
        public void Configure (IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {

        }
    }
    }
}
