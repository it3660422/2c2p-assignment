﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebService.Models
{
    public class CardInfos
    {
        public string cardNum { get; set; }
        public string expDate { get; set; }

    }
    public class CardResult
    {
        public string cardStat { get; set; }
        public string cardType { get; set; }
    }
}