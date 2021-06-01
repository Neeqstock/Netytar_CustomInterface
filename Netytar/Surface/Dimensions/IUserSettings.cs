using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netytar
{
    public interface IUserSettings
    {
        int VerticalSpacer { get; }
        int HorizontalSpacer { get; }
        int OccluderOffset { get; }
        int EllipseRadius { get; }
        int LineThickness { get; }
        int HighlightStrokeDim { get; }
        int HighlightRadius { get; }
    }
}
