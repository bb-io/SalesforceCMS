﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Salesforce.Cms.Models.Responses
{
    public class GetArticleContentAsHtmlResponse
    {
        public byte[] File { get; set; }

        public string Filename { get; set; }
    }
}
