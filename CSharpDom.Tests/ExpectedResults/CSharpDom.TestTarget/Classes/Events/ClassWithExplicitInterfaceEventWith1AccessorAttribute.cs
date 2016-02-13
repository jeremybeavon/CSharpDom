using System;

namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithExplicitInterfaceEventWith1AccessorAttribute : IInterfaceWithEvent
    {
        event EventHandler IInterfaceWithEvent.Event
        {
            [Attribute1]
            add { }
            [Attribute1]
            remove { }
        }
    }
}
