using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal interface IEventFactory<TEvent, TEventProperty, TType>
        where TType : ITypeWithMonoCecil
    {
        TEvent CreateEvent(TType declaringType, EventDefinition @event);

        TEventProperty CreateEventProperty(TType declaringType, EventDefinition @event);
    }
}
