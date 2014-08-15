using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class EventPropertyWithSymbols : AbstractSymbolNode<IEventPropertyWithSymbols>
    {
        private readonly IEventPropertyWithSymbols eventProperty;

        public EventPropertyWithSymbols(IEventPropertyWithSymbols eventProperty)
            : base(eventProperty)
        {
            this.eventProperty = eventProperty;
        }

        public EventDeclarationSyntax Declaration
        {
            get { return eventProperty.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(eventProperty.DeclaringType); }
        }

        public int EndLine
        {
            get { return eventProperty.EndLine; }
        }

        public string Name
        {
            get { return eventProperty.Name; }
        }

        public int StartLine
        {
            get { return eventProperty.StartLine; }
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
