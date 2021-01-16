using System;
using System.Collections.Generic;

namespace dotnet_conf_2020_demo
{
    public class BlogItem
    {
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<string> Tags { get; set; }

    }
}