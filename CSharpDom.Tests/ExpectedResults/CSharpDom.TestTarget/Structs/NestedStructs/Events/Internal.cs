﻿namespace CSharpDom.TestTarget.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithInternalEvent
    {
        public struct Struct
        {
            internal event EventHandler Event;
        }
    }
}
