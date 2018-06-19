using scm_mainbanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scm_mainbanner.ViewModels
{
    public class BannerViewModel
    {
        public IEnumerable<Banner> Banners { get; set; }
    }
}
