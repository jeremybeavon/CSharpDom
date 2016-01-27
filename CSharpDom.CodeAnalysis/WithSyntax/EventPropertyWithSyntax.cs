using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class EventPropertyWithSyntax : AbstractSyntaxNode<IEventPropertySyntax>
    {
        private readonly IEventPropertySyntax eventProperty;

        public EventPropertyWithSyntax(IEventPropertySyntax eventProperty)
            : base(eventProperty)
        {
            this.eventProperty = eventProperty;
        }

        public EventDeclarationSyntax Declaration
        {
            get { return eventProperty.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(eventProperty.DeclaringType); }
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

        public IEventPropertySyntax AsInterface()
        {
            return eventProperty;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            eventProperty.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitEventProperty(this);
        }
    }
}
