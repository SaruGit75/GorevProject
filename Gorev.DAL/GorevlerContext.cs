using System;
using Gorev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Gorev.DAL
{
    public partial class GorevlerContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GorevlerContext(DbContextOptions<GorevlerContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Gorevler> Gorevlers { get; set; }
    }
}
