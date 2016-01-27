using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class PropertyWithSyntax : AbstractSyntaxNode<IPropertySyntax>
    {
        private readonly IPropertySyntax property;

        public PropertyWithSyntax(IPropertySyntax property)
            : base(property)
        {
            this.property = property;
        }

        public PropertyDeclarationSyntax Declaration
        {
            get { return property.Declaration; }
        }

        public BasicTypeWithSyntax DeclaringType
        {
            get { return BasicTypeWithSyntax.GetBasicType(property.DeclaringType); }
        }

        public int EndLine
        {
            get { return property.EndLine; }
        }

        public bool HasGet
        {
            get { return property.HasGet; }
        }

        public bool HasSet
        {
            get { return property.HasSet; }
        }

        public string Name
        {
            get { return property.Name; }
        }

        public int StartLine
        {
            get { return property.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            property.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitProperty(this);
        }
    }
}
