using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class EventWithSymbols : AbstractSymbolNode<IEventWithSymbols>
    {
        private readonly IEventWithSymbols @event;

        public EventWithSymbols(IEventWithSymbols @event)
            : base(@event)
        {
            this.@event = @event;
        }

        public EventFieldDeclarationSyntax Declaration
        {
            get { return @event.Declaration; }
        }

        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(@event.DeclaringType); }
        }

        public int EndLine
        {
            get { return @event.EndLine; }
        }

        public string Name
        {
            get { return @event.Name; }
        }

        public int StartLine
        {
            get { return @event.StartLine; }
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
