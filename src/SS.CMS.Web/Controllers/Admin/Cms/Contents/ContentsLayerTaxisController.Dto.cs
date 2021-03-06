﻿using SS.CMS.Abstractions.Dto.Request;

namespace SS.CMS.Web.Controllers.Admin.Cms.Contents
{
    public partial class ContentsLayerTaxisController
    {
        public class SubmitRequest : ChannelRequest
        {
            public string ChannelContentIds { get; set; }
            public bool IsUp { get; set; }
            public int Taxis { get; set; }
        }
    }
}