using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class FieldWithSyntax : AbstractSyntaxNode<IFieldSyntax>
    {
        private readonly IFieldSyntax field;

        public FieldWithSyntax(IFieldSyntax field)
            : base(field)
        {
            this.field = field;
        }

        public FieldDeclarationSyntax Declaration
        {
            get { return field.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(field.DeclaringType); }
        }

        public int EndLine
        {
            get { return field.EndLine; }
        }

        public string Name
        {
            get { return field.Name; }
        }

        public int StartLine
        {
            get { return field.StartLine; }
        }

        public IFieldSyntax AsInterface()
        {
            return field;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            field.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitField(this);
        }
    }
}
