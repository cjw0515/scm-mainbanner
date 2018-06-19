using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scm_mainbanner.Models
{
    public class Banner
    {
        public int idx { get; set; }
        public int Id { get; set; }
        public String bannerImageUrl { get; set; }
        public int gubun { get; set; }
        public int contentType { get; set; }
        public byte linkType { get; set; }
        public int releaseCycle { get; set; }
        public String startDate { get; set; }
        public String endDate{ get; set; }
        public Char isUsing { get; set; }
        public int priority { get; set; }
        public String registrant { get; set; }
        public String worker { get; set; }
    }
}
