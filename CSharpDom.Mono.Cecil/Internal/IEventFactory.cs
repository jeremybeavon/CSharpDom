using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal interface IEventFactory<TEvent, TEventProperty, TType>
        where TType : ITypeWithMonoCecil
    {
        TEvent CreateEvent(TType declaringType, EventInfo @event);

        TEventProperty CreateEventProperty(TType declaringType, EventInfo @event);
    }
}
