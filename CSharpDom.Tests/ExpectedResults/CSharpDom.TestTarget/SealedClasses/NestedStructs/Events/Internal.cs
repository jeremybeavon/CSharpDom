﻿namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Events
{
    public sealed class SealedClassWithNestedStructWithInternalEvent
    {
        public struct Struct
        {
            internal event EventHandler Event;
        }
    }
}
