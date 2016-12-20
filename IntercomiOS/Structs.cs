using System;
using ObjCRuntime;

namespace IntercomiOS
{
    [Native]
    public enum ICMPreviewPosition : ulong
    {
        BottomLeft = 0,
        BottomRight = 1,
        TopLeft = 2,
        TopRight = 3
    }
}