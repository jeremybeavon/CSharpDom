using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal interface IEventFactory<TEvent, TEventProperty, TType>
        where TType : ITypeWithCodeAnalysis
    {
        TEvent CreateEvent(TType declaringType, EventDefinition @event);

        TEventProperty CreateEventProperty(TType declaringType, EventDefinition @event);
    }
}
