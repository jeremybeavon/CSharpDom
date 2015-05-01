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
    public sealed class EventPropertyWithLinqExpressions
    {
        private readonly IEventPropertyWithLinqExpressions eventProperty;

        public EventPropertyWithLinqExpressions(IEventPropertyWithLinqExpressions eventProperty)
        {
            this.eventProperty = eventProperty;
        }

        public EventDeclarationSyntax Declaration
        {
            get { return eventProperty.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(eventProperty.DeclaringType); }
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

        public IEventPropertyWithLinqExpressions AsInterface()
        {
            return eventProperty;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            eventProperty.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return eventProperty.ToString();
        }
    }
}
