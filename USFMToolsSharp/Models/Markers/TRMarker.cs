﻿using System;
using System.Collections.Generic;
using System.Text;

namespace USFMToolsSharp.Models.Markers
{
    /// <summary>
    /// Table Row Marker
    /// </summary>
    public class TRMarker : Marker
    {
<<<<<<< HEAD
        public override string Identifier => "tr";

        public override List<Type> AllowedContents => new List<Type>() {
            typeof(TCMarker),
            typeof(THMarker),
            typeof(TCRMarker),
            typeof(THRMarker)
=======
        public override string Identifier => "tr";

        public override List<Type> AllowedContents => new List<Type>() {
            typeof(TCMarker),
            typeof(THMarker),
            typeof(TCRMarker),
            typeof(THRMarker)
>>>>>>> Update Table Row 'Allowed Contents
        };
    }
}
