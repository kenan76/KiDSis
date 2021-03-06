﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiDSisMvcWebUI.Models
{
    public class ShoolBooksurplusViewModel
    {
        public int Id { get; set; }
        public string SchoolsCategory { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string DemandDate { get; set; }
        public string SchoolName { get; set; }
        public int BookCount { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
    }
}