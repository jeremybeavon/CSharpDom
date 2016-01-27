using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class EventPropertyWithSymbols : AbstractSymbolNode<IEventPropertyWithSymbols>
    {
        private readonly IEventPropertyWithSymbols eventProperty;

        public EventPropertyWithSymbols(IEventPropertyWithSymbols eventProperty)
            : base(eventProperty)
        {
            this.eventProperty = eventProperty;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(eventProperty.DeclaringType); }
        }
        
        public string Name
        {
            get { return eventProperty.Name; }
        }
        
        public IEventSymbol Symbol
        {
            get { return eventProperty.Symbol; }
        }

        public IEventPropertyWithSymbols AsInterface()
        {
            return eventProperty;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            eventProperty.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
