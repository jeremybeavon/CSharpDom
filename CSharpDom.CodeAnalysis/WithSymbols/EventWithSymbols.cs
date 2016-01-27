using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class EventWithSymbols : AbstractSymbolNode<IEventWithSymbols>
    {
        private readonly IEventWithSymbols @event;

        public EventWithSymbols(IEventWithSymbols @event)
            : base(@event)
        {
            this.@event = @event;
        }
        
        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(@event.DeclaringType); }
        }
        
        public string Name
        {
            get { return @event.Name; }
        }
        
        public IEventSymbol Symbol
        {
            get { return @event.Symbol; }
        }

        public IEventWithSymbols AsInterface()
        {
            return @event;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @event.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
