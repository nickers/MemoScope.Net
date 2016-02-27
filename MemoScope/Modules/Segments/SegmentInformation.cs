﻿using BrightIdeasSoftware;
using Microsoft.Diagnostics.Runtime;
using System.Windows.Forms;
using WinFwk.UITools;

namespace MemoScope.Modules.Segments
{
    public class SegmentInformation
    {
        private ClrSegment segment;

        public SegmentInformation(ClrSegment segment)
        {
            this.segment = segment;
        }

        [IntColumn(AspectToStringFormat = "{0:X}")]
        public ulong Start => segment.Start;
        [IntColumn]
        public ulong Length => segment.Length;
        [BoolColumn]
        public bool IsLarge => segment.IsLarge;
        [OLVColumn(TextAlign = HorizontalAlignment.Right, AspectToStringFormat = "{0:X}")]
        public ulong End => segment.End;
        [IntColumn(Title = "Gen 0 Length")]
        public ulong Gen0Length => segment.Gen0Length;
        [IntColumn(Title = "Gen 1 Length")]
        public ulong Gen1Length => segment.Gen1Length;
        [IntColumn(Title="Gen 2 Length")]
        public ulong Gen2Length => segment.Gen2Length;
        [BoolColumn]
        public bool IsEphemeral => segment.IsEphemeral;
    }
}