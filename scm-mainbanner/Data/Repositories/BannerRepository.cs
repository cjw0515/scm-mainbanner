using scm_mainbanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scm_mainbanner.Data.Repositories
{
    public class BannerRepository : IBannerRepository
    {
        private readonly ScmContext _context;
        public BannerRepository(ScmContext context)
        {
            _context = context;
        }

        public IEnumerable<Banner> GetAllBanners()
        {
            var result = _context.banners.ToList();

            return result;
        }
    }
}
