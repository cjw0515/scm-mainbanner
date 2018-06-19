using System.Collections.Generic;
using scm_mainbanner.Models;

namespace scm_mainbanner.Data.Repositories
{
    public interface IBannerRepository
    {
        IEnumerable<Banner> GetAllBanners();
    }
}