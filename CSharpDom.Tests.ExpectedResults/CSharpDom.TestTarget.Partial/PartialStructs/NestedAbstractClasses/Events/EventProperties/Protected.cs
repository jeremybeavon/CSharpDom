﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedAbstractClassWithProtectedEventProperty
    {
        public abstract class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
