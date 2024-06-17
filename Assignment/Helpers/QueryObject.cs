using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Helpers
{
    public class QueryObject
    {
        public String? Title {get; set; } = null;
        public String? EmailAddress {get; set; } = null;
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int PageNumber {get; set; } = 1;
        public int PageSize {get; set; } = 5; 
    }
}