using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netytar
{
    class DefaultUserSettings : IUserSettings
    {
        public int HighlightStrokeDim { get; set; } = 5;
        public int HighlightRadius { get; set; } = 65;
        public int VerticalSpacer { get; set; } = -70;
        public int HorizontalSpacer { get; set; } = 170;
        public int OccluderOffset { get; set; } = 35;
        public int EllipseRadius { get; set; } = 23;
        public int LineThickness { get; set; } = 3;
        public _SharpNotesModes SharpNotesMode { get; set; } = _SharpNotesModes.On;
        public _BlinkSelectScaleMode BlinkSelectScaleMode { get; set; } = _BlinkSelectScaleMode.On;
        public _BreathControlModes BreathControlMode { get; set; } = _BreathControlModes.Dynamic;
        public _NetytarControlModes NetytarControlModes { get; set; } = _NetytarControlModes.Keyboard;
    }
}
