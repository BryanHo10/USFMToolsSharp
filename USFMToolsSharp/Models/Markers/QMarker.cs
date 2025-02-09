﻿using System;
using System.Collections.Generic;
using System.Text;

namespace USFMToolsSharp.Models.Markers
{
    /// <summary>
    /// A Poetry Marker
    /// </summary>
    public class QMarker : Marker
    {
        public int Depth = 1;
        public string Text;
        public override string Identifier => "q";
        public override List<Type> AllowedContents => new List<Type>() {
            typeof(BMarker),
            typeof(QSMarker),
            typeof(TextBlock),
        };
    }
}
