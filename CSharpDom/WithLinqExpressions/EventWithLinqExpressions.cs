using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class EventWithLinqExpressions
    {
        private readonly IEventWithLinqExpressions @event;

        public EventWithLinqExpressions(IEventWithLinqExpressions @event)
        {
            this.@event = @event;
        }

        public EventFieldDeclarationSyntax Declaration
        {
            get { return @event.Declaration; }
        }

        public BasicTypeWithLinqExpressions DeclaringType
        {
            get { return BasicTypeWithLinqExpressions.GetBasicType(@event.DeclaringType); }
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

        public IEventWithLinqExpressions AsInterface()
        {
            return @event;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @event.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @event.ToString();
        }
    }
}
