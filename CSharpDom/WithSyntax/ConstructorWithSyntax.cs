using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class ConstructorWithSyntax : AbstractSyntaxNode<IConstructorSyntax>
    {
        private readonly IConstructorSyntax constructor;

        public ConstructorWithSyntax(IConstructorSyntax constructor)
            : base(constructor)
        {
            this.constructor = constructor;
        }

        public ConstructorDeclarationSyntax Declaration
        {
            get { return constructor.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(constructor.DeclaringType); }
        }

        public int EndLine
        {
            get { return constructor.EndLine; }
        }

        public int StartLine
        {
            get { return constructor.StartLine; }
        }

        public IConstructorSyntax AsInterface()
        {
            return constructor;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            constructor.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitConstructor(this);
        }
    }
}
