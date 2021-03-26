using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netytar
{
    class DimensionInvert : IDimension
    {
        public int HighlightStrokeDim { get; } = 5;
        public int HighlightRadius { get; } = 65;
        public int VerticalSpacer { get; } = -70;
        public int HorizontalSpacer { get; } = 170;
        public int OccluderOffset { get; } = 35;
        public int EllipseRadius { get; } = 23;
        public int LineThickness { get; } = 3;
    }
}
