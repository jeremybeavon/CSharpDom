﻿namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
