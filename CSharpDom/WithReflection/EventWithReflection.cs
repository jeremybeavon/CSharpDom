using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class EventWithReflection
    {
        private readonly IEventWithReflection @event;

        public EventWithReflection(IEventWithReflection @event)
        {
            this.@event = @event;
        }

        public EventFieldDeclarationSyntax Declaration
        {
            get { return @event.Declaration; }
        }

        public BasicTypeWithReflection DeclaringType
        {
            get { return BasicTypeWithReflection.GetBasicType(@event.DeclaringType); }
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

        public IEventWithReflection AsInterface()
        {
            return @event;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @event.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @event.ToString();
        }
    }
}
