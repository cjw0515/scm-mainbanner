using Microsoft.EntityFrameworkCore;
using scm_mainbanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scm_mainbanner.Data
{
    public class ScmContext : DbContext
    {
        public ScmContext(DbContextOptions options) : base(options){}

        public DbSet<Banner> banners { get; set; }        //테이블 맵핑
    }
}
