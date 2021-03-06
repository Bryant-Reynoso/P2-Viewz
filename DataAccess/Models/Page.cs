﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Page
    {
        public Page()
        {
            Contents = new HashSet<Contents>();
            PageDetails = new HashSet<PageDetails>();
        }

        public int WikiId { get; set; }
        public long PageId { get; set; }
        public string Url { get; set; }
        public string PageName { get; set; }
        public long HitCount { get; set; }

        public virtual Wiki Wiki { get; set; }
        public virtual PageHtmlContent PageHtmlContent { get; set; }
        public virtual PageMdContent PageMdContent { get; set; }
        public virtual ICollection<Contents> Contents { get; set; }
        public virtual ICollection<PageDetails> PageDetails { get; set; }
    }
}
