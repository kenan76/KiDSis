﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiDSisMvcWebUI.Models
{
    public class Booksurplus
    {
        public int Id { get; set; }
        public int BookCount { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }


    }
}