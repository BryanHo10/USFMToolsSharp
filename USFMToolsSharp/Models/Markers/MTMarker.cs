﻿using System;
using System.Collections.Generic;
using System.Text;

namespace USFMToolsSharp.Models.Markers
{
    /// <summary>
    /// Major title marker
    /// </summary>
    public class MTMarker : Marker
    {
        public string Title;
        public override string Identifier => "mt";
        public override void Populate(string input)
        {
            Title = input;
        }
    }
}
