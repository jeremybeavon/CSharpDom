using System;

namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithExplicitInterfaceEventWithGenericInterface : IGenericInterfaceWithEventWithGenericDelegate<EventArgs>
    {
        event EventHandler<EventArgs> IGenericInterfaceWithEventWithGenericDelegate<EventArgs>.Event
        {
            add { }
            remove { }
        }
    }
}
