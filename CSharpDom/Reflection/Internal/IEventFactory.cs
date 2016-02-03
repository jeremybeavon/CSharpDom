using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal interface IEventFactory<TEvent, TEventProperty>
    {
        TEvent CreateEvent(ITypeWithReflection declaringType, EventInfo @event);

        TEventProperty CreateEventProperty(ITypeWithReflection declaringType, EventInfo @event);
    }
}
