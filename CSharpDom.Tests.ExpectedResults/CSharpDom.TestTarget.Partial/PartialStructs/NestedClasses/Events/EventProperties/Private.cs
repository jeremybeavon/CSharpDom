﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedClassWithPrivateEventProperty
    {
        public class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
