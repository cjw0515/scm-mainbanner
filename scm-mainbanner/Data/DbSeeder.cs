using scm_mainbanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scm_mainbanner.Data
{
    public class DbSeeder
    {

        private ScmContext _context;

        public DbSeeder(ScmContext context)
        {
            _context = context;
        }

        public async Task SeedDatabase()
        {
            if (!_context.banners.Any())
            {
                List<Banner> banners = new List<Banner>()
                {
                    new Banner() {
                       bannerImageUrl = "http://sdfsfs/sdfsdf",
                       gubun = 1,
                       contentType = 1,
                       linkType = 1,
                       releaseCycle = 1,
                       startDate = "2018-03-20",
                       endDate = "2018-05-20",
                       isUsing = 'Y',
                       priority = 39,
                       registrant = "최종원",
                       worker = "최종원"
                    },
                        new Banner() {
                       bannerImageUrl = "http://sdfsfs/sdfsdf",
                       gubun = 1,
                       contentType = 1,
                       linkType = 1,
                       releaseCycle = 1,
                       startDate = "2018-03-20",
                       endDate = "2018-05-20",
                       isUsing = 'Y',
                       priority = 39,
                       registrant = "최종원",
                       worker = "최종원"
                    },
                            new Banner() {
                       bannerImageUrl = "http://sdfsfs/sdfsdf",
                       gubun = 1,
                       contentType = 1,
                       linkType = 1,
                       releaseCycle = 1,
                       startDate = "2018-03-20",
                       endDate = "2018-05-20",
                       isUsing = 'Y',
                       priority = 39,
                       registrant = "최종원",
                       worker = "최종원"
                    }
                };

                await _context.AddRangeAsync(banners);
                await _context.SaveChangesAsync();//삽입
            }
        }
    }
}
