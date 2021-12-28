using System;

namespace WebMusic_Auth.Helpers
{
    public class PagingModel
    {
        public int currentpage { get; set; }
        public int countpage { get; set; }
        public Func<int?, string> generateUrl { get; set; }
    }
}
