using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class EventWithSyntax : AbstractSyntaxNode<IEventSyntax>
    {
        private readonly IEventSyntax @event;

        public EventWithSyntax(IEventSyntax @event)
            : base(@event)
        {
            this.@event = @event;
        }

        public EventFieldDeclarationSyntax Declaration
        {
            get { return @event.Declaration; }
        }

        public BasicTypeWithSyntax DeclaringType
        {
            get { return BasicTypeWithSyntax.GetBasicType(@event.DeclaringType); }
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

        public IEventSyntax AsInterface()
        {
            return @event;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @event.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitEvent(this);
        }
    }
}
