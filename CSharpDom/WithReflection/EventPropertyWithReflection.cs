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
    public sealed class EventPropertyWithReflection
    {
        private readonly IEventPropertyWithReflection eventProperty;

        public EventPropertyWithReflection(IEventPropertyWithReflection eventProperty)
        {
            this.eventProperty = eventProperty;
        }

        public EventDeclarationSyntax Declaration
        {
            get { return eventProperty.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(eventProperty.DeclaringType); }
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

        public IEventPropertyWithReflection AsInterface()
        {
            return eventProperty;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            eventProperty.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return eventProperty.ToString();
        }
    }
}
