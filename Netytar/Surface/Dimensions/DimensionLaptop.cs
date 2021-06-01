using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netytar
{
    class DimensionLaptop : IUserSettings
    {
        public int HighlightStrokeDim { get; } = 5;
        public int HighlightRadius { get; } = 65;
        public int VerticalSpacer { get; } = 100;
        public int HorizontalSpacer { get; } = 200;
        public int OccluderOffset { get; } = 25;
        public int EllipseRadius { get; } = 35;
        public int LineThickness { get; } = 3;
    }
}
