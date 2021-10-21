﻿using Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChaKi.Common
{
    public class SvgButton : Button
    {
        public SvgButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        public byte[] Svg
        {
            set
            {
                using (var str = new MemoryStream(value))
                {
                    var svgDoc = SvgDocument.Open<SvgDocument>(str);
                    this.Image?.Dispose();
                    this.Image = svgDoc.Draw(this.Width, this.Height);
                }
            }
            get { return null; }
        }
    }
}
