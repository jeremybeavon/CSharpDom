using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class NestedClassDeclarationWithSyntax : TypeWithSyntax
    {
        private readonly INestedClassDeclarationSyntax @class;

        public NestedClassDeclarationWithSyntax(INestedClassDeclarationSyntax @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public NestedClassWithSyntax CompositeType
        {
            get { return new NestedClassWithSyntax(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(@class.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public INestedClassDeclarationSyntax AsInterface()
        {
            return @class;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @class.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedClassDeclaration(this);
        }
    }
}
