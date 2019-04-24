﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace USFMToolsSharp.Models.Markers
{
    public class VMarker : Marker
    {
        // TODO: This needs to be altered to handle verse bridges
        public int Number;
        public string Text;
        public override string Identifier => "v";
        public override void Populate(string input)
        {
            Regex pattern = new Regex("([0-9]+) (.*)");
            Match match = pattern.Match(input);
            Number = int.Parse(match.Groups[1].Value);
            Text = match.Groups[2].Value;
        }
        public override List<Type> AllowedContents
        {
            get
            {
                return new List<Type>()
                {
                    typeof(BMarker),
                    typeof(QMarker),
                    typeof(MMarker),
                    typeof(FMarker),
                    typeof(SPMarker)
                };
            }
        }
    }
}
