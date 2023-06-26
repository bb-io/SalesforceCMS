﻿using Blackbird.Applications.Sdk.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Salesforce.Cms.Models.Requests
{
    public class GetArticleInfoRequest
    {
        [Display("Article ID")]
        public string ArticleId { get; set; }
    }
}
