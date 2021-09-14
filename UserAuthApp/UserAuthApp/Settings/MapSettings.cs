using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuthApp
{
    public class MapSettings
    {
        public string GoogleMapsApiKey { get; set; }
        public int DefaultZoomLevel { get; set; }
        public Location DefaultLocation { get; set; }
    }
}
